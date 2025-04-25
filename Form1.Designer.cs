namespace gcode_maker
{
    partial class Form1
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
            input_centery = new NumericUpDown();
            input_centerx = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            input_sizeheight = new NumericUpDown();
            input_sizewidth = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)input_centery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_centerx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_sizeheight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_sizewidth).BeginInit();
            SizeBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_toolsize).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_stepperc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_stepmm).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)input_angle).BeginInit();
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
            // input_centery
            // 
            input_centery.DecimalPlaces = 3;
            input_centery.Location = new Point(69, 37);
            input_centery.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            input_centery.Name = "input_centery";
            input_centery.Size = new Size(56, 23);
            input_centery.TabIndex = 6;
            // 
            // input_centerx
            // 
            input_centerx.DecimalPlaces = 3;
            input_centerx.Location = new Point(7, 37);
            input_centerx.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            input_centerx.Name = "input_centerx";
            input_centerx.Size = new Size(56, 23);
            input_centerx.TabIndex = 5;
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
            // input_sizeheight
            // 
            input_sizeheight.DecimalPlaces = 3;
            input_sizeheight.Location = new Point(71, 37);
            input_sizeheight.Name = "input_sizeheight";
            input_sizeheight.Size = new Size(56, 23);
            input_sizeheight.TabIndex = 11;
            input_sizeheight.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // input_sizewidth
            // 
            input_sizewidth.DecimalPlaces = 3;
            input_sizewidth.Location = new Point(9, 37);
            input_sizewidth.Name = "input_sizewidth";
            input_sizewidth.Size = new Size(56, 23);
            input_sizewidth.TabIndex = 10;
            input_sizewidth.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // SizeBox
            // 
            SizeBox.Controls.Add(input_sizeheight);
            SizeBox.Controls.Add(label2);
            SizeBox.Controls.Add(input_sizewidth);
            SizeBox.Controls.Add(label3);
            SizeBox.Location = new Point(152, 19);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(137, 71);
            SizeBox.TabIndex = 14;
            SizeBox.TabStop = false;
            SizeBox.Text = "Size";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(input_centery);
            groupBox1.Controls.Add(input_centerx);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 71);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Center";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(input_toolsize);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(75, 71);
            groupBox2.TabIndex = 16;
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
            input_toolsize.TabIndex = 14;
            input_toolsize.Value = new decimal(new int[] { 4, 0, 0, 0 });
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
            groupBox3.Location = new Point(93, 96);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(159, 71);
            groupBox3.TabIndex = 17;
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
            input_stepperc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            input_stepperc.Name = "input_stepperc";
            input_stepperc.Size = new Size(56, 23);
            input_stepperc.TabIndex = 17;
            input_stepperc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            input_stepperc.ValueChanged += input_stepperc_ValueChanged;
            // 
            // input_stepmm
            // 
            input_stepmm.DecimalPlaces = 3;
            input_stepmm.Location = new Point(6, 37);
            input_stepmm.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            input_stepmm.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            input_stepmm.Name = "input_stepmm";
            input_stepmm.Size = new Size(56, 23);
            input_stepmm.TabIndex = 14;
            input_stepmm.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            btn_gen.Location = new Point(258, 115);
            btn_gen.Name = "btn_gen";
            btn_gen.Size = new Size(112, 52);
            btn_gen.TabIndex = 18;
            btn_gen.Text = "Generate";
            btn_gen.UseVisualStyleBackColor = true;
            btn_gen.Click += btn_gen_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(input_angle);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(295, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(75, 71);
            groupBox4.TabIndex = 19;
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
            input_angle.TabIndex = 14;
            input_angle.Value = new decimal(new int[] { 45, 0, 0, 0 });
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
            chk_way.Checked = true;
            chk_way.CheckState = CheckState.Checked;
            chk_way.Location = new Point(258, 96);
            chk_way.Name = "chk_way";
            chk_way.Size = new Size(97, 19);
            chk_way.TabIndex = 20;
            chk_way.Text = "Conventional";
            chk_way.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 264);
            Controls.Add(chk_way);
            Controls.Add(groupBox4);
            Controls.Add(btn_gen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(SizeBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)input_centery).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_centerx).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_sizeheight).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_sizewidth).EndInit();
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private NumericUpDown input_centery;
        private NumericUpDown input_centerx;
        private Label label2;
        private Label label3;
        private NumericUpDown input_sizeheight;
        private NumericUpDown input_sizewidth;
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
    }
}
