namespace Medical_record.Forms
{
    partial class DiagnosesView
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
            this._dataGridViewDiagnoses = new System.Windows.Forms.DataGridView();
            this._columnOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._buttonUpdate = new System.Windows.Forms.Button();
            this._buttonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._comboBoxSelectSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxSearchByName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDiagnoses)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridViewDiagnoses
            // 
            this._dataGridViewDiagnoses.AllowUserToAddRows = false;
            this._dataGridViewDiagnoses.AllowUserToDeleteRows = false;
            this._dataGridViewDiagnoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewDiagnoses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnOrderNumber,
            this._columnName,
            this._columnDescr});
            this._dataGridViewDiagnoses.Location = new System.Drawing.Point(44, 49);
            this._dataGridViewDiagnoses.Name = "_dataGridViewDiagnoses";
            this._dataGridViewDiagnoses.ReadOnly = true;
            this._dataGridViewDiagnoses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewDiagnoses.Size = new System.Drawing.Size(580, 251);
            this._dataGridViewDiagnoses.TabIndex = 0;
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
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(117, 306);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 1;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            // 
            // _buttonUpdate
            // 
            this._buttonUpdate.Location = new System.Drawing.Point(208, 306);
            this._buttonUpdate.Name = "_buttonUpdate";
            this._buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this._buttonUpdate.TabIndex = 2;
            this._buttonUpdate.Text = "Изменить";
            this._buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // _buttonRemoveDiagnosis
            // 
            this._buttonRemove.Location = new System.Drawing.Point(299, 306);
            this._buttonRemove.Name = "_buttonRemoveDiagnosis";
            this._buttonRemove.Size = new System.Drawing.Size(75, 23);
            this._buttonRemove.TabIndex = 3;
            this._buttonRemove.Text = "Удалить";
            this._buttonRemove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сортировка по:";
            // 
            // _comboBoxSelectSort
            // 
            this._comboBoxSelectSort.FormattingEnabled = true;
            this._comboBoxSelectSort.Items.AddRange(new object[] {
            "По Наименованию",
            "По Описанию"});
            this._comboBoxSelectSort.Location = new System.Drawing.Point(113, 16);
            this._comboBoxSelectSort.Name = "_comboBoxSelectSort";
            this._comboBoxSelectSort.Size = new System.Drawing.Size(121, 21);
            this._comboBoxSelectSort.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по наименованию:";
            // 
            // _textBoxSearchByName
            // 
            this._textBoxSearchByName.Location = new System.Drawing.Point(399, 16);
            this._textBoxSearchByName.Name = "_textBoxSearchByName";
            this._textBoxSearchByName.Size = new System.Drawing.Size(225, 20);
            this._textBoxSearchByName.TabIndex = 7;
            // 
            // DiagnosesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 341);
            this.Controls.Add(this._textBoxSearchByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._comboBoxSelectSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonRemove);
            this.Controls.Add(this._buttonUpdate);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._dataGridViewDiagnoses);
            this.Name = "DiagnosesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр диагназов";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDiagnoses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridViewDiagnoses;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Button _buttonUpdate;
        private System.Windows.Forms.Button _buttonRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboBoxSelectSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxSearchByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnDescr;
    }
}