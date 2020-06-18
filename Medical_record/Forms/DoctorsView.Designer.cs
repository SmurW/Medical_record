namespace Medical_record.Forms
{
    partial class DoctorsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsView));
            this._textBoxMiddleName = new System.Windows.Forms.TextBox();
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._buttonSave = new System.Windows.Forms.Button();
            this._comboBoxSpecialization = new System.Windows.Forms.ComboBox();
            this._dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this._columnOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBoxMiddleName
            // 
            this._textBoxMiddleName.Location = new System.Drawing.Point(658, 64);
            this._textBoxMiddleName.Name = "_textBoxMiddleName";
            this._textBoxMiddleName.Size = new System.Drawing.Size(146, 20);
            this._textBoxMiddleName.TabIndex = 25;
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(658, 38);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(146, 20);
            this._textBoxFirstName.TabIndex = 24;
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(658, 12);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(146, 20);
            this._textBoxLastName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Специализация";
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(658, 130);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(146, 23);
            this._buttonSave.TabIndex = 28;
            this._buttonSave.Text = "Сохранить врача";
            this._buttonSave.UseVisualStyleBackColor = true;
            // 
            // _comboBoxSpecialization
            // 
            this._comboBoxSpecialization.FormattingEnabled = true;
            this._comboBoxSpecialization.Location = new System.Drawing.Point(658, 90);
            this._comboBoxSpecialization.Name = "_comboBoxSpecialization";
            this._comboBoxSpecialization.Size = new System.Drawing.Size(146, 21);
            this._comboBoxSpecialization.TabIndex = 29;
            // 
            // _dataGridViewDoctors
            // 
            this._dataGridViewDoctors.AllowUserToAddRows = false;
            this._dataGridViewDoctors.AllowUserToDeleteRows = false;
            this._dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnOrderNumber,
            this._columnLastName,
            this._columnFirstName,
            this._columnMiddleName,
            this._columnSpec});
            this._dataGridViewDoctors.Location = new System.Drawing.Point(14, 12);
            this._dataGridViewDoctors.Name = "_dataGridViewDoctors";
            this._dataGridViewDoctors.ReadOnly = true;
            this._dataGridViewDoctors.Size = new System.Drawing.Size(534, 295);
            this._dataGridViewDoctors.TabIndex = 30;
            // 
            // _columnOrderNumber
            // 
            this._columnOrderNumber.HeaderText = "Н/П";
            this._columnOrderNumber.Name = "_columnOrderNumber";
            this._columnOrderNumber.ReadOnly = true;
            this._columnOrderNumber.Width = 50;
            // 
            // _columnLastName
            // 
            this._columnLastName.HeaderText = "Фамилия";
            this._columnLastName.Name = "_columnLastName";
            this._columnLastName.ReadOnly = true;
            // 
            // _columnFirstName
            // 
            this._columnFirstName.HeaderText = "Имя";
            this._columnFirstName.Name = "_columnFirstName";
            this._columnFirstName.ReadOnly = true;
            // 
            // _columnMiddleName
            // 
            this._columnMiddleName.HeaderText = "Отчество";
            this._columnMiddleName.Name = "_columnMiddleName";
            this._columnMiddleName.ReadOnly = true;
            // 
            // _columnSpec
            // 
            this._columnSpec.HeaderText = "Специализация";
            this._columnSpec.Name = "_columnSpec";
            this._columnSpec.ReadOnly = true;
            this._columnSpec.Width = 150;
            // 
            // DoctorsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 322);
            this.Controls.Add(this._dataGridViewDoctors);
            this.Controls.Add(this._comboBoxSpecialization);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._textBoxMiddleName);
            this.Controls.Add(this._textBoxFirstName);
            this.Controls.Add(this._textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Врачи";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxMiddleName;
        private System.Windows.Forms.TextBox _textBoxFirstName;
        private System.Windows.Forms.TextBox _textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.ComboBox _comboBoxSpecialization;
        private System.Windows.Forms.DataGridView _dataGridViewDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnSpec;
    }
}