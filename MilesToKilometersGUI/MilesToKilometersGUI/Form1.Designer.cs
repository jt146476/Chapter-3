namespace MilesToKilometersGUI
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToKilos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(168, 155);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 51);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "Convert To Kilos";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(180, 82);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblToKilos
            // 
            this.lblToKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToKilos.Location = new System.Drawing.Point(168, 251);
            this.lblToKilos.Name = "lblToKilos";
            this.lblToKilos.Size = new System.Drawing.Size(100, 23);
            this.lblToKilos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 327);
            this.Controls.Add(this.lblToKilos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.btn_Convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToKilos;
    }
}

