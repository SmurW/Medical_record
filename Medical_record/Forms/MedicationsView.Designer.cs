namespace Medical_record
{
    partial class MedicationsView
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this._buttonUpdateMedication = new System.Windows.Forms.Button();
            this._buttonAddMedication = new System.Windows.Forms.Button();
            this._dataGridViewMedicat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewMedicat)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Сортировка по:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // _buttonUpdateMedication
            // 
            this._buttonUpdateMedication.Location = new System.Drawing.Point(347, 307);
            this._buttonUpdateMedication.Name = "_buttonUpdateMedication";
            this._buttonUpdateMedication.Size = new System.Drawing.Size(164, 23);
            this._buttonUpdateMedication.TabIndex = 10;
            this._buttonUpdateMedication.Text = "Изменить";
            this._buttonUpdateMedication.UseVisualStyleBackColor = true;
            // 
            // _buttonAddMedication
            // 
            this._buttonAddMedication.Location = new System.Drawing.Point(44, 307);
            this._buttonAddMedication.Name = "_buttonAddMedication";
            this._buttonAddMedication.Size = new System.Drawing.Size(164, 23);
            this._buttonAddMedication.TabIndex = 9;
            this._buttonAddMedication.Text = "Добавить";
            this._buttonAddMedication.UseVisualStyleBackColor = true;
            // 
            // _dataGridViewMedicat
            // 
            this._dataGridViewMedicat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridViewMedicat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewMedicat.Location = new System.Drawing.Point(12, 50);
            this._dataGridViewMedicat.Name = "_dataGridViewMedicat";
            this._dataGridViewMedicat.Size = new System.Drawing.Size(842, 251);
            this._dataGridViewMedicat.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Поиск по наименованию:";
            // 
            // MedicationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this._buttonUpdateMedication);
            this.Controls.Add(this._buttonAddMedication);
            this.Controls.Add(this._dataGridViewMedicat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MedicationsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр лекарств";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewMedicat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button _buttonUpdateMedication;
        private System.Windows.Forms.Button _buttonAddMedication;
        private System.Windows.Forms.DataGridView _dataGridViewMedicat;
        private System.Windows.Forms.Label label2;
    }
}