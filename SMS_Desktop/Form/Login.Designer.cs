namespace SMS_Desktop
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_signin = new System.Windows.Forms.Button();
            this.ErrorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmd_SignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.AutoCompleteCustomSource.AddRange(new string[] {
            "fxtrananhtuan@gmail.com",
            "anhtuan_0605@gmail.com"});
            this.txt_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_User.Location = new System.Drawing.Point(127, 90);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(172, 20);
            this.txt_User.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(127, 126);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(172, 20);
            this.txt_pass.TabIndex = 0;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // cmd_signin
            // 
            this.cmd_signin.Location = new System.Drawing.Point(224, 152);
            this.cmd_signin.Name = "cmd_signin";
            this.cmd_signin.Size = new System.Drawing.Size(75, 23);
            this.cmd_signin.TabIndex = 2;
            this.cmd_signin.Text = "Sign In";
            this.cmd_signin.UseVisualStyleBackColor = true;
            this.cmd_signin.Click += new System.EventHandler(this.cmd_signin_Click);
            // 
            // ErrorPro
            // 
            this.ErrorPro.ContainerControl = this;
            // 
            // cmd_SignUp
            // 
            this.cmd_SignUp.Location = new System.Drawing.Point(127, 152);
            this.cmd_SignUp.Name = "cmd_SignUp";
            this.cmd_SignUp.Size = new System.Drawing.Size(75, 23);
            this.cmd_SignUp.TabIndex = 2;
            this.cmd_SignUp.Text = "Sign Up";
            this.cmd_SignUp.UseVisualStyleBackColor = true;
            this.cmd_SignUp.Click += new System.EventHandler(this.cmd_SignUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 267);
            this.Controls.Add(this.cmd_SignUp);
            this.Controls.Add(this.cmd_signin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_User);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_signin;
        private System.Windows.Forms.ErrorProvider ErrorPro;
        private System.Windows.Forms.Button cmd_SignUp;
    }
}

