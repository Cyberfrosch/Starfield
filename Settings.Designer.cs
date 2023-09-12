namespace Lesson1
{
    partial class Settings
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
            Color = new Button();
            lbStarSize = new Label();
            tbStarSize = new TrackBar();
            colorDialogBackground = new ColorDialog();
            lbStarSizeValue = new Label();
            lbSpeedValue = new Label();
            tbSpeed = new TrackBar();
            lbSpeed = new Label();
            btClose = new Button();
            lbStarsNumberValue = new Label();
            tbStarsNumber = new TrackBar();
            lbStarsNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)tbStarSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbStarsNumber).BeginInit();
            SuspendLayout();
            // 
            // Color
            // 
            Color.Location = new Point(12, 12);
            Color.Name = "Color";
            Color.Size = new Size(150, 34);
            Color.TabIndex = 0;
            Color.Text = "Change color";
            Color.UseVisualStyleBackColor = true;
            Color.Click += Color_Click;
            // 
            // lbStarSize
            // 
            lbStarSize.AutoSize = true;
            lbStarSize.Location = new Point(12, 63);
            lbStarSize.Name = "lbStarSize";
            lbStarSize.Size = new Size(76, 25);
            lbStarSize.TabIndex = 2;
            lbStarSize.Text = "Star size";
            // 
            // tbStarSize
            // 
            tbStarSize.Location = new Point(118, 63);
            tbStarSize.Maximum = 20;
            tbStarSize.Minimum = 3;
            tbStarSize.Name = "tbStarSize";
            tbStarSize.Size = new Size(214, 69);
            tbStarSize.TabIndex = 3;
            tbStarSize.Value = 8;
            tbStarSize.Scroll += TBStarSize_Scroll;
            // 
            // lbStarSizeValue
            // 
            lbStarSizeValue.AutoSize = true;
            lbStarSizeValue.Location = new Point(338, 63);
            lbStarSizeValue.Name = "lbStarSizeValue";
            lbStarSizeValue.Size = new Size(22, 25);
            lbStarSizeValue.TabIndex = 4;
            lbStarSizeValue.Text = "0";
            // 
            // lbSpeedValue
            // 
            lbSpeedValue.AutoSize = true;
            lbSpeedValue.Location = new Point(338, 138);
            lbSpeedValue.Name = "lbSpeedValue";
            lbSpeedValue.Size = new Size(22, 25);
            lbSpeedValue.TabIndex = 7;
            lbSpeedValue.Text = "0";
            // 
            // tbSpeed
            // 
            tbSpeed.Location = new Point(118, 138);
            tbSpeed.Maximum = 100;
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new Size(214, 69);
            tbSpeed.TabIndex = 6;
            tbSpeed.TickFrequency = 10;
            tbSpeed.Value = 10;
            tbSpeed.Scroll += TBSpeed_Scroll;
            // 
            // lbSpeed
            // 
            lbSpeed.AutoSize = true;
            lbSpeed.Location = new Point(12, 138);
            lbSpeed.Name = "lbSpeed";
            lbSpeed.Size = new Size(62, 25);
            lbSpeed.TabIndex = 5;
            lbSpeed.Text = "Speed";
            // 
            // btClose
            // 
            btClose.Location = new Point(295, 273);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 8;
            btClose.Text = "OK";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += BtClose_Click;
            // 
            // lbStarsNumberValue
            // 
            lbStarsNumberValue.AutoSize = true;
            lbStarsNumberValue.Location = new Point(338, 213);
            lbStarsNumberValue.Name = "lbStarsNumberValue";
            lbStarsNumberValue.Size = new Size(22, 25);
            lbStarsNumberValue.TabIndex = 11;
            lbStarsNumberValue.Text = "0";
            // 
            // tbStarsNumber
            // 
            tbStarsNumber.Location = new Point(118, 204);
            tbStarsNumber.Maximum = 50;
            tbStarsNumber.Minimum = 1;
            tbStarsNumber.Name = "tbStarsNumber";
            tbStarsNumber.Size = new Size(214, 69);
            tbStarsNumber.TabIndex = 10;
            tbStarsNumber.TickFrequency = 5;
            tbStarsNumber.Value = 15;
            tbStarsNumber.Scroll += tbStarsNumber_Scroll;
            // 
            // lbStarsNumber
            // 
            lbStarsNumber.AutoSize = true;
            lbStarsNumber.Location = new Point(12, 213);
            lbStarsNumber.Name = "lbStarsNumber";
            lbStarsNumber.Size = new Size(100, 25);
            lbStarsNumber.TabIndex = 9;
            lbStarsNumber.Text = "Stars count";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 319);
            Controls.Add(lbStarsNumberValue);
            Controls.Add(tbStarsNumber);
            Controls.Add(lbStarsNumber);
            Controls.Add(btClose);
            Controls.Add(lbSpeedValue);
            Controls.Add(tbSpeed);
            Controls.Add(lbSpeed);
            Controls.Add(lbStarSizeValue);
            Controls.Add(tbStarSize);
            Controls.Add(lbStarSize);
            Controls.Add(Color);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            KeyDown += Settings_KeyDown;
            ((System.ComponentModel.ISupportInitialize)tbStarSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbStarsNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Color;
        private Label lbStarSize;
        private TrackBar tbStarSize;
        private ColorDialog colorDialogBackground;
        private Label lbStarSizeValue;
        private Label lbSpeedValue;
        private TrackBar tbSpeed;
        private Label lbSpeed;
        private Button btClose;
        private Label lbStarsNumberValue;
        private TrackBar tbStarsNumber;
        private Label lbStarsNumber;
    }
}