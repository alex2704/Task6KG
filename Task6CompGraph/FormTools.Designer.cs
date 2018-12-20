namespace Task6CompGraph
{
    partial class FormTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.firstPerspectivePoint_sb = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PerspectiveVisible_cb = new System.Windows.Forms.CheckBox();
            this.OXYZ_visible = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.secodPerspectivePoint_sb = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonStereo = new System.Windows.Forms.RadioButton();
            this.radioButtonFace = new System.Windows.Forms.RadioButton();
            this.radioButtonEdge = new System.Windows.Forms.RadioButton();
            this.noVector_rb = new System.Windows.Forms.RadioButton();
            this.rotateY_rb = new System.Windows.Forms.RadioButton();
            this.rotateX_rb = new System.Windows.Forms.RadioButton();
            this.radioButtonHexaedr = new System.Windows.Forms.RadioButton();
            this.radioButtonDodecahedron = new System.Windows.Forms.RadioButton();
            this.radioButtonXaxahedron = new System.Windows.Forms.RadioButton();
            this.radioButtonOctaedr = new System.Windows.Forms.RadioButton();
            this.speed_Box = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rotateBody = new System.Windows.Forms.RadioButton();
            this.radioButtonTetraedr = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rotateOXYZ = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPBtn = new System.Windows.Forms.RadioButton();
            this.OPbtn = new System.Windows.Forms.RadioButton();
            this.onePointScroll = new System.Windows.Forms.HScrollBar();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_Box)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точки схода";
            // 
            // firstPerspectivePoint_sb
            // 
            this.firstPerspectivePoint_sb.Location = new System.Drawing.Point(21, 163);
            this.firstPerspectivePoint_sb.Name = "firstPerspectivePoint_sb";
            this.firstPerspectivePoint_sb.Size = new System.Drawing.Size(294, 21);
            this.firstPerspectivePoint_sb.TabIndex = 0;
            this.firstPerspectivePoint_sb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.firstPerspectivePoint_sb_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PerspectiveVisible_cb);
            this.groupBox1.Controls.Add(this.OXYZ_visible);
            this.groupBox1.Location = new System.Drawing.Point(222, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(124, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Видимость";
            // 
            // PerspectiveVisible_cb
            // 
            this.PerspectiveVisible_cb.AutoSize = true;
            this.PerspectiveVisible_cb.Location = new System.Drawing.Point(8, 55);
            this.PerspectiveVisible_cb.Name = "PerspectiveVisible_cb";
            this.PerspectiveVisible_cb.Size = new System.Drawing.Size(116, 21);
            this.PerspectiveVisible_cb.TabIndex = 1;
            this.PerspectiveVisible_cb.Text = "Перспектива";
            this.PerspectiveVisible_cb.UseVisualStyleBackColor = true;
            this.PerspectiveVisible_cb.CheckedChanged += new System.EventHandler(this.PerspectiveVisible_cb_CheckedChanged);
            // 
            // OXYZ_visible
            // 
            this.OXYZ_visible.AutoSize = true;
            this.OXYZ_visible.Location = new System.Drawing.Point(8, 26);
            this.OXYZ_visible.Margin = new System.Windows.Forms.Padding(4);
            this.OXYZ_visible.Name = "OXYZ_visible";
            this.OXYZ_visible.Size = new System.Drawing.Size(56, 21);
            this.OXYZ_visible.TabIndex = 0;
            this.OXYZ_visible.Text = "Оси";
            this.OXYZ_visible.UseVisualStyleBackColor = true;
            this.OXYZ_visible.CheckedChanged += new System.EventHandler(this.OXYZ_visible_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.onePointScroll);
            this.tabPage3.Controls.Add(this.OPbtn);
            this.tabPage3.Controls.Add(this.TPBtn);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.secodPerspectivePoint_sb);
            this.tabPage3.Controls.Add(this.firstPerspectivePoint_sb);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(369, 283);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Перспектива";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // secodPerspectivePoint_sb
            // 
            this.secodPerspectivePoint_sb.Location = new System.Drawing.Point(21, 204);
            this.secodPerspectivePoint_sb.Name = "secodPerspectivePoint_sb";
            this.secodPerspectivePoint_sb.Size = new System.Drawing.Size(294, 21);
            this.secodPerspectivePoint_sb.TabIndex = 1;
            this.secodPerspectivePoint_sb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.secodPerspectivePoint_sb_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Угловая скорость";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonStereo);
            this.groupBox3.Controls.Add(this.radioButtonFace);
            this.groupBox3.Controls.Add(this.radioButtonEdge);
            this.groupBox3.Location = new System.Drawing.Point(222, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(124, 106);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изображение";
            // 
            // radioButtonStereo
            // 
            this.radioButtonStereo.AutoSize = true;
            this.radioButtonStereo.Location = new System.Drawing.Point(13, 78);
            this.radioButtonStereo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStereo.Name = "radioButtonStereo";
            this.radioButtonStereo.Size = new System.Drawing.Size(75, 21);
            this.radioButtonStereo.TabIndex = 2;
            this.radioButtonStereo.Text = "стерео";
            this.radioButtonStereo.UseVisualStyleBackColor = true;
            this.radioButtonStereo.CheckedChanged += new System.EventHandler(this.radioButtonStereo_CheckedChanged);
            // 
            // radioButtonFace
            // 
            this.radioButtonFace.AutoSize = true;
            this.radioButtonFace.Location = new System.Drawing.Point(13, 50);
            this.radioButtonFace.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFace.Name = "radioButtonFace";
            this.radioButtonFace.Size = new System.Drawing.Size(66, 21);
            this.radioButtonFace.TabIndex = 1;
            this.radioButtonFace.Text = "грани";
            this.radioButtonFace.UseVisualStyleBackColor = true;
            this.radioButtonFace.CheckedChanged += new System.EventHandler(this.radioButtonFace_CheckedChanged);
            // 
            // radioButtonEdge
            // 
            this.radioButtonEdge.AutoSize = true;
            this.radioButtonEdge.Checked = true;
            this.radioButtonEdge.Location = new System.Drawing.Point(13, 22);
            this.radioButtonEdge.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEdge.Name = "radioButtonEdge";
            this.radioButtonEdge.Size = new System.Drawing.Size(69, 21);
            this.radioButtonEdge.TabIndex = 0;
            this.radioButtonEdge.TabStop = true;
            this.radioButtonEdge.Text = "ребра";
            this.radioButtonEdge.UseVisualStyleBackColor = true;
            this.radioButtonEdge.CheckedChanged += new System.EventHandler(this.radioButtonEdge_CheckedChanged);
            // 
            // noVector_rb
            // 
            this.noVector_rb.AutoSize = true;
            this.noVector_rb.Location = new System.Drawing.Point(7, 80);
            this.noVector_rb.Name = "noVector_rb";
            this.noVector_rb.Size = new System.Drawing.Size(113, 21);
            this.noVector_rb.TabIndex = 2;
            this.noVector_rb.TabStop = true;
            this.noVector_rb.Text = "Вокруг оси Z";
            this.noVector_rb.UseVisualStyleBackColor = true;
            // 
            // rotateY_rb
            // 
            this.rotateY_rb.AutoSize = true;
            this.rotateY_rb.Location = new System.Drawing.Point(7, 53);
            this.rotateY_rb.Name = "rotateY_rb";
            this.rotateY_rb.Size = new System.Drawing.Size(113, 21);
            this.rotateY_rb.TabIndex = 1;
            this.rotateY_rb.TabStop = true;
            this.rotateY_rb.Text = "Вокруг оси Y";
            this.rotateY_rb.UseVisualStyleBackColor = true;
            // 
            // rotateX_rb
            // 
            this.rotateX_rb.AutoSize = true;
            this.rotateX_rb.Location = new System.Drawing.Point(7, 22);
            this.rotateX_rb.Name = "rotateX_rb";
            this.rotateX_rb.Size = new System.Drawing.Size(113, 21);
            this.rotateX_rb.TabIndex = 0;
            this.rotateX_rb.TabStop = true;
            this.rotateX_rb.Text = "Вокруг оси X";
            this.rotateX_rb.UseVisualStyleBackColor = true;
            // 
            // radioButtonHexaedr
            // 
            this.radioButtonHexaedr.AutoSize = true;
            this.radioButtonHexaedr.Location = new System.Drawing.Point(35, 65);
            this.radioButtonHexaedr.Name = "radioButtonHexaedr";
            this.radioButtonHexaedr.Size = new System.Drawing.Size(90, 21);
            this.radioButtonHexaedr.TabIndex = 5;
            this.radioButtonHexaedr.Text = "Гексаэдр";
            this.radioButtonHexaedr.UseVisualStyleBackColor = true;
            this.radioButtonHexaedr.CheckedChanged += new System.EventHandler(this.radioButtonTetraedr_CheckedChanged);
            // 
            // radioButtonDodecahedron
            // 
            this.radioButtonDodecahedron.AutoSize = true;
            this.radioButtonDodecahedron.Location = new System.Drawing.Point(35, 179);
            this.radioButtonDodecahedron.Name = "radioButtonDodecahedron";
            this.radioButtonDodecahedron.Size = new System.Drawing.Size(102, 21);
            this.radioButtonDodecahedron.TabIndex = 4;
            this.radioButtonDodecahedron.TabStop = true;
            this.radioButtonDodecahedron.Text = "Додекаэдр";
            this.radioButtonDodecahedron.UseVisualStyleBackColor = true;
            this.radioButtonDodecahedron.CheckedChanged += new System.EventHandler(this.radioButtonTetraedr_CheckedChanged);
            // 
            // radioButtonXaxahedron
            // 
            this.radioButtonXaxahedron.AutoSize = true;
            this.radioButtonXaxahedron.Location = new System.Drawing.Point(35, 140);
            this.radioButtonXaxahedron.Name = "radioButtonXaxahedron";
            this.radioButtonXaxahedron.Size = new System.Drawing.Size(92, 21);
            this.radioButtonXaxahedron.TabIndex = 3;
            this.radioButtonXaxahedron.TabStop = true;
            this.radioButtonXaxahedron.Text = "Иксоаэдр";
            this.radioButtonXaxahedron.UseVisualStyleBackColor = true;
            this.radioButtonXaxahedron.CheckedChanged += new System.EventHandler(this.radioButtonTetraedr_CheckedChanged);
            // 
            // radioButtonOctaedr
            // 
            this.radioButtonOctaedr.AutoSize = true;
            this.radioButtonOctaedr.Location = new System.Drawing.Point(35, 103);
            this.radioButtonOctaedr.Name = "radioButtonOctaedr";
            this.radioButtonOctaedr.Size = new System.Drawing.Size(85, 21);
            this.radioButtonOctaedr.TabIndex = 2;
            this.radioButtonOctaedr.TabStop = true;
            this.radioButtonOctaedr.Text = "Октаэдр";
            this.radioButtonOctaedr.UseVisualStyleBackColor = true;
            this.radioButtonOctaedr.CheckedChanged += new System.EventHandler(this.radioButtonTetraedr_CheckedChanged);
            // 
            // speed_Box
            // 
            this.speed_Box.DecimalPlaces = 2;
            this.speed_Box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speed_Box.Location = new System.Drawing.Point(158, 20);
            this.speed_Box.Name = "speed_Box";
            this.speed_Box.Size = new System.Drawing.Size(69, 22);
            this.speed_Box.TabIndex = 3;
            this.speed_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speed_Box.ValueChanged += new System.EventHandler(this.speed_Box_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.noVector_rb);
            this.groupBox4.Controls.Add(this.rotateY_rb);
            this.groupBox4.Controls.Add(this.rotateX_rb);
            this.groupBox4.Location = new System.Drawing.Point(31, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 126);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вектор вращения";
            // 
            // rotateBody
            // 
            this.rotateBody.AutoSize = true;
            this.rotateBody.Checked = true;
            this.rotateBody.Location = new System.Drawing.Point(13, 22);
            this.rotateBody.Margin = new System.Windows.Forms.Padding(4);
            this.rotateBody.Name = "rotateBody";
            this.rotateBody.Size = new System.Drawing.Size(60, 21);
            this.rotateBody.TabIndex = 0;
            this.rotateBody.TabStop = true;
            this.rotateBody.Text = "тела";
            this.rotateBody.UseVisualStyleBackColor = true;
            this.rotateBody.CheckedChanged += new System.EventHandler(this.rotateBody_CheckedChanged);
            // 
            // radioButtonTetraedr
            // 
            this.radioButtonTetraedr.AutoSize = true;
            this.radioButtonTetraedr.Checked = true;
            this.radioButtonTetraedr.Location = new System.Drawing.Point(35, 21);
            this.radioButtonTetraedr.Name = "radioButtonTetraedr";
            this.radioButtonTetraedr.Size = new System.Drawing.Size(92, 21);
            this.radioButtonTetraedr.TabIndex = 0;
            this.radioButtonTetraedr.TabStop = true;
            this.radioButtonTetraedr.Text = "Тетраэдр";
            this.radioButtonTetraedr.UseVisualStyleBackColor = true;
            this.radioButtonTetraedr.CheckedChanged += new System.EventHandler(this.radioButtonTetraedr_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rotateOXYZ);
            this.groupBox2.Controls.Add(this.rotateBody);
            this.groupBox2.Location = new System.Drawing.Point(222, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(124, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вращение";
            // 
            // rotateOXYZ
            // 
            this.rotateOXYZ.AutoSize = true;
            this.rotateOXYZ.Location = new System.Drawing.Point(13, 50);
            this.rotateOXYZ.Margin = new System.Windows.Forms.Padding(4);
            this.rotateOXYZ.Name = "rotateOXYZ";
            this.rotateOXYZ.Size = new System.Drawing.Size(60, 21);
            this.rotateOXYZ.TabIndex = 1;
            this.rotateOXYZ.Text = "осей";
            this.rotateOXYZ.UseVisualStyleBackColor = true;
            this.rotateOXYZ.CheckedChanged += new System.EventHandler(this.rotateOXYZ_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.speed_Box);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вращение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.radioButtonHexaedr);
            this.tabPage1.Controls.Add(this.radioButtonDodecahedron);
            this.tabPage1.Controls.Add(this.radioButtonXaxahedron);
            this.tabPage1.Controls.Add(this.radioButtonOctaedr);
            this.tabPage1.Controls.Add(this.radioButtonTetraedr);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Тела";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 312);
            this.tabControl1.TabIndex = 1;
            // 
            // TPBtn
            // 
            this.TPBtn.AutoSize = true;
            this.TPBtn.Location = new System.Drawing.Point(21, 127);
            this.TPBtn.Name = "TPBtn";
            this.TPBtn.Size = new System.Drawing.Size(208, 21);
            this.TPBtn.TabIndex = 3;
            this.TPBtn.Text = "двухточечная перспектива";
            this.TPBtn.UseVisualStyleBackColor = true;
            this.TPBtn.CheckedChanged += new System.EventHandler(this.OPbtn_CheckedChanged);
            // 
            // OPbtn
            // 
            this.OPbtn.AutoSize = true;
            this.OPbtn.Location = new System.Drawing.Point(21, 37);
            this.OPbtn.Name = "OPbtn";
            this.OPbtn.Size = new System.Drawing.Size(212, 21);
            this.OPbtn.TabIndex = 4;
            this.OPbtn.Text = "одноточечная перспектива";
            this.OPbtn.UseVisualStyleBackColor = true;
            this.OPbtn.CheckedChanged += new System.EventHandler(this.OPbtn_CheckedChanged);
            // 
            // onePointScroll
            // 
            this.onePointScroll.Location = new System.Drawing.Point(21, 65);
            this.onePointScroll.Name = "onePointScroll";
            this.onePointScroll.Size = new System.Drawing.Size(294, 21);
            this.onePointScroll.TabIndex = 5;
            this.onePointScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.onePointScroll_Scroll);
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 312);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTools";
            this.Text = "FormTools";
            this.Load += new System.EventHandler(this.FormTools_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_Box)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar firstPerspectivePoint_sb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PerspectiveVisible_cb;
        private System.Windows.Forms.CheckBox OXYZ_visible;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.HScrollBar secodPerspectivePoint_sb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonStereo;
        private System.Windows.Forms.RadioButton radioButtonFace;
        private System.Windows.Forms.RadioButton radioButtonEdge;
        private System.Windows.Forms.RadioButton noVector_rb;
        private System.Windows.Forms.RadioButton rotateY_rb;
        private System.Windows.Forms.RadioButton rotateX_rb;
        private System.Windows.Forms.RadioButton radioButtonHexaedr;
        private System.Windows.Forms.RadioButton radioButtonDodecahedron;
        private System.Windows.Forms.RadioButton radioButtonXaxahedron;
        private System.Windows.Forms.RadioButton radioButtonOctaedr;
        private System.Windows.Forms.NumericUpDown speed_Box;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rotateBody;
        private System.Windows.Forms.RadioButton radioButtonTetraedr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rotateOXYZ;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.HScrollBar onePointScroll;
        private System.Windows.Forms.RadioButton OPbtn;
        private System.Windows.Forms.RadioButton TPBtn;
    }
}