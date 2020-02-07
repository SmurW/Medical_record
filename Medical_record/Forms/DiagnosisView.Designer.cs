namespace Medical_record.Forms
{
    partial class DiagnosisView
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
            this._buttonSaveDiagnosis = new System.Windows.Forms.Button();
            this._textBoxDescriptionDiagnosis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxNameDiagnosis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _buttonSaveDiagnosis
            // 
            this._buttonSaveDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSaveDiagnosis.Location = new System.Drawing.Point(121, 121);
            this._buttonSaveDiagnosis.Name = "_buttonSaveDiagnosis";
            this._buttonSaveDiagnosis.Size = new System.Drawing.Size(142, 23);
            this._buttonSaveDiagnosis.TabIndex = 14;
            this._buttonSaveDiagnosis.Text = "Добавить диагноз";
            this._buttonSaveDiagnosis.UseVisualStyleBackColor = true;
            // 
            // _textBoxDescriptionDiagnosis
            // 
            this._textBoxDescriptionDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxDescriptionDiagnosis.Location = new System.Drawing.Point(75, 36);
            this._textBoxDescriptionDiagnosis.Multiline = true;
            this._textBoxDescriptionDiagnosis.Name = "_textBoxDescriptionDiagnosis";
            this._textBoxDescriptionDiagnosis.Size = new System.Drawing.Size(301, 79);
            this._textBoxDescriptionDiagnosis.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Описание";
            // 
            // _textBoxNameDiagnosis
            // 
            this._textBoxNameDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxNameDiagnosis.Location = new System.Drawing.Point(159, 10);
            this._textBoxNameDiagnosis.Name = "_textBoxNameDiagnosis";
            this._textBoxNameDiagnosis.Size = new System.Drawing.Size(217, 20);
            this._textBoxNameDiagnosis.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование диагноза";
            // 
            // DiagnosisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 155);
            this.Controls.Add(this._buttonSaveDiagnosis);
            this.Controls.Add(this._textBoxDescriptionDiagnosis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxNameDiagnosis);
            this.Controls.Add(this.label1);
            this.Name = "DiagnosisView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление диагнозов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonSaveDiagnosis;
        private System.Windows.Forms.TextBox _textBoxDescriptionDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxNameDiagnosis;
        private System.Windows.Forms.Label label1;
    }
}