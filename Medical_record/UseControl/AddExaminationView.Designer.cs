namespace Medical_record.UseControl
{
    partial class AddExaminationView
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
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this._comboBoxDiagnosis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._comboBoxHealthGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this._comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Location = new System.Drawing.Point(139, 4);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(169, 20);
            this._dateTimePicker.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Дата осмотра\r\n";
            // 
            // _comboBoxDiagnosis
            // 
            this._comboBoxDiagnosis.FormattingEnabled = true;
            this._comboBoxDiagnosis.Location = new System.Drawing.Point(196, 43);
            this._comboBoxDiagnosis.Name = "_comboBoxDiagnosis";
            this._comboBoxDiagnosis.Size = new System.Drawing.Size(231, 21);
            this._comboBoxDiagnosis.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Диагноз основного заболевания";
            // 
            // _comboBoxHealthGroup
            // 
            this._comboBoxHealthGroup.FormattingEnabled = true;
            this._comboBoxHealthGroup.Location = new System.Drawing.Point(140, 77);
            this._comboBoxHealthGroup.Name = "_comboBoxHealthGroup";
            this._comboBoxHealthGroup.Size = new System.Drawing.Size(286, 21);
            this._comboBoxHealthGroup.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Группа здаровья";
            // 
            // _comboBoxDoctor
            // 
            this._comboBoxDoctor.FormattingEnabled = true;
            this._comboBoxDoctor.Location = new System.Drawing.Point(86, 113);
            this._comboBoxDoctor.Name = "_comboBoxDoctor";
            this._comboBoxDoctor.Size = new System.Drawing.Size(340, 21);
            this._comboBoxDoctor.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Врач";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Записей";
            // 
            // _labelCount
            // 
            this._labelCount.AutoSize = true;
            this._labelCount.Location = new System.Drawing.Point(413, 11);
            this._labelCount.Name = "_labelCount";
            this._labelCount.Size = new System.Drawing.Size(24, 13);
            this._labelCount.TabIndex = 44;
            this._labelCount.Text = "0/0";
            // 
            // AddDoctorsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._labelCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._comboBoxDoctor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._comboBoxHealthGroup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._comboBoxDiagnosis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dateTimePicker);
            this.Controls.Add(this.label5);
            this.Name = "AddDoctorsView";
            this.Size = new System.Drawing.Size(447, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _comboBoxDiagnosis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _comboBoxHealthGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _comboBoxDoctor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _labelCount;
    }
}