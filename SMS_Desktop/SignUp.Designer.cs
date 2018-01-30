namespace SMS_Desktop
{
    partial class SignUp
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmd_Delete = new System.Windows.Forms.Button();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.Group_info = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_suburb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.Group_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmd_Delete);
            this.groupBox2.Controls.Add(this.cmd_Add);
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 72);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Location = new System.Drawing.Point(164, 28);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(75, 23);
            this.cmd_Delete.TabIndex = 11;
            this.cmd_Delete.Text = "Cancel";
            this.cmd_Delete.UseVisualStyleBackColor = true;
            this.cmd_Delete.Click += new System.EventHandler(this.cmd_Delete_Click);
            // 
            // cmd_Add
            // 
            this.cmd_Add.Location = new System.Drawing.Point(70, 28);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(75, 23);
            this.cmd_Add.TabIndex = 11;
            this.cmd_Add.Text = "Add New";
            this.cmd_Add.UseVisualStyleBackColor = true;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // Group_info
            // 
            this.Group_info.Controls.Add(this.label10);
            this.Group_info.Controls.Add(this.label4);
            this.Group_info.Controls.Add(this.txt_street);
            this.Group_info.Controls.Add(this.label1);
            this.Group_info.Controls.Add(this.txt_number);
            this.Group_info.Controls.Add(this.label2);
            this.Group_info.Controls.Add(this.txt_postcode);
            this.Group_info.Controls.Add(this.label3);
            this.Group_info.Controls.Add(this.txt_state);
            this.Group_info.Controls.Add(this.label5);
            this.Group_info.Controls.Add(this.txt_suburb);
            this.Group_info.Controls.Add(this.label6);
            this.Group_info.Controls.Add(this.txt_mobile);
            this.Group_info.Controls.Add(this.txt_fullName);
            this.Group_info.Controls.Add(this.label7);
            this.Group_info.Controls.Add(this.txt_password);
            this.Group_info.Controls.Add(this.label8);
            this.Group_info.Controls.Add(this.txt_email);
            this.Group_info.Controls.Add(this.label9);
            this.Group_info.Controls.Add(this.txt_ID);
            this.Group_info.Location = new System.Drawing.Point(12, 12);
            this.Group_info.Name = "Group_info";
            this.Group_info.Size = new System.Drawing.Size(317, 332);
            this.Group_info.TabIndex = 11;
            this.Group_info.TabStop = false;
            this.Group_info.Text = "Account information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mobile phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Full Name";
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(202, 215);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(104, 20);
            this.txt_street.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acount ID";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(112, 215);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(43, 20);
            this.txt_number.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email (User Name)";
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(239, 287);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(67, 20);
            this.txt_postcode.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(112, 287);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(59, 20);
            this.txt_state.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // txt_suburb
            // 
            this.txt_suburb.Location = new System.Drawing.Point(112, 251);
            this.txt_suburb.Name = "txt_suburb";
            this.txt_suburb.Size = new System.Drawing.Size(194, 20);
            this.txt_suburb.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Street";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(112, 180);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(194, 20);
            this.txt_mobile.TabIndex = 3;
            // 
            // txt_fullName
            // 
            this.txt_fullName.Location = new System.Drawing.Point(112, 150);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(194, 20);
            this.txt_fullName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Suburb";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(112, 114);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(194, 20);
            this.txt_password.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "State";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(112, 78);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(194, 20);
            this.txt_email.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Post Code";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(112, 42);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Group_info);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.groupBox2.ResumeLayout(false);
            this.Group_info.ResumeLayout(false);
            this.Group_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmd_Delete;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.GroupBox Group_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_suburb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.ErrorProvider Error;
    }
}