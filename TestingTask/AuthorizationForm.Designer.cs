namespace TestingTask
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.changePassViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(64, 12);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(126, 20);
            this.loginTB.TabIndex = 2;
            this.loginTB.TextChanged += new System.EventHandler(this.loginTB_TextChanged);
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(64, 46);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(100, 20);
            this.passTB.TabIndex = 3;
            this.passTB.UseSystemPasswordChar = true;
            this.passTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTB_KeyDown);
            // 
            // signInButton
            // 
            this.signInButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.signInButton.Location = new System.Drawing.Point(0, 78);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(209, 23);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // changePassViewButton
            // 
            this.changePassViewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePassViewButton.BackgroundImage")));
            this.changePassViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePassViewButton.Location = new System.Drawing.Point(170, 46);
            this.changePassViewButton.Name = "changePassViewButton";
            this.changePassViewButton.Size = new System.Drawing.Size(20, 20);
            this.changePassViewButton.TabIndex = 5;
            this.changePassViewButton.UseVisualStyleBackColor = true;
            this.changePassViewButton.Click += new System.EventHandler(this.changePassViewButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 101);
            this.Controls.Add(this.changePassViewButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button changePassViewButton;
    }
}