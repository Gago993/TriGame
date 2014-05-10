using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuButton
{


    public partial class Settings : Form
    {
        


        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public MP3Player mp3Player;
        public SoundPlayer initialPlayer;
        public string path;
        private Font defaultFont;
        public Boolean playing;

        public int timer;

        public Settings(MP3Player mp3,string mp3Path,SoundPlayer sb,Font font,int timerGame,Boolean isPlaying)
        {
            InitializeComponent();
            mp3Player = mp3;
            path = mp3Path;
            initialPlayer = sb;
            SetMusicFile(mp3Path);
            defaultFont = font;
            playing = isPlaying;
            if (isPlaying == false) cbMusicOnOff.Checked = false;

            setTimer(timerGame);
            
            // By the default set the volume to 0
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
            tbarVolume.Value = CalcVol / (ushort.MaxValue / 10);
        }

        private void setTimer(int timerGame)
        {
            timer = timerGame;
            if (timer == 900) rbEasy.Checked = true;
            if (timer == 600) rbMedium.Checked = true;
            if (timer == 300) rbHard.Checked = true;
        }

        private void btnChooseSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Music file (*.mp3,*.wav)|*.mp3;*.wav";
            openFileDialog1.Title = "Open a Music File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SetMusicFile(openFileDialog1.FileName);
                initialPlayer.Stop();
                this.cbMusicOnOff_CheckedChanged(null,null);
            }
        }

        private void SetMusicFile(string p)
        {
            if (p !=  null)
            {
                path = p;
                string []name = p.Split('\\');
                lblCurrentSong.Text = name.Last();
                
            }
            else
            {
                lblCurrentSong.Text = "Default song";
            }
            
        }

        private void cbMusicOnOff_CheckedChanged(object sender, EventArgs e)
        {
                if (cbMusicOnOff.Checked)
                {
                    playing = true;
                    if (path == null)
                    {
                        initialPlayer.PlayLooping();
                    }
                    else
                    {
                        mp3Player.Close();
                        mp3Player.Open(path);
                        mp3Player.Play(true);
                    }
                }
                else
                {
                    playing = false;
                    initialPlayer.Stop();
                    mp3Player.Close();
                }
        }  
             
        

        private void tbarVolume_Scroll(object sender, EventArgs e)
        {
            // Calculate the volume that's being set
            int NewVolume = ((ushort.MaxValue / 10) * tbarVolume.Value);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void Settings_Load(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                control.Font = defaultFont;
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEasy.Checked)
            {
                timer = 900;
            }
            else if (rbMedium.Checked)
            {
                timer = 600;
            }
            else if (rbHard.Checked)
            {
                timer = 300;
            }
        }

        private void btn_Back_Settings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
