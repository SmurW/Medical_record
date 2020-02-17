namespace Medical_record.UseControl
{
    partial class ExaminationView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._labelCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this._textBoxGroup = new System.Windows.Forms.TextBox();
            this._textBoxDoctor = new System.Windows.Forms.TextBox();
            this._textBoxDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _labelCount
            // 
            this._labelCount.AutoSize = true;
            this._labelCount.Location = new System.Drawing.Point(415, 16);
            this._labelCount.Name = "_labelCount";
            this._labelCount.Size = new System.Drawing.Size(24, 13);
            this._labelCount.TabIndex = 53;
            this._labelCount.Text = "0/0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Записей";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Врач";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Группа здаровья";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Диагноз основного заболевания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Дата осмотра\r\n";
            // 
            // _textBoxDiagnosis
            // 
            this._textBoxDiagnosis.Location = new System.Drawing.Point(198, 48);
            this._textBoxDiagnosis.Name = "_textBoxDiagnosis";
            this._textBoxDiagnosis.Size = new System.Drawing.Size(230, 20);
            this._textBoxDiagnosis.TabIndex = 55;
            // 
            // _textBoxGroup
            // 
            this._textBoxGroup.Location = new System.Drawing.Point(141, 82);
            this._textBoxGroup.Name = "_textBoxGroup";
            this._textBoxGroup.Size = new System.Drawing.Size(287, 20);
            this._textBoxGroup.TabIndex = 56;
            // 
            // _textBoxDoctor
            // 
            this._textBoxDoctor.Location = new System.Drawing.Point(141, 118);
            this._textBoxDoctor.Name = "_textBoxDoctor";
            this._textBoxDoctor.Size = new System.Drawing.Size(287, 20);
            this._textBoxDoctor.TabIndex = 57;
            // 
            // _textBoxDate
            // 
            this._textBoxDate.Location = new System.Drawing.Point(99, 12);
            this._textBoxDate.Name = "_textBoxDate";
            this._textBoxDate.Size = new System.Drawing.Size(163, 20);
            this._textBoxDate.TabIndex = 58;
            // 
            // ExaminationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBoxDate);
            this.Controls.Add(this._textBoxDoctor);
            this.Controls.Add(this._textBoxGroup);
            this.Controls.Add(this._textBoxDiagnosis);
            this.Controls.Add(this._labelCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "ExaminationView";
            this.Size = new System.Drawing.Size(453, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _textBoxDiagnosis;
        private System.Windows.Forms.TextBox _textBoxGroup;
        private System.Windows.Forms.TextBox _textBoxDoctor;
        private System.Windows.Forms.TextBox _textBoxDate;
    }
}
