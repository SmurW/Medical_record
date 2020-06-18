namespace Medical_record
{
    partial class ProceduresView
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

        #region Windows from Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProceduresView));
            this._textBoxSearch = new System.Windows.Forms.TextBox();
            this._comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._buttonUpdate = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._dataGridViewProcedures = new System.Windows.Forms.DataGridView();
            this._columnOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewProcedures)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBoxSearch
            // 
            this._textBoxSearch.Location = new System.Drawing.Point(388, 16);
            this._textBoxSearch.Name = "_textBoxSearch";
            this._textBoxSearch.Size = new System.Drawing.Size(224, 20);
            this._textBoxSearch.TabIndex = 15;
            // 
            // _comboBoxSort
            // 
            this._comboBoxSort.FormattingEnabled = true;
            this._comboBoxSort.Items.AddRange(new object[] {
            "По Наименованию",
            "По Описанию"});
            this._comboBoxSort.Location = new System.Drawing.Point(110, 16);
            this._comboBoxSort.Name = "_comboBoxSort";
            this._comboBoxSort.Size = new System.Drawing.Size(121, 21);
            this._comboBoxSort.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Сортировка по:";
            // 
            // _buttonRemove
            // 
            this._buttonRemove.Location = new System.Drawing.Point(296, 306);
            this._buttonRemove.Name = "_buttonRemove";
            this._buttonRemove.Size = new System.Drawing.Size(75, 23);
            this._buttonRemove.TabIndex = 11;
            this._buttonRemove.Text = "Удалить";
            this._buttonRemove.UseVisualStyleBackColor = true;
            // 
            // _buttonUpdate
            // 
            this._buttonUpdate.Location = new System.Drawing.Point(205, 306);
            this._buttonUpdate.Name = "_buttonUpdate";
            this._buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this._buttonUpdate.TabIndex = 10;
            this._buttonUpdate.Text = "Изменить";
            this._buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(114, 306);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 9;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Поиск по наименованию:";
            // 
            // _dataGridViewProcedures
            // 
            this._dataGridViewProcedures.AllowUserToAddRows = false;
            this._dataGridViewProcedures.AllowUserToDeleteRows = false;
            this._dataGridViewProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewProcedures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnOrderNumber,
            this._columnName,
            this._columnDescr});
            this._dataGridViewProcedures.Location = new System.Drawing.Point(32, 48);
            this._dataGridViewProcedures.Name = "_dataGridViewProcedures";
            this._dataGridViewProcedures.ReadOnly = true;
            this._dataGridViewProcedures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewProcedures.Size = new System.Drawing.Size(580, 251);
            this._dataGridViewProcedures.TabIndex = 17;
            // 
            // _columnOrderNumber
            // 
            this._columnOrderNumber.HeaderText = "Н/П";
            this._columnOrderNumber.Name = "_columnOrderNumber";
            this._columnOrderNumber.ReadOnly = true;
            this._columnOrderNumber.Width = 50;
            // 
            // _columnName
            // 
            this._columnName.HeaderText = "Наименование";
            this._columnName.Name = "_columnName";
            this._columnName.ReadOnly = true;
            this._columnName.Width = 170;
            // 
            // _columnDescr
            // 
            this._columnDescr.HeaderText = "Описание";
            this._columnDescr.Name = "_columnDescr";
            this._columnDescr.ReadOnly = true;
            this._columnDescr.Width = 300;
            // 
            // ProceduresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 346);
            this.Controls.Add(this._dataGridViewProcedures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxSearch);
            this.Controls.Add(this._comboBoxSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonRemove);
            this.Controls.Add(this._buttonUpdate);
            this.Controls.Add(this._buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProceduresView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр процедур";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewProcedures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxSearch;
        private System.Windows.Forms.ComboBox _comboBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonRemove;
        private System.Windows.Forms.Button _buttonUpdate;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView _dataGridViewProcedures;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnDescr;
    }
}