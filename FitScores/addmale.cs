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
    public partial class addmale : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public addmale()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= scores.db");
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox7.Text = "0";
            textBox15.Text = "0"; 
            textBox9.Text = "0"; 
            textBox11.Text = "0"; 
            textBox13.Text = "0";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void addmale_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                qu = "INSERT INTO studtb (faculty,name,level,mael,mael2,gloss,gloss2,mrona,mrona2," +
                    "Wathb,Wathb2,Gary,Gary2,adw,adw2,mash,mash2,total) VALUES " +
                    "($faculty,$name,$level,$mael,$mael2,$gloss,$gloss2,$mrona,$mrona2,$Wathb,$Wathb2," +
                    "$Gary,$Gary2,$adw,$adw2,$mash,$mash2,$total)";
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
                cmd.Parameters.AddWithValue("$mash", textBox14.Text);
                cmd.Parameters.AddWithValue("$mash2", textBox13.Text);
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
            textBox13.Text = "0";

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
            textBox14.Clear();
            //textBox13.Clear();
            label5.Text = "0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try { textBox4.Text = mael(Convert.ToDouble(textBox3.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox3.Text = "0"; sumall(); }
            
        }

        private void sumall()
        {
           double sum= Convert.ToDouble(textBox4.Text)+ Convert.ToDouble(textBox5.Text)+ Convert.ToDouble(textBox7.Text)
                + Convert.ToDouble(textBox15.Text)+ Convert.ToDouble(textBox9.Text)+ Convert.ToDouble(textBox11.Text)+ Convert.ToDouble(textBox13.Text);
            label5.Text = sum.ToString();
        }

        private double mael(double v)
        {
            double deg=0;
            switch (v)
            {
                case 71: deg = 100; break;
                case 70: deg = 98.2; break;
                case 69: deg = 96.4; break;
                case 68: deg = 94.6; break;
                case 67: deg = 92.9; break;
                case 66: deg = 91.1; break;
                case 65: deg = 89.3; break;
                case 64: deg = 87.5; break;
                //jjjjjj
                case 63: deg = 85.7; break;
                case 62: deg = 83.9; break;
                case 61: deg = 82.1; break;
                case 60: deg = 80.4; break;
                case 59: deg = 78.6; break;
                case 58: deg = 76.8; break;
                case 57: deg = 75; break;
                case 56: deg = 73.2; break;
                case 55: deg = 71.4; break;
                case 54: deg = 69.6; break;
                case 53: deg = 67.9; break;
                case 52: deg = 66.1; break;
                case 51: deg = 64.3; break;
                case 50: deg = 62.5; break;
                case 49: deg = 60.7; break;
                //case 48: deg = 58.9; break;
                case 47: deg = 58.9; break;
                case 46: deg = 57.1; break;
                case 45: deg = 55.4; break;
                case 44: deg = 53.6; break;
                case 43: deg = 51.8; break;
                case 42: deg = 50; break;
                case 41: deg = 48.2; break;
                case 40: deg = 46.4; break;
                case 39: deg = 44.6; break;
                case 38: deg = 42.9; break;
                case 37: deg = 41.1; break;
                case 36: deg = 39.3; break;
                case 35: deg = 37.5; break;
                case 34: deg = 35.5; break;
                case 33: deg = 33.9; break;
                case 32: deg = 32.1; break;
                case 31: deg = 30.4; break;
                case 30: deg = 28.6; break;
                case 29: deg = 26.8; break;
                case 28: deg = 25; break;
                case 27: deg = 23.2; break;
                case 26: deg = 21.4; break;
                case 25: deg = 19.6; break;
                case 24: deg = 17.9; break;
                case 23: deg = 16.1; break;
                case 22: deg = 14.3; break;
                case 21: deg = 12.5; break;
                case 20: deg = 10.7; break;
                case 19: deg = 8.9; break;
                case 18: deg = 7.1; break;
                case 17: deg = 5.4; break;
                case 16: deg = 3.6; break;
                case 15: deg = 1.8; break;
                case 14: deg = 0; break;
                default: deg = 0; break;

            }
            return deg;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try { textBox5.Text = gloss(Convert.ToDouble(textBox6.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox6.Text = "0"; sumall(); }
            
        }

        private double gloss(double v)
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try { textBox7.Text = mrona(Convert.ToDouble(textBox8.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox8.Text = "0"; sumall(); }
            
        }

        private double mrona(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 30: deg = 100; break;
                case 29: deg = 97.6; break;
                case 28: deg = 95.3; break;
                case 27: deg = 92.9; break;
                case 26: deg = 90.5; break;
                case 25: deg = 88.1; break;
                case 24: deg = 85.7; break;
                case 23: deg = 83.3; break;
                case 22: deg = 81; break;
                case 21: deg = 78.6; break;
                case 20: deg = 76.2; break;
                case 19: deg = 73.8; break;
                case 18: deg = 71.4; break;
                case 17: deg = 69; break;
                case 16: deg = 66.7; break;
                case 15: deg = 64.3; break;
                case 14: deg = 61.9; break;
                case 13: deg = 59.5; break;
                case 12: deg = 57.1; break;
                case 11: deg = 54.8; break;
                case 10: deg = 52.4; break;
                case 9: deg = 50; break;
                case 8: deg = 47.6; break;
                case 7: deg = 45.2; break;
                case 6: deg = 42.9; break;
                case 5: deg = 40.5; break;
                case 4: deg = 38.1; break;
                case 3: deg = 35.7; break;
                case 2: deg = 33.3; break;
                case 1: deg = 31; break;
                case 0: deg = 28.6; break;
                case -1: deg = 26.2; break;
                case -2: deg = 23.8; break;
                case -3: deg = 21.4; break;
                case -4: deg = 19; break;
                case -5: deg = 16.7; break;
                case -6: deg = 14.3; break;
                case -7: deg = 11.9; break;
                case -8: deg = 9.5; break;
                case -9: deg = 7.1; break;
                case -10: deg = 4.8; break;
                case -11: deg = 2.4; break;
                case -12: deg = 0; break;
                default: deg = 0; break;
            }
            return deg;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try { textBox15.Text = Wathb(Convert.ToDouble(textBox16.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox16.Text = "0"; sumall(); }
        }

        private double Wathb(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 245: deg = 100; break;
                case 240: deg = 94.4; break;
                case 235: deg = 88.9; break;
                case 230: deg = 83.3; break;
                case 225: deg = 77.8; break;
                case 220: deg = 72.2; break;
                case 215: deg = 66.7; break;
                case 210: deg = 61.1; break;
                case 205: deg = 55.6; break;
                case 200: deg = 50; break;
                case 195: deg = 44.4; break;
                case 190: deg = 38.9; break;
                case 185: deg = 33.3; break;
                case 180: deg = 27.8; break;
                case 175: deg = 22.2; break;
                case 170: deg = 16.7; break;
                case 165: deg = 11.1; break;
                case 160: deg = 5.6; break;
                case 155: deg = 0; break;
                default: deg = 0; break;
            }
            return deg;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try { textBox9.Text = gary(Convert.ToDouble(textBox10.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox10.Text = "0"; sumall(); }
        }

        private double gary(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 7.5: deg = 100; break;
                case 8: deg = 92.9; break;
                case 8.5: deg = 85.6; break;
                case 9: deg = 78.6; break;
                case 9.5: deg = 71.4; break;
                case 10: deg = 64.3; break;
                case 10.5: deg = 57.1; break;
                case 11: deg = 50; break;
                case 11.5: deg = 42.9; break;
                case 12: deg = 35.7; break;
                case 12.5: deg = 28.6; break;
                case 13: deg = 21.4; break;
                case 13.5: deg = 14.3; break;
                case 14: deg = 7.1; break;
                case 14.5: deg = 0; break;
                default: deg = 0; break;
            }
            return deg;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try { textBox11.Text = adw(Convert.ToDouble(textBox12.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox12.Text = "0"; sumall(); }
        }

        private double adw(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 5.1: deg = 100; break;
                case 5.2: deg = 98.9; break;
                case 5.3: deg = 97.8; break;
                case 5.4: deg = 96.7; break;
                case 5.5: deg = 95.6; break;
                case 5.6: deg = 94.4; break;
                case 5.7: deg = 93.3; break;
                case 5.8: deg = 92.2; break;
                case 5.9: deg = 91.1; break;
                case 6: deg = 90; break;
                case 6.1: deg = 88.9; break;
                case 6.2: deg = 87.8; break;
                case 6.3: deg = 86.7; break;
                case 6.4: deg = 85.6; break;
                case 6.5: deg = 84.4; break;
                case 6.6: deg = 83.3; break;
                case 6.7: deg = 82.2; break;
                case 6.8: deg = 81.1; break;
                case 6.9: deg = 80; break;
                case 7: deg = 78.9; break;
                case 7.1: deg = 77.8; break;
                case 7.2: deg = 76.7; break;
                case 7.3: deg = 75.6; break;
                case 7.4: deg = 74.4; break;
                case 7.5: deg = 73.3; break;
                case 7.6: deg = 72.2; break;
                case 7.7: deg = 71.1; break;
                case 7.8: deg = 70; break;
                case 7.9: deg = 68.9; break;
                case 8: deg = 67.8; break;
                case 8.1: deg = 66.7; break;
                case 8.2: deg = 65.6; break;
                case 8.3: deg = 64.4; break;
                case 8.4: deg = 63.3; break;
                case 8.5: deg = 62.2; break;
                case 8.6: deg = 61.1; break;
                case 8.7: deg = 60; break;
                case 8.8: deg = 58.9; break;
                case 8.9: deg = 57.8; break;
                case 9: deg = 56.7; break;
                case 9.1: deg = 55.6; break;
                case 9.2: deg = 54.4; break;
                case 9.3: deg = 53.3; break;
                case 9.4: deg = 52.2; break;
                case 9.5: deg = 51.1; break;
                case 9.6: deg = 50; break;
                case 9.7: deg = 48.9; break;
                case 9.8: deg = 47.8; break;
                case 9.9: deg = 46.7; break;
                case 10: deg = 45.6; break;
                case 10.1: deg = 44.4; break;
                case 10.2: deg = 43.3; break;
                case 10.3: deg = 42.2; break;
                case 10.4: deg = 41.1; break;
                case 10.5: deg = 40; break;
                case 10.6: deg = 37.9; break;
                case 10.7: deg = 37.8; break;
                case 10.8: deg = 36.7; break;
                case 10.9: deg = 35.6; break;
                case 11: deg = 34.4; break;
                case 11.1: deg = 33.3; break;
                case 11.2: deg = 32.2; break;
                case 11.3: deg = 31.3; break;
                case 11.4: deg = 30; break;
                case 11.5: deg = 28.9; break;
                case 11.6: deg = 27.8; break;
                case 11.7: deg = 26.7; break;
                case 11.8: deg = 25.6; break;
                case 11.9: deg = 24.4; break;
                case 12: deg = 23.3; break;
                case 12.1: deg = 22.2; break;
                case 12.2: deg = 21.1; break;
                case 12.3: deg = 20; break;
                case 12.4: deg = 18.9; break;
                case 12.5: deg = 17.8; break;
                case 12.6: deg = 16.7; break;
                case 12.7: deg = 15.6; break;
                case 12.8: deg = 14.4; break;
                case 12.9: deg = 13.3; break;
                case 13: deg = 12.2; break;
                case 13.1: deg = 11.1; break;
                case 13.2: deg = 10; break;
                case 13.3: deg = 8.9; break;
                case 13.4: deg = 7.8; break;
                case 13.5: deg = 6.7; break;
                case 13.6: deg = 5.6; break;
                case 13.7: deg = 4.4; break;
                case 13.8: deg = 3.3; break;
                case 13.9: deg = 2.2; break;
                case 14: deg = 1.1; break;
                case 14.1: deg = 0; break;
                default: deg = 0; break;
            }
            return deg;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try { textBox13.Text = mash(Convert.ToDouble(textBox14.Text)).ToString(); sumall(); }
            catch (Exception ex) { textBox14.Text = "0"; sumall(); }
        }

        private object mash(double v)
        {
            double deg = 0;
            switch (v)
            {
                case 85: deg = 100; break;
                case 90: deg = 95.9; break;
                case 95: deg = 91.8; break;
                case 100: deg = 87.7; break;
                case 105: deg = 83.6; break;
                case 110: deg = 79.5; break;
                case 115: deg = 75.4; break;
                case 120: deg = 71.3; break;
                case 125: deg = 67.2; break;
                case 130: deg = 63.1; break;
                case 135: deg = 59; break;
                case 140: deg = 54.9; break;
                case 145: deg = 50.8; break;
                case 150: deg = 46.7; break;
                case 155: deg = 42.6; break;
                case 160: deg = 38.5; break;
                case 165: deg = 34.4; break;
                case 170: deg = 30.3; break;
                case 175: deg = 26.2; break;
                case 180: deg = 22.1; break;
                case 185: deg = 18; break;
                case 190: deg = 13.9; break;
                case 195: deg = 9.8; break;
                case 200: deg = 5.7; break;
                case 205: deg = 1.6; break;
                case 210: deg = 0; break;
                default: deg = 0; break;

            }
            return deg;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
