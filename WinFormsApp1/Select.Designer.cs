
namespace WinFormsApp1
{
    partial class Select
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
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(24, 24);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(264, 20);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "从以下选项中选取唯一一个正确答案：";
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(39, 74);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(97, 24);
            this.rbtnA.TabIndex = 1;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "A：答案A";
            this.rbtnA.UseVisualStyleBackColor = true;
            this.rbtnA.CheckedChanged += new System.EventHandler(this.rbtnA_CheckedChanged);
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(246, 74);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(93, 24);
            this.rbtnB.TabIndex = 2;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "B：答案B";
            this.rbtnB.UseVisualStyleBackColor = true;
            this.rbtnB.CheckedChanged += new System.EventHandler(this.rbtnB_CheckedChanged);
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(39, 127);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(95, 24);
            this.rbtnC.TabIndex = 3;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "C：答案C";
            this.rbtnC.UseVisualStyleBackColor = true;
            this.rbtnC.CheckedChanged += new System.EventHandler(this.rbtnC_CheckedChanged);
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.Location = new System.Drawing.Point(246, 127);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(97, 24);
            this.rbtnD.TabIndex = 4;
            this.rbtnD.TabStop = true;
            this.rbtnD.Text = "D：答案D";
            this.rbtnD.UseVisualStyleBackColor = true;
            this.rbtnD.CheckedChanged += new System.EventHandler(this.rbtnD_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(39, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(246, 225);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(94, 29);
            this.btnNO.TabIndex = 6;
            this.btnNO.Text = "退出";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(39, 179);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(114, 20);
            this.lblHelp.TabIndex = 7;
            this.lblHelp.Text = "未选择任何答案";
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 303);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbtnD);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.rbtnB);
            this.Controls.Add(this.rbtnA);
            this.Controls.Add(this.lbltitle);
            this.Name = "Select";
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Label lblHelp;
    }
}