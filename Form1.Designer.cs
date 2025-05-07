namespace gcode_maker
{
    partial class GCoder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label5 = new Label();
            input_starty = new NumericUpDown();
            input_startx = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            input_height = new NumericUpDown();
            input_width = new NumericUpDown();
            SizeBox = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            input_toolsize = new NumericUpDown();
            label6 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            input_stepperc = new NumericUpDown();
            input_stepmm = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            btn_gen = new Button();
            groupBox4 = new GroupBox();
            input_angle = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            chk_way = new CheckBox();
            txt_filename = new TextBox();
            groupBox5 = new GroupBox();
            btn_browse = new Button();
            groupBox6 = new GroupBox();
            input_toolspeed = new NumericUpDown();
            groupBox7 = new GroupBox();
            input_homez = new NumericUpDown();
            label15 = new Label();
            input_homey = new NumericUpDown();
            input_homex = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            groupBox8 = new GroupBox();
            label18 = new Label();
            input_Zstep = new NumericUpDown();
            label17 = new Label();
            input_Zend = new NumericUpDown();
            label16 = new Label();
            input_Zstart = new NumericUpDown();
            dial_browse = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)input_starty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_startx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_width).BeginInit();
            SizeBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_toolsize).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_stepperc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_stepmm).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_angle).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_toolspeed).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_homez).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_homey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_homex).BeginInit();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_Zstep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_Zend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_Zstart).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 19);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 8;
            label4.Text = "y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 19);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 7;
            label5.Text = "x";
            // 
            // input_starty
            // 
            input_starty.DecimalPlaces = 3;
            input_starty.Location = new Point(69, 37);
            input_starty.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            input_starty.Name = "input_starty";
            input_starty.Size = new Size(56, 23);
            input_starty.TabIndex = 4;
            input_starty.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // input_startx
            // 
            input_startx.DecimalPlaces = 3;
            input_startx.Location = new Point(7, 37);
            input_startx.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            input_startx.Name = "input_startx";
            input_startx.Size = new Size(56, 23);
            input_startx.TabIndex = 3;
            input_startx.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 19);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 13;
            label2.Text = "height";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 19);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 12;
            label3.Text = "width";
            // 
            // input_height
            // 
            input_height.DecimalPlaces = 3;
            input_height.Location = new Point(71, 37);
            input_height.Name = "input_height";
            input_height.Size = new Size(56, 23);
            input_height.TabIndex = 6;
            input_height.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // input_width
            // 
            input_width.DecimalPlaces = 3;
            input_width.Location = new Point(9, 37);
            input_width.Name = "input_width";
            input_width.Size = new Size(56, 23);
            input_width.TabIndex = 5;
            input_width.Value = new decimal(new int[] { 25, 0, 0, 65536 });
            // 
            // SizeBox
            // 
            SizeBox.Controls.Add(input_height);
            SizeBox.Controls.Add(label2);
            SizeBox.Controls.Add(input_width);
            SizeBox.Controls.Add(label3);
            SizeBox.Location = new Point(353, 19);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(137, 71);
            SizeBox.TabIndex = 2;
            SizeBox.TabStop = false;
            SizeBox.Text = "Size";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(input_starty);
            groupBox1.Controls.Add(input_startx);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(213, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 71);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Start";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(input_toolsize);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(218, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(75, 71);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tool Size";
            // 
            // input_toolsize
            // 
            input_toolsize.DecimalPlaces = 3;
            input_toolsize.Location = new Point(6, 37);
            input_toolsize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            input_toolsize.Name = "input_toolsize";
            input_toolsize.Size = new Size(56, 23);
            input_toolsize.TabIndex = 11;
            input_toolsize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 19);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 15;
            label1.Text = "mm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(input_stepperc);
            groupBox3.Controls.Add(input_stepmm);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(299, 96);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(159, 71);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Step";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 19);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 20;
            label7.Text = "% of tool";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 39);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 19;
            label8.Text = "or";
            // 
            // input_stepperc
            // 
            input_stepperc.DecimalPlaces = 3;
            input_stepperc.Location = new Point(92, 37);
            input_stepperc.Name = "input_stepperc";
            input_stepperc.Size = new Size(56, 23);
            input_stepperc.TabIndex = 13;
            input_stepperc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            input_stepperc.ValueChanged += input_stepperc_ValueChanged;
            // 
            // input_stepmm
            // 
            input_stepmm.DecimalPlaces = 3;
            input_stepmm.Location = new Point(6, 37);
            input_stepmm.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            input_stepmm.Name = "input_stepmm";
            input_stepmm.Size = new Size(56, 23);
            input_stepmm.TabIndex = 12;
            input_stepmm.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            input_stepmm.ValueChanged += input_stepmm_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(86, 19);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 15;
            label10.Text = "mm";
            // 
            // btn_gen
            // 
            btn_gen.Location = new Point(441, 192);
            btn_gen.Name = "btn_gen";
            btn_gen.Size = new Size(112, 32);
            btn_gen.TabIndex = 17;
            btn_gen.Text = "Generate";
            btn_gen.UseVisualStyleBackColor = true;
            btn_gen.Click += btn_gen_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(input_angle);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(496, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(75, 71);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Angle";
            // 
            // input_angle
            // 
            input_angle.DecimalPlaces = 1;
            input_angle.Location = new Point(6, 37);
            input_angle.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            input_angle.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            input_angle.Name = "input_angle";
            input_angle.Size = new Size(56, 23);
            input_angle.TabIndex = 7;
            input_angle.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(86, 19);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 19);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 15;
            label12.Text = "deg";
            // 
            // chk_way
            // 
            chk_way.AutoSize = true;
            chk_way.Location = new Point(441, 173);
            chk_way.Name = "chk_way";
            chk_way.Size = new Size(117, 19);
            chk_way.TabIndex = 16;
            chk_way.Text = "Reverse Direction";
            chk_way.UseVisualStyleBackColor = true;
            // 
            // txt_filename
            // 
            txt_filename.Location = new Point(6, 22);
            txt_filename.Name = "txt_filename";
            txt_filename.Size = new Size(329, 23);
            txt_filename.TabIndex = 1;
            txt_filename.Text = "invalid";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_browse);
            groupBox5.Controls.Add(txt_filename);
            groupBox5.Location = new Point(12, 169);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(423, 55);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "path";
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(339, 21);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(78, 23);
            btn_browse.TabIndex = 2;
            btn_browse.Text = "browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(input_toolspeed);
            groupBox6.Location = new Point(464, 96);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(88, 71);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tool Speed";
            // 
            // input_toolspeed
            // 
            input_toolspeed.Location = new Point(14, 37);
            input_toolspeed.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            input_toolspeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            input_toolspeed.Name = "input_toolspeed";
            input_toolspeed.Size = new Size(56, 23);
            input_toolspeed.TabIndex = 14;
            input_toolspeed.Value = new decimal(new int[] { 1600, 0, 0, 0 });
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(input_homez);
            groupBox7.Controls.Add(label15);
            groupBox7.Controls.Add(input_homey);
            groupBox7.Controls.Add(input_homex);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(label14);
            groupBox7.Location = new Point(12, 19);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(195, 71);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Home";
            // 
            // input_homez
            // 
            input_homez.DecimalPlaces = 3;
            input_homez.Location = new Point(130, 37);
            input_homez.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            input_homez.Name = "input_homez";
            input_homez.Size = new Size(56, 23);
            input_homez.TabIndex = 2;
            input_homez.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(130, 19);
            label15.Name = "label15";
            label15.Size = new Size(12, 15);
            label15.TabIndex = 10;
            label15.Text = "z";
            // 
            // input_homey
            // 
            input_homey.DecimalPlaces = 3;
            input_homey.Location = new Point(69, 37);
            input_homey.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            input_homey.Name = "input_homey";
            input_homey.Size = new Size(56, 23);
            input_homey.TabIndex = 1;
            // 
            // input_homex
            // 
            input_homex.DecimalPlaces = 3;
            input_homex.Location = new Point(7, 37);
            input_homex.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            input_homex.Name = "input_homex";
            input_homex.Size = new Size(56, 23);
            input_homex.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(69, 19);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 8;
            label13.Text = "y";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 19);
            label14.Name = "label14";
            label14.Size = new Size(13, 15);
            label14.TabIndex = 7;
            label14.Text = "x";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label18);
            groupBox8.Controls.Add(input_Zstep);
            groupBox8.Controls.Add(label17);
            groupBox8.Controls.Add(input_Zend);
            groupBox8.Controls.Add(label16);
            groupBox8.Controls.Add(input_Zstart);
            groupBox8.Location = new Point(12, 96);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(200, 67);
            groupBox8.TabIndex = 4;
            groupBox8.TabStop = false;
            groupBox8.Text = "Z ing";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(132, 19);
            label18.Name = "label18";
            label18.Size = new Size(37, 15);
            label18.TabIndex = 12;
            label18.Text = "step z";
            // 
            // input_Zstep
            // 
            input_Zstep.DecimalPlaces = 3;
            input_Zstep.Location = new Point(132, 37);
            input_Zstep.Name = "input_Zstep";
            input_Zstep.Size = new Size(55, 23);
            input_Zstep.TabIndex = 10;
            input_Zstep.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(71, 19);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 10;
            label17.Text = "ending z";
            // 
            // input_Zend
            // 
            input_Zend.DecimalPlaces = 3;
            input_Zend.Location = new Point(71, 37);
            input_Zend.Name = "input_Zend";
            input_Zend.Size = new Size(55, 23);
            input_Zend.TabIndex = 9;
            input_Zend.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 19);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 8;
            label16.Text = "starting z";
            // 
            // input_Zstart
            // 
            input_Zstart.DecimalPlaces = 3;
            input_Zstart.Location = new Point(10, 37);
            input_Zstart.Name = "input_Zstart";
            input_Zstart.Size = new Size(55, 23);
            input_Zstart.TabIndex = 8;
            input_Zstart.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // dial_browse
            // 
            dial_browse.FileName = "bleak.txt";
            dial_browse.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // GCoder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 235);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(chk_way);
            Controls.Add(groupBox4);
            Controls.Add(btn_gen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(SizeBox);
            Name = "GCoder";
            Text = "GCode-Maker";
            ((System.ComponentModel.ISupportInitialize)input_starty).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_startx).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_height).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_width).EndInit();
            SizeBox.ResumeLayout(false);
            SizeBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)input_toolsize).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)input_stepperc).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_stepmm).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)input_angle).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)input_toolspeed).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)input_homez).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_homey).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_homex).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)input_Zstep).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_Zend).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_Zstart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private NumericUpDown input_starty;
        private NumericUpDown input_startx;
        private Label label2;
        private Label label3;
        private NumericUpDown input_height;
        private NumericUpDown input_width;
        private GroupBox SizeBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown input_toolsize;
        private Label label6;
        private Label label1;
        private GroupBox groupBox3;
        private Label label8;
        private NumericUpDown input_stepperc;
        private NumericUpDown input_stepmm;
        private Label label9;
        private Label label10;
        private Label label7;
        private Button btn_gen;
        private GroupBox groupBox4;
        private NumericUpDown input_angle;
        private Label label11;
        private Label label12;
        private CheckBox chk_way;
        private TextBox txt_filename;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private NumericUpDown input_toolspeed;
        private GroupBox groupBox7;
        private NumericUpDown input_homez;
        private Label label15;
        private NumericUpDown input_homey;
        private NumericUpDown input_homex;
        private Label label13;
        private Label label14;
        private GroupBox groupBox8;
        private Label label18;
        private NumericUpDown input_Zstep;
        private Label label17;
        private NumericUpDown input_Zend;
        private Label label16;
        private NumericUpDown input_Zstart;
        private Button btn_browse;
        private SaveFileDialog dial_browse;
    }
}
