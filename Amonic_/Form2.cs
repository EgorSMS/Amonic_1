using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amonic_
{
    public partial class AddUser : Form
    {
        string str = "Data Source=DESKTOP-PTPI5LJ\\DESKTOPEGOR;Initial Catalog=Session1_17;Integrated Security=True";
        private SqlConnection connection;
        private DataSet ds;
        private SqlDataAdapter da;
        public AddUser()
        {
            InitializeComponent();
            GetCB();
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

        private void Save_add_user_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emailBox.Text) && !string.IsNullOrWhiteSpace(emailBox.Text) && !string.IsNullOrEmpty(firstNameBox.Text) && !string.IsNullOrWhiteSpace(firstNameBox.Text) && !string.IsNullOrEmpty(lastNameBox.Text) && !string.IsNullOrWhiteSpace(lastNameBox.Text) && !string.IsNullOrEmpty(birthdayPicker.Text) && !string.IsNullOrWhiteSpace(birthdayPicker.Text) && !string.IsNullOrEmpty(passwordBox.Text) && !string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                connection = new SqlConnection(str);
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Users] (ID, RoleID, Email, FirstName, LastName,OfficeID, BirthDate, Password, Active) VALUES(@ID, @RoleID, @Email, @FirstName, @LastName, @OfficeID, @BirthDate, @Password, @Active)", connection);
                cmd.Parameters.AddWithValue("RoleID", 2);
                cmd.Parameters.AddWithValue("Email", emailBox.Text);
                cmd.Parameters.AddWithValue("FirstName", firstNameBox.Text);
                cmd.Parameters.AddWithValue("LastName", lastNameBox.Text);
                cmd.Parameters.AddWithValue("OfficeID", officeCB.Text);
                cmd.Parameters.AddWithValue("BirthDate", birthdayPicker.Value.Date.ToString());
                cmd.Parameters.AddWithValue("Password", passwordBox.Text);
                cmd.Parameters.AddWithValue("Active", 1);
                cmd.Parameters.AddWithValue("ID", 10);
                cmd.ExecuteNonQuery();
                Form3 frm = new Form3();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Лох");
            }
        }

        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            string pass = Convert.ToBase64String(hash);

            return pass;
        }

        private void Exit_add_user_button_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Hide();
        }
    }
}
