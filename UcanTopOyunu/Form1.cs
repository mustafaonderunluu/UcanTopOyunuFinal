namespace UcanTopOyunu
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5, yerY = 5, can = 3;
        private void CarpmaOlay�()
        {
            //Label 2 �arpma

            if (Ball.Top <= label2.Bottom)
                yerY = yerY * -1;
            //Kontrol e �arpma
            if (Ball.Bottom >= Kontrol.Top && Ball.Left >= Kontrol.Left && Ball.Right <= Kontrol.Right)
                yerY = yerY * -1;

            // sa� kenara �arpma 

            else if (Ball.Right >= label5.Left)
                yerX = yerX * -1;
            //sol kenara �arpma
            else if (Ball.Left <= label1.Right)
                yerX = yerX * -1;
        }
        private void YanmaOlay�(object sender, EventArgs e)
        {

            if (Ball.Top >= label5.Bottom)
            {
                if (can > 0)
                {

                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yand�n�z Kalan Can >= " + can.ToString());
                    Form1_Load(sender, e);
                }
                if (can == 0)
                {

                    timer1.Stop();
                    MessageBox.Show("Oyunu Kaybettiniz", " ", MessageBoxButtons.OK);
                }
            }
            label3.Text = can.ToString();
        }
        private void TopBasa()
        {
            Ball.Location = new Point(373, 191);
                }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopBasa();
            timer1.Enabled = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Kontrol.Left = e.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            YanmaOlay�(sender, e);
            CarpmaOlay�();
            Ball.Location = new Point(Ball.Location.X + yerX, Ball.Location.Y + yerY);
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }
    }
}
