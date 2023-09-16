using System.Runtime.InteropServices;

namespace Lesson1
{
    public partial class Starfield : Form
    {
        public class Star
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
        }

        public Color colorBackground = Color.DarkViolet;
        public int starSize = 8;
        public int speed = 10;
        public int starsNumber = 15000;

        public bool flagRun = false;

        private Star[] stars;
        private readonly Random random = new Random();
        private Graphics graphics;

        public Starfield()
        {
            InitializeComponent();

            KeyPreview = true;
        }

        private static float Map(float position, int minOriginal, int maxOriginal, int minNew, int maxNew)
        {
            return (position - minOriginal) / (maxOriginal - minOriginal) * (maxNew - minNew) + minNew;
        }

        private void DrawStar(Star star)
        {
            SolidBrush customBrush = new SolidBrush(colorBackground);

            float starSize = Map(star.Z, 0, pbScreenSaver.Width, this.starSize, 0);

            float x = Map(star.X / star.Z, 0, 1, 0, pbScreenSaver.Width) + pbScreenSaver.Width / 2;
            float y = Map(star.Y / star.Z, 0, 1, 0, pbScreenSaver.Height) + pbScreenSaver.Height / 2;

            graphics?.FillEllipse(customBrush, x, y, starSize, starSize);
        }

        private void MoveStar(Star star)
        {
            star.Z -= speed;

            if (star.Z < 1)
            {
                star.X = random.Next(-pbScreenSaver.Width, pbScreenSaver.Width);
                star.Y = random.Next(-pbScreenSaver.Height, pbScreenSaver.Height);
                star.Z = random.Next(1, pbScreenSaver.Width);
            }
        }

        private void BtRun_Click(object sender, EventArgs e)
        {
            stars = new Star[starsNumber];

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            btRun.Visible = false;
            btClose.Visible = false;
            menuStripSettings.Visible = false;
            Cursor.Hide();

            flagRun = true;
            pbScreenSaver.Visible = true;

            pbScreenSaver.Image = new Bitmap(pbScreenSaver.Width, pbScreenSaver.Height);

            graphics = Graphics.FromImage(pbScreenSaver.Image);

            for (int i = 0; i < stars.Length; ++i)
            {
                stars[i] = new Star()
                {
                    X = random.Next(-pbScreenSaver.Width, pbScreenSaver.Width),
                    Y = random.Next(-pbScreenSaver.Height, pbScreenSaver.Height),
                    Z = random.Next(1, pbScreenSaver.Width)
                };
            }

            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            graphics?.Clear(Color.Black);

            foreach (var star in stars)
            {
                DrawStar(star);
                MoveStar(star);
            }

            pbScreenSaver.Refresh();
        }

        private void CBParams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorDialog colorDialogBackground = new ColorDialog();

            if (colorDialogBackground.ShowDialog() == DialogResult.OK)
            {
                colorBackground = colorDialogBackground.Color;
            }
        }

        public void Starfield_KeyDown(object sender, KeyEventArgs e)
        {
            if (!flagRun)
            {
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                btRun.Visible = true;
                btClose.Visible = true;
                menuStripSettings.Visible = true;
                Cursor.Show();

                pbScreenSaver.Visible = false;
                flagRun = false;
                timer1.Stop();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                Cursor.Show();

                Settings settingsForm = new Settings(this);
                DialogResult result = settingsForm.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    Cursor.Hide();
                }
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(this);
            settingsForm.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}