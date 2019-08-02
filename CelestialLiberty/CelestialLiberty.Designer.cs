namespace CelestialLiberty
{
    partial class CelestialLiberty
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
            this.components = new System.ComponentModel.Container();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tmrRival = new System.Windows.Forms.Timer(this.components);
            this.tmrSerpent = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Silver;
            this.pnlGame.Location = new System.Drawing.Point(12, 32);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(500, 400);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // tmrRival
            // 
            this.tmrRival.Enabled = true;
            this.tmrRival.Tick += new System.EventHandler(this.tmrRival_Tick);
            // 
            // tmrSerpent
            // 
            this.tmrSerpent.Enabled = true;
            this.tmrSerpent.Interval = 50;
            this.tmrSerpent.Tick += new System.EventHandler(this.tmrSerpent_Tick);
            // 
            // CelestialLiberty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.pnlGame);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "CelestialLiberty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celestial Liberty";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CelestialLiberty_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CelestialLiberty_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrRival;
        private System.Windows.Forms.Timer tmrSerpent;
    }
}

