
namespace WinFormsApp1
{
    partial class Checkbox
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(55, 28);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(189, 20);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "从中选出多个正确的选项：";
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Location = new System.Drawing.Point(55, 85);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(98, 24);
            this.cbA.TabIndex = 1;
            this.cbA.Text = "A：答案A";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Location = new System.Drawing.Point(306, 85);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(94, 24);
            this.cbB.TabIndex = 2;
            this.cbB.Text = "B：答案B";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(55, 137);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(96, 24);
            this.cbC.TabIndex = 3;
            this.cbC.Text = "C：答案C";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Location = new System.Drawing.Point(306, 137);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(98, 24);
            this.cbD.TabIndex = 4;
            this.cbD.Text = "D：答案D";
            this.cbD.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(55, 237);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(306, 237);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(94, 29);
            this.btnNO.TabIndex = 6;
            this.btnNO.Text = "退出";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // Checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 309);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.cbA);
            this.Controls.Add(this.lbltitle);
            this.Name = "Checkbox";
            this.Text = "Checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNO;
    }
}