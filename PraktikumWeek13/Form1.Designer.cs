
namespace PraktikumWeek13
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
            this.lblinput = new System.Windows.Forms.Label();
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.btnproses = new System.Windows.Forms.Button();
            this.labeloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblinput.Location = new System.Drawing.Point(12, 9);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(77, 17);
            this.lblinput.TabIndex = 0;
            this.lblinput.Text = "Input Data:";
            // 
            // textBoxinput
            // 
            this.textBoxinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxinput.Location = new System.Drawing.Point(15, 30);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(342, 23);
            this.textBoxinput.TabIndex = 1;
            // 
            // btnproses
            // 
            this.btnproses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnproses.Location = new System.Drawing.Point(15, 84);
            this.btnproses.Name = "btnproses";
            this.btnproses.Size = new System.Drawing.Size(75, 23);
            this.btnproses.TabIndex = 2;
            this.btnproses.Text = "Proses";
            this.btnproses.UseVisualStyleBackColor = true;
            this.btnproses.Click += new System.EventHandler(this.btnproses_Click);
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Location = new System.Drawing.Point(12, 143);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(100, 26);
            this.labeloutput.TabIndex = 3;
            this.labeloutput.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 205);
            this.Controls.Add(this.labeloutput);
            this.Controls.Add(this.btnproses);
            this.Controls.Add(this.textBoxinput);
            this.Controls.Add(this.lblinput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.Button btnproses;
        private System.Windows.Forms.Label labeloutput;
    }
}

