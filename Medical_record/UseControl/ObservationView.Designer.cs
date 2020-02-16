namespace Medical_record.UseControl
{
    partial class ObservationView
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._textBoxStartDate = new System.Windows.Forms.TextBox();
            this._textBoxEndDate = new System.Windows.Forms.TextBox();
            this._textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this._textBoxDoctor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _labelCount
            // 
            this._labelCount.AutoSize = true;
            this._labelCount.Location = new System.Drawing.Point(389, 10);
            this._labelCount.Name = "_labelCount";
            this._labelCount.Size = new System.Drawing.Size(27, 13);
            this._labelCount.TabIndex = 41;
            this._labelCount.Text = " 0/0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Записей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Врач";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Диагноз";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Дата прекращения наблюдения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Дата начала наблюдения";
            // 
            // _textBoxStartDate
            // 
            this._textBoxStartDate.Location = new System.Drawing.Point(188, 13);
            this._textBoxStartDate.Name = "_textBoxStartDate";
            this._textBoxStartDate.Size = new System.Drawing.Size(140, 20);
            this._textBoxStartDate.TabIndex = 42;
            // 
            // _textBoxEndDate
            // 
            this._textBoxEndDate.Location = new System.Drawing.Point(188, 45);
            this._textBoxEndDate.Name = "_textBoxEndDate";
            this._textBoxEndDate.Size = new System.Drawing.Size(140, 20);
            this._textBoxEndDate.TabIndex = 43;
            // 
            // _textBoxDiagnosis
            // 
            this._textBoxDiagnosis.Location = new System.Drawing.Point(70, 79);
            this._textBoxDiagnosis.Name = "_textBoxDiagnosis";
            this._textBoxDiagnosis.Size = new System.Drawing.Size(340, 20);
            this._textBoxDiagnosis.TabIndex = 44;
            // 
            // _textBoxDoctor
            // 
            this._textBoxDoctor.Location = new System.Drawing.Point(70, 112);
            this._textBoxDoctor.Name = "_textBoxDoctor";
            this._textBoxDoctor.Size = new System.Drawing.Size(340, 20);
            this._textBoxDoctor.TabIndex = 45;
            // 
            // ObservationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBoxDoctor);
            this.Controls.Add(this._textBoxDiagnosis);
            this.Controls.Add(this._textBoxEndDate);
            this.Controls.Add(this._textBoxStartDate);
            this.Controls.Add(this._labelCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "ObservationView";
            this.Size = new System.Drawing.Size(429, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _textBoxStartDate;
        private System.Windows.Forms.TextBox _textBoxEndDate;
        private System.Windows.Forms.TextBox _textBoxDiagnosis;
        private System.Windows.Forms.TextBox _textBoxDoctor;
    }
}
