using System;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.IO;

namespace Näyttötyö_peli
{
    
    public partial class Form1 : Form
    {
        private int balance = 0;
        private int multiplier = 0;
        private float TimeSeconds = 1;
        private System.Timers.Timer timer;
        private int seconds = 30;


        public Form1()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Interval = 5000;
            robot.Interval = 1000;
            

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            
            //autoclicker antaa 2 keksiä 3 keksiä jne
            balance++;
            if (multiplier > 0)
            {
                balance += multiplier;
            }

            //päivitetään label automaattisesti
            if (Cookies.InvokeRequired)
            {
                Cookies.Invoke(new Action(() => Cookies.Text = "🍪:" + balance.ToString()));
            }
            else
            {
                Cookies.Text = "🍪:" + balance.ToString();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //kun keksiä klikkaa niin tulee yksi keksi lisää
            balance += 1;
            Cookies.Text = "🍪:" + balance;

            //kerroin mekanismi että keksejä tulee 2 yhdellä klikkausella tai 3, 4...
            if (multiplier > 0)
            {
                balance++;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        { 
                pictureBox1.Width = (int)(pictureBox1.Width * 0.9);
                pictureBox1.Height = (int)(pictureBox1.Height * 0.9);
        }

        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //säädetään keksin kuvaa että hiiren painike ylhäällä se muuttaa koon normaaliin
            pictureBox1.Width = (int)(pictureBox1.Width / 0.9);
            pictureBox1.Height = (int)(pictureBox1.Height / 0.9);
        }

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            //kun painetaan kauppa paneeli tulee esiin ja klikkaus näyttö lähtee näkyvistä
            panel1.Visible = true;
            panel2.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //formin latauksella päivitetään teksti tiedostosta aijemmat lukemat
            LoadBalanceFromFile();
            UpdateBalance();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //kauppa kiinni painike joka ottaaa kauppa paneelin pois ja klikkaus paneelin näkyviin
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void buyMulti_Click_1(object sender, EventArgs e)
        {
            //kertoimen osto, jossa kerroin kasvaa ja päivitetäänb label automaattisesti
            if (balance >= 1000)
            {
                balance -= 1000;
                Cookies.Invoke(new Action(() => Cookies.Text = "🍪:" + balance.ToString()));
                multiplier++;

            }
            //jos et pysty ostamaan kertoimia
            else
            {
                MessageBox.Show("Keksisi eivät riitä!");
            }
        }

        private void buyAutoclicker_Click(object sender, EventArgs e)
        {
            //autoclikcer osto jossa tapahtuu balancen muutos ja timerin päälle laitto ja myös labelin päivitys
            // otetaan autoclicker label pois ja nappi ja korvataan ne boost napilla ja labelilla
            int maksu2 = 100;
            if (balance >= maksu2)
            {

                balance -= 100;
                Cookies.Invoke(new Action(() => Cookies.Text = "🍪:" + balance.ToString()));
                timer.Start();

                buyAutoclicker.Visible = false;
                Boostbtn.Visible = true;
                BoostLabel.Visible = true;
            }
            //jos keksit eivät riitä ostamaan autoclickeriä
            else
            {
                MessageBox.Show("Keksisi eivät riitä!");
            }
        }

        private void Boostbtn_Click(object sender, EventArgs e)
        {
            //nopeutetaan autoclickeriä ja otetaan balancesta 10000 keksiä pois ja label päivittyy automaattisesti
            balance -= 10000;
            if (timer.Interval > 1000)
            {
                timer.Interval -= 1000;
                MessageBox.Show("autoclicker nopeutui sekunnilla!");

            }
            //jos autoclicker painaa yhdessä sekunnissa niin tätä päivitystä ei voi enään ostaa
            if (timer.Interval == 1000)
            {
                Boostbtn.Text = "Maxed";
                Boostbtn.Enabled = false;
            }
        }


        private void StartTimer()
        {//timer robotin napille että sitä ei voi painaa 30 sekunnin sisällä uudelleen
            if (!timer.Enabled)
            {
                seconds = 30;
                RobotBtn.Text = seconds.ToString();
                robot.Start();
                RobotBtn.Enabled = false;
            }
        }

        private void RobotBtn_Click(object sender, EventArgs e)
        {
            //Käytetään robotti auttajaa joka antaa 1000 keksiä heti ja aloitetaan timer että sitä ei voi painaa heit uudelleen
            if (balance >= 1000)
            {
                StartTimer();
                balance += 1000;
                Cookies.Invoke(new Action(() => Cookies.Text = "🍪:" + balance.ToString()));
            }
            //jos keksit eivät riitä
            if (balance < 1000)
            {
                MessageBox.Show("Keksit eivät riitä!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void autobotBtn_Click(object sender, EventArgs e)
        {
            //ostetaan auttaja robotti kaupasta joka antaa painikkeen näkyviin ja pictureboxin
            //label päivittyy automaattisesti
            if (balance >= 10000)
            {
                balance -= 10000;
                RobotBtn.Visible = true;
                pictureBox5.Visible = true;
                Cookies.Invoke(new Action(() => Cookies.Text = "🍪:" + balance.ToString()));
            }
            //jos keksit eivät riitä
            if (balance < 10000)
            {
                MessageBox.Show("Keksit eivät riitä!");
            }
        }

        private void robot_Tick(object sender, EventArgs e)
        {
            //käyetään for looppia laskemaan aikaa ja kun se loppuu niin robotti nappi tulee näkyviin
            for (int i = seconds; i > 0; i--)
            {
                seconds--;
                RobotBtn.Text = seconds.ToString();
                RobotBtn.Enabled = false;

                //lopeta looppi kun aika on 0
                if (seconds == 0)
                {
                    robot.Stop();
                    RobotBtn.Text = "Käynnistä Robotti";
                    RobotBtn.Enabled = true;
                    break;
                }
            }
        }
        private void SaveBalanceTofile()
        {
            //tallennus balance.txt nimiseen tiedostoon ja tietokone lukee sen ja laittaa balancen takaisin
            string filepath = Path.Combine(Application.StartupPath, "balance.txt");

            try
            {
                File.WriteAllText(filepath, balance.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void LoadBalanceFromFile()
        {
            //tiedoston lukeminen ja tarkistaminen onko balance.txt nimistä tiedostoa
            string filepath = Path.Combine(Application.StartupPath, "balance.txt");

            if (File.Exists(filepath))
            {
                try
                {
                    string balanceText = File.ReadAllText(filepath);
                    int.TryParse(balanceText, out balance);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
            //jos tiedostoa ei ole niin balance on 0
            else
            {
                balance = 0;
            }
        }


        private void UpdateBalance()
        {
            //päivittää balancen tiedoston mukaan
            Cookies.Text = $"🍪:{balance}";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //tallennus nappi joka tallentaa tiedoston kun nappia painaa
            SaveBalanceTofile();
            MessageBox.Show("Tallennettu!");
        }

        private void StoreBtn_MouseEnter(object sender, EventArgs e)
        {
            //kun hiiri on napin päällä niin sen väriä ja fontin väriä muutetaan
            StoreBtn.BackColor = Color.White;
            StoreBtn.ForeColor = Color.Black;
            StoreBtn.FlatAppearance.BorderColor = Color.Black;
            
        }

        private void StoreBtn_MouseLeave(object sender, EventArgs e)
        {
            //palautetaan oletus värit kun hiiri lähtee napin päältä pois
            StoreBtn.BackColor = Color.Transparent;
            StoreBtn.ForeColor = Color.White;
            StoreBtn.FlatAppearance.BorderColor = Color.White;
        }
    }
}
