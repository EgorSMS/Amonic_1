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
    // FORM 1 - НАЧАЛЬНАЯ
    // FORM2 - ДЛЯ ДОБАВЛЕНИЯ ПОЛЬЗОВАТЕЛЯ
    // FORM 3 - ADMIN PAGE
    public partial class StartPage : Form
    {
        string str = "Data Source=DESKTOP-PTPI5LJ\\DESKTOPEGOR;Initial Catalog=Session1_17;Integrated Security=True";
        private SqlCommand cmd;
        private SqlConnection connection;
        private DataSet ds;
        private SqlDataAdapter da;
        public StartPage()
        {
            InitializeComponent();
        }

        private int FindRole(string userEmail)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT RoleId FROM Users WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("Email", userEmail);
                int i = Convert.ToInt32(com.ExecuteScalar());
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }

        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            string pass = Convert.ToBase64String(hash);

            return pass;
        }
        int auto = 3;
        private void button1_Click(object sender, EventArgs e) //ЗАБЛОКАННЫЙ ПОЛЬЗОВАТЕЛЬ ДЛЯ НЕГО СВОЕ СООБЩЕНИЕ
        {
            connection = new SqlConnection(str);
       
            string query = "SELECT * FROM [Users] WHERE Email = '" + LoginBox.Text.Trim() + "' and Password = '" + PasswordBox.Text.Trim() + "'";
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(dataTable);
            ds = new DataSet();
            //string roleID = ds.Tables["Users"].Rows[0].ItemArray[1].ToString();
            //if (dataTable.Rows.Count == 1 && roleID == "1")
            //{
            //    Form3 admin = new Form3();
            //    admin.Show();
            //    Hide();
            //}
            //if (dataTable.Rows.Count == 2)
            //{
            //    UserForms userForms = new UserForms();
            //    userForms.Show();
            //    Hide();
            //}
            if(dataTable.Rows.Count == 1)  
            {
                int role = FindRole(LoginBox.Text);

                Form form = null;

                if (role == 1)
                {
                    form = new Form3();
                }
                if (role == 2)
                {
                    form = new UserForms();
                }

                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
                auto = 0;
                timer1.Start();
                login_button.Enabled = false;
            }
        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            timer_label.Text = i.ToString();
            if(i == 0)
            {
                login_button.Enabled = true;
                timer1.Enabled = false;
                timer_label.Visible = false;
            }
        }
    }
}
