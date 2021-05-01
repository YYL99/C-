
namespace Practice
{
    partial class Add
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
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Location = new System.Drawing.Point(31, 26);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(69, 20);
            this.lblAdd1.TabIndex = 0;
            this.lblAdd1.Text = "加数一：";
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Location = new System.Drawing.Point(31, 76);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(69, 20);
            this.lblAdd2.TabIndex = 1;
            this.lblAdd2.Text = "加数二：";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(141, 26);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(125, 27);
            this.txtAdd1.TabIndex = 2;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(141, 76);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(125, 27);
            this.txtAdd2.TabIndex = 3;
            // 
            // txtHelp
            // 
            this.txtHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.txtHelp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHelp.Location = new System.Drawing.Point(31, 193);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(353, 27);
            this.txtHelp.TabIndex = 4;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(141, 128);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(125, 27);
            this.txtSum.TabIndex = 5;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(31, 128);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(54, 20);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "结果：";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(290, 50);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(94, 29);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "计算";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 244);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.lblAdd2);
            this.Controls.Add(this.lblAdd1);
            this.Name = "Add";
            this.Text = "加法计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnSum;
    }
}