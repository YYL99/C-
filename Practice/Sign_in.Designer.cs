
namespace Practice
{
    partial class Sign_in
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPawssed = new System.Windows.Forms.Label();
            this.txtPawssed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "账号：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 27);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPawssed
            // 
            this.lblPawssed.AutoSize = true;
            this.lblPawssed.Location = new System.Drawing.Point(53, 131);
            this.lblPawssed.Name = "lblPawssed";
            this.lblPawssed.Size = new System.Drawing.Size(54, 20);
            this.lblPawssed.TabIndex = 2;
            this.lblPawssed.Text = "密码：";
            // 
            // txtPawssed
            // 
            this.txtPawssed.Location = new System.Drawing.Point(137, 131);
            this.txtPawssed.MaxLength = 3;
            this.txtPawssed.Name = "txtPawssed";
            this.txtPawssed.PasswordChar = '*';
            this.txtPawssed.Size = new System.Drawing.Size(171, 27);
            this.txtPawssed.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPawssed);
            this.Controls.Add(this.lblPawssed);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Sign_in";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPawssed;
        private System.Windows.Forms.TextBox txtPawssed;
        private System.Windows.Forms.Button button1;
    }
}