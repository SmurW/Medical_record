namespace Medical_record
{
    partial class Mainfrom_MedicalRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrom_MedicalRecord));
            this._buttonCard = new System.Windows.Forms.Button();
            this._buttonDiagnoses = new System.Windows.Forms.Button();
            this._buttonMedications = new System.Windows.Forms.Button();
            this._buttonProcedures = new System.Windows.Forms.Button();
            this._buttonDoctors = new System.Windows.Forms.Button();
            this._linkLabel = new System.Windows.Forms.LinkLabel();
            this._buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonCard
            // 
            this._buttonCard.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonCard.Location = new System.Drawing.Point(27, 29);
            this._buttonCard.Name = "_buttonCard";
            this._buttonCard.Size = new System.Drawing.Size(206, 39);
            this._buttonCard.TabIndex = 0;
            this._buttonCard.Text = "Создать карту пациента";
            this._buttonCard.UseVisualStyleBackColor = true;
            // 
            // _buttonDiagnoses
            // 
            this._buttonDiagnoses.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonDiagnoses.Location = new System.Drawing.Point(27, 74);
            this._buttonDiagnoses.Name = "_buttonDiagnoses";
            this._buttonDiagnoses.Size = new System.Drawing.Size(206, 39);
            this._buttonDiagnoses.TabIndex = 1;
            this._buttonDiagnoses.Text = "Список диагнозов";
            this._buttonDiagnoses.UseVisualStyleBackColor = true;
            // 
            // _buttonMedications
            // 
            this._buttonMedications.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonMedications.Location = new System.Drawing.Point(27, 117);
            this._buttonMedications.Name = "_buttonMedications";
            this._buttonMedications.Size = new System.Drawing.Size(206, 39);
            this._buttonMedications.TabIndex = 2;
            this._buttonMedications.Text = "Список лекарств";
            this._buttonMedications.UseVisualStyleBackColor = true;
            // 
            // _buttonProcedures
            // 
            this._buttonProcedures.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonProcedures.Location = new System.Drawing.Point(27, 163);
            this._buttonProcedures.Name = "_buttonProcedures";
            this._buttonProcedures.Size = new System.Drawing.Size(206, 39);
            this._buttonProcedures.TabIndex = 3;
            this._buttonProcedures.Text = "Список процедур";
            this._buttonProcedures.UseVisualStyleBackColor = true;
            // 
            // _buttonDoctors
            // 
            this._buttonDoctors.BackColor = System.Drawing.SystemColors.Control;
            this._buttonDoctors.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonDoctors.Location = new System.Drawing.Point(27, 208);
            this._buttonDoctors.Name = "_buttonDoctors";
            this._buttonDoctors.Size = new System.Drawing.Size(206, 39);
            this._buttonDoctors.TabIndex = 4;
            this._buttonDoctors.Text = "Врачи";
            this._buttonDoctors.UseVisualStyleBackColor = false;
            // 
            // _linkLabel
            // 
            this._linkLabel.AutoSize = true;
            this._linkLabel.BackColor = System.Drawing.Color.Transparent;
            this._linkLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._linkLabel.ForeColor = System.Drawing.Color.Transparent;
            this._linkLabel.Location = new System.Drawing.Point(84, 274);
            this._linkLabel.Name = "_linkLabel";
            this._linkLabel.Size = new System.Drawing.Size(98, 18);
            this._linkLabel.TabIndex = 5;
            this._linkLabel.TabStop = true;
            this._linkLabel.Text = "О программе";
            // 
            // _buttonEnter
            // 
            this._buttonEnter.BackColor = System.Drawing.Color.Transparent;
            this._buttonEnter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._buttonEnter.ForeColor = System.Drawing.Color.Black;
            this._buttonEnter.Location = new System.Drawing.Point(384, 3);
            this._buttonEnter.Name = "_buttonEnter";
            this._buttonEnter.Size = new System.Drawing.Size(49, 34);
            this._buttonEnter.TabIndex = 6;
            this._buttonEnter.Text = "Вход";
            this._buttonEnter.UseVisualStyleBackColor = false;
            // 
            // Mainfrom_MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Medical_record.Properties.Resources.MainImg;
            this.ClientSize = new System.Drawing.Size(435, 296);
            this.Controls.Add(this._buttonEnter);
            this.Controls.Add(this._linkLabel);
            this.Controls.Add(this._buttonDoctors);
            this.Controls.Add(this._buttonProcedures);
            this.Controls.Add(this._buttonMedications);
            this.Controls.Add(this._buttonDiagnoses);
            this.Controls.Add(this._buttonCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainfrom_MedicalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonCard;
        private System.Windows.Forms.Button _buttonDiagnoses;
        private System.Windows.Forms.Button _buttonMedications;
        private System.Windows.Forms.Button _buttonProcedures;
        private System.Windows.Forms.Button _buttonDoctors;
        private System.Windows.Forms.LinkLabel _linkLabel;
        private System.Windows.Forms.Button _buttonEnter;
    }
}