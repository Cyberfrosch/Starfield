namespace Lesson1
{
    public partial class Form1 : Form
    {
        public class Star
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
        }

        private Star[] stars = new Star[15000];

        private Random random = new Random();

        private Graphics? graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private static float Map(float position, int firstOriginal, int lastOriginal, int firstNew, int lastNew)
        {
            return (position - firstOriginal) / (lastOriginal - firstOriginal) * (lastNew - firstNew) + firstNew;
        }

        private void DrawStar(Star star)
        {
            float starSize = Map(star.Z, 0, pbScreenSaver.Width, 8, 0);

            float x = Map(star.X / star.Z, 0, 1, 0, pbScreenSaver.Width) + pbScreenSaver.Width / 2;
            float y = Map(star.Y / star.Z, 0, 1, 0, pbScreenSaver.Height) + pbScreenSaver.Height / 2;

            graphics?.FillEllipse(Brushes.Violet, x, y, starSize, starSize);
        }

        private void MoveStar(Star star)
        {
            star.Z -= 10;

            if (star.Z < 1)
            {
                star.X = random.Next(-pbScreenSaver.Width, pbScreenSaver.Width);
                star.Y = random.Next(-pbScreenSaver.Height, pbScreenSaver.Height);
                star.Z = random.Next(1, pbScreenSaver.Width);
            }
        }

        private void BtRun_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            btRun.Visible = false;

            pbScreenSaver.Dock = DockStyle.Fill;
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
    }
}