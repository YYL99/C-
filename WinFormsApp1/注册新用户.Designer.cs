
namespace WinFormsApp1
{
    partial class 注册新用户
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAgain = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAgain = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(52, 62);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(39, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "密码";
            // 
            // lblAgain
            // 
            this.lblAgain.AutoSize = true;
            this.lblAgain.Location = new System.Drawing.Point(52, 103);
            this.lblAgain.Name = "lblAgain";
            this.lblAgain.Size = new System.Drawing.Size(69, 20);
            this.lblAgain.TabIndex = 3;
            this.lblAgain.Text = "确认密码";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(52, 143);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(39, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "性别";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(52, 181);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(69, 20);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "电话号码";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 21);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 6;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 62);
            this.txtPassword.MaxLength = 6;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtAgain
            // 
            this.txtAgain.Location = new System.Drawing.Point(142, 103);
            this.txtAgain.MaxLength = 6;
            this.txtAgain.Name = "txtAgain";
            this.txtAgain.PasswordChar = '*';
            this.txtAgain.Size = new System.Drawing.Size(125, 27);
            this.txtAgain.TabIndex = 8;
            this.txtAgain.Enter += new System.EventHandler(this.txtAgain_Enter);
            this.txtAgain.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgain_Validating);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(142, 143);
            this.txtGender.MaxLength = 2;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(125, 27);
            this.txtGender.TabIndex = 9;
            this.txtGender.Enter += new System.EventHandler(this.txtGender_Enter);
            this.txtGender.Validating += new System.ComponentModel.CancelEventHandler(this.txtGender_Validating);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(142, 181);
            this.txtTelephone.MaxLength = 11;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(125, 27);
            this.txtTelephone.TabIndex = 10;
            this.txtTelephone.Enter += new System.EventHandler(this.txtTelephone_Enter);
            this.txtTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelephone_Validating);
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(24, 268);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHelp.Size = new System.Drawing.Size(243, 27);
            this.txtHelp.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.Location = new System.Drawing.Point(142, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // 注册新用户
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 318);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAgain);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAgain);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Name = "注册新用户";
            this.Text = "注册新用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAgain;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAgain;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Button btnSubmit;
    }
}