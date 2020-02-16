namespace Medical_record.UseControl
{
    partial class AddHospitalizationView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this._dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxMedOrg = new System.Windows.Forms.TextBox();
            this._textBoxDiag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сведения о госпитализациях";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата поступления";
            // 
            // _dateTimePickerStart
            // 
            this._dateTimePickerStart.Location = new System.Drawing.Point(120, 48);
            this._dateTimePickerStart.Name = "_dateTimePickerStart";
            this._dateTimePickerStart.Size = new System.Drawing.Size(132, 20);
            this._dateTimePickerStart.TabIndex = 2;
            // 
            // _dateTimePickerEnd
            // 
            this._dateTimePickerEnd.Location = new System.Drawing.Point(324, 48);
            this._dateTimePickerEnd.Name = "_dateTimePickerEnd";
            this._dateTimePickerEnd.Size = new System.Drawing.Size(132, 20);
            this._dateTimePickerEnd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "и выписки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Медицинская организация, в которой была оказана медецинская помощь";
            // 
            // _textBoxMedOrg
            // 
            this._textBoxMedOrg.Location = new System.Drawing.Point(17, 104);
            this._textBoxMedOrg.Name = "_textBoxMedOrg";
            this._textBoxMedOrg.Size = new System.Drawing.Size(439, 20);
            this._textBoxMedOrg.TabIndex = 6;
            // 
            // _textBoxDiag
            // 
            this._textBoxDiag.Location = new System.Drawing.Point(158, 140);
            this._textBoxDiag.Name = "_textBoxDiag";
            this._textBoxDiag.Size = new System.Drawing.Size(298, 20);
            this._textBoxDiag.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Заключительный диагноз";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Записей";
            // 
            // _labelCount
            // 
            this._labelCount.AutoSize = true;
            this._labelCount.Location = new System.Drawing.Point(441, 10);
            this._labelCount.Name = "_labelCount";
            this._labelCount.Size = new System.Drawing.Size(24, 13);
            this._labelCount.TabIndex = 9;
            this._labelCount.Text = "0/0";
            // 
            // AddHospitalizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._labelCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._textBoxDiag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._textBoxMedOrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dateTimePickerEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._dateTimePickerStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddHospitalizationView";
            this.Size = new System.Drawing.Size(468, 172);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker _dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker _dateTimePickerEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _textBoxMedOrg;
        private System.Windows.Forms.TextBox _textBoxDiag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _labelCount;
    }
}