namespace Odtwarzacz_muzyki_v2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayButton1 = new System.Windows.Forms.Button();
            this.CzasPiosenkiLrogressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TerazOdtwarzaneListBox1 = new System.Windows.Forms.ListBox();
            this.ListaUtworowListView1 = new System.Windows.Forms.ListView();
            this.StopButton1 = new System.Windows.Forms.Button();
            this.PauseButton1 = new System.Windows.Forms.Button();
            this.NextButton1 = new System.Windows.Forms.Button();
            this.PrevButton2 = new System.Windows.Forms.Button();
            this.GlosnoscTrackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FBButton1 = new System.Windows.Forms.Button();
            this.FFButton1 = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.GlosnoscTextBox2 = new System.Windows.Forms.TextBox();
            this.MuteButton1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.DodajButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Zmiana_StandardButton2 = new System.Windows.Forms.Button();
            this.Zmiana_CiemnyButton1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CzasTrwaniaTextBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GlosnoscTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton1
            // 
            this.PlayButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayButton1.ForeColor = System.Drawing.Color.Lime;
            this.PlayButton1.Location = new System.Drawing.Point(330, 328);
            this.PlayButton1.Name = "PlayButton1";
            this.PlayButton1.Size = new System.Drawing.Size(70, 70);
            this.PlayButton1.TabIndex = 0;
            this.PlayButton1.Text = "Graj";
            this.PlayButton1.UseVisualStyleBackColor = false;
            this.PlayButton1.Click += new System.EventHandler(this.PlayButton1_Click);
            // 
            // CzasPiosenkiLrogressBar1
            // 
            this.CzasPiosenkiLrogressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CzasPiosenkiLrogressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CzasPiosenkiLrogressBar1.Location = new System.Drawing.Point(115, 280);
            this.CzasPiosenkiLrogressBar1.Name = "CzasPiosenkiLrogressBar1";
            this.CzasPiosenkiLrogressBar1.Size = new System.Drawing.Size(480, 25);
            this.CzasPiosenkiLrogressBar1.Step = 1;
            this.CzasPiosenkiLrogressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CzasPiosenkiLrogressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TerazOdtwarzaneListBox1
            // 
            this.TerazOdtwarzaneListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TerazOdtwarzaneListBox1.ForeColor = System.Drawing.Color.Lime;
            this.TerazOdtwarzaneListBox1.FormattingEnabled = true;
            this.TerazOdtwarzaneListBox1.Location = new System.Drawing.Point(115, 255);
            this.TerazOdtwarzaneListBox1.Name = "TerazOdtwarzaneListBox1";
            this.TerazOdtwarzaneListBox1.Size = new System.Drawing.Size(480, 17);
            this.TerazOdtwarzaneListBox1.TabIndex = 4;
            // 
            // ListaUtworowListView1
            // 
            this.ListaUtworowListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListaUtworowListView1.ForeColor = System.Drawing.Color.Lime;
            this.ListaUtworowListView1.FullRowSelect = true;
            this.ListaUtworowListView1.GridLines = true;
            this.ListaUtworowListView1.LabelWrap = false;
            this.ListaUtworowListView1.Location = new System.Drawing.Point(115, 20);
            this.ListaUtworowListView1.MultiSelect = false;
            this.ListaUtworowListView1.Name = "ListaUtworowListView1";
            this.ListaUtworowListView1.Size = new System.Drawing.Size(480, 230);
            this.ListaUtworowListView1.TabIndex = 5;
            this.ListaUtworowListView1.UseCompatibleStateImageBehavior = false;
            this.ListaUtworowListView1.DoubleClick += new System.EventHandler(this.ListaUtworowListView1_OnDoubleClick);
            // 
            // StopButton1
            // 
            this.StopButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopButton1.ForeColor = System.Drawing.Color.Lime;
            this.StopButton1.Location = new System.Drawing.Point(407, 328);
            this.StopButton1.Name = "StopButton1";
            this.StopButton1.Size = new System.Drawing.Size(70, 70);
            this.StopButton1.TabIndex = 6;
            this.StopButton1.Text = "Stop";
            this.StopButton1.UseVisualStyleBackColor = false;
            this.StopButton1.Click += new System.EventHandler(this.StopButton1_Click);
            // 
            // PauseButton1
            // 
            this.PauseButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PauseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PauseButton1.ForeColor = System.Drawing.Color.Lime;
            this.PauseButton1.Location = new System.Drawing.Point(254, 328);
            this.PauseButton1.Name = "PauseButton1";
            this.PauseButton1.Size = new System.Drawing.Size(70, 70);
            this.PauseButton1.TabIndex = 7;
            this.PauseButton1.Text = "Pauza";
            this.PauseButton1.UseVisualStyleBackColor = false;
            this.PauseButton1.Click += new System.EventHandler(this.PauseButton1_Click);
            // 
            // NextButton1
            // 
            this.NextButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NextButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NextButton1.ForeColor = System.Drawing.Color.Lime;
            this.NextButton1.Location = new System.Drawing.Point(483, 328);
            this.NextButton1.Name = "NextButton1";
            this.NextButton1.Size = new System.Drawing.Size(70, 30);
            this.NextButton1.TabIndex = 8;
            this.NextButton1.Text = "Nast";
            this.NextButton1.UseVisualStyleBackColor = false;
            this.NextButton1.Click += new System.EventHandler(this.NextButton1_Click);
            // 
            // PrevButton2
            // 
            this.PrevButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrevButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrevButton2.ForeColor = System.Drawing.Color.Lime;
            this.PrevButton2.Location = new System.Drawing.Point(178, 328);
            this.PrevButton2.Name = "PrevButton2";
            this.PrevButton2.Size = new System.Drawing.Size(70, 30);
            this.PrevButton2.TabIndex = 9;
            this.PrevButton2.Text = "Poprz";
            this.PrevButton2.UseVisualStyleBackColor = false;
            this.PrevButton2.Click += new System.EventHandler(this.PrevButton2_Click);
            // 
            // GlosnoscTrackBar1
            // 
            this.GlosnoscTrackBar1.Location = new System.Drawing.Point(559, 328);
            this.GlosnoscTrackBar1.Maximum = 100;
            this.GlosnoscTrackBar1.Name = "GlosnoscTrackBar1";
            this.GlosnoscTrackBar1.Size = new System.Drawing.Size(160, 45);
            this.GlosnoscTrackBar1.TabIndex = 10;
            this.GlosnoscTrackBar1.Value = 50;
            this.GlosnoscTrackBar1.Scroll += new System.EventHandler(this.GlosnoscTrackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(609, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 13);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Głośność";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FBButton1
            // 
            this.FBButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FBButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FBButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FBButton1.ForeColor = System.Drawing.Color.Lime;
            this.FBButton1.Location = new System.Drawing.Point(178, 368);
            this.FBButton1.Name = "FBButton1";
            this.FBButton1.Size = new System.Drawing.Size(70, 30);
            this.FBButton1.TabIndex = 12;
            this.FBButton1.Text = "-10s";
            this.FBButton1.UseVisualStyleBackColor = false;
            this.FBButton1.Click += new System.EventHandler(this.FBButton1_Click);
            // 
            // FFButton1
            // 
            this.FFButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FFButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FFButton1.ForeColor = System.Drawing.Color.Lime;
            this.FFButton1.Location = new System.Drawing.Point(483, 368);
            this.FFButton1.Name = "FFButton1";
            this.FFButton1.Size = new System.Drawing.Size(70, 30);
            this.FFButton1.TabIndex = 13;
            this.FFButton1.Text = "+10s";
            this.FFButton1.UseVisualStyleBackColor = false;
            this.FFButton1.Click += new System.EventHandler(this.FFButton1_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 328);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(160, 70);
            this.player.TabIndex = 14;
            this.player.TabStop = false;
            // 
            // GlosnoscTextBox2
            // 
            this.GlosnoscTextBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GlosnoscTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GlosnoscTextBox2.Location = new System.Drawing.Point(665, 377);
            this.GlosnoscTextBox2.Name = "GlosnoscTextBox2";
            this.GlosnoscTextBox2.Size = new System.Drawing.Size(54, 13);
            this.GlosnoscTextBox2.TabIndex = 15;
            // 
            // MuteButton1
            // 
            this.MuteButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MuteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MuteButton1.ForeColor = System.Drawing.Color.Lime;
            this.MuteButton1.Location = new System.Drawing.Point(559, 368);
            this.MuteButton1.Name = "MuteButton1";
            this.MuteButton1.Size = new System.Drawing.Size(48, 30);
            this.MuteButton1.TabIndex = 16;
            this.MuteButton1.Text = "Mute";
            this.MuteButton1.UseVisualStyleBackColor = false;
            this.MuteButton1.Click += new System.EventHandler(this.MuteButton1_Click);
            // 
            // DodajButton1
            // 
            this.DodajButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DodajButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajButton1.ForeColor = System.Drawing.Color.Lime;
            this.DodajButton1.Location = new System.Drawing.Point(617, 23);
            this.DodajButton1.Margin = new System.Windows.Forms.Padding(2);
            this.DodajButton1.Name = "DodajButton1";
            this.DodajButton1.Size = new System.Drawing.Size(95, 24);
            this.DodajButton1.TabIndex = 17;
            this.DodajButton1.Text = "Dodaj Pliki";
            this.DodajButton1.UseVisualStyleBackColor = false;
            this.DodajButton1.Click += new System.EventHandler(this.DodajButton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(617, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Wyczyść Listę";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zmiana_StandardButton2
            // 
            this.Zmiana_StandardButton2.ForeColor = System.Drawing.Color.Black;
            this.Zmiana_StandardButton2.Location = new System.Drawing.Point(19, 50);
            this.Zmiana_StandardButton2.Margin = new System.Windows.Forms.Padding(2);
            this.Zmiana_StandardButton2.Name = "Zmiana_StandardButton2";
            this.Zmiana_StandardButton2.Size = new System.Drawing.Size(75, 28);
            this.Zmiana_StandardButton2.TabIndex = 19;
            this.Zmiana_StandardButton2.Text = "Standard";
            this.Zmiana_StandardButton2.UseVisualStyleBackColor = true;
            this.Zmiana_StandardButton2.Click += new System.EventHandler(this.Zmiana_StandardButton2_Click);
            // 
            // Zmiana_CiemnyButton1
            // 
            this.Zmiana_CiemnyButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Zmiana_CiemnyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zmiana_CiemnyButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zmiana_CiemnyButton1.ForeColor = System.Drawing.Color.Lime;
            this.Zmiana_CiemnyButton1.Location = new System.Drawing.Point(19, 83);
            this.Zmiana_CiemnyButton1.Margin = new System.Windows.Forms.Padding(2);
            this.Zmiana_CiemnyButton1.Name = "Zmiana_CiemnyButton1";
            this.Zmiana_CiemnyButton1.Size = new System.Drawing.Size(75, 28);
            this.Zmiana_CiemnyButton1.TabIndex = 20;
            this.Zmiana_CiemnyButton1.Text = "Ciemny";
            this.Zmiana_CiemnyButton1.UseVisualStyleBackColor = false;
            this.Zmiana_CiemnyButton1.Click += new System.EventHandler(this.Zmiana_CiemnyButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(19, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 13);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Styl Graficzny";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CzasTrwaniaTextBox3
            // 
            this.CzasTrwaniaTextBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CzasTrwaniaTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CzasTrwaniaTextBox3.Location = new System.Drawing.Point(328, 312);
            this.CzasTrwaniaTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.CzasTrwaniaTextBox3.Name = "CzasTrwaniaTextBox3";
            this.CzasTrwaniaTextBox3.Size = new System.Drawing.Size(70, 13);
            this.CzasTrwaniaTextBox3.TabIndex = 22;
            this.CzasTrwaniaTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(734, 421);
            this.Controls.Add(this.CzasTrwaniaTextBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Zmiana_CiemnyButton1);
            this.Controls.Add(this.Zmiana_StandardButton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DodajButton1);
            this.Controls.Add(this.MuteButton1);
            this.Controls.Add(this.GlosnoscTextBox2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.FFButton1);
            this.Controls.Add(this.FBButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GlosnoscTrackBar1);
            this.Controls.Add(this.PrevButton2);
            this.Controls.Add(this.NextButton1);
            this.Controls.Add(this.PauseButton1);
            this.Controls.Add(this.StopButton1);
            this.Controls.Add(this.ListaUtworowListView1);
            this.Controls.Add(this.TerazOdtwarzaneListBox1);
            this.Controls.Add(this.CzasPiosenkiLrogressBar1);
            this.Controls.Add(this.PlayButton1);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Odtwarzacz Muzyki";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlosnoscTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton1;
        private System.Windows.Forms.ProgressBar CzasPiosenkiLrogressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox TerazOdtwarzaneListBox1;
        private System.Windows.Forms.ListView ListaUtworowListView1;
        private System.Windows.Forms.Button StopButton1;
        private System.Windows.Forms.Button PauseButton1;
        private System.Windows.Forms.Button NextButton1;
        private System.Windows.Forms.Button PrevButton2;
        private System.Windows.Forms.TrackBar GlosnoscTrackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FBButton1;
        private System.Windows.Forms.Button FFButton1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TextBox GlosnoscTextBox2;
        private System.Windows.Forms.Button MuteButton1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button DodajButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Zmiana_StandardButton2;
        private System.Windows.Forms.Button Zmiana_CiemnyButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox CzasTrwaniaTextBox3;
    }
}

