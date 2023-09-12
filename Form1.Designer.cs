namespace Lesson1
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
            components = new System.ComponentModel.Container();
            btRun = new Button();
            pbScreenSaver = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbScreenSaver).BeginInit();
            SuspendLayout();
            // 
            // btRun
            // 
            btRun.Location = new Point(499, 383);
            btRun.Name = "btRun";
            btRun.Size = new Size(112, 34);
            btRun.TabIndex = 0;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += BtRun_Click;
            // 
            // pbScreenSaver
            // 
            pbScreenSaver.Location = new Point(0, 0);
            pbScreenSaver.Name = "pbScreenSaver";
            pbScreenSaver.Size = new Size(378, 258);
            pbScreenSaver.TabIndex = 1;
            pbScreenSaver.TabStop = false;
            pbScreenSaver.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += Timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 429);
            Controls.Add(pbScreenSaver);
            Controls.Add(btRun);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbScreenSaver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btRun;
        private PictureBox pbScreenSaver;
        private System.Windows.Forms.Timer timer1;
    }
}