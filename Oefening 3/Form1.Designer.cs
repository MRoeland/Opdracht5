namespace Oefening_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSPAdd = new System.Windows.Forms.ToolStripButton();
            this.TSPDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSPAdd,
            this.TSPDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSPAdd
            // 
            this.TSPAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSPAdd.Image = ((System.Drawing.Image)(resources.GetObject("TSPAdd.Image")));
            this.TSPAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSPAdd.Name = "TSPAdd";
            this.TSPAdd.Size = new System.Drawing.Size(127, 22);
            this.TSPAdd.Text = "Rechthoek Toevoegen";
            this.TSPAdd.Click += new System.EventHandler(this.TSPAdd_Click);
            // 
            // TSPDelete
            // 
            this.TSPDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSPDelete.Image = ((System.Drawing.Image)(resources.GetObject("TSPDelete.Image")));
            this.TSPDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSPDelete.Name = "TSPDelete";
            this.TSPDelete.Size = new System.Drawing.Size(131, 22);
            this.TSPDelete.Text = "Rechthoek Verwijderen";
            this.TSPDelete.Click += new System.EventHandler(this.TSPDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TSPAdd;
        private ToolStripButton TSPDelete;
    }
}