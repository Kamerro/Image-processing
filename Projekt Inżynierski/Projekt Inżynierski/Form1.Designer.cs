
namespace Projekt_Inżynierski
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Transformuj_Obraz = new System.Windows.Forms.Button();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RozpocznijAnal = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.odejmij2 = new System.Windows.Forms.Button();
            this.OtwPanHist = new System.Windows.Forms.Button();
            this.picWyb = new System.Windows.Forms.ComboBox();
            this.Rtext = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Wyznacz_dlugosc = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.Dodatkowa_Analiza = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Szerokosc = new System.Windows.Forms.TextBox();
            this.Wysokosc = new System.Windows.Forms.TextBox();
            this.Zapisz_Obraz = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Zakoncz_Analize = new System.Windows.Forms.Button();
            this.Wyznacz_szerokosc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Zmierz_Srednice = new System.Windows.Forms.Button();
            this.Zmierz_Odleglosc = new System.Windows.Forms.Button();
            this.Zakoncz = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ywsp = new System.Windows.Forms.TextBox();
            this.Xwsp = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OryginalL = new System.Windows.Forms.Label();
            this.FiltrowaneL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(351, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Transformuj_Obraz
            // 
            this.Transformuj_Obraz.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Transformuj_Obraz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Transformuj_Obraz.Location = new System.Drawing.Point(130, 121);
            this.Transformuj_Obraz.Name = "Transformuj_Obraz";
            this.Transformuj_Obraz.Size = new System.Drawing.Size(97, 96);
            this.Transformuj_Obraz.TabIndex = 12;
            this.Transformuj_Obraz.Text = "Transformuj obraz";
            this.Transformuj_Obraz.UseVisualStyleBackColor = false;
            this.Transformuj_Obraz.Click += new System.EventHandler(this.Transformuj_Obraz_Click);
            // 
            // filterCombo
            // 
            this.filterCombo.BackColor = System.Drawing.Color.Black;
            this.filterCombo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Location = new System.Drawing.Point(168, 91);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(121, 24);
            this.filterCombo.TabIndex = 2;
            this.filterCombo.SelectedIndexChanged += new System.EventHandler(this.filterCombo_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(675, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // RozpocznijAnal
            // 
            this.RozpocznijAnal.BackColor = System.Drawing.Color.Black;
            this.RozpocznijAnal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RozpocznijAnal.Location = new System.Drawing.Point(12, 71);
            this.RozpocznijAnal.Name = "RozpocznijAnal";
            this.RozpocznijAnal.Size = new System.Drawing.Size(149, 125);
            this.RozpocznijAnal.TabIndex = 16;
            this.RozpocznijAnal.Text = "Rozpocznij Analize";
            this.RozpocznijAnal.UseVisualStyleBackColor = false;
            this.RozpocznijAnal.Click += new System.EventHandler(this.RozpocznijAnal_Click);
            // 
            // usun
            // 
            this.usun.BackColor = System.Drawing.Color.DarkSlateGray;
            this.usun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usun.Location = new System.Drawing.Point(105, 367);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(102, 91);
            this.usun.TabIndex = 21;
            this.usun.Text = "Usun kolor";
            this.usun.UseVisualStyleBackColor = false;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // odejmij2
            // 
            this.odejmij2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.odejmij2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.odejmij2.Location = new System.Drawing.Point(213, 367);
            this.odejmij2.Name = "odejmij2";
            this.odejmij2.Size = new System.Drawing.Size(117, 91);
            this.odejmij2.TabIndex = 22;
            this.odejmij2.Text = "odejmij obrazy";
            this.odejmij2.UseVisualStyleBackColor = false;
            this.odejmij2.Click += new System.EventHandler(this.odejmij2_Click);
            // 
            // OtwPanHist
            // 
            this.OtwPanHist.BackColor = System.Drawing.Color.Black;
            this.OtwPanHist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OtwPanHist.Location = new System.Drawing.Point(167, 71);
            this.OtwPanHist.Name = "OtwPanHist";
            this.OtwPanHist.Size = new System.Drawing.Size(160, 125);
            this.OtwPanHist.TabIndex = 23;
            this.OtwPanHist.Text = "Otwórz panel histogramu";
            this.OtwPanHist.UseVisualStyleBackColor = false;
            this.OtwPanHist.Click += new System.EventHandler(this.OtwPanHist_Click);
            // 
            // picWyb
            // 
            this.picWyb.BackColor = System.Drawing.Color.Black;
            this.picWyb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.picWyb.FormattingEnabled = true;
            this.picWyb.Location = new System.Drawing.Point(168, 33);
            this.picWyb.Name = "picWyb";
            this.picWyb.Size = new System.Drawing.Size(121, 24);
            this.picWyb.TabIndex = 25;
            this.picWyb.SelectedIndexChanged += new System.EventHandler(this.picWyb_SelectedIndexChanged_1);
            // 
            // Rtext
            // 
            this.Rtext.Location = new System.Drawing.Point(20, 603);
            this.Rtext.Name = "Rtext";
            this.Rtext.Size = new System.Drawing.Size(285, 22);
            this.Rtext.TabIndex = 17;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Ok.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ok.Location = new System.Drawing.Point(3, 179);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(121, 68);
            this.Ok.TabIndex = 26;
            this.Ok.Text = "Zatwierdz Obraz";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 39);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(315, 56);
            this.trackBar1.TabIndex = 27;
            // 
            // Wyznacz_dlugosc
            // 
            this.Wyznacz_dlugosc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Wyznacz_dlugosc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Wyznacz_dlugosc.Location = new System.Drawing.Point(3, 3);
            this.Wyznacz_dlugosc.Name = "Wyznacz_dlugosc";
            this.Wyznacz_dlugosc.Size = new System.Drawing.Size(121, 82);
            this.Wyznacz_dlugosc.TabIndex = 29;
            this.Wyznacz_dlugosc.Text = "Wyznacz wysokosc";
            this.Wyznacz_dlugosc.UseVisualStyleBackColor = false;
            this.Wyznacz_dlugosc.Click += new System.EventHandler(this.Wyznacz_dlugosc_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(241, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 22);
            this.textBox3.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txName);
            this.panel1.Controls.Add(this.Dodatkowa_Analiza);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Szerokosc);
            this.panel1.Controls.Add(this.Wysokosc);
            this.panel1.Controls.Add(this.Zapisz_Obraz);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Zakoncz_Analize);
            this.panel1.Controls.Add(this.Wyznacz_szerokosc);
            this.panel1.Controls.Add(this.Wyznacz_dlugosc);
            this.panel1.Controls.Add(this.filterCombo);
            this.panel1.Controls.Add(this.Ok);
            this.panel1.Controls.Add(this.picWyb);
            this.panel1.Controls.Add(this.Rtext);
            this.panel1.Controls.Add(this.odejmij2);
            this.panel1.Controls.Add(this.usun);
            this.panel1.Controls.Add(this.Transformuj_Obraz);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 637);
            this.panel1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(217, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nazwa pliku";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(215, 535);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 22);
            this.txName.TabIndex = 35;
            // 
            // Dodatkowa_Analiza
            // 
            this.Dodatkowa_Analiza.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Dodatkowa_Analiza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dodatkowa_Analiza.Location = new System.Drawing.Point(230, 121);
            this.Dodatkowa_Analiza.Name = "Dodatkowa_Analiza";
            this.Dodatkowa_Analiza.Size = new System.Drawing.Size(100, 96);
            this.Dodatkowa_Analiza.TabIndex = 34;
            this.Dodatkowa_Analiza.Text = "Dokładna analiza";
            this.Dodatkowa_Analiza.UseVisualStyleBackColor = false;
            this.Dodatkowa_Analiza.Click += new System.EventHandler(this.Dodatkowa_Analiza_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(130, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Szerokosc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(130, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Wysokosc";
            // 
            // Szerokosc
            // 
            this.Szerokosc.Location = new System.Drawing.Point(20, 505);
            this.Szerokosc.Name = "Szerokosc";
            this.Szerokosc.Size = new System.Drawing.Size(104, 22);
            this.Szerokosc.TabIndex = 36;
            // 
            // Wysokosc
            // 
            this.Wysokosc.AcceptsReturn = true;
            this.Wysokosc.Location = new System.Drawing.Point(20, 477);
            this.Wysokosc.Name = "Wysokosc";
            this.Wysokosc.Size = new System.Drawing.Size(104, 22);
            this.Wysokosc.TabIndex = 35;
            // 
            // Zapisz_Obraz
            // 
            this.Zapisz_Obraz.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Zapisz_Obraz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Zapisz_Obraz.Location = new System.Drawing.Point(6, 367);
            this.Zapisz_Obraz.Name = "Zapisz_Obraz";
            this.Zapisz_Obraz.Size = new System.Drawing.Size(99, 91);
            this.Zapisz_Obraz.TabIndex = 34;
            this.Zapisz_Obraz.Text = "Zapisz Obraz";
            this.Zapisz_Obraz.UseVisualStyleBackColor = false;
            this.Zapisz_Obraz.Click += new System.EventHandler(this.Zapisz_Obraz_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Location = new System.Drawing.Point(3, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 108);
            this.panel2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Wybierz współczynnik gamma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(182, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Wybierz filtr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(127, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Wybierz zdjęcie do porównania";
            // 
            // Zakoncz_Analize
            // 
            this.Zakoncz_Analize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Zakoncz_Analize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Zakoncz_Analize.Location = new System.Drawing.Point(20, 563);
            this.Zakoncz_Analize.Name = "Zakoncz_Analize";
            this.Zakoncz_Analize.Size = new System.Drawing.Size(285, 34);
            this.Zakoncz_Analize.TabIndex = 31;
            this.Zakoncz_Analize.Text = "Zakończ analizę";
            this.Zakoncz_Analize.UseVisualStyleBackColor = false;
            this.Zakoncz_Analize.Click += new System.EventHandler(this.Zakoncz_Analize_Click);
            // 
            // Wyznacz_szerokosc
            // 
            this.Wyznacz_szerokosc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Wyznacz_szerokosc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Wyznacz_szerokosc.Location = new System.Drawing.Point(3, 91);
            this.Wyznacz_szerokosc.Name = "Wyznacz_szerokosc";
            this.Wyznacz_szerokosc.Size = new System.Drawing.Size(121, 82);
            this.Wyznacz_szerokosc.TabIndex = 30;
            this.Wyznacz_szerokosc.Text = "Wyznacz szerokosc";
            this.Wyznacz_szerokosc.UseVisualStyleBackColor = false;
            this.Wyznacz_szerokosc.Click += new System.EventHandler(this.Wyznacz_szerokosc_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.Zmierz_Srednice);
            this.panel3.Controls.Add(this.Zmierz_Odleglosc);
            this.panel3.Controls.Add(this.Zakoncz);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Ywsp);
            this.panel3.Controls.Add(this.Xwsp);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(662, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 637);
            this.panel3.TabIndex = 34;
            // 
            // Zmierz_Srednice
            // 
            this.Zmierz_Srednice.Location = new System.Drawing.Point(6, 354);
            this.Zmierz_Srednice.Name = "Zmierz_Srednice";
            this.Zmierz_Srednice.Size = new System.Drawing.Size(309, 67);
            this.Zmierz_Srednice.TabIndex = 37;
            this.Zmierz_Srednice.Text = "Zmierz srednice";
            this.Zmierz_Srednice.UseVisualStyleBackColor = true;
            this.Zmierz_Srednice.Click += new System.EventHandler(this.Zmierz_Srednice_Click);
            // 
            // Zmierz_Odleglosc
            // 
            this.Zmierz_Odleglosc.Location = new System.Drawing.Point(6, 277);
            this.Zmierz_Odleglosc.Name = "Zmierz_Odleglosc";
            this.Zmierz_Odleglosc.Size = new System.Drawing.Size(309, 71);
            this.Zmierz_Odleglosc.TabIndex = 35;
            this.Zmierz_Odleglosc.Text = "Zmierz odleglosc";
            this.Zmierz_Odleglosc.UseVisualStyleBackColor = true;
            this.Zmierz_Odleglosc.Click += new System.EventHandler(this.Zmierz_Odleglosc_Click);
            // 
            // Zakoncz
            // 
            this.Zakoncz.Location = new System.Drawing.Point(34, 602);
            this.Zakoncz.Name = "Zakoncz";
            this.Zakoncz.Size = new System.Drawing.Size(255, 23);
            this.Zakoncz.TabIndex = 35;
            this.Zakoncz.Text = "Zakoncz analize";
            this.Zakoncz.UseVisualStyleBackColor = true;
            this.Zakoncz.Click += new System.EventHandler(this.Zakoncz_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(15, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Wskaż początkowego y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(15, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Wskaż początkowego x";
            // 
            // Ywsp
            // 
            this.Ywsp.Location = new System.Drawing.Point(20, 192);
            this.Ywsp.Name = "Ywsp";
            this.Ywsp.Size = new System.Drawing.Size(100, 22);
            this.Ywsp.TabIndex = 35;
            this.Ywsp.TextChanged += new System.EventHandler(this.Ywsp_TextChanged);
            // 
            // Xwsp
            // 
            this.Xwsp.Location = new System.Drawing.Point(20, 115);
            this.Xwsp.Name = "Xwsp";
            this.Xwsp.Size = new System.Drawing.Size(100, 22);
            this.Xwsp.TabIndex = 35;
            this.Xwsp.TextChanged += new System.EventHandler(this.Xwsp_TextChanged);
            // 
            // OryginalL
            // 
            this.OryginalL.AutoSize = true;
            this.OryginalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OryginalL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OryginalL.Location = new System.Drawing.Point(349, 74);
            this.OryginalL.Name = "OryginalL";
            this.OryginalL.Size = new System.Drawing.Size(235, 32);
            this.OryginalL.TabIndex = 32;
            this.OryginalL.Text = "Oryginale zdjęcie";
            // 
            // FiltrowaneL
            // 
            this.FiltrowaneL.AutoSize = true;
            this.FiltrowaneL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FiltrowaneL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FiltrowaneL.Location = new System.Drawing.Point(351, 74);
            this.FiltrowaneL.Name = "FiltrowaneL";
            this.FiltrowaneL.Size = new System.Drawing.Size(251, 32);
            this.FiltrowaneL.TabIndex = 33;
            this.FiltrowaneL.Text = "Oryginalne zdjęcie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1779, 772);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FiltrowaneL);
            this.Controls.Add(this.OryginalL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OtwPanHist);
            this.Controls.Add(this.RozpocznijAnal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Transformuj_Obraz;
        private System.Windows.Forms.ComboBox filterCombo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button RozpocznijAnal;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Button odejmij2;
        private System.Windows.Forms.Button OtwPanHist;
        private System.Windows.Forms.ComboBox picWyb;
        private System.Windows.Forms.TextBox Rtext;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Wyznacz_dlugosc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Wyznacz_szerokosc;
        private System.Windows.Forms.Button Zakoncz_Analize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OryginalL;
        private System.Windows.Forms.Label FiltrowaneL;
        private System.Windows.Forms.Button Zapisz_Obraz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Szerokosc;
        private System.Windows.Forms.TextBox Wysokosc;
        private System.Windows.Forms.Button Dodatkowa_Analiza;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Zakoncz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ywsp;
        private System.Windows.Forms.TextBox Xwsp;
        private System.Windows.Forms.Button Zmierz_Srednice;
        private System.Windows.Forms.Button Zmierz_Odleglosc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txName;
    }
}

