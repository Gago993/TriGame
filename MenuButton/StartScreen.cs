using MenuButton.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuButton
{
    public partial class StartScreen : Form
    {
        private int buttonSelected = 1;
        
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;
        Font fontButtonRegular;
        Font fontButtonSelected;
        Font fontRankings;
        
        MP3Player mp3Player;
        Boolean isPlaying = true;
        SoundPlayer sp;
        private string mp3Path;

        public int TIMER_GAME = 200; //200 sekundi tajmer easy

        public StartScreen()
        {
           
            InitializeComponent();
            mp3Player = new MP3Player();
            mp3Path = null;
            sp = new SoundPlayer(Resources.Initial_song);
            sp.PlayLooping();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FontCollection();
            SetNewFont();

        }

       
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Up)
            {
                buttonSelected--;
                if (buttonSelected < 1) buttonSelected = 4;


            }
        }


        private void FontCollection()
        {
            // Create the byte array and get its length

            byte[] fontArray = Resources.gill_sans_ultra_bold_condensed;
            int dataLength = Resources.gill_sans_ultra_bold_condensed.Length;


            // ASSIGN MEMORY AND COPY  BYTE[] ON THAT MEMORY ADDRESS
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);


            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            //PASS THE FONT TO THE  PRIVATEFONTCOLLECTION OBJECT
            pfc.AddMemoryFont(ptrData, dataLength);

            //FREE THE  "UNSAFE" MEMORY
            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);
            fontButtonRegular = new Font(ff, 25f, FontStyle.Bold);
            fontButtonSelected = new Font(ff, 30f, FontStyle.Bold);
            fontRankings = new Font(ff, 25f, FontStyle.Bold);

            MyButton._normalFont = fontButtonRegular;
            MyButton._hoverFont = fontButtonSelected;
            
        }

        private void SetNewFont()
        {
            myButton1.SetFont(fontButtonRegular);
            myButton2.SetFont(fontButtonRegular);
            myButton3.SetFont(fontButtonRegular);
            myButton4.SetFont(fontButtonRegular);

            myButton1.Text = "New Game";
            myButton2.Text = "Rankings";
            myButton3.Text = "Settings";
            myButton4.Text = "Quit Game";
         }

        private void myButton1_Click(object sender, EventArgs e)
        {
            //New Game
            NewGame newGame = new NewGame(fontRankings,fontButtonSelected,TIMER_GAME,1);
            newGame.ShowDialog();
            //MessageBox.Show("New Game");
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            //Rankings
            //MessageBox.Show("Rankings");
            Rankings rankings = new Rankings(fontRankings);
            rankings.ShowDialog();
            
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            //Settings
            Settings settings = new Settings(mp3Player,mp3Path,sp,font,TIMER_GAME,isPlaying);
            DialogResult settingsResult = settings.ShowDialog();
            if (settingsResult == System.Windows.Forms.DialogResult.Cancel)
            {
                isPlaying = settings.playing;
                TIMER_GAME = settings.timer;
                mp3Player = settings.mp3Player;
                mp3Path = settings.path;
                
            }
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            //Quit Game
            this.Close();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    foreach (Control control in this.Controls)
                    {
                        if (control.GetType() == typeof(Button))
                        {
                            if (control.Focused) {
                                ((Button)control).PerformClick();
                            }

                        }
                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
    }
}
