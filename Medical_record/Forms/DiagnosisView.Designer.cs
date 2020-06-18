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

        #region Windows from Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisView));
            this._buttonSave = new System.Windows.Forms.Button();
            this._textBoxDescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _buttonSave
            // 
            this._buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSave.Location = new System.Drawing.Point(121, 121);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(142, 23);
            this._buttonSave.TabIndex = 14;
            this._buttonSave.Text = "Добавить диагноз";
            this._buttonSave.UseVisualStyleBackColor = true;
            // 
            // _textBoxDescr
            // 
            this._textBoxDescr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxDescr.Location = new System.Drawing.Point(75, 36);
            this._textBoxDescr.Multiline = true;
            this._textBoxDescr.Name = "_textBoxDescr";
            this._textBoxDescr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._textBoxDescr.Size = new System.Drawing.Size(301, 79);
            this._textBoxDescr.TabIndex = 13;
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
            // _textBoxName
            // 
            this._textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxName.Location = new System.Drawing.Point(159, 10);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(217, 20);
            this._textBoxName.TabIndex = 11;
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
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._textBoxDescr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiagnosisView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление диагнозов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.TextBox _textBoxDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.Label label1;
    }
}