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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._textBoxMiddleName = new System.Windows.Forms.TextBox();
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._buttonAddDoctors = new System.Windows.Forms.Button();
            this._comboBoxSpecialization = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _textBoxMiddleName
            // 
            this._textBoxMiddleName.Location = new System.Drawing.Point(101, 61);
            this._textBoxMiddleName.Name = "_textBoxMiddleName";
            this._textBoxMiddleName.Size = new System.Drawing.Size(146, 20);
            this._textBoxMiddleName.TabIndex = 25;
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(101, 35);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(146, 20);
            this._textBoxFirstName.TabIndex = 24;
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(101, 9);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(146, 20);
            this._textBoxLastName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Специализация";
            // 
            // _buttonAddDoctors
            // 
            this._buttonAddDoctors.Location = new System.Drawing.Point(48, 116);
            this._buttonAddDoctors.Name = "_buttonAddDoctors";
            this._buttonAddDoctors.Size = new System.Drawing.Size(146, 23);
            this._buttonAddDoctors.TabIndex = 28;
            this._buttonAddDoctors.Text = "Добавить врача";
            this._buttonAddDoctors.UseVisualStyleBackColor = true;
            // 
            // _comboBoxSpecialization
            // 
            this._comboBoxSpecialization.FormattingEnabled = true;
            this._comboBoxSpecialization.Location = new System.Drawing.Point(101, 87);
            this._comboBoxSpecialization.Name = "_comboBoxSpecialization";
            this._comboBoxSpecialization.Size = new System.Drawing.Size(146, 21);
            this._comboBoxSpecialization.TabIndex = 29;
            // 
            // DoctorsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 151);
            this.Controls.Add(this._comboBoxSpecialization);
            this.Controls.Add(this._buttonAddDoctors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._textBoxMiddleName);
            this.Controls.Add(this._textBoxFirstName);
            this.Controls.Add(this._textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoctorsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Врачи";
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
        private System.Windows.Forms.Button _buttonAddDoctors;
        private System.Windows.Forms.ComboBox _comboBoxSpecialization;
    }
}