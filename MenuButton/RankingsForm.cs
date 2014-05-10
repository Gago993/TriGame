using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuButton
{


    public partial class Rankings : Form
    {
        private Font font;
        public Rankings(Font font)
        {
            InitializeComponent();
            this.font = font;
            setFont(font);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readingDefaultRankings();
            // ako sakas da vidis kako reagira koga se vmetnuva nov score, povikaj trgni go komentarot od
            // ova dole
            //newScore("Zverot 52");
            
            readingDefaultRankings();
        }

        public void setFont(Font setFont)
        {
            foreach (Control control in this.Controls)
            {
                control.Font = setFont;
            }
        }

        public void readingDefaultRankings()
        {
            //citanje na pocetnata sostojba od rankingsRead datotekata so nekoi pocetni rezultati
            StreamReader sr = null;
            try
            {
                sr= new StreamReader(".//rankingsRead.txt");
            }
            catch (Exception e)
            {
                return;
            }
            
            String s;
            String[] pom;
            //Citanje prv red
            s = sr.ReadLine();
            if (s != null)
            {

            pom = s.Split();
            lblName1.Text = pom[0] + " " + pom[1];
            lblPoints1.Text = pom[2];
            }
            
            //Citanje vtor red
            s = sr.ReadLine();
            if (s != null)
            {

                pom = s.Split();
                lblName2.Text = pom[0] + " " + pom[1];
                lblPoints2.Text = pom[2];
            }
            //Citanje tret red
            s = sr.ReadLine();
                    if (s != null)
            {

            pom = s.Split();
            lblName3.Text = pom[0] + " " + pom[1];
            lblPoints3.Text = pom[2];
                    }
            //Citanje cetvrt red
            s = sr.ReadLine();
            if (s != null)
            {

            pom = s.Split();
            lblName4.Text = pom[0] + " " + pom[1];
            lblPoints4.Text = pom[2];
                          }
            //Citanje petti red
            s = sr.ReadLine();
            if (s != null)
            {
            pom = s.Split();
            lblName5.Text = pom[0] + " " + pom[1];
            lblPoints5.Text = pom[2];
            }

            
            
            sr.Close();
        }
        public static void newScore(String nameAndScore)
        {
            //Argumentot koj se prima e string od Ime i Poeni sto gi vnesuvas koga ke zavrsi igrata
            //Napraveno e sekogas da se prikazuvaat najdobrite 5
            StreamReader sr;
            try
            {
                sr = new StreamReader(".//rankingsRead.txt");

            }catch(Exception e){
                    var writer = new StreamWriter(".//rankingsRead.txt");
                    writer.Close();
                   
                    sr = new StreamReader(".//rankingsRead.txt");
            }
                
    
            
            List<String> rezultat = new List<String>();
            Boolean flag = true;
            String tmp;
            String [] nameAndScoreSplitted = nameAndScore.Split();
            Boolean flag2 = false;
            //gi citam site od rankingsRead i gi vnesuvam vo lista rezultat
            // go vmetnuvam vo listata i noviot rezultat na mestoto kade sto treba da bide, reden broj mu stavam
            // random 0
            while ((tmp = sr.ReadLine()) != null)
            {
                flag2 = true;
                String[] indexNameScore = tmp.Split();
                if ((Int32.Parse(indexNameScore[2]) < (Int32.Parse(nameAndScoreSplitted[1]))) && flag)
                {
                    rezultat.Add("0. " + nameAndScore);
                    rezultat.Add(tmp);
                    flag = false;
                }
                else
                {
                    
                    rezultat.Add(tmp);
                }
            }
            sr.Close();
            if (!flag2 || flag)
            {
                rezultat.Add("0. " + nameAndScore);
            }
       
            //site od listata so rezultati gi vmetnuvam vo rankingsRead so toa sto go zapazuvam 
            //i nivniot redenBroj
            var swRankingsRead = new StreamWriter(".//rankingsRead.txt");
            for (int i = 0; i < rezultat.Count; i++ )
            {
                String[] pom1 = rezultat[i].Split();
                swRankingsRead.WriteLine((i + 1).ToString() + ". " + pom1[1] + " " + pom1[2]);
            }
            swRankingsRead.Close();
            
            
            
        }

        private void btn_Back_Rankings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
