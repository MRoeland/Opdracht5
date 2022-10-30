namespace Oefening_2
{
    partial class Gemiddelde
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
            this.LBNumbers = new System.Windows.Forms.ListBox();
            this.btnNewNumber = new System.Windows.Forms.Button();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBNumbers
            // 
            this.LBNumbers.FormattingEnabled = true;
            this.LBNumbers.ItemHeight = 15;
            this.LBNumbers.Location = new System.Drawing.Point(32, 12);
            this.LBNumbers.Name = "LBNumbers";
            this.LBNumbers.Size = new System.Drawing.Size(120, 94);
            this.LBNumbers.TabIndex = 0;
            // 
            // btnNewNumber
            // 
            this.btnNewNumber.Location = new System.Drawing.Point(32, 146);
            this.btnNewNumber.Name = "btnNewNumber";
            this.btnNewNumber.Size = new System.Drawing.Size(102, 23);
            this.btnNewNumber.TabIndex = 1;
            this.btnNewNumber.Text = "Nieuw Getal";
            this.btnNewNumber.UseVisualStyleBackColor = true;
            this.btnNewNumber.Click += new System.EventHandler(this.btnNewNumber_Click);
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(135, 203);
            this.tbAverage.Multiline = true;
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(100, 23);
            this.tbAverage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gemiddelde";
            // 
            // Gemiddelde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.btnNewNumber);
            this.Controls.Add(this.LBNumbers);
            this.Name = "Gemiddelde";
            this.Text = "Gemiddelde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LBNumbers;
        private Button btnNewNumber;
        private TextBox tbAverage;
        private Label label1;
    }
}