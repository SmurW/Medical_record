namespace Medical_record
{
    partial class MainForm_MedicalRecord
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
            this._buttonCard = new System.Windows.Forms.Button();
            this._buttonDiagnoses = new System.Windows.Forms.Button();
            this._buttonMedications = new System.Windows.Forms.Button();
            this._buttonProcedures = new System.Windows.Forms.Button();
            this._buttonDoctors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonMedicalRecord
            // 
            this._buttonCard.Location = new System.Drawing.Point(21, 39);
            this._buttonCard.Name = "_buttonMedicalRecord";
            this._buttonCard.Size = new System.Drawing.Size(193, 23);
            this._buttonCard.TabIndex = 0;
            this._buttonCard.Text = "Создать карту пациента";
            this._buttonCard.UseVisualStyleBackColor = true;
            // 
            // _buttonDiagnoses
            // 
            this._buttonDiagnoses.Location = new System.Drawing.Point(21, 68);
            this._buttonDiagnoses.Name = "_buttonDiagnoses";
            this._buttonDiagnoses.Size = new System.Drawing.Size(193, 23);
            this._buttonDiagnoses.TabIndex = 1;
            this._buttonDiagnoses.Text = "Список диагназов";
            this._buttonDiagnoses.UseVisualStyleBackColor = true;
            // 
            // _buttonMedications
            // 
            this._buttonMedications.Location = new System.Drawing.Point(21, 97);
            this._buttonMedications.Name = "_buttonMedications";
            this._buttonMedications.Size = new System.Drawing.Size(193, 23);
            this._buttonMedications.TabIndex = 2;
            this._buttonMedications.Text = "Список лекарств";
            this._buttonMedications.UseVisualStyleBackColor = true;
            // 
            // _buttonProcedures
            // 
            this._buttonProcedures.Location = new System.Drawing.Point(21, 126);
            this._buttonProcedures.Name = "_buttonProcedures";
            this._buttonProcedures.Size = new System.Drawing.Size(193, 23);
            this._buttonProcedures.TabIndex = 3;
            this._buttonProcedures.Text = "Список процедур";
            this._buttonProcedures.UseVisualStyleBackColor = true;
            // 
            // _buttonDoctors
            // 
            this._buttonDoctors.Location = new System.Drawing.Point(21, 155);
            this._buttonDoctors.Name = "_buttonDoctors";
            this._buttonDoctors.Size = new System.Drawing.Size(193, 23);
            this._buttonDoctors.TabIndex = 4;
            this._buttonDoctors.Text = "Врачи";
            this._buttonDoctors.UseVisualStyleBackColor = true;
            // 
            // MainForm_MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 217);
            this.Controls.Add(this._buttonDoctors);
            this.Controls.Add(this._buttonProcedures);
            this.Controls.Add(this._buttonMedications);
            this.Controls.Add(this._buttonDiagnoses);
            this.Controls.Add(this._buttonCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm_MedicalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonCard;
        private System.Windows.Forms.Button _buttonDiagnoses;
        private System.Windows.Forms.Button _buttonMedications;
        private System.Windows.Forms.Button _buttonProcedures;
        private System.Windows.Forms.Button _buttonDoctors;
    }
}