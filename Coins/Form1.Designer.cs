namespace Coins
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
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.IntegerTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.Location = new System.Drawing.Point(250, 73);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(106, 36);
            this.SubmitBTN.TabIndex = 0;
            this.SubmitBTN.Text = "Submit";
            this.SubmitBTN.UseVisualStyleBackColor = true;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // IntegerTB
            // 
            this.IntegerTB.Location = new System.Drawing.Point(87, 73);
            this.IntegerTB.Name = "IntegerTB";
            this.IntegerTB.Size = new System.Drawing.Size(136, 20);
            this.IntegerTB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IntegerTB);
            this.Controls.Add(this.SubmitBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.TextBox IntegerTB;
    }
}

