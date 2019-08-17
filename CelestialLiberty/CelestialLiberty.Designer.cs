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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CelestialLiberty));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tmrRival = new System.Windows.Forms.Timer(this.components);
            this.tmrSerpent = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileStart = new System.Windows.Forms.ToolStripMenuItem();
            this.FileStop = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsSoundOn = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsSoundOff = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpBackstory = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLives = new System.Windows.Forms.TextBox();
            this.LblScore = new System.Windows.Forms.Label();
            this.tmrMissile = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Silver;
            this.pnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGame.BackgroundImage")));
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
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuOptions,
            this.MenuHelp});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(634, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStart,
            this.FileStop,
            this.FileExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // FileStart
            // 
            this.FileStart.Name = "FileStart";
            this.FileStart.Size = new System.Drawing.Size(98, 22);
            this.FileStart.Text = "Start";
            this.FileStart.Click += new System.EventHandler(this.FileStart_Click);
            // 
            // FileStop
            // 
            this.FileStop.Name = "FileStop";
            this.FileStop.Size = new System.Drawing.Size(98, 22);
            this.FileStop.Text = "Stop";
            this.FileStop.Click += new System.EventHandler(this.FileStop_Click);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(98, 22);
            this.FileExit.Text = "Exit";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // MenuOptions
            // 
            this.MenuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsSoundOn,
            this.OptionsSoundOff});
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(61, 20);
            this.MenuOptions.Text = "Options";
            // 
            // OptionsSoundOn
            // 
            this.OptionsSoundOn.Name = "OptionsSoundOn";
            this.OptionsSoundOn.Size = new System.Drawing.Size(126, 22);
            this.OptionsSoundOn.Text = "Sound on";
            // 
            // OptionsSoundOff
            // 
            this.OptionsSoundOff.Name = "OptionsSoundOff";
            this.OptionsSoundOff.Size = new System.Drawing.Size(126, 22);
            this.OptionsSoundOff.Text = "Sound off";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpBackstory,
            this.HelpInstructions});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "Help";
            // 
            // HelpBackstory
            // 
            this.HelpBackstory.Name = "HelpBackstory";
            this.HelpBackstory.Size = new System.Drawing.Size(136, 22);
            this.HelpBackstory.Text = "Backstory";
            // 
            // HelpInstructions
            // 
            this.HelpInstructions.Name = "HelpInstructions";
            this.HelpInstructions.Size = new System.Drawing.Size(136, 22);
            this.HelpInstructions.Text = "Instructions";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(522, 78);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 2;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(549, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Score";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(553, 231);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(40, 16);
            this.lblLives.TabIndex = 4;
            this.lblLives.Text = "Lives";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // TxtLives
            // 
            this.TxtLives.Location = new System.Drawing.Point(548, 250);
            this.TxtLives.Name = "TxtLives";
            this.TxtLives.Size = new System.Drawing.Size(50, 20);
            this.TxtLives.TabIndex = 6;
            this.TxtLives.TextChanged += new System.EventHandler(this.TxtLives_TextChanged);
            // 
            // LblScore
            // 
            this.LblScore.BackColor = System.Drawing.SystemColors.Window;
            this.LblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(548, 173);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(50, 20);
            this.LblScore.TabIndex = 7;
            // 
            // tmrMissile
            // 
            this.tmrMissile.Enabled = true;
            this.tmrMissile.Interval = 1;
            this.tmrMissile.Tick += new System.EventHandler(this.tmrMissile_Tick);
            // 
            // CelestialLiberty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLives);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "CelestialLiberty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celestial Liberty";
            this.Load += new System.EventHandler(this.CelestialLiberty_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CelestialLiberty_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CelestialLiberty_KeyUp);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrRival;
        private System.Windows.Forms.Timer tmrSerpent;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.MenuStrip Menu;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem FileStart;
        private System.Windows.Forms.ToolStripMenuItem FileStop;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuOptions;
        private System.Windows.Forms.ToolStripMenuItem OptionsSoundOn;
        private System.Windows.Forms.ToolStripMenuItem OptionsSoundOff;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem HelpBackstory;
        private System.Windows.Forms.ToolStripMenuItem HelpInstructions;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLives;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Timer tmrMissile;
    }
}

