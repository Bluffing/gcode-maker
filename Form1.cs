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
            double degToRad(double d) => d * Math.PI / 180;
            var angle = degToRad((double)input_angle.Value);
            var toolSize = (double)input_toolsize.Value;
            var stepSize = (double)input_stepmm.Value;
            var conventional = chk_way.Checked;

            var height = (double)input_sizeheight.Value;
            var width = (double)input_sizewidth.Value;
            Coord center = ((double)input_centerx.Value, (double)input_centery.Value);
            Coord end = center + (width / 2, height / 2);

            // y = (x/yAxis)x + b
            var xAxis = Math.Sin(angle);
            var yAxis = Math.Cos(angle);

            double Sin(double a) => Math.Sin(a);
            double Cos(double a) => Math.Cos(a);

            Coord toppityTop = center + (width / 2 * Sin(angle), height / 2 * Cos(angle));
            Coord boppityBot = center - (width / 2 * Sin(angle), height / 2 * Cos(angle));

            Coord topCenter = center + (width / 2 * Sin(angle), height / 2 * Cos(angle));


            // Coord left(Coord center) => center + (-width / 2 * Sin(Math.PI / 2 + angle), -width / 2 * Cos(Math.PI / 2 + angle));
            // Coord right(Coord center) => center + (width / 2 * Sin(Math.PI / 2 - angle), width / 2 * -Cos(Math.PI / 2 - angle));

            Coord stepos() => (width / 2 * Sin(Math.PI / 2 - angle), width / 2 * -Cos(Math.PI / 2 - angle));

            Coord left(Coord center) => center - stepos();
            Coord right(Coord center) => center + stepos();
            (Coord start, Coord end) line(Coord center) => conventional ? (left(center), right(center)) : (right(center), left(center));

            Coord moveOnYAxis(Coord point, double step) => point + (xAxis * step, yAxis * step);

            double moveStep = 2d; // 2 mm

            var l = line(topCenter);
            var GCode = l.start.GCodeString("G00") + " Z3";
            GCode += "\n" + l.start.GCodeString("G01") + " Z0";
            GCode += "\n" + l.end.GCodeString("G01");

            int counter = 0;
            while (topCenter.FitIn(boppityBot, toppityTop))
            {
                // move up, then back to start
                topCenter = moveOnYAxis(topCenter, moveStep);
                l = line(topCenter);
                GCode += "\n" + l.end.GCodeString("G01");
                GCode += "\n" + l.start.GCodeString("G00");

                // move down, then cross
                topCenter = moveOnYAxis(topCenter, -(stepSize + moveStep));
                l = line(topCenter);
                GCode += "\n" + l.start.GCodeString("G01");
                GCode += "\n" + l.end.GCodeString("G01");

                if (counter++ >= 100)
                    break;
            }

            using (var fs = File.Open("bleak.gcode", FileMode.Create))
            {
                fs.Write(Encoding.Default.GetBytes(GCode));
            }
        }
    }
}
