namespace ProjectedPraisesGUI
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
            this.btn_raise = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_entry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_raise
            // 
            this.btn_raise.Location = new System.Drawing.Point(98, 89);
            this.btn_raise.Name = "btn_raise";
            this.btn_raise.Size = new System.Drawing.Size(75, 56);
            this.btn_raise.TabIndex = 0;
            this.btn_raise.Text = "Click me for raise";
            this.btn_raise.UseVisualStyleBackColor = true;
            this.btn_raise.Click += new System.EventHandler(this.btn_raise_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(32, 51);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(34, 13);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "salary";
            // 
            // lbl_result
            // 
            this.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_result.Location = new System.Drawing.Point(47, 166);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(162, 23);
            this.lbl_result.TabIndex = 2;
            // 
            // txt_entry
            // 
            this.txt_entry.Location = new System.Drawing.Point(86, 51);
            this.txt_entry.Name = "txt_entry";
            this.txt_entry.Size = new System.Drawing.Size(100, 20);
            this.txt_entry.TabIndex = 3;
            this.txt_entry.TextChanged += new System.EventHandler(this.txt_entry_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 368);
            this.Controls.Add(this.txt_entry);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btn_raise);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_raise;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_entry;
    }
}

