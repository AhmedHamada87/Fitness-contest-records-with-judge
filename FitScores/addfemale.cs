using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;


namespace FitScores
{
    public partial class addfemale : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public addfemale()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= scores.db");
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox7.Text = "0";
            textBox15.Text = "0";
            textBox9.Text = "0";
            textBox11.Text = "0";
            

        }

        private void addfemale_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                qu = "INSERT INTO studtbfemale (faculty,name,level,mael,mael2,gloss,gloss2,mrona,mrona2," +
                    "Wathb,Wathb2,Gary,Gary2,adw,adw2,total) VALUES " +
                    "($faculty,$name,$level,$mael,$mael2,$gloss,$gloss2,$mrona,$mrona2,$Wathb,$Wathb2," +
                    "$Gary,$Gary2,$adw,$adw2,$total)";
                cmd = new SqliteCommand(qu, con);
                //enter cmd.
                cmd.Parameters.AddWithValue("$faculty", comboBox1.Text);
                cmd.Parameters.AddWithValue("$name", textBox2.Text);
                cmd.Parameters.AddWithValue("$level", numericUpDown1.Value.ToString());
                cmd.Parameters.AddWithValue("$mael", textBox3.Text);
                cmd.Parameters.AddWithValue("$mael2", textBox4.Text);
                cmd.Parameters.AddWithValue("$gloss", textBox6.Text);
                cmd.Parameters.AddWithValue("$gloss2", textBox5.Text);
                cmd.Parameters.AddWithValue("$mrona", textBox8.Text);
                cmd.Parameters.AddWithValue("$mrona2", textBox7.Text);
                cmd.Parameters.AddWithValue("$Wathb", textBox16.Text);
                cmd.Parameters.AddWithValue("$Wathb2", textBox15.Text);
                cmd.Parameters.AddWithValue("$Gary", textBox10.Text);
                cmd.Parameters.AddWithValue("$Gary2", textBox9.Text);
                cmd.Parameters.AddWithValue("$adw", textBox12.Text);
                cmd.Parameters.AddWithValue("$adw2", textBox11.Text);
                cmd.Parameters.AddWithValue("$total", label5.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                emptyfield();
                MessageBox.Show("تمت الاضافة بنجاح");


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void emptyfield()
        {
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox7.Text = "0";
            textBox15.Text = "0";
            textBox9.Text = "0";
            textBox11.Text = "0";
            

            textBox2.Clear();
            textBox3.Clear();
            //textBox4.Clear();
            textBox6.Clear();
            //textBox5.Clear();
            textBox8.Clear();
            //textBox7.Clear();
            textBox16.Clear();
            //textBox15.Clear();
            textBox10.Clear();
            //textBox9.Clear();
            textBox12.Clear();
            //textBox11.Clear();
            
            //textBox13.Clear();
            label5.Text = "0";
        }
        private void sumall()
        {
            double sum = Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) + Convert.ToDouble(textBox7.Text)
                 + Convert.ToDouble(textBox15.Text) + Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox11.Text) ;
            label5.Text = sum.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try { textBox4.Text = glose(Convert.ToDouble(textBox3.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox3.Text = "0"; sumall(); }
        }

        private double glose(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 34: deg = 100; break;
                case 33: deg = 96.2; break;
                case 32: deg = 92.3; break;
                case 31: deg = 88.5; break;
                case 30: deg = 84.6; break;
                case 29: deg = 80.8; break;
                case 28: deg = 76.9; break;
                case 27: deg = 73.1; break;
                case 26: deg = 69.2; break;
                case 25: deg = 65.4; break;
                case 24: deg = 61.5; break;
                case 23: deg = 57.7; break;
                case 22: deg = 53.8; break;
                case 21: deg = 50; break;
                case 20: deg = 46.2; break;
                case 19: deg = 42.3; break;
                case 18: deg = 38.5; break;
                case 17: deg = 34.6; break;
                case 16: deg = 30.8; break;
                case 15: deg = 26.9; break;
                case 14: deg = 23.1; break;
                case 13: deg = 19.2; break;
                case 12: deg = 15.4; break;
                case 11: deg = 11.5; break;
                case 10: deg = 7.7; break;
                case 9: deg = 3.8; break;
                case 8: deg = 0; break;
                default: deg = 0; break;



            }
            return deg;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try { textBox5.Text = mrona(Convert.ToDouble(textBox6.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox6.Text = "0"; sumall(); }
        }

        private double mrona(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 26: deg = 100; break;
                case 25: deg = 99.18; break;
                case 24: deg = 96.39; break;
                case 23: deg = 93.59; break;
                case 22: deg = 90.78; break;
                case 21: deg = 87.98; break;
                case 20: deg = 85.18; break;
                case 19: deg = 82.38; break;
                case 18: deg = 79.58; break;
                case 17: deg = 76.78; break;
                case 16: deg = 74.98; break;
                case 15: deg = 71.38; break;
                case 14: deg = 67.38; break;
                case 13: deg = 65.57; break;
                case 12: deg = 62.77; break;
                case 11: deg = 59.97; break;
                case 10: deg = 57.17; break;
                case 9: deg = 54.37; break;
                case 8: deg = 51.57; break;
                case 7: deg = 48.77; break;
                case 6: deg = 45.97; break;
                case 5: deg = 43.17; break;
                case 4: deg = 40.36; break;
                case 3: deg = 37.65; break;
                case 2: deg = 34.76; break;
                case 1: deg = 31.96; break;
                case 0: deg = 29.16; break;
                case -1: deg = 26.36; break;
                case -2: deg = 23.56; break;
                case -3: deg = 20.76; break;
                case -4: deg = 17.96; break;
                case -5: deg = 15.15; break;
                case -6: deg = 12.35; break;
                case -7: deg = 9.55; break;
                case -8: deg = 6.75; break;
                case -9: deg = 3.95; break;
                case -10: deg = 1.15; break;
                case -11: deg = 0; break;
                default: deg = 0; break;
            }
            return deg;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try { textBox7.Text = wathp(Convert.ToDouble(textBox8.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox8.Text = "0"; sumall(); }
        }

        private double wathp(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 210: deg = 100; break;
                case 205: deg = 98.7; break;
                case 200: deg = 94.2; break;
                case 195: deg = 89.8; break;
                case 190: deg = 85.4; break;
                case 185: deg = 81; break;
                case 180: deg = 76.5; break;
                case 175: deg = 72.1; break;
                case 170: deg = 67.7; break;
                case 165: deg = 63.3; break;
                case 160: deg = 58.8; break;
                case 155: deg = 54.4; break;
                case 150: deg = 50; break;
                case 145: deg = 45.6; break;
                case 140: deg = 41.2; break;
                case 135: deg = 36.7; break;
                case 130: deg = 32.3; break;
                case 125: deg = 27.9; break;
                case 120: deg = 23.5; break;
                case 115: deg = 19; break;
                case 110: deg = 14.6; break;
                case 105: deg = 10.2; break;
                case 100: deg = 5.65; break;
                case 95: deg = 1.3; break;
                case 90: deg = 0; break;
                default: deg = 0; break;

            }
            return deg;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try { textBox15.Text = garymac(Convert.ToDouble(textBox16.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox16.Text = "0"; sumall(); }
        }

        private double garymac(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 10.3: deg = 100; break;
                case 10.4: deg = 97.5; break;
                case 10.5: deg = 95; break;
                case 10.6: deg = 92.5; break;
                case 10.7: deg = 90; break;
                case 10.8: deg = 87.5; break;
                case 10.9: deg = 85; break;
                case 11: deg = 82.5; break;
                case 11.1: deg = 80; break;
                case 11.2: deg = 77.5; break;
                case 11.3: deg = 75; break;
                case 11.4: deg = 72.5; break;
                case 11.5: deg = 70; break;
                case 11.6: deg = 67.5; break;
                case 11.7: deg = 65; break;
                case 11.8: deg = 62.5; break;
                case 11.9: deg = 60; break;
                case 12: deg = 57.5; break;
                case 12.1: deg = 55; break;
                case 12.2: deg = 52.5; break;
                case 12.3: deg = 50; break;
                case 12.4: deg = 47.5; break;
                case 12.5: deg = 45; break;
                case 12.6: deg = 42.5; break;
                case 12.7: deg = 40; break;
                case 12.8: deg = 37.5; break;
                case 12.9: deg = 35; break;
                case 13: deg = 32.5; break;
                case 13.1: deg = 30; break;
                case 13.2: deg = 27.5; break;
                case 13.3: deg = 25; break;
                case 13.4: deg = 22.5; break;
                case 13.5: deg = 20; break;
                case 13.6: deg = 17.5; break;
                case 13.7: deg = 15; break;
                case 13.8: deg = 12.5; break;
                case 13.9: deg = 10; break;
                case 14: deg = 7.5; break;
                case 14.1: deg = 5; break;
                case 14.2: deg = 2.5; break;
                case 14.3: deg = 0; break;
                default: deg = 0; break;
            }
            return deg;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try { textBox9.Text = adw(Convert.ToDouble(textBox10.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox10.Text = "0"; sumall(); }
        }

        private double adw(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 3.4: deg = 100; break;
                case 3.5: deg = 97.5; break;
                case 3.6: deg = 95; break;
                case 3.7: deg = 92.5; break;
                case 3.8: deg = 90; break;
                case 3.9: deg = 87.5; break;
                case 4: deg = 85; break;
                case 4.1: deg = 82.5; break;
                case 4.2: deg = 80; break;
                case 4.3: deg = 77.5; break;
                case 4.4: deg = 75; break;
                case 4.5: deg = 72.5; break;
                case 4.6: deg = 70; break;
                case 4.7: deg = 67.5; break;
                case 4.8: deg = 65; break;
                case 4.9: deg = 62.5; break;
                case 5: deg = 60; break;
                case 5.1: deg = 57.5; break;
                case 5.2: deg = 55; break;
                case 5.3: deg = 52.5; break;
                case 5.4: deg = 50; break;
                case 5.5: deg = 47.5; break;
                case 5.6: deg = 45; break;
                case 5.7: deg = 42.5; break;
                case 5.8: deg = 40; break;
                case 5.9: deg = 37.5; break;
                case 6: deg = 35; break;
                case 6.1: deg = 32.5; break;
                case 6.2: deg = 30; break;
                case 6.3: deg = 27.5; break;
                case 6.4: deg = 25; break;
                case 6.5: deg = 22.5; break;
                case 6.6: deg = 20; break;
                case 6.7: deg = 17.5; break;
                case 6.8: deg = 15; break;
                case 6.9: deg = 12.5; break;
                case 7: deg = 10; break;
                case 7.1: deg = 7.5; break;
                case 7.2: deg = 5; break;
                case 7.3: deg = 2.5; break;
                case 7.4: deg = 0; break;
                default: deg = 0; break;
            }
            return deg;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try { textBox11.Text = garmasha(Convert.ToDouble(textBox12.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox12.Text = "0"; sumall(); }
        }

        private object garmasha(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 115: deg = 100; break;
                case 120: deg = 96.8; break;
                case 125: deg = 93.8; break;
                case 130: deg = 90.6; break;
                case 135: deg = 87.5; break;
                case 140: deg = 84.4; break;
                case 145: deg = 81.3; break;
                case 150: deg = 78.1; break;
                case 155: deg = 75; break;
                case 160: deg = 71.8; break;
                case 165: deg = 68.8; break;
                case 170: deg = 65.6; break;
                case 175: deg = 62.5; break;
                case 180: deg = 59.8; break;
                case 185: deg = 56.3; break;
                case 190: deg = 53.1; break;
                case 195: deg = 50; break;
                case 200: deg = 46.8; break;
                case 205: deg = 43.8; break;
                case 210: deg = 40.6; break;
                case 215: deg = 37.5; break;
                case 220: deg = 34.4; break;
                case 225: deg = 31.3; break;
                case 230: deg = 28.1; break;
                case 235: deg = 25; break;
                case 240: deg = 21.8; break;
                case 245: deg = 18.8; break;
                case 250: deg = 15.6; break;
                case 255: deg = 12.5; break;
                case 260: deg = 9.8; break;
                case 265: deg = 6.3; break;
                case 270: deg = 3.1; break;
                case 275: deg = 0; break;
                default: deg = 0; break;
            }
            return deg;
        }
    }
}
