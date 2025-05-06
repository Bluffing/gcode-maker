using System.Diagnostics;
using System.Text;

namespace gcode_maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool updatingStepValue = false;
        private void input_stepmm_ValueChanged(object sender, EventArgs e)
        {
            if (updatingStepValue)
            {
                updatingStepValue = false;
                return;
            }

            updatingStepValue = true;
            input_stepperc.Value = input_stepmm.Value / input_toolsize.Value * 100;
        }

        private void input_stepperc_ValueChanged(object sender, EventArgs e)
        {
            if (updatingStepValue)
            {
                updatingStepValue = false;
                return;
            }

            updatingStepValue = true;
            input_stepmm.Value = input_toolsize.Value * (input_stepperc.Value / 100);
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            /// 3 ------ 2
            /// |        |
            /// |        |
            /// 4 ------ 1

            double degToRad(double d) => d * Math.PI / 180;

            var angle = degToRad((double)input_angle.Value);
            var toolSize = (double)input_toolsize.Value;
            var stepSize = (double)input_stepmm.Value;
            var clockwise = !chk_way.Checked;

            var height = (double)input_sizeheight.Value;
            var width = (double)input_sizewidth.Value;

            double Sin(double a) => Math.Sin(a);
            double Cos(double a) => Math.Cos(a);

            Coord horizontalStep = (width * Cos(angle + degToRad(90)), width * Sin(angle + degToRad(90)));
            Coord verticalStep = (height * Cos(angle + degToRad(180)), height * Sin(angle + degToRad(180)));

            Coord corner1 = new Coord((double)input_trx.Value, (double)input_try.Value).Round(3);
            Coord corner2 = (corner1 + horizontalStep).Round(3);
            Coord corner3 = (corner2 + verticalStep).Round(3);
            Coord corner4 = (corner3 - horizontalStep).Round(3);

            Coord lineEnd(Coord start) => start + ((clockwise ? 1 : -1) * horizontalStep);
            Coord moveOnYAxis(Coord point, double step) => (point + (step * Cos(angle), step * Sin(angle)));

            double moveStep = 2d; // 2 mm

            Coord current = corner1;
            var end = lineEnd(current);
            var GCode = $"S{input_toolspeed.Value}M03";

            // debug
            // GCode += "\n" + corner1.GCodeString("G00");
            // GCode += "\n" + corner2.GCodeString("G00");
            // GCode += "\n" + corner3.GCodeString("G00");
            // GCode += "\n" + corner4.GCodeString("G00");
            // GCode += "\n" + corner1.GCodeString("G01");

            GCode += "\n" + current.GCodeString("G00") + " Z3";
            GCode += "\n" + current.GCodeString("G01") + " Z0";
            GCode += "\n" + end.GCodeString("G01");

            int counter = 0;
            while (moveOnYAxis(current, -stepSize).FitIn(corner4, corner1))
            {
                // move up, then back to start
                current = moveOnYAxis(current, moveStep);
                end = lineEnd(current);
                GCode += "\n" + end.GCodeString("G00");
                GCode += "\n" + current.GCodeString("G00");

                // move down, then cross
                current = moveOnYAxis(current, -(stepSize + moveStep));
                end = lineEnd(current);
                GCode += "\n" + current.GCodeString("G01");
                GCode += "\n" + end.GCodeString("G01");

                if (counter++ >= 100)
                    break;
            }

            var blooza = moveOnYAxis(current, -stepSize).Round(3).GCodeString("G00");
            var what = moveOnYAxis(current, -stepSize).Round(3).FitIn(corner4.Round(3), corner1.Round(3));

            using (var fs = File.Open($"{txt_filename.Text}.txt", FileMode.Create))
                fs.Write(Encoding.Default.GetBytes(GCode));
        }
    }
}
