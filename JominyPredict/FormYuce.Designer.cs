namespace JominyPredict
{
    partial class FormYuce
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
            this.btCal = new System.Windows.Forms.Button();
            this.lbSampleID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbMo = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbNi = new System.Windows.Forms.TextBox();
            this.tbSi = new System.Windows.Forms.TextBox();
            this.tbTi = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbCr = new System.Windows.Forms.TextBox();
            this.tbMn = new System.Windows.Forms.TextBox();
            this.btReCal = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCal
            // 
            this.btCal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCal.Location = new System.Drawing.Point(763, 92);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(173, 49);
            this.btCal.TabIndex = 0;
            this.btCal.Text = "预报实验";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // lbSampleID
            // 
            this.lbSampleID.AutoSize = true;
            this.lbSampleID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSampleID.Location = new System.Drawing.Point(36, 52);
            this.lbSampleID.Name = "lbSampleID";
            this.lbSampleID.Size = new System.Drawing.Size(118, 24);
            this.lbSampleID.TabIndex = 3;
            this.lbSampleID.Text = "样品编号:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(160, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 35);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(374, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "钢  种：";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "alg";
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(483, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "alg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbMo);
            this.groupBox1.Controls.Add(this.tbB);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbNi);
            this.groupBox1.Controls.Add(this.tbSi);
            this.groupBox1.Controls.Add(this.tbTi);
            this.groupBox1.Controls.Add(this.tbC);
            this.groupBox1.Controls.Add(this.tbCr);
            this.groupBox1.Controls.Add(this.tbMn);
            this.groupBox1.Location = new System.Drawing.Point(19, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(668, 148);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "钢种化学成分(%)";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(337, 98);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 18);
            this.label23.TabIndex = 0;
            this.label23.Text = "Mo:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(498, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "B:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(498, 43);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 18);
            this.label22.TabIndex = 0;
            this.label22.Text = "Ni:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(44, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "C:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(184, 98);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 18);
            this.label21.TabIndex = 0;
            this.label21.Text = "Ti:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(40, 98);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Cr:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(184, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mn:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMo
            // 
            this.tbMo.Location = new System.Drawing.Point(388, 88);
            this.tbMo.Margin = new System.Windows.Forms.Padding(4);
            this.tbMo.Name = "tbMo";
            this.tbMo.Size = new System.Drawing.Size(80, 28);
            this.tbMo.TabIndex = 14;
            this.tbMo.Text = "0.010800000000000";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(558, 88);
            this.tbB.Margin = new System.Windows.Forms.Padding(4);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(80, 28);
            this.tbB.TabIndex = 9;
            this.tbB.Text = "0.002150000000000";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(337, 43);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Si:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNi
            // 
            this.tbNi.Location = new System.Drawing.Point(558, 33);
            this.tbNi.Margin = new System.Windows.Forms.Padding(4);
            this.tbNi.Name = "tbNi";
            this.tbNi.Size = new System.Drawing.Size(80, 28);
            this.tbNi.TabIndex = 9;
            this.tbNi.Text = "0.030000000000000";
            // 
            // tbSi
            // 
            this.tbSi.Location = new System.Drawing.Point(388, 33);
            this.tbSi.Margin = new System.Windows.Forms.Padding(4);
            this.tbSi.Name = "tbSi";
            this.tbSi.Size = new System.Drawing.Size(80, 28);
            this.tbSi.TabIndex = 5;
            this.tbSi.Text = "0.288000000000000";
            // 
            // tbTi
            // 
            this.tbTi.Location = new System.Drawing.Point(240, 88);
            this.tbTi.Margin = new System.Windows.Forms.Padding(4);
            this.tbTi.Name = "tbTi";
            this.tbTi.Size = new System.Drawing.Size(80, 28);
            this.tbTi.TabIndex = 12;
            this.tbTi.Text = "0.026200000000000";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(95, 33);
            this.tbC.Margin = new System.Windows.Forms.Padding(4);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(80, 28);
            this.tbC.TabIndex = 3;
            this.tbC.Text = "0.329400000000000";
            // 
            // tbCr
            // 
            this.tbCr.Location = new System.Drawing.Point(95, 88);
            this.tbCr.Margin = new System.Windows.Forms.Padding(4);
            this.tbCr.Name = "tbCr";
            this.tbCr.Size = new System.Drawing.Size(80, 28);
            this.tbCr.TabIndex = 10;
            this.tbCr.Text = "0.167000000000000";
            // 
            // tbMn
            // 
            this.tbMn.Location = new System.Drawing.Point(240, 33);
            this.tbMn.Margin = new System.Windows.Forms.Padding(4);
            this.tbMn.Name = "tbMn";
            this.tbMn.Size = new System.Drawing.Size(80, 28);
            this.tbMn.TabIndex = 4;
            this.tbMn.Text = "1.032000000000000";
            // 
            // btReCal
            // 
            this.btReCal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReCal.Location = new System.Drawing.Point(763, 176);
            this.btReCal.Name = "btReCal";
            this.btReCal.Size = new System.Drawing.Size(173, 49);
            this.btReCal.TabIndex = 1;
            this.btReCal.Text = "清空数据";
            this.btReCal.UseVisualStyleBackColor = true;
            this.btReCal.Click += new System.EventHandler(this.btReCal_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(19, 287);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(864, 319);
            this.tbResult.TabIndex = 22;
            // 
            // FormYuce
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 645);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSampleID);
            this.Controls.Add(this.btReCal);
            this.Controls.Add(this.btCal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYuce";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormYuce";
            this.Load += new System.EventHandler(this.FormYuce_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Label lbSampleID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbMo;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbNi;
        private System.Windows.Forms.TextBox tbSi;
        private System.Windows.Forms.TextBox tbTi;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbCr;
        private System.Windows.Forms.TextBox tbMn;
        private System.Windows.Forms.Button btReCal;
        private System.Windows.Forms.TextBox tbResult;
    }
}