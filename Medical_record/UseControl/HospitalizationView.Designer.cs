namespace Medical_record.UseControl
{
    partial class HospitalizationView
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
            this._textBoxDiag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._textBoxMedOrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxStartDate = new System.Windows.Forms.TextBox();
            this._textBoxEndDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _labelCount
            // 
            this._labelCount.AutoSize = true;
            this._labelCount.Location = new System.Drawing.Point(436, 11);
            this._labelCount.Name = "_labelCount";
            this._labelCount.Size = new System.Drawing.Size(24, 13);
            this._labelCount.TabIndex = 19;
            this._labelCount.Text = "0/0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Записей";
            // 
            // _textBoxDiag
            // 
            this._textBoxDiag.Location = new System.Drawing.Point(153, 141);
            this._textBoxDiag.Name = "_textBoxDiag";
            this._textBoxDiag.Size = new System.Drawing.Size(298, 20);
            this._textBoxDiag.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Заключительный диагноз";
            // 
            // _textBoxMedOrg
            // 
            this._textBoxMedOrg.Location = new System.Drawing.Point(12, 105);
            this._textBoxMedOrg.Name = "_textBoxMedOrg";
            this._textBoxMedOrg.Size = new System.Drawing.Size(439, 20);
            this._textBoxMedOrg.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Медицинская организация, в которой была оказана медецинская помощь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "и выписки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата поступления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сведения о госпитализациях";
            // 
            // _textBoxStartDate
            // 
            this._textBoxStartDate.Location = new System.Drawing.Point(115, 52);
            this._textBoxStartDate.Name = "_textBoxStartDate";
            this._textBoxStartDate.Size = new System.Drawing.Size(132, 20);
            this._textBoxStartDate.TabIndex = 21;
            // 
            // _textBoxEndDate
            // 
            this._textBoxEndDate.Location = new System.Drawing.Point(319, 52);
            this._textBoxEndDate.Name = "_textBoxEndDate";
            this._textBoxEndDate.Size = new System.Drawing.Size(132, 20);
            this._textBoxEndDate.TabIndex = 22;
            // 
            // HospitalizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBoxEndDate);
            this.Controls.Add(this._textBoxStartDate);
            this.Controls.Add(this._labelCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._textBoxDiag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._textBoxMedOrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HospitalizationView";
            this.Size = new System.Drawing.Size(468, 172);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _textBoxDiag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _textBoxMedOrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxStartDate;
        private System.Windows.Forms.TextBox _textBoxEndDate;
    }
}
