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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSteelAlgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jominyDBDataSet = new JominyPredict.jominyDBDataSet();
            this.tbSteelAlgTableAdapter = new JominyPredict.jominyDBDataSetTableAdapters.tbSteelAlgTableAdapter();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteelAlgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.steelDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.algDataGridViewTextBoxColumn,
            this.outpointDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbSteelAlgBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(685, 370);
            this.dataGridView1.TabIndex = 0;
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
            this.steelDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelDataGridViewTextBoxColumn.Name = "steelDataGridViewTextBoxColumn";
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "规格";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            // 
            // algDataGridViewTextBoxColumn
            // 
            this.algDataGridViewTextBoxColumn.DataPropertyName = "alg";
            this.algDataGridViewTextBoxColumn.HeaderText = "算法";
            this.algDataGridViewTextBoxColumn.Name = "algDataGridViewTextBoxColumn";
            // 
            // outpointDataGridViewTextBoxColumn
            // 
            this.outpointDataGridViewTextBoxColumn.DataPropertyName = "outpoint";
            this.outpointDataGridViewTextBoxColumn.HeaderText = "输出点";
            this.outpointDataGridViewTextBoxColumn.Name = "outpointDataGridViewTextBoxColumn";
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
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(191, 428);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(114, 41);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(445, 428);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 41);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormCfgCal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(833, 498);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCfgCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCfgCal";
            this.Load += new System.EventHandler(this.FormCfgCal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteelAlgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jominyDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private jominyDBDataSet jominyDBDataSet;
        private System.Windows.Forms.BindingSource tbSteelAlgBindingSource;
        private jominyDBDataSetTableAdapters.tbSteelAlgTableAdapter tbSteelAlgTableAdapter;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn algDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outpointDataGridViewTextBoxColumn;
    }
}