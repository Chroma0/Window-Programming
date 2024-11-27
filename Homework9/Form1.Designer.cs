namespace Homework9
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Homework9.Database1DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.員工編號姓名電子信箱BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.員工編號_姓名_電子信箱TableAdapter = new Homework9.Database1DataSetTableAdapters.員工編號_姓名_電子信箱TableAdapter();
            this.員工編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電子信箱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.員工編號姓名電子信箱員工編號薪水BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.員工編號_薪水TableAdapter = new Homework9.Database1DataSetTableAdapters.員工編號_薪水TableAdapter();
            this.員工編號DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.薪水DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.員工編號薪水電話員工編號BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.電話_員工編號TableAdapter = new Homework9.Database1DataSetTableAdapters.電話_員工編號TableAdapter();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.員工編號DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工編號姓名電子信箱BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工編號姓名電子信箱員工編號薪水BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工編號薪水電話員工編號BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.員工編號DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.電子信箱DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.員工編號姓名電子信箱BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.員工編號DataGridViewTextBoxColumn1,
            this.薪水DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.員工編號姓名電子信箱員工編號薪水BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(776, 130);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.電話DataGridViewTextBoxColumn,
            this.員工編號DataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.員工編號薪水電話員工編號BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 322);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(776, 116);
            this.dataGridView3.TabIndex = 2;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.database1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // 員工編號姓名電子信箱BindingSource
            // 
            this.員工編號姓名電子信箱BindingSource.DataMember = "員工編號_姓名_電子信箱";
            this.員工編號姓名電子信箱BindingSource.DataSource = this.database1DataSet;
            // 
            // 員工編號_姓名_電子信箱TableAdapter
            // 
            this.員工編號_姓名_電子信箱TableAdapter.ClearBeforeFill = true;
            // 
            // 員工編號DataGridViewTextBoxColumn
            // 
            this.員工編號DataGridViewTextBoxColumn.DataPropertyName = "員工編號";
            this.員工編號DataGridViewTextBoxColumn.HeaderText = "員工編號";
            this.員工編號DataGridViewTextBoxColumn.Name = "員工編號DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 電子信箱DataGridViewTextBoxColumn
            // 
            this.電子信箱DataGridViewTextBoxColumn.DataPropertyName = "電子信箱";
            this.電子信箱DataGridViewTextBoxColumn.HeaderText = "電子信箱";
            this.電子信箱DataGridViewTextBoxColumn.Name = "電子信箱DataGridViewTextBoxColumn";
            // 
            // 員工編號姓名電子信箱員工編號薪水BindingSource
            // 
            this.員工編號姓名電子信箱員工編號薪水BindingSource.DataMember = "員工編號_姓名_電子信箱_員工編號_薪水";
            this.員工編號姓名電子信箱員工編號薪水BindingSource.DataSource = this.員工編號姓名電子信箱BindingSource;
            // 
            // 員工編號_薪水TableAdapter
            // 
            this.員工編號_薪水TableAdapter.ClearBeforeFill = true;
            // 
            // 員工編號DataGridViewTextBoxColumn1
            // 
            this.員工編號DataGridViewTextBoxColumn1.DataPropertyName = "員工編號";
            this.員工編號DataGridViewTextBoxColumn1.HeaderText = "員工編號";
            this.員工編號DataGridViewTextBoxColumn1.Name = "員工編號DataGridViewTextBoxColumn1";
            // 
            // 薪水DataGridViewTextBoxColumn
            // 
            this.薪水DataGridViewTextBoxColumn.DataPropertyName = "薪水";
            this.薪水DataGridViewTextBoxColumn.HeaderText = "薪水";
            this.薪水DataGridViewTextBoxColumn.Name = "薪水DataGridViewTextBoxColumn";
            // 
            // 員工編號薪水電話員工編號BindingSource
            // 
            this.員工編號薪水電話員工編號BindingSource.DataMember = "員工編號_薪水_電話_員工編號";
            this.員工編號薪水電話員工編號BindingSource.DataSource = this.員工編號姓名電子信箱員工編號薪水BindingSource;
            // 
            // 電話_員工編號TableAdapter
            // 
            this.電話_員工編號TableAdapter.ClearBeforeFill = true;
            // 
            // 電話DataGridViewTextBoxColumn
            // 
            this.電話DataGridViewTextBoxColumn.DataPropertyName = "電話";
            this.電話DataGridViewTextBoxColumn.HeaderText = "電話";
            this.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn";
            // 
            // 員工編號DataGridViewTextBoxColumn2
            // 
            this.員工編號DataGridViewTextBoxColumn2.DataPropertyName = "員工編號";
            this.員工編號DataGridViewTextBoxColumn2.HeaderText = "員工編號";
            this.員工編號DataGridViewTextBoxColumn2.Name = "員工編號DataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工編號姓名電子信箱BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工編號姓名電子信箱員工編號薪水BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工編號薪水電話員工編號BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource 員工編號姓名電子信箱BindingSource;
        private Database1DataSetTableAdapters.員工編號_姓名_電子信箱TableAdapter 員工編號_姓名_電子信箱TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 員工編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電子信箱DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 員工編號姓名電子信箱員工編號薪水BindingSource;
        private Database1DataSetTableAdapters.員工編號_薪水TableAdapter 員工編號_薪水TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 員工編號DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 薪水DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 員工編號薪水電話員工編號BindingSource;
        private Database1DataSetTableAdapters.電話_員工編號TableAdapter 電話_員工編號TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 員工編號DataGridViewTextBoxColumn2;
    }
}

