using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;


namespace Odtwarzacz_muzyki_v2
{

    public partial class Form1 : Form
    {       
        List<string> Lista_piosenek_Lokalizacja = new List<string>();
        List<double> Lista_piosenek_czasy = new List<double>();
        List<string> Lista_piosenek_nazwa = new List<string>();

        //this.Controls.Add(player);
        //this.player.uiMode = "none";

        WindowsMediaPlayerClass wmp = new WindowsMediaPlayerClass();

        int tmp_glosnosc;
        int indeks_wybranego = 0;
        bool stoped = true;
        
        public Form1()
        {
            InitializeComponent();
            GlosnoscTextBox2.Text = "50 %";
            player.uiMode = "none";
            player.settings.autoStart = false;
            player.settings.volume = 50;
            ListaUtworowListView1.View = View.Details;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            ListaUtworowListView1.Columns.Add("Id", 35, HorizontalAlignment.Center);
            ListaUtworowListView1.Columns.Add("Nazwa Utworu", ListaUtworowListView1.Size.Width - 105, HorizontalAlignment.Left);
            ListaUtworowListView1.Columns.Add("Czas", 45, HorizontalAlignment.Right);            
            
        }

        private void PlayButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (indeks_wybranego != ListaUtworowListView1.SelectedItems[0].Index)
                {
                    indeks_wybranego = ListaUtworowListView1.SelectedItems[0].Index;

                    TerazOdtwarzaneListBox1.Items.Clear();
                    TerazOdtwarzaneListBox1.Items.Add(Lista_piosenek_nazwa[indeks_wybranego]);
                    CzasPiosenkiLrogressBar1.Maximum = Convert.ToInt32(Lista_piosenek_czasy[indeks_wybranego]);
                    CzasPiosenkiLrogressBar1.Value = 0;
                    player.URL = Lista_piosenek_Lokalizacja[indeks_wybranego];
                    player.Ctlcontrols.play();
                    timer1.Enabled = true;
                    stoped = false;
                }
            }
            catch (Exception) { }
                        
            if (stoped == true)
            {
                try
                {
                    indeks_wybranego = ListaUtworowListView1.SelectedItems[0].Index;
                    ListaUtworowListView1.SelectedItems.Clear();
                    TerazOdtwarzaneListBox1.Items.Clear();
                    TerazOdtwarzaneListBox1.Items.Add(Lista_piosenek_nazwa[indeks_wybranego]);
                    CzasPiosenkiLrogressBar1.Maximum = Convert.ToInt32(Lista_piosenek_czasy[indeks_wybranego]);
                    CzasPiosenkiLrogressBar1.Value = 0;
                    player.URL = Lista_piosenek_Lokalizacja[indeks_wybranego];
                    player.Ctlcontrols.play();
                    timer1.Enabled = true;
                    stoped = false;
                }
                catch (Exception) { }

            }
            else
            {
                player.Ctlcontrols.play();
                timer1.Enabled = true;
            }                      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CzasPiosenkiLrogressBar1.Value = Convert.ToInt16(player.Ctlcontrols.currentPosition);
            Koniec_piosenki();
            CzasTrwaniaTextBox3.Text = String.Format("{0:0}:{1:00} / {2:0}:{3:00}", Math.Floor(player.Ctlcontrols.currentPosition / 60), player.Ctlcontrols.currentPosition % 60, Math.Floor(Lista_piosenek_czasy[indeks_wybranego] / 60), Lista_piosenek_czasy[indeks_wybranego] % 60);
        }

        private void StopButton1_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            timer1.Enabled = false;
            CzasPiosenkiLrogressBar1.Value = 0;
            TerazOdtwarzaneListBox1.Items.Clear();
            stoped = true;
        }

        private void PauseButton1_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            timer1.Enabled = false;
        }

        private void NextButton1_Click(object sender, EventArgs e)
        {
            try
            {
                player.Ctlcontrols.stop();
                timer1.Enabled = false;
                CzasPiosenkiLrogressBar1.Value = 0;
                if (indeks_wybranego < Lista_piosenek_Lokalizacja.Count - 1)
                {
                    indeks_wybranego++;
                }
                else
                {
                    indeks_wybranego = 0;
                }
                player.URL = Lista_piosenek_Lokalizacja[indeks_wybranego];
                player.Ctlcontrols.play();
                CzasPiosenkiLrogressBar1.Maximum = Convert.ToInt32(Lista_piosenek_czasy[indeks_wybranego]);
                timer1.Enabled = true;
                TerazOdtwarzaneListBox1.Items.Clear();
                TerazOdtwarzaneListBox1.Items.Add(Lista_piosenek_nazwa[indeks_wybranego]);
            }
            catch (Exception) { }
        }

        private void Koniec_piosenki()
        {           
            if (CzasPiosenkiLrogressBar1.Value == CzasPiosenkiLrogressBar1.Maximum)
            {
                player.Ctlcontrols.stop();
                timer1.Enabled = false;
                CzasPiosenkiLrogressBar1.Value = 0;
                if (indeks_wybranego < Lista_piosenek_Lokalizacja.Count - 1)
                {
                    indeks_wybranego++;
                }
                else
                {
                    indeks_wybranego = 0;
                }
                player.URL = Lista_piosenek_Lokalizacja[indeks_wybranego];
                player.Ctlcontrols.play();
                CzasPiosenkiLrogressBar1.Maximum = Convert.ToInt32(Lista_piosenek_czasy[indeks_wybranego]);
                timer1.Enabled = true;
                TerazOdtwarzaneListBox1.Items.Clear();
                TerazOdtwarzaneListBox1.Items.Add(Lista_piosenek_nazwa[indeks_wybranego]);
            }           
        }

        private void PrevButton2_Click(object sender, EventArgs e)
        {
            try
            {
                player.Ctlcontrols.stop();
                timer1.Enabled = false;
                CzasPiosenkiLrogressBar1.Value = 0;
                if (indeks_wybranego > 0)
                {
                    indeks_wybranego--;
                }
                else
                {
                    indeks_wybranego = Lista_piosenek_Lokalizacja.Count - 1;
                }
                player.URL = Lista_piosenek_Lokalizacja[indeks_wybranego];
                player.Ctlcontrols.play();
                CzasPiosenkiLrogressBar1.Maximum = Convert.ToInt32(Lista_piosenek_czasy[indeks_wybranego]);
                timer1.Enabled = true;
                TerazOdtwarzaneListBox1.Items.Clear();
                TerazOdtwarzaneListBox1.Items.Add(Lista_piosenek_nazwa[indeks_wybranego]);
            }
            catch (Exception) { }
        }

        private void GlosnoscTrackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = GlosnoscTrackBar1.Value;
            GlosnoscTextBox2.Text = Convert.ToString(player.settings.volume)+" %";
        }

        private void FFButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.Ctlcontrols.currentPosition < Lista_piosenek_czasy[indeks_wybranego] - 10)
                {
                    player.Ctlcontrols.currentPosition += 10;
                }
            }
            catch (Exception) { }  
        }

        private void FBButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.Ctlcontrols.currentPosition > 10)
                {
                    player.Ctlcontrols.currentPosition -= 10;
                }
                else
                {
                    player.Ctlcontrols.currentPosition = 0;
                }
            }
            catch (Exception)
            {
                string info = "Wpierw Musisz wczytać Playlistę";
                string nazwa = "Brak Utworu muzycznego";
                MessageBoxButtons przycisk = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(info, nazwa, przycisk);
                throw;
            }
        }

        private void MuteButton1_Click(object sender, EventArgs e)
        {
            if (player.settings.volume == 0)
            {
                player.settings.volume = tmp_glosnosc;
                GlosnoscTextBox2.Text = Convert.ToString(player.settings.volume) + " %";
            }
            else
            {
                tmp_glosnosc = player.settings.volume;
                player.settings.volume = 0;
                GlosnoscTextBox2.Text = Convert.ToString(player.settings.volume) + " %";
            }            
        }

        private void DodajButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string lokalizacja = folderBrowserDialog1.SelectedPath;
                Lista_piosenek_Lokalizacja.AddRange(Import.import_lokalizacja(lokalizacja));
                Lista_piosenek_nazwa.AddRange(Import.import_nazwa(lokalizacja));

                ListaUtworowListView1.Items.Clear();

                for (int i = 0; i < Lista_piosenek_Lokalizacja.Count; i++)
                {
                    IWMPMedia mediaInfo = wmp.newMedia(Lista_piosenek_Lokalizacja[i]);
                    Lista_piosenek_czasy.Add(mediaInfo.duration);

                    ListViewItem utwor = new ListViewItem(Convert.ToString(i+1), 0);
                    utwor.SubItems.Add(Lista_piosenek_nazwa[i]);
                    utwor.SubItems.Add(mediaInfo.durationString);
                    ListaUtworowListView1.Items.AddRange(new ListViewItem[] { utwor });
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CzasTrwaniaTextBox3.Text = String.Empty;
            timer1.Enabled = false;
            player.Ctlcontrols.stop();
            CzasPiosenkiLrogressBar1.Value = 0;
            Lista_piosenek_nazwa.Clear();
            Lista_piosenek_czasy.Clear();
            Lista_piosenek_Lokalizacja.Clear();
            ListaUtworowListView1.Items.Clear();
            TerazOdtwarzaneListBox1.Items.Clear();
        }

        private void Zmiana_StandardButton2_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ForeColor = System.Drawing.Color.Black;

            ListaUtworowListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            ListaUtworowListView1.ForeColor = System.Drawing.Color.Black;

            TerazOdtwarzaneListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            TerazOdtwarzaneListBox1.ForeColor = System.Drawing.Color.Black;

            GlosnoscTextBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            CzasTrwaniaTextBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;

            PlayButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            PlayButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            PlayButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            PlayButton1.ForeColor = System.Drawing.Color.Black;

            StopButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            StopButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            StopButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            StopButton1.ForeColor = System.Drawing.Color.Black;

            PauseButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            PauseButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            PauseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            PauseButton1.ForeColor = System.Drawing.Color.Black;

            FFButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            FFButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            FFButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            FFButton1.ForeColor = System.Drawing.Color.Black;

            FBButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            FBButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            FBButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            FBButton1.ForeColor = System.Drawing.Color.Black;

            NextButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            NextButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            NextButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            NextButton1.ForeColor = System.Drawing.Color.Black;

            PrevButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            PrevButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            PrevButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            PrevButton2.ForeColor = System.Drawing.Color.Black;

            MuteButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            MuteButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            MuteButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            MuteButton1.ForeColor = System.Drawing.Color.Black;

            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            button1.ForeColor = System.Drawing.Color.Black;

            DodajButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            DodajButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            DodajButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            DodajButton1.ForeColor = System.Drawing.Color.Black;
        }

        private void Zmiana_CiemnyButton1_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ForeColor = System.Drawing.Color.LimeGreen;

            ListaUtworowListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ListaUtworowListView1.ForeColor = System.Drawing.Color.Lime;

            TerazOdtwarzaneListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            TerazOdtwarzaneListBox1.ForeColor = System.Drawing.Color.Lime;

            GlosnoscTextBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            CzasTrwaniaTextBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;

            PlayButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            PlayButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PlayButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            PlayButton1.ForeColor = System.Drawing.Color.Lime;

            StopButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            StopButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StopButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            StopButton1.ForeColor = System.Drawing.Color.Lime;

            PauseButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            PauseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PauseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            PauseButton1.ForeColor = System.Drawing.Color.Lime;

            FFButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            FFButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FFButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            FFButton1.ForeColor = System.Drawing.Color.Lime;

            FBButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            FBButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FBButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            FBButton1.ForeColor = System.Drawing.Color.Lime;

            NextButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            NextButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NextButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            NextButton1.ForeColor = System.Drawing.Color.Lime;

            PrevButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            PrevButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PrevButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            PrevButton2.ForeColor = System.Drawing.Color.Lime;

            MuteButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            MuteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MuteButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            MuteButton1.ForeColor = System.Drawing.Color.Lime;

            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            button1.ForeColor = System.Drawing.Color.Lime;

            DodajButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            DodajButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DodajButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            DodajButton1.ForeColor = System.Drawing.Color.Lime;
        }

        private void ListaUtworowListView1_OnDoubleClick(object sender, EventArgs e)
        {
            indeks_wybranego = ListaUtworowListView1.SelectedItems[0].Index;

            TerazOdtwarzaneListBox1.Items.Clear();
            TerazOdtwarzaneListBox1.Items.Add(Lista_piosenek_nazwa[indeks_wybranego]);
            CzasPiosenkiLrogressBar1.Maximum = Convert.ToInt32(Lista_piosenek_czasy[indeks_wybranego]);
            CzasPiosenkiLrogressBar1.Value = 0;
            player.URL = Lista_piosenek_Lokalizacja[indeks_wybranego];
            player.Ctlcontrols.play();
            timer1.Enabled = true;
            stoped = false;
        }
    }
}
