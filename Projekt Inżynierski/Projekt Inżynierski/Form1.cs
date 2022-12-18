using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekt_Inżynierski
{
    public partial class Form1 : Form
    {
        Histogram histogram = new Histogram();
        private bool filter1 = false;
        private int zmianaX = 0;
        private int zmianaY = 0;
        private int poprzedniX = 0;
        private int poprzedniY = 0;
        private int tryb = 0;
        private bool usunwybrane = false;
        Bitmap btmpakcja;
        //wpisz tu domyslna sciezke!
        Bitmap Akcja;
        Bitmap mapa = (Bitmap)Image.FromFile($@"{AppDomain.CurrentDomain.BaseDirectory}\squares.jpg");
        Bitmap mapa2 = (Bitmap)Image.FromFile($@"{AppDomain.CurrentDomain.BaseDirectory}\serce.png");
        //funkcje   
        public int ZmianaTrybu(int i)
        {
            if (i == 0)
                i = 1;
            else i = 0;
            return i;
        }
        public void PrzypisanieWartosci(int i)
        {
            if (i == 0)
            {
                zmianaX = Form1.MousePosition.X;
                zmianaY = Form1.MousePosition.Y;
            }
            else
            {
                poprzedniX = Form1.MousePosition.X;
                poprzedniY = Form1.MousePosition.Y;
            }
        }
        public void metodaZaznaczenia(int x, int y)
        {
           // pictureBox2.Image = (Bitmap)(btmpakcja).Clone();
            ((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.Blue);
            ((Bitmap)pictureBox2.Image).SetPixel(x, y, Color.Blue);
        }
        public void wyznacz_przesuniecie(int x, int y)
        {
            Color binaryCheckpicbox1;
            Color binaryCheckpicbox2;
            int MinOdlegloscpicbox1 = 999;
            int MinOdlegloscpicbox2 = 999;
            int dlugosc = 50;
            bool Binary255picbox1 = false;
            bool Binary255picbox2 = false;
            pictureBox2.Image = (Bitmap)(btmpakcja).Clone();
            for (int i = 0; i < dlugosc; i++)
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x, y + i, Color.Blue);
                ((Bitmap)pictureBox2.Image).SetPixel(x, y + i, Color.Blue);
            }
                for(int yy = y; yy < dlugosc+y; yy++)
                {
                    int sprawdzanaOdlegloscpicbox11 = 0;
                    int sprawdzanaOdlegloscpicbox22 = 0;
                     Binary255picbox1 = false;
                     Binary255picbox2 = false;
                    for (int xx = x; xx < 60+x; xx++){

                    if (Binary255picbox1 == false)
                    {
                        binaryCheckpicbox1 = ((Bitmap)pictureBox1.Image).GetPixel(xx, yy);
                        if (binaryCheckpicbox1.R != 255)
                        {
                            sprawdzanaOdlegloscpicbox11++;
                        }

                        else
                        {
                            Binary255picbox1 = true;
                        }
                    }
                    if (Binary255picbox2 == false)
                    {
                        binaryCheckpicbox2 = ((Bitmap)pictureBox2.Image).GetPixel(xx, yy);
                        if (binaryCheckpicbox2.R != 255)
                        {
                            sprawdzanaOdlegloscpicbox22++;
                        }
                        else
                        {
                            Binary255picbox2 = true;
                        }
                    } 
                    }
                    if (sprawdzanaOdlegloscpicbox11 < MinOdlegloscpicbox1)
                    {
                    MinOdlegloscpicbox1 = sprawdzanaOdlegloscpicbox11;
                    }
                    if(sprawdzanaOdlegloscpicbox22 < MinOdlegloscpicbox2)
                    {
                    MinOdlegloscpicbox2 = sprawdzanaOdlegloscpicbox22;
                    }
                }
            MessageBox.Show("" + MinOdlegloscpicbox1 + " " + MinOdlegloscpicbox2);

        }
        public void wyznacz_srednice(int x,int y)
        {
            Color binaryCheckpicbox1;
            Color binaryCheckpicbox2;
            int Odlegloscpicbox1;
            int Odlegloscpicbox2;
            int maxOdlegloscpicbox1 = 0;
            int maxOdlegloscpicbox2 = 0;
            int sprawdzanaOdlegloscpicbox1 = 0;
            int sprawdzanaOdlegloscpicbox2 = 0;
            bool Binary255picbox1 = false;
            bool Binary255picbox2 = false;
            int dlugosc= 15;
            pictureBox2.Image = (Bitmap)(btmpakcja).Clone();
            for(int dl = 0; dl < dlugosc; dl++)
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x+dl, y, Color.Blue);
                ((Bitmap)pictureBox2.Image).SetPixel(x+dl, y, Color.Blue);

            }
            for (int xx=x;xx<dlugosc+x;xx++)
            {
                Binary255picbox1 = false;
                Binary255picbox2 = false;
                Odlegloscpicbox1 = 0;
                Odlegloscpicbox2 = 0;
                sprawdzanaOdlegloscpicbox1 = 0;
                sprawdzanaOdlegloscpicbox2 = 0;

                for (int yy = y; yy < y + 25; yy++)
                {

                    if (Binary255picbox1 == false)
                    {
                        binaryCheckpicbox1 = ((Bitmap)pictureBox1.Image).GetPixel(xx, yy);
                        if (binaryCheckpicbox1.R < 255)
                        {
                            Odlegloscpicbox1++;
                        }
                        else
                        {
                            Binary255picbox1 = true;
                        }
                    }

                    if (Binary255picbox2 == false)
                    {
                        binaryCheckpicbox2 = ((Bitmap)pictureBox2.Image).GetPixel(xx, yy);
                        if (binaryCheckpicbox2.R < 255)
                        {
                            Odlegloscpicbox2++;
                        }
                        else
                        {
                            Binary255picbox2 = true;
                        }
                    }

                }

                Binary255picbox1 = false;
                Binary255picbox2 = false;

                if (Odlegloscpicbox1 > 20)
                {
                    Odlegloscpicbox1 = 0;
                }
                if (Odlegloscpicbox2 > 20)
                {
                    Odlegloscpicbox2 = 0;
                }
                sprawdzanaOdlegloscpicbox1 = 0;
                sprawdzanaOdlegloscpicbox2 = 0;

                for (int yyy = y; yyy > y-25 ; yyy--)
                {
                       

                    if (Binary255picbox1 == false)
                    {
                        binaryCheckpicbox1 = ((Bitmap)pictureBox1.Image).GetPixel(xx, yyy);
                        if (binaryCheckpicbox1.R != 255)
                        {
                            sprawdzanaOdlegloscpicbox1 ++;
                        }
                        else
                        {
                            Binary255picbox1 = true;
                        }
                    }

                    if (Binary255picbox2 == false)
                    {
                        binaryCheckpicbox2 = ((Bitmap)pictureBox2.Image).GetPixel(xx, yyy);
                        if (binaryCheckpicbox2.R != 255)
                        {
                            sprawdzanaOdlegloscpicbox2 ++;
                        }
                        else
                        {
                            Binary255picbox2 = true;
                        }
                    }
                }
                if (sprawdzanaOdlegloscpicbox1 > 20)
                {
                    sprawdzanaOdlegloscpicbox1 = 0;
                }
                if (sprawdzanaOdlegloscpicbox2 > 20)
                {
                    sprawdzanaOdlegloscpicbox2 = 0;
                }
                Odlegloscpicbox1 = Odlegloscpicbox1 + sprawdzanaOdlegloscpicbox1;
                Odlegloscpicbox2 = Odlegloscpicbox2 + sprawdzanaOdlegloscpicbox2;

                    if (Odlegloscpicbox1 > maxOdlegloscpicbox1)
                    {
                    maxOdlegloscpicbox1 = Odlegloscpicbox1;
                    }

                    if (Odlegloscpicbox2 > maxOdlegloscpicbox2)
                    {
                    maxOdlegloscpicbox2 = Odlegloscpicbox2;
                    }
            }
            MessageBox.Show("" + maxOdlegloscpicbox1 + " " + maxOdlegloscpicbox2);
        }
        //Klasy

        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            //tutaj tez wpisz domyslna sciezke obrazu ( PB1, PB2 );
            form2.chart1.ChartAreas[0].AxisY.Maximum = 1000;
            trackBar1.Maximum = 30;
            trackBar1.Minimum = 10;
            trackBar1.Value = 10;
            trackBar1.SmallChange = 10;
            trackBar1.LargeChange = 10;
            //i ponizej tez dodaj domyslna sciezke
        }
        private void Form1_Load(object sender, EventArgs e){
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            filterCombo.Items.Add("Szarosci");
            filterCombo.Items.Add("Krawedzi");
            filterCombo.Items.Add("Logarytmiczny");
            filterCombo.Items.Add("Laplasjan");
            filterCombo.Items.Add("RedukcjaSzumu");
            filterCombo.Items.Add("Potegowy");
            filterCombo.Items.Add("Medianowy");
            filterCombo.Items.Add("Binaryzacja");
            filterCombo.Items.Add("Usun odosobnione");
            filterCombo.Items.Add("Pierwiastkowy");
            filterCombo.Items.Add("Negacja");
            filterCombo.Items.Add("normalizacja");
            Form2 frm2 = new Form2();
            pictureBox1.Image = mapa;
            pictureBox2.Image = mapa;
            picWyb.Items.Add("Squares");
            picWyb.Items.Add("Heart");
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            pictureBox2.Left = pictureBox1.Right + 30;
            OryginalL.Top = pictureBox1.Bottom;
            FiltrowaneL.Left += pictureBox1.Width + 20;
            FiltrowaneL.Top += pictureBox1.Height - 50;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {

            PrzypisanieWartosci(tryb);
            if (poprzedniY == zmianaY && poprzedniX == zmianaX)
            {

            }
            else
            {
                textBox1.Text = Convert.ToString(Form1.MousePosition.X);
                textBox2.Text = Convert.ToString(Form1.MousePosition.Y);
                ZmianaTrybu(tryb);
            }
            double a = (double)(trackBar1.Value);
            a = a % 10;
            textBox3.Text = Convert.ToString(trackBar1.Value / 10) + "." + a;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int picxpos = Form1.MousePosition.X - pictureBox1.Location.X;
            int picypos = Form1.MousePosition.Y - pictureBox1.Location.Y;
            if (usunwybrane == true)
            {
                int rozstrzal = 10;
                Color colordousuniecia = ((Bitmap)pictureBox1.Image).GetPixel(picxpos, picypos);
                Color colorsprawdzajacy = new Color();
                Color nicosc = new Color();
                nicosc = Color.Black;
                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {

                        colorsprawdzajacy = ((Bitmap)pictureBox1.Image).GetPixel(i, j);
                        if (colordousuniecia.R + rozstrzal > colorsprawdzajacy.R && colordousuniecia.R - rozstrzal < colorsprawdzajacy.R)
                        {
                            ((Bitmap)pictureBox2.Image).SetPixel(i, j, nicosc);
                        }
                    }
                }

            }
            pictureBox2.Refresh();
            usunwybrane = false;

        }
        private void usun_Click(object sender, EventArgs e)
        {
            usunwybrane = true;
        }
        private void OtwPanHist_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.chart1.Series["Series1"].Points.Clear();
            form2.chart2.Series["Series1"].Points.Clear();
            form2.chart3.Series["Series1"].Points.Clear();
            histogram.zerowanieTablic();
            for (int i = 1; i < pictureBox1.Width; i++)
            {
                for (int j = 1; j < pictureBox1.Height; j++)
                {

                    Color colour = ((Bitmap)pictureBox1.Image).GetPixel(i, j);
                    histogram.tabR[colour.R] += 1;
                    histogram.tabG[colour.G] += 1;
                    histogram.tabB[colour.B] += 1;
                }
            }
            for (int k = 0; k < 255; k++)
            {

                form2.chart1.Series["Series1"].Points.AddXY(k, histogram.tabR[k]);
                form2.chart2.Series["Series1"].Points.AddXY(k, histogram.tabG[k]);
                form2.chart3.Series["Series1"].Points.AddXY(k, histogram.tabB[k]);
            }
            form2.Show();
        }
        private void picWyb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox sen = (ComboBox)sender;
            switch (sen.SelectedIndex)
            {
                case 0:
                    {
                        pictureBox1.Image = mapa;
                        pictureBox2.Image = mapa;
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = mapa2;
                        pictureBox2.Image = mapa2;
                        break;
                    }
            }
            
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Bitmap)pictureBox2.Image.Clone();
            FiltrowaneL.Text = "Oryginalne zdjęcie";
            Akcja = (Bitmap)(pictureBox1.Image).Clone();
        }
        private void WyswietlPanel_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }
        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterCombo.SelectedIndex == 5)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }
        private void Wyznacz_dlugosc_Click(object sender, EventArgs e)
        {
            Color color;
            bool wykrytokrawedz = false;
            int wysokosc = 0;
            for (int i = 10; i < pictureBox1.Width - 10; i++){
                for (int j = 10; j < pictureBox1.Height - 10; j++){

                    color = ((Bitmap)pictureBox2.Image).GetPixel(i, j);
                    if (color.R == 255){
                        if (wykrytokrawedz == false){
                            wykrytokrawedz = true;
                            ++wysokosc;

                        }
                        else{
                            wysokosc++;
                            ((Bitmap)pictureBox2.Image).SetPixel(i, j, Color.Black);
                            pictureBox2.Refresh();
                        }

                    }
                    else{
                        if (wykrytokrawedz == true){
                            Wysokosc.Text = Convert.ToString(wysokosc);
                            break;
                        }
                    }
                }
            }
        }
        private void Wyznacz_szerokosc_Click(object sender, EventArgs e)
        {
            Color color;
            Color color2;
            bool wykrytokrawedz = false;
            bool znalezionokoniec = false;
            int szerokosc = 0;
            for (int j = pictureBox1.Height - 10; j > 20; j--)
            {
                for (int i = 10; i < pictureBox1.Width - 10; i++)
                {

                    color = ((Bitmap)pictureBox2.Image).GetPixel(i, j);
                    color2 = ((Bitmap)pictureBox2.Image).GetPixel(i, j - 1);
                    if (color.R == 255 || color2.R == 255)
                    {
                        if (wykrytokrawedz == false)
                        {
                            wykrytokrawedz = true;
                            ++szerokosc;
                        }
                        else
                        {
                            szerokosc++;
                            ((Bitmap)pictureBox2.Image).SetPixel(i, j, Color.Black);
                            pictureBox2.Refresh();
                        }
                    }
                    else
                    {
                        if (wykrytokrawedz == true)
                        {
                            znalezionokoniec = true;
                            if (szerokosc < 50)
                            {
                                wykrytokrawedz = false;
                                j--;
                                szerokosc = 0;
                                i = 10;
                            }
                            else
                            {
                                Szerokosc.Text = Convert.ToString(szerokosc);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void Dodatkowa_Analiza_Click(object sender, EventArgs e)
        {
            if(picWyb.SelectedIndex == 1)
            {
            }
            else if(picWyb.SelectedIndex == 2)
            {
            }
            int xwsp = 0;
            int ywsp = 0;
            Xwsp.Text = "0";
            Ywsp.Text = "0";
            metodaZaznaczenia(xwsp, ywsp);
            panel3.Visible = !panel3.Visible;

        }
        private void Zakoncz_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pictureBox1.Image = (Bitmap)pictureBox2.Image.Clone();
        }
        private void Xwsp_TextChanged(object sender, EventArgs e)
        {
            int i, y;
            string g, h;
            g = Xwsp.Text;
            h = Ywsp.Text;
            bool success = Int32.TryParse(g, out i);
            if (success)
            {
                i = Convert.ToInt32(g);
                bool succes = Int32.TryParse(h, out y);
                if (success)
                {
                    metodaZaznaczenia(i, y);
                }
                else
                {

                }

            }
        }
        private void Ywsp_TextChanged(object sender, EventArgs e)
        {
            int i, y;
            string g, h;
            g = Ywsp.Text;
            h = Xwsp.Text;
            bool success = Int32.TryParse(g, out i);
            if (success)
            {
                i = Convert.ToInt32(g);
                bool succes = Int32.TryParse(h, out y);
                if (success)
                {
                    metodaZaznaczenia(y, i);
                }
                else
                {

                }
            }
        }
        private void Zmierz_Odleglosc_Click(object sender, EventArgs e)
        {
            int i, y;
            i = Convert.ToInt32(Xwsp.Text);
            y = Convert.ToInt32(Ywsp.Text);

            wyznacz_przesuniecie(i, y);
        }
        private void Zmierz_Srednice_Click(object sender, EventArgs e)
        {
            int i, y;
            i = Convert.ToInt32(Xwsp.Text);
            y = Convert.ToInt32(Ywsp.Text);

            wyznacz_srednice(i, y);
        }
        private void Zakoncz_Analize_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void Transformuj_Obraz_Click(object sender, EventArgs e)
        {
            filter1 = true;
            if (filter1 == true)
            {
                if (filterCombo.SelectedIndex == 0)
                {
                    Bitmap nowabitmapa;
                    normalizacja norm = new normalizacja(pictureBox1.Width, pictureBox1.Height);
                    nowabitmapa = norm.SprawdzenieOdcieni((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();

                }
                else if (filterCombo.SelectedIndex == 1)
                {
                    krawedziowy kr = new krawedziowy(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = kr.Fkrawedziowy((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();
                }
                else if (filterCombo.SelectedIndex == 2)
                {
                    logarytmiczny log = new logarytmiczny(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = log.Flogarytmiczny((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();

                }
                else if (filterCombo.SelectedIndex == 3)
                {
                    laplasjan lap = new laplasjan(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = lap.FLaplasjanowy((Bitmap)pictureBox1.Image);
                    Bitmap bt = (Bitmap)nowabitmapa.Clone();
                    pictureBox2.Image = (Bitmap)bt.Clone();
                }
                else if (filterCombo.SelectedIndex == 4)
                {
                    filtrRozmywajacy rozm = new filtrRozmywajacy(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = rozm.Metoda((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();
                }
                else if (filterCombo.SelectedIndex == 5)
                {
                    double d = trackBar1.Value;
                    potegowy pot = new potegowy(pictureBox1.Width, pictureBox1.Height, d);
                    Bitmap nowabitmapa = pot.Fpotegowy((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();
                }
                else if (filterCombo.SelectedIndex == 7)
                {

                    Binaryzacja bin = new Binaryzacja(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = bin.FBinaryzacja((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();
                }
                else if (filterCombo.SelectedIndex == 8)
                {

                    usunOdosobnione pot = new usunOdosobnione(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = pot.Metoda((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();
                }
                else if (filterCombo.SelectedIndex == 9)
                {

                    pierwiastkowy pier = new pierwiastkowy(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = pier.Fpierwiastkowy((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();
                }
                else if (filterCombo.SelectedIndex == 10)
                {

                    negacja neg = new negacja(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = neg.Fnegacja((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();
                }
                else if (filterCombo.SelectedIndex == 11)
                {

                    normalizacja norm = new normalizacja(pictureBox1.Width, pictureBox1.Height);
                    Bitmap nowabitmapa = norm.gsMetod((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = (Bitmap)nowabitmapa.Clone();
                }

                filter1 = false;
                pictureBox1.Refresh();
                pictureBox2.Refresh();
            }
            FiltrowaneL.Text = "zdjęcie po obróbce";
        }

        private void Zapisz_Obraz_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save($@"C:\zdj\{txName.Text}.jpeg", ImageFormat.Jpeg);
        }

        private void odejmij2_Click(object sender, EventArgs e)
        {
            Bitmap btmp = (Bitmap)pictureBox1.Image.Clone();
            Bitmap btp = (Bitmap)pictureBox2.Image.Clone();
            Color col,col2,col3;
            for(int i = 0; i < pictureBox1.Width; i++)
            {
                for(int j = 0; j < pictureBox1.Height; j++)
                {
                    col = btmp.GetPixel(i, j);
                    col2 = btp.GetPixel(i, j);
                    col3 = Color.FromArgb(Math.Abs(col.R - col2.R),Math.Abs(col.G - col2.G),Math.Abs(col.B - col2.B));
                    btp.SetPixel(i, j,col3);
                }
            }
            pictureBox2.Image = btp;
        }

        private void RozpocznijAnal_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }
    }
}

