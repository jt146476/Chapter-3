namespace TextInteractiveGUI
{
    partial class Form1
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
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.txtScore5 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(27, 77);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 20);
            this.txtScore1.TabIndex = 0;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(155, 77);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 20);
            this.txtScore2.TabIndex = 1;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(27, 140);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 20);
            this.txtScore3.TabIndex = 2;
            // 
            // txtScore4
            // 
            this.txtScore4.Location = new System.Drawing.Point(155, 140);
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(100, 20);
            this.txtScore4.TabIndex = 3;
            // 
            // txtScore5
            // 
            this.txtScore5.Location = new System.Drawing.Point(27, 210);
            this.txtScore5.Name = "txtScore5";
            this.txtScore5.Size = new System.Drawing.Size(100, 20);
            this.txtScore5.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(27, 263);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Click to Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Test Scores";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(40, 315);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(181, 40);
            this.lblResult.TabIndex = 7;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtScore5);
            this.Controls.Add(this.txtScore4);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore4;
        private System.Windows.Forms.TextBox txtScore5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

