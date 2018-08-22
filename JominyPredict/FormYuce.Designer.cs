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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCal = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lbSampleID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbSteelAlgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jominyDBDataSet = new JominyPredict.jominyDBDataSet();
            this.tbSteelAlgTableAdapter = new JominyPredict.jominyDBDataSetTableAdapters.tbSteelAlgTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SampleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Si = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jominy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jominyDBDataSet1 = new JominyPredict.jominyDBDataSet1();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btReCal = new System.Windows.Forms.Button();
            this.tbSampleTableAdapter = new JominyPredict.jominyDBDataSet1TableAdapters.tbSampleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteelAlgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCal
            // 
            this.btCal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCal.Location = new System.Drawing.Point(763, 70);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(120, 49);
            this.btCal.TabIndex = 0;
            this.btCal.Text = "预测计算";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSave.Location = new System.Drawing.Point(763, 173);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 49);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "保存记录";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            this.comboBox1.DataSource = this.tbSteelAlgBindingSource;
            this.comboBox1.DisplayMember = "steel";
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(483, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "alg";
            // 
            // tbSteelAlgBindingSource
            // 
            this.tbSteelAlgBindingSource.DataMember = "tbSteelAlg";
            this.tbSteelAlgBindingSource.DataSource = this.jominyDBDataSet;
            // 
            // jominyDBDataSet
            // 
            this.jominyDBDataSet.DataSetName = "jominyDBDataSet";
            this.jominyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSteelAlgTableAdapter
            // 
            this.tbSteelAlgTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SampleNo,
            this.steelClass,
            this.C,
            this.Mn,
            this.Si,
            this.Ni,
            this.Cr,
            this.Ti,
            this.Mo,
            this.B,
            this.Jominy,
            this.algDateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbSampleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 344);
            this.dataGridView1.TabIndex = 6;
            // 
            // SampleNo
            // 
            this.SampleNo.DataPropertyName = "sampleId";
            this.SampleNo.HeaderText = "样品编号";
            this.SampleNo.Name = "SampleNo";
            this.SampleNo.ReadOnly = true;
            this.SampleNo.Width = 120;
            // 
            // steelClass
            // 
            this.steelClass.DataPropertyName = "steel";
            this.steelClass.HeaderText = "钢种";
            this.steelClass.Name = "steelClass";
            this.steelClass.ReadOnly = true;
            // 
            // C
            // 
            this.C.DataPropertyName = "C";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.C.DefaultCellStyle = dataGridViewCellStyle1;
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 50;
            // 
            // Mn
            // 
            this.Mn.DataPropertyName = "MN";
            dataGridViewCellStyle2.Format = "N3";
            this.Mn.DefaultCellStyle = dataGridViewCellStyle2;
            this.Mn.HeaderText = "Mn";
            this.Mn.Name = "Mn";
            this.Mn.ReadOnly = true;
            this.Mn.Width = 50;
            // 
            // Si
            // 
            this.Si.DataPropertyName = "SI";
            dataGridViewCellStyle3.Format = "N3";
            this.Si.DefaultCellStyle = dataGridViewCellStyle3;
            this.Si.HeaderText = "Si";
            this.Si.Name = "Si";
            this.Si.ReadOnly = true;
            this.Si.Width = 50;
            // 
            // Ni
            // 
            this.Ni.DataPropertyName = "NI";
            dataGridViewCellStyle4.Format = "N3";
            this.Ni.DefaultCellStyle = dataGridViewCellStyle4;
            this.Ni.HeaderText = "Ni";
            this.Ni.Name = "Ni";
            this.Ni.ReadOnly = true;
            this.Ni.Width = 50;
            // 
            // Cr
            // 
            this.Cr.DataPropertyName = "CR";
            dataGridViewCellStyle5.Format = "N3";
            this.Cr.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cr.HeaderText = "Cr";
            this.Cr.Name = "Cr";
            this.Cr.ReadOnly = true;
            this.Cr.Width = 50;
            // 
            // Ti
            // 
            this.Ti.DataPropertyName = "TI";
            this.Ti.HeaderText = "Ti";
            this.Ti.Name = "Ti";
            this.Ti.ReadOnly = true;
            this.Ti.Width = 50;
            // 
            // Mo
            // 
            this.Mo.DataPropertyName = "MO";
            this.Mo.HeaderText = "Mo";
            this.Mo.Name = "Mo";
            this.Mo.ReadOnly = true;
            this.Mo.Width = 50;
            // 
            // B
            // 
            this.B.DataPropertyName = "B";
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 50;
            // 
            // Jominy
            // 
            this.Jominy.DataPropertyName = "jominy";
            this.Jominy.HeaderText = "端淬度";
            this.Jominy.Name = "Jominy";
            this.Jominy.ReadOnly = true;
            this.Jominy.Width = 300;
            // 
            // algDateTimeDataGridViewTextBoxColumn
            // 
            this.algDateTimeDataGridViewTextBoxColumn.DataPropertyName = "algDateTime";
            this.algDateTimeDataGridViewTextBoxColumn.HeaderText = "计算时间";
            this.algDateTimeDataGridViewTextBoxColumn.Name = "algDateTimeDataGridViewTextBoxColumn";
            this.algDateTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // tbSampleBindingSource
            // 
            this.tbSampleBindingSource.DataMember = "tbSample";
            this.tbSampleBindingSource.DataSource = this.jominyDBDataSet1;
            // 
            // jominyDBDataSet1
            // 
            this.jominyDBDataSet1.DataSetName = "jominyDBDataSet1";
            this.jominyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tbMo.Text = "0";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(558, 88);
            this.tbB.Margin = new System.Windows.Forms.Padding(4);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(80, 28);
            this.tbB.TabIndex = 9;
            this.tbB.Text = "0";
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
            this.tbNi.Text = "0";
            // 
            // tbSi
            // 
            this.tbSi.Location = new System.Drawing.Point(388, 33);
            this.tbSi.Margin = new System.Windows.Forms.Padding(4);
            this.tbSi.Name = "tbSi";
            this.tbSi.Size = new System.Drawing.Size(80, 28);
            this.tbSi.TabIndex = 5;
            this.tbSi.Text = "0";
            // 
            // tbTi
            // 
            this.tbTi.Location = new System.Drawing.Point(240, 88);
            this.tbTi.Margin = new System.Windows.Forms.Padding(4);
            this.tbTi.Name = "tbTi";
            this.tbTi.Size = new System.Drawing.Size(80, 28);
            this.tbTi.TabIndex = 12;
            this.tbTi.Text = "0";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(95, 33);
            this.tbC.Margin = new System.Windows.Forms.Padding(4);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(80, 28);
            this.tbC.TabIndex = 3;
            this.tbC.Text = "0";
            // 
            // tbCr
            // 
            this.tbCr.Location = new System.Drawing.Point(95, 88);
            this.tbCr.Margin = new System.Windows.Forms.Padding(4);
            this.tbCr.Name = "tbCr";
            this.tbCr.Size = new System.Drawing.Size(80, 28);
            this.tbCr.TabIndex = 10;
            this.tbCr.Text = "0";
            // 
            // tbMn
            // 
            this.tbMn.Location = new System.Drawing.Point(240, 33);
            this.tbMn.Margin = new System.Windows.Forms.Padding(4);
            this.tbMn.Name = "tbMn";
            this.tbMn.Size = new System.Drawing.Size(80, 28);
            this.tbMn.TabIndex = 4;
            this.tbMn.Text = "0";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // btReCal
            // 
            this.btReCal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReCal.Location = new System.Drawing.Point(763, 123);
            this.btReCal.Name = "btReCal";
            this.btReCal.Size = new System.Drawing.Size(120, 49);
            this.btReCal.TabIndex = 1;
            this.btReCal.Text = "重新计算";
            this.btReCal.UseVisualStyleBackColor = true;
            // 
            // tbSampleTableAdapter
            // 
            this.tbSampleTableAdapter.ClearBeforeFill = true;
            // 
            // FormYuce
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSampleID);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btReCal);
            this.Controls.Add(this.btCal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYuce";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormYuce";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormYuce_FormClosing);
            this.Load += new System.EventHandler(this.FormYuce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSteelAlgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbSampleID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private jominyDBDataSet jominyDBDataSet;
        private System.Windows.Forms.BindingSource tbSteelAlgBindingSource;
        private jominyDBDataSetTableAdapters.tbSteelAlgTableAdapter tbSteelAlgTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btReCal;
        private jominyDBDataSet1 jominyDBDataSet1;
        private System.Windows.Forms.BindingSource tbSampleBindingSource;
        private jominyDBDataSet1TableAdapters.tbSampleTableAdapter tbSampleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Si;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mo;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jominy;
        private System.Windows.Forms.DataGridViewTextBoxColumn algDateTimeDataGridViewTextBoxColumn;
    }
}