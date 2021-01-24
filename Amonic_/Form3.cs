using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amonic_
{
    public partial class Form3 : Form
    {
        string str = "Data Source=DESKTOP-PTPI5LJ\\DESKTOPEGOR;Initial Catalog=Session1_17;Integrated Security=True";
        private SqlCommand cmd;
        private SqlConnection connection;
        private DataSet ds, dsoffices;
        private SqlDataAdapter da;

        public Form3()
        {
            InitializeComponent();
            GetCB();
            connection = new SqlConnection(str);
            try
            {
                connection.Open();
                da = new SqlDataAdapter("SELECT * FROM Users", connection);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            try
            {
                connection.Open();
                da = new SqlDataAdapter("SELECT * FROM Users", connection);
                ds = new DataSet();
                da.Fill(dsoffices);
                comboBox1.DataSource = dsoffices.Tables[0];
                comboBox1.DisplayMember = "Title";
                comboBox1.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void GetCB()
        {
            connection = new SqlConnection(str);
            try
            {
                connection.Open();
                da = new SqlDataAdapter("SELECT * FROM Offices", connection);
                ds = new DataSet();
                da.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e) // EXIT BUTTON
        {
            StartPage frm = new StartPage();
            frm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e) // ENABLE/DISABLE
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            cmd = new SqlCommand($"SELECT ID as 'ID', OfficeID as 'OfficeID', Password as 'Password',  Email as 'Email', FirstName as 'FirstName', LastName as 'LastName', BirthDate as 'BirthDate', Active as 'Active' FROM Users Where OfficeID like '%" + comboBox1.Text + "' or Active like '%" + comboBox1.Text + "'", connection);
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dataTable.DefaultView;
            connection.Close();
        }

        private void changeRoleButton_Click(object sender, EventArgs e)
        {
            ChangeRoleForm changeRoleForm = new ChangeRoleForm();
            changeRoleForm.Show();
            Hide();
        }
        private void datagridview1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                decimal x1 = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["p107"].Value.ToString());
                decimal x2 = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["p108"].Value.ToString());
                decimal x3 = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["p109"].Value.ToString());
                decimal summ = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["p110"].Value.ToString());

                if ((x1 + x2 + x3) != summ)
                {
                    e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
                    e.Graphics.DrawRectangle(new Pen(Brushes.Black), e.CellBounds);
                    if (e.Value != null)
                        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Black, e.CellBounds);
                    e.Handled = true;
                }


            }
        }

        private void add_user_AdminPage_Click(object sender, EventArgs e)
        {
            AddUser frm = new AddUser();
            frm.Show();
            Hide();
        }
    }
}
