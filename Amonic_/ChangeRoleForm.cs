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
    public partial class ChangeRoleForm : Form
    {
        string str = "Data Source=DESKTOP-PTPI5LJ\\DESKTOPEGOR;Initial Catalog=Session1_17;Integrated Security=True";
        private SqlCommand cmd;
        private SqlConnection connection;
        private DataSet ds, dsoffices;
        private SqlDataAdapter da;
        public ChangeRoleForm(OfficeClas userForChange)
        {
            InitializeComponent();
            GetCB();
            SetBox();
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
                officeCB.DataSource = ds.Tables[0];
                officeCB.DisplayMember = "ID";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 admin = new Form3();
            admin.Show();
            Hide();
        }

        private void SetBox()
        {
            emailBox.Text = User
        }

        private void button1_Click(object sender, EventArgs e) // APPLY
        {

        }
    }
}
