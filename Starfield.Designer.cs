namespace Lesson1
{
    partial class Starfield
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
            components = new System.ComponentModel.Container();
            btRun = new Button();
            pbScreenSaver = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStripSettings = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            btClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbScreenSaver).BeginInit();
            menuStripSettings.SuspendLayout();
            SuspendLayout();
            // 
            // btRun
            // 
            btRun.Anchor = AnchorStyles.None;
            btRun.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btRun.Location = new Point(148, 110);
            btRun.Name = "btRun";
            btRun.Size = new Size(215, 100);
            btRun.TabIndex = 0;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += BtRun_Click;
            // 
            // pbScreenSaver
            // 
            pbScreenSaver.Dock = DockStyle.Fill;
            pbScreenSaver.Location = new Point(0, 33);
            pbScreenSaver.Name = "pbScreenSaver";
            pbScreenSaver.Size = new Size(490, 263);
            pbScreenSaver.TabIndex = 1;
            pbScreenSaver.TabStop = false;
            pbScreenSaver.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += Timer1_Tick;
            // 
            // menuStripSettings
            // 
            menuStripSettings.ImageScalingSize = new Size(24, 24);
            menuStripSettings.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStripSettings.Location = new Point(0, 0);
            menuStripSettings.Name = "menuStripSettings";
            menuStripSettings.Size = new Size(490, 33);
            menuStripSettings.TabIndex = 4;
            menuStripSettings.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(92, 29);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(366, 250);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 5;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // Starfield
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 296);
            Controls.Add(btClose);
            Controls.Add(btRun);
            Controls.Add(pbScreenSaver);
            Controls.Add(menuStripSettings);
            Name = "Starfield";
            Text = "Starfield";
            KeyDown += Starfield_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbScreenSaver).EndInit();
            menuStripSettings.ResumeLayout(false);
            menuStripSettings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btRun;
        private PictureBox pbScreenSaver;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStripSettings;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Button btClose;
    }
}