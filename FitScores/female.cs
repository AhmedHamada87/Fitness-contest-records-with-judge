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
    public partial class female : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public female()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= scores.db");
            loaddata();
        }
        private void loaddata()
        {

            kryptonDataGridView1.Rows.Clear();

            con.Open();
            cmd = new SqliteCommand("Select * From studtbfemale", con);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    kryptonDataGridView1.Rows.Add(new object[] {
                    read.GetValue(0),
                    read.GetValue(1),
                    read.GetValue(2),
                    read.GetValue(3),
                    read.GetValue(4),
                    read.GetValue(5),
                    read.GetValue(6),
                    read.GetValue(7),
                    read.GetValue(8),
                    read.GetValue(9),
                    read.GetValue(10),
                    read.GetValue(11),
                    read.GetValue(12),
                    read.GetValue(13),
                    read.GetValue(14),
                    read.GetValue(15),
                    read.GetValue(16),
                    

                    });

                }

            }
            sumaman();
        }
        private void sumaman()
        {
            label4.Text = "0";
            double suma = 0;
            for (int i = 0; i < kryptonDataGridView1.Rows.Count; i++)
            {
                suma += Convert.ToDouble(kryptonDataGridView1.Rows[i].Cells[16].Value);
            }

            label4.Text = suma.ToString();
        }

        private void female_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "الكل")
            {
                loaddata();
            }
            else
            {
                kryptonDataGridView1.Rows.Clear();

                con.Open();
                cmd = new SqliteCommand("Select * From studtbfemale Where faculty=$fac", con);
                cmd.Parameters.AddWithValue("$fac", comboBox1.Text);
                using (SqliteDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        kryptonDataGridView1.Rows.Add(new object[] {
                    read.GetValue(0),
                    read.GetValue(1),
                    read.GetValue(2),
                    read.GetValue(3),
                    read.GetValue(4),
                    read.GetValue(5),
                    read.GetValue(6),
                    read.GetValue(7),
                    read.GetValue(8),
                    read.GetValue(9),
                    read.GetValue(10),
                    read.GetValue(11),
                    read.GetValue(12),
                    read.GetValue(13),
                    read.GetValue(14),
                    read.GetValue(15),
                    read.GetValue(16),
                    

                    });

                    }

                }
                sumaman();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addfemale adf = new addfemale();
            adf.ShowDialog();
        }
        int ida;
        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 17)
            {
                if (MessageBox.Show("هل أنت متأكد من حذف هذا الطالب؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ida = Convert.ToInt32(kryptonDataGridView1.CurrentRow.Cells[0].Value);
                    kryptonDataGridView1.Rows.Clear();
                    qu = "DELETE FROM studtbfemale WHERE id=$ida";
                    cmd = new SqliteCommand(qu, con);
                    cmd.Parameters.AddWithValue("$ida", ida);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loaddata();
                }




            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < kryptonDataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = kryptonDataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < kryptonDataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < kryptonDataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = kryptonDataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
