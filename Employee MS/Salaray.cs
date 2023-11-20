using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_MS
{
    public partial class Salaray : Form
    {
        public Salaray()
        {
            InitializeComponent();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\so_no\Documents\EM.mdf;Integrated Security=True;Connect Timeout=30");

        private void Fetchemp()
        {
            try
            {
                if (Eid.Text == " ")
                {
                    MessageBox.Show("Enter Employee Id");

                }
                else
                {
                    Con.Open();
                    string query = "select * from ETBL WHERE EmpId= '" + Eid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        En.Text = dr["EmpName"].ToString();
                        Ep.Text = dr["EmpPos"].ToString();
                    }
                    Con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }


        }

            private void CrossBtn_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void HomeBtn_Click(object sender, EventArgs e)
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
        int Dailybase;
        int total;
        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (Ep.Text== "")
            {
                MessageBox.Show("Select An Employee");

            }
            else  if (Wd.Text==" " || Convert.ToInt32(Wd.Text) > 28     )
                {
                MessageBox.Show("Enter A Valid Number Of Days");
            }
            else if (Ep.Text == "Manager")
                {
                    Dailybase = 1200;
                }
                else if(Ep.Text== "Senior Developer")
                {
                    Dailybase = 1000;
                }
                else if (Ep.Text== "Junior Developer")
                {
                    Dailybase = 950;

                }
                else
                {
                    Dailybase = 850;
                }
                total = Dailybase * Convert.ToInt32(Wd.Text);
                SS.Text = "Employee Id:" + Eid.Text + "\n" + "Employee Name:" + En.Text + "\n" + "Employee Position:" + Ep.Text + "\n" + "Daily Salary:" + Dailybase + "\n" + "Total Amount:" + total;
            }
            

        private void FetchBtn_Click(object sender, EventArgs e)
        {
            Fetchemp();
        }

        private void HomeBtn_Click_1(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void CrossBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SS_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    