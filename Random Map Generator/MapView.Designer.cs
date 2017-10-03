namespace RandomMapGenerator
{
    partial class MapView
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
            this.picHexMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHexMap)).BeginInit();
            this.SuspendLayout();
            // 
            // picHexMap
            // 
            this.picHexMap.BackColor = System.Drawing.Color.LightCyan;
            this.picHexMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picHexMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHexMap.Location = new System.Drawing.Point(0, 0);
            this.picHexMap.Name = "picHexMap";
            this.picHexMap.Size = new System.Drawing.Size(284, 261);
            this.picHexMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHexMap.TabIndex = 0;
            this.picHexMap.TabStop = false;
            this.picHexMap.Paint += new System.Windows.Forms.PaintEventHandler(this.picHexMap_Paint);
            // 
            // Map_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picHexMap);
            this.Name = "Map_View";
            this.Text = "Map_View";
            ((System.ComponentModel.ISupportInitialize)(this.picHexMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHexMap;
    }
}