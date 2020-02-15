namespace Medical_record.UseControl
{
    partial class AddObservationView
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
            this._dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this._dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._comboBoxDiagnosis = new System.Windows.Forms.ComboBox();
            this._comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _dateTimePickerStart
            // 
            this._dateTimePickerStart.Location = new System.Drawing.Point(190, 8);
            this._dateTimePickerStart.Name = "_dateTimePickerStart";
            this._dateTimePickerStart.Size = new System.Drawing.Size(140, 20);
            this._dateTimePickerStart.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Дата начала наблюдения";
            // 
            // _dateTimePickerEnd
            // 
            this._dateTimePickerEnd.Location = new System.Drawing.Point(190, 40);
            this._dateTimePickerEnd.Name = "_dateTimePickerEnd";
            this._dateTimePickerEnd.Size = new System.Drawing.Size(140, 20);
            this._dateTimePickerEnd.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Дата прекращения наблюдения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Диагноз";
            // 
            // _comboBoxDiagnosis
            // 
            this._comboBoxDiagnosis.FormattingEnabled = true;
            this._comboBoxDiagnosis.Location = new System.Drawing.Point(72, 77);
            this._comboBoxDiagnosis.Name = "_comboBoxDiagnosis";
            this._comboBoxDiagnosis.Size = new System.Drawing.Size(340, 21);
            this._comboBoxDiagnosis.TabIndex = 27;
            // 
            // _comboBoxDoctor
            // 
            this._comboBoxDoctor.FormattingEnabled = true;
            this._comboBoxDoctor.Location = new System.Drawing.Point(72, 110);
            this._comboBoxDoctor.Name = "_comboBoxDoctor";
            this._comboBoxDoctor.Size = new System.Drawing.Size(340, 21);
            this._comboBoxDoctor.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Врач";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Записей";
            // 
            // _labelCount
            // 
            this._labelCount.AutoSize = true;
            this._labelCount.Location = new System.Drawing.Point(391, 8);
            this._labelCount.Name = "_labelCount";
            this._labelCount.Size = new System.Drawing.Size(27, 13);
            this._labelCount.TabIndex = 31;
            this._labelCount.Text = " 0/0";
            // 
            // AddObservationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._labelCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._comboBoxDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._comboBoxDiagnosis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._dateTimePickerEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._dateTimePickerStart);
            this.Controls.Add(this.label5);
            this.Name = "AddObservationView";
            this.Size = new System.Drawing.Size(429, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker _dateTimePickerStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker _dateTimePickerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _comboBoxDiagnosis;
        private System.Windows.Forms.ComboBox _comboBoxDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _labelCount;
    }
}