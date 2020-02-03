namespace Med_karta.Forms
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this._labelRegistr = new System.Windows.Forms.Label();
            this._buttonAutorization = new System.Windows.Forms.Button();
            this._txtboxLogin = new System.Windows.Forms.TextBox();
            this._txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this._visiblePassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._visiblePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelRegistr
            // 
            this._labelRegistr.AutoSize = true;
            this._labelRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelRegistr.Location = new System.Drawing.Point(12, 133);
            this._labelRegistr.Name = "_labelRegistr";
            this._labelRegistr.Size = new System.Drawing.Size(228, 13);
            this._labelRegistr.TabIndex = 6;
            this._labelRegistr.Text = "Не зарегистрированы? Зарегистрируйтесь";
            // 
            // _buttonAutorization
            // 
            this._buttonAutorization.Location = new System.Drawing.Point(15, 101);
            this._buttonAutorization.Name = "_buttonAutorization";
            this._buttonAutorization.Size = new System.Drawing.Size(193, 23);
            this._buttonAutorization.TabIndex = 0;
            this._buttonAutorization.Text = "Войти";
            this._buttonAutorization.UseVisualStyleBackColor = true;
            // 
            // _txtboxLogin
            // 
            this._txtboxLogin.Location = new System.Drawing.Point(15, 24);
            this._txtboxLogin.Name = "_txtboxLogin";
            this._txtboxLogin.Size = new System.Drawing.Size(193, 20);
            this._txtboxLogin.TabIndex = 1;
            // 
            // _txtboxPassword
            // 
            this._txtboxPassword.Location = new System.Drawing.Point(15, 65);
            this._txtboxPassword.Name = "_txtboxPassword";
            this._txtboxPassword.Size = new System.Drawing.Size(193, 20);
            this._txtboxPassword.TabIndex = 2;
            this._txtboxPassword.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 8);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль";
            // 
            // _visiblePassword
            // 
            this._visiblePassword.Image = global::Med_karta.Properties.Resources.PassFalse;
            this._visiblePassword.Location = new System.Drawing.Point(214, 65);
            this._visiblePassword.Name = "_visiblePassword";
            this._visiblePassword.Size = new System.Drawing.Size(26, 20);
            this._visiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._visiblePassword.TabIndex = 5;
            this._visiblePassword.TabStop = false;
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 162);
            this.Controls.Add(this._visiblePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this._labelRegistr);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this._txtboxLogin);
            this.Controls.Add(this._txtboxPassword);
            this.Controls.Add(this._buttonAutorization);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this._visiblePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelRegistr;
        private System.Windows.Forms.Button _buttonAutorization;
        private System.Windows.Forms.TextBox _txtboxLogin;
        private System.Windows.Forms.TextBox _txtboxPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox _visiblePassword;
    }
}