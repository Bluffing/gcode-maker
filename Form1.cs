using System.Diagnostics;
using System.Text;

namespace gcode_maker
{
    public partial class GCoder : Form
    {
        public GCoder()
        {
            InitializeComponent();

            // settings
            LoadSettings();
            FormClosed += (_, _) => SaveSettings();

            // browser
            dial_browse.InitialDirectory = Path.GetDirectoryName(txt_filename.Text);
            dial_browse.FileOk += (_, _) =>
            {
                txt_filename.Text = dial_browse.FileName;
                dial_browse.FileName = Path.GetFileNameWithoutExtension(dial_browse.FileName);
            };
        }

        private void LoadSettings()
        {
            input_homex.Value = (decimal)Properties.Settings.Default.homex;
            input_homey.Value = (decimal)Properties.Settings.Default.homey;
            input_homez.Value = (decimal)Properties.Settings.Default.homez;

            input_startx.Value = (decimal)Properties.Settings.Default.startx;
            input_starty.Value = (decimal)Properties.Settings.Default.starty;

            input_width.Value = (decimal)Properties.Settings.Default.width;
            input_height.Value = (decimal)Properties.Settings.Default.height;

            input_angle.Value = (decimal)Properties.Settings.Default.angle;

            input_Zstart.Value = (decimal)Properties.Settings.Default.zstart;
            input_Zend.Value = (decimal)Properties.Settings.Default.zend;
            input_Zstep.Value = (decimal)Properties.Settings.Default.zstep;

            input_toolsize.Value = (decimal)Properties.Settings.Default.toolsize;

            input_stepmm.Value = (decimal)Properties.Settings.Default.toolstepmm;
            input_stepperc.Value = (decimal)Properties.Settings.Default.toolstepperc;

            input_toolspeed.Value = Properties.Settings.Default.toolspeed;

            txt_filename.Text = Properties.Settings.Default.filename;

            chk_way.Checked = Properties.Settings.Default.reversed;
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.homex = (double)input_homex.Value;
            Properties.Settings.Default.homey = (double)input_homey.Value;
            Properties.Settings.Default.homez = (double)input_homez.Value;

            Properties.Settings.Default.startx = (double)input_startx.Value;
            Properties.Settings.Default.starty = (double)input_starty.Value;

            Properties.Settings.Default.width = (double)input_width.Value;
            Properties.Settings.Default.height = (double)input_height.Value;

            Properties.Settings.Default.angle = (double)input_angle.Value;

            Properties.Settings.Default.zstart = (double)input_Zstart.Value;
            Properties.Settings.Default.zend = (double)input_Zend.Value;
            Properties.Settings.Default.zstep = (double)input_Zstep.Value;

            Properties.Settings.Default.toolsize = (double)input_toolsize.Value;

            Properties.Settings.Default.toolstepmm = (double)input_stepmm.Value;
            Properties.Settings.Default.toolstepperc = (double)input_stepperc.Value;

            Properties.Settings.Default.toolspeed = (int)input_toolspeed.Value;

            Properties.Settings.Default.filename = txt_filename.Text;

            Properties.Settings.Default.reversed = chk_way.Checked;

            Properties.Settings.Default.Save();
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
            (int x, int y, int z) home = ((int)input_homex.Value, (int)input_homey.Value, (int)input_homez.Value);

            var angle = degToRad((double)input_angle.Value);
            var stepSize = (double)input_stepmm.Value;
            var clockwise = !chk_way.Checked;

            var height = (double)input_height.Value;
            var width = (double)input_width.Value;

            double Sin(double a) => Math.Sin(a);
            double Cos(double a) => Math.Cos(a);

            Coord horizontalStep = (width * Cos(angle + degToRad(90)), width * Sin(angle + degToRad(90)));
            Coord verticalStep = (height * Cos(angle + degToRad(180)), height * Sin(angle + degToRad(180)));

            Coord corner1;
            Coord corner2;
            Coord corner3;
            Coord corner4;

            if (clockwise)
            {
                // 3 ------ 2
                // |        |
                // |        |
                // 4 ------ 1 (input)
                corner1 = new Coord((double)input_startx.Value, (double)input_starty.Value).Round(3);
                corner2 = (corner1 + horizontalStep).Round(3);
                corner3 = (corner2 + verticalStep).Round(3);
                corner4 = (corner3 - horizontalStep).Round(3);
            }
            else
            {
                // 4 ------ 1
                // |        |
                // |        |
                // 3 ------ 2 (input)
                corner2 = new Coord((double)input_startx.Value, (double)input_starty.Value).Round(3);
                corner1 = (corner2 + horizontalStep).Round(3);
                corner3 = (corner2 + verticalStep).Round(3);
                corner4 = (corner3 + horizontalStep).Round(3);
            }

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

            GCode += $"\nZ{home.z}";
            // GCode += $"\n{new Coord(home.x, home.y).GCodeString("G00")}";
            GCode += $"\n{current.GCodeString("G00")}";

            int counter = 0;

            double currentZ = (double)input_Zstart.Value;
            double stepZ = (double)input_Zstep.Value;
            double endZ = (double)input_Zend.Value;

            while (true)
            {
                GCode += $"\n{current.GCodeString("G00")} Z{currentZ + 2}";
                GCode += $"\n{current.GCodeString("G01")} Z{currentZ}";

                current = moveOnYAxis(current, -stepSize);
                while (true)
                {
                    // move down, then cross
                    end = lineEnd(current);
                    GCode += "\n" + current.GCodeString("G01"); // down
                    GCode += "\n" + end.GCodeString("G01");     // across

                    // if (!moveOnYAxis(current, -stepSize).FitIn(corner4, corner1))
                    if (current.CloseTo(corner4, 0.1))
                        break;

                    // move up, then back to start
                    current = moveOnYAxis(current, moveStep);
                    end = lineEnd(current);
                    GCode += "\n" + end.GCodeString("G00");     // up
                    GCode += "\n" + current.GCodeString("G00"); // back to start

                    // take last edge
                    current = moveOnYAxis(current, -(stepSize + moveStep));
                    if (!current.FitIn(corner4, corner1))
                        current = corner4;

                    if (counter++ >= 100)
                        break;
                }

                if (currentZ == endZ)
                    break;

                currentZ = currentZ - stepZ < endZ ? endZ : currentZ - stepZ;
                current = corner1;

                GCode += $"\n{end.GCodeString("G00")} Z{currentZ + 2}";
            }

            GCode += $"\n{end.GCodeString("G00")} Z{home.z}";
            GCode += $"\n{new Coord(home.x, home.y).GCodeString("G00")}";

            using var fs = File.Open(txt_filename.Text, FileMode.Create);
            fs.Write(Encoding.Default.GetBytes(GCode));
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            dial_browse.ShowDialog();
        }
    }
}
