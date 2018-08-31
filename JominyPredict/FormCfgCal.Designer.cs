namespace JominyPredict
{
    partial class FormCfgCal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jominyDBDataSet = new JominyPredict.jominyDBDataSet();
            this.jominyDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSteelAlgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSteelAlgTableAdapter = new JominyPredict.jominyDBDataSetTableAdapters.tbSteelAlgTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancepointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteelAlgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1080, 400);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.steelDataGridViewTextBoxColumn,
            this.algDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.outpointDataGridViewTextBoxColumn,
            this.distancepointDataGridViewTextBoxColumn,
            this.dp1DataGridViewTextBoxColumn,
            this.dp2DataGridViewTextBoxColumn,
            this.dp3DataGridViewTextBoxColumn,
            this.dp4DataGridViewTextBoxColumn,
            this.dp5DataGridViewTextBoxColumn,
            this.dp6DataGridViewTextBoxColumn,
            this.dp7DataGridViewTextBoxColumn,
            this.dp8DataGridViewTextBoxColumn,
            this.dp9DataGridViewTextBoxColumn,
            this.dp10DataGridViewTextBoxColumn,
            this.dp11DataGridViewTextBoxColumn,
            this.dp12DataGridViewTextBoxColumn,
            this.dp13DataGridViewTextBoxColumn,
            this.dp14DataGridViewTextBoxColumn,
            this.dp15DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbSteelAlgBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // jominyDBDataSet
            // 
            this.jominyDBDataSet.DataSetName = "jominyDBDataSet";
            this.jominyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jominyDBDataSetBindingSource
            // 
            this.jominyDBDataSetBindingSource.DataSource = this.jominyDBDataSet;
            this.jominyDBDataSetBindingSource.Position = 0;
            // 
            // tbSteelAlgBindingSource
            // 
            this.tbSteelAlgBindingSource.DataMember = "tbSteelAlg";
            this.tbSteelAlgBindingSource.DataSource = this.jominyDBDataSetBindingSource;
            // 
            // tbSteelAlgTableAdapter
            // 
            this.tbSteelAlgTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // steelDataGridViewTextBoxColumn
            // 
            this.steelDataGridViewTextBoxColumn.DataPropertyName = "steel";
            this.steelDataGridViewTextBoxColumn.HeaderText = "steel";
            this.steelDataGridViewTextBoxColumn.Name = "steelDataGridViewTextBoxColumn";
            // 
            // algDataGridViewTextBoxColumn
            // 
            this.algDataGridViewTextBoxColumn.DataPropertyName = "alg";
            this.algDataGridViewTextBoxColumn.HeaderText = "alg";
            this.algDataGridViewTextBoxColumn.Name = "algDataGridViewTextBoxColumn";
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "spec";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            // 
            // outpointDataGridViewTextBoxColumn
            // 
            this.outpointDataGridViewTextBoxColumn.DataPropertyName = "outpoint";
            this.outpointDataGridViewTextBoxColumn.HeaderText = "outpoint";
            this.outpointDataGridViewTextBoxColumn.Name = "outpointDataGridViewTextBoxColumn";
            // 
            // distancepointDataGridViewTextBoxColumn
            // 
            this.distancepointDataGridViewTextBoxColumn.DataPropertyName = "distancepoint";
            this.distancepointDataGridViewTextBoxColumn.HeaderText = "distancepoint";
            this.distancepointDataGridViewTextBoxColumn.Name = "distancepointDataGridViewTextBoxColumn";
            // 
            // dp1DataGridViewTextBoxColumn
            // 
            this.dp1DataGridViewTextBoxColumn.DataPropertyName = "dp1";
            this.dp1DataGridViewTextBoxColumn.HeaderText = "dp1";
            this.dp1DataGridViewTextBoxColumn.Name = "dp1DataGridViewTextBoxColumn";
            // 
            // dp2DataGridViewTextBoxColumn
            // 
            this.dp2DataGridViewTextBoxColumn.DataPropertyName = "dp2";
            this.dp2DataGridViewTextBoxColumn.HeaderText = "dp2";
            this.dp2DataGridViewTextBoxColumn.Name = "dp2DataGridViewTextBoxColumn";
            // 
            // dp3DataGridViewTextBoxColumn
            // 
            this.dp3DataGridViewTextBoxColumn.DataPropertyName = "dp3";
            this.dp3DataGridViewTextBoxColumn.HeaderText = "dp3";
            this.dp3DataGridViewTextBoxColumn.Name = "dp3DataGridViewTextBoxColumn";
            // 
            // dp4DataGridViewTextBoxColumn
            // 
            this.dp4DataGridViewTextBoxColumn.DataPropertyName = "dp4";
            this.dp4DataGridViewTextBoxColumn.HeaderText = "dp4";
            this.dp4DataGridViewTextBoxColumn.Name = "dp4DataGridViewTextBoxColumn";
            // 
            // dp5DataGridViewTextBoxColumn
            // 
            this.dp5DataGridViewTextBoxColumn.DataPropertyName = "dp5";
            this.dp5DataGridViewTextBoxColumn.HeaderText = "dp5";
            this.dp5DataGridViewTextBoxColumn.Name = "dp5DataGridViewTextBoxColumn";
            // 
            // dp6DataGridViewTextBoxColumn
            // 
            this.dp6DataGridViewTextBoxColumn.DataPropertyName = "dp6";
            this.dp6DataGridViewTextBoxColumn.HeaderText = "dp6";
            this.dp6DataGridViewTextBoxColumn.Name = "dp6DataGridViewTextBoxColumn";
            // 
            // dp7DataGridViewTextBoxColumn
            // 
            this.dp7DataGridViewTextBoxColumn.DataPropertyName = "dp7";
            this.dp7DataGridViewTextBoxColumn.HeaderText = "dp7";
            this.dp7DataGridViewTextBoxColumn.Name = "dp7DataGridViewTextBoxColumn";
            // 
            // dp8DataGridViewTextBoxColumn
            // 
            this.dp8DataGridViewTextBoxColumn.DataPropertyName = "dp8";
            this.dp8DataGridViewTextBoxColumn.HeaderText = "dp8";
            this.dp8DataGridViewTextBoxColumn.Name = "dp8DataGridViewTextBoxColumn";
            // 
            // dp9DataGridViewTextBoxColumn
            // 
            this.dp9DataGridViewTextBoxColumn.DataPropertyName = "dp9";
            this.dp9DataGridViewTextBoxColumn.HeaderText = "dp9";
            this.dp9DataGridViewTextBoxColumn.Name = "dp9DataGridViewTextBoxColumn";
            // 
            // dp10DataGridViewTextBoxColumn
            // 
            this.dp10DataGridViewTextBoxColumn.DataPropertyName = "dp10";
            this.dp10DataGridViewTextBoxColumn.HeaderText = "dp10";
            this.dp10DataGridViewTextBoxColumn.Name = "dp10DataGridViewTextBoxColumn";
            // 
            // dp11DataGridViewTextBoxColumn
            // 
            this.dp11DataGridViewTextBoxColumn.DataPropertyName = "dp11";
            this.dp11DataGridViewTextBoxColumn.HeaderText = "dp11";
            this.dp11DataGridViewTextBoxColumn.Name = "dp11DataGridViewTextBoxColumn";
            // 
            // dp12DataGridViewTextBoxColumn
            // 
            this.dp12DataGridViewTextBoxColumn.DataPropertyName = "dp12";
            this.dp12DataGridViewTextBoxColumn.HeaderText = "dp12";
            this.dp12DataGridViewTextBoxColumn.Name = "dp12DataGridViewTextBoxColumn";
            // 
            // dp13DataGridViewTextBoxColumn
            // 
            this.dp13DataGridViewTextBoxColumn.DataPropertyName = "dp13";
            this.dp13DataGridViewTextBoxColumn.HeaderText = "dp13";
            this.dp13DataGridViewTextBoxColumn.Name = "dp13DataGridViewTextBoxColumn";
            // 
            // dp14DataGridViewTextBoxColumn
            // 
            this.dp14DataGridViewTextBoxColumn.DataPropertyName = "dp14";
            this.dp14DataGridViewTextBoxColumn.HeaderText = "dp14";
            this.dp14DataGridViewTextBoxColumn.Name = "dp14DataGridViewTextBoxColumn";
            // 
            // dp15DataGridViewTextBoxColumn
            // 
            this.dp15DataGridViewTextBoxColumn.DataPropertyName = "dp15";
            this.dp15DataGridViewTextBoxColumn.HeaderText = "dp15";
            this.dp15DataGridViewTextBoxColumn.Name = "dp15DataGridViewTextBoxColumn";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(306, 491);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(80, 35);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(536, 491);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(80, 35);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormCfgCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 661);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.panel1);
            this.Name = "FormCfgCal";
            this.Text = "FormCfgCal";
            this.Load += new System.EventHandler(this.FormCfgCal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteelAlgBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jominyDBDataSetBindingSource;
        private jominyDBDataSet jominyDBDataSet;
        private System.Windows.Forms.BindingSource tbSteelAlgBindingSource;
        private jominyDBDataSetTableAdapters.tbSteelAlgTableAdapter tbSteelAlgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn algDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancepointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp15DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}