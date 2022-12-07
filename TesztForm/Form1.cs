namespace TesztForm
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int solutionNumber = 0;
        private int guessNumber = 0;
        private int points = 0;
        public Form1()
        {
            InitializeComponent();
            setRandom();
        }

        private void setRandom()
        {
            solutionNumber= rnd.Next(1,10);
            guessNumber = rnd.Next(1,10);
            label2.Text = guessNumber.ToString();
        }
        private void UpdatePoints(int num)
        {
            points += num;            
            if (points <= 0)
            {
                MessageBox.Show("Vesztett�l! �j j�t�k!");
                points = 0;
                label1.Text = "Pontsz�mod: 0";
                setRandom();
                return;
            }
            else if (points >= 10)
            {
                MessageBox.Show("Gy�zt�l! �j j�t�k!");
                points = 0;
                label1.Text = "Pontsz�mod: 0";
                setRandom();
                return;
            }
            label1.Text = "Pontsz�mod: " + points;
            setRandom();
        }
        private void ifgreat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(guessNumber) < solutionNumber)
                {
                    MessageBox.Show("Gratul�lunk, nyert�l! +1 pont! A sz�m: " + solutionNumber + " volt");                    
                    UpdatePoints(1);
                }
                else if (Convert.ToInt32(guessNumber) == solutionNumber)
                {
                    MessageBox.Show("Ugyanaz a k�t sz�m! Nem j�r pont! A sz�m: " + solutionNumber + " volt");
                    UpdatePoints(0);
                }
                else
                {
                    MessageBox.Show("Gratul�lunk, vesztett�l! -1 pont! A sz�m: " + solutionNumber + " volt");
                    UpdatePoints(-1);                        
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba t�rt�nt");
            }            
        }

        private void ifless_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(guessNumber) > solutionNumber)
                {
                    MessageBox.Show("Gratul�lunk, nyert�l! +1 pont! A sz�m: " + solutionNumber + " volt");
                    UpdatePoints(1);
                }
                else if (Convert.ToInt32(guessNumber) == solutionNumber)
                {
                    MessageBox.Show("Ugyanaz a k�t sz�m! Nem j�r pont! A sz�m: " + solutionNumber + " volt");
                    UpdatePoints(0);
                }
                else
                {
                    MessageBox.Show("Gratul�lunk, vesztett�l! -1 pont! A sz�m: " + solutionNumber + " volt");
                    UpdatePoints(-1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba t�rt�nt");
            }
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�j j�t�k!");
            points = 0;
            label1.Text = "Pontsz�mod: 0";
            setRandom();
        }
    }
}