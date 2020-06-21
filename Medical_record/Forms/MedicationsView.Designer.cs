namespace Medical_record
{
    partial class MedicationsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationsView));
            this._textBoxSearchByName = new System.Windows.Forms.TextBox();
            this._comboBoxSelectSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonDelete = new System.Windows.Forms.Button();
            this._buttonUpdate = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._dataGridViewMedicat = new System.Windows.Forms.DataGridView();
            this._columnOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnShelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnArrivalPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnRestPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnQuantityPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnRemainedUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewMedicat)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBoxSearchByName
            // 
            this._textBoxSearchByName.Location = new System.Drawing.Point(403, 17);
            this._textBoxSearchByName.Name = "_textBoxSearchByName";
            this._textBoxSearchByName.Size = new System.Drawing.Size(228, 20);
            this._textBoxSearchByName.TabIndex = 15;
            // 
            // _comboBoxSelectSort
            // 
            this._comboBoxSelectSort.FormattingEnabled = true;
            this._comboBoxSelectSort.Items.AddRange(new object[] {
            "По Наименованию",
            "По Описанию"});
            this._comboBoxSelectSort.Location = new System.Drawing.Point(120, 17);
            this._comboBoxSelectSort.Name = "_comboBoxSelectSort";
            this._comboBoxSelectSort.Size = new System.Drawing.Size(121, 21);
            this._comboBoxSelectSort.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Сортировка по:";
            // 
            // _buttonDelete
            // 
            this._buttonDelete.Location = new System.Drawing.Point(639, 307);
            this._buttonDelete.Name = "_buttonDelete";
            this._buttonDelete.Size = new System.Drawing.Size(164, 23);
            this._buttonDelete.TabIndex = 11;
            this._buttonDelete.Text = "Удалить";
            this._buttonDelete.UseVisualStyleBackColor = true;
            // 
            // _buttonUpdate
            // 
            this._buttonUpdate.Location = new System.Drawing.Point(347, 307);
            this._buttonUpdate.Name = "_buttonUpdate";
            this._buttonUpdate.Size = new System.Drawing.Size(164, 23);
            this._buttonUpdate.TabIndex = 10;
            this._buttonUpdate.Text = "Изменить";
            this._buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(44, 307);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(164, 23);
            this._buttonAdd.TabIndex = 9;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            // 
            // _dataGridViewMedicat
            // 
            this._dataGridViewMedicat.AllowUserToAddRows = false;
            this._dataGridViewMedicat.AllowUserToDeleteRows = false;
            this._dataGridViewMedicat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridViewMedicat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewMedicat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnOrderNumber,
            this._columnName,
            this._columnDescription,
            this._columnArrivalDate,
            this._columnShelfLife,
            this._columnArrivalPackage,
            this._columnRestPackage,
            this._columnQuantityPackage,
            this._columnRemainedUnits});
            this._dataGridViewMedicat.Location = new System.Drawing.Point(12, 50);
            this._dataGridViewMedicat.Name = "_dataGridViewMedicat";
            this._dataGridViewMedicat.ReadOnly = true;
            this._dataGridViewMedicat.Size = new System.Drawing.Size(842, 251);
            this._dataGridViewMedicat.TabIndex = 8;
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
            // 
            // _columnDescription
            // 
            this._columnDescription.HeaderText = "Описание";
            this._columnDescription.Name = "_columnDescription";
            this._columnDescription.ReadOnly = true;
            this._columnDescription.Width = 230;
            // 
            // _columnArrivalDate
            // 
            this._columnArrivalDate.HeaderText = "Дата прихода";
            this._columnArrivalDate.Name = "_columnArrivalDate";
            this._columnArrivalDate.ReadOnly = true;
            this._columnArrivalDate.Width = 70;
            // 
            // _columnShelfLife
            // 
            this._columnShelfLife.HeaderText = "Срок годности";
            this._columnShelfLife.Name = "_columnShelfLife";
            this._columnShelfLife.ReadOnly = true;
            this._columnShelfLife.Width = 70;
            // 
            // _columnArrivalPackage
            // 
            this._columnArrivalPackage.HeaderText = "Приход упаковок";
            this._columnArrivalPackage.Name = "_columnArrivalPackage";
            this._columnArrivalPackage.ReadOnly = true;
            this._columnArrivalPackage.Width = 70;
            // 
            // _columnRestPackage
            // 
            this._columnRestPackage.HeaderText = "Остаток упаковок";
            this._columnRestPackage.Name = "_columnRestPackage";
            this._columnRestPackage.ReadOnly = true;
            this._columnRestPackage.Width = 70;
            // 
            // _columnQuantityPackage
            // 
            this._columnQuantityPackage.HeaderText = "Количество в упаковке";
            this._columnQuantityPackage.Name = "_columnQuantityPackage";
            this._columnQuantityPackage.ReadOnly = true;
            this._columnQuantityPackage.Width = 70;
            // 
            // _columnRemainedUnits
            // 
            this._columnRemainedUnits.HeaderText = "Остаток едениц";
            this._columnRemainedUnits.Name = "_columnRemainedUnits";
            this._columnRemainedUnits.ReadOnly = true;
            this._columnRemainedUnits.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Поиск по наименованию:";
            // 
            // MedicationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxSearchByName);
            this.Controls.Add(this._comboBoxSelectSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonDelete);
            this.Controls.Add(this._buttonUpdate);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._dataGridViewMedicat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicationsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр лекарств";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewMedicat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxSearchByName;
        private System.Windows.Forms.ComboBox _comboBoxSelectSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonDelete;
        private System.Windows.Forms.Button _buttonUpdate;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.DataGridView _dataGridViewMedicat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnShelfLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnArrivalPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnRestPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnQuantityPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnRemainedUnits;
    }
}