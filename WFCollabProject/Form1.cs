using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace WFCollabProject
{
    public partial class Form1 : Form
    {
        public SqlConnection SqlConnect()
        {
            //Put your Data info inside SqlConnection
            /*@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29"*/
            return new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // John Code Here
            // Rownie Code Here
            // Kelsey Code Here
            //@Username nvarchar(50),
            //@Password nvarchar(50),
            //@Name nvarchar(50) null,
            //@Contact int null
            //usp_deleteUserInfo
            //usp_updateUserInfo
            //usp_insertToUserInfo
            //usp_selectAllFrmUserInfo
            HideInputs();


        }
        void HideInputs()
        {
            //Hides Inputs until a menu option is selected
            UNLabel.Visible = false;
            UNTBox.Visible = false;
            IDLabel.Visible = false;
            IDTBox.Visible = false;
            NameL.Visible = false;
            NameTBox.Visible = false;
            PasswordL.Visible = false;
            PasswordTBox.Visible = false;
            ContactL.Visible = false;
            ContactNTBox.Visible = false;
            DiverseB.Visible = false;
            dataGridView1.Visible = false;
            return;
        }
        void ShowSelect()
        {
            //if Select is selected
            HideInputs();
            dataGridView1.Visible = true;
            dataGridView1.Dock = DockStyle.Fill;
            SelectUser();

        }
        void InsertSelect()
        {
            //if Insert is selected
            UNLabel.Visible = true;
            UNTBox.Visible = true;
            NameL.Visible = true;
            NameTBox.Visible = true;
            PasswordL.Visible = true;
            PasswordTBox.Visible = true;
            ContactL.Visible = true;
            ContactNTBox.Visible = true;
            DiverseB.Visible = true;
            IDLabel.Visible = false;
            IDTBox.Visible = false;
            dataGridView1.Visible = true;
            DiverseB.Text = "Insert";
            dataGridView1.Dock = DockStyle.Bottom;
            SelectUser();
            return;
        }
        void DeleteSelect()
        {
            //if delete is selected
            UNLabel.Visible = false;
            UNTBox.Visible = false;
            IDLabel.Visible = true;
            IDTBox.Visible = true;
            NameL.Visible = false;
            NameTBox.Visible = false;
            PasswordL.Visible = false;
            PasswordTBox.Visible = false;
            ContactL.Visible = false;
            ContactNTBox.Visible = false;
            DiverseB.Visible = true;
            DiverseB.Text = "Delete";
            dataGridView1.Visible = true;
            dataGridView1.Dock = DockStyle.Bottom;
            SelectUser();
            return;
        }
        void ModifySelect()
        {
            //if modify or update is selected
            UNLabel.Visible = true;
            UNTBox.Visible = true;
            NameL.Visible = true;
            NameTBox.Visible = true;
            PasswordL.Visible = true;
            PasswordTBox.Visible = true;
            ContactL.Visible = true;
            ContactNTBox.Visible = true;
            DiverseB.Visible = true;
            IDLabel.Visible = true;
            IDTBox.Visible = true;
            DiverseB.Text = "Update";
            dataGridView1.Visible = true;
            dataGridView1.Dock = DockStyle.Bottom;
            SelectUser();
            return;
        }
        void SelectUser()
        {

            //usp_insertToUserInfo

            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_selectAllFrmUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                displayGridView(cmd);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        void CreateUser()
        {

            //usp_insertToUserInfo
            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" usp_insertToUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = UNTBox.Text.Trim();
                cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = PasswordTBox.Text.Trim();

                if (!String.IsNullOrEmpty(NameTBox.Text.Trim()))
                {
                    cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = NameTBox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }
                if (!String.IsNullOrEmpty(ContactNTBox.Text.Trim()))
                {
                    cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = ContactNTBox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Contact", DBNull.Value);
                }
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("usp_selectAllFrmUserInfo", con);
                displayGridView(cmd2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {

                con.Close();
            }

        }
        void DeleteUser()
        {
            //usp_deleteUserInfo
            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_deleteUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = Int64.Parse(IDTBox.Text.Trim());

                displayGridView(cmd);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                MessageBox.Show("User has been deleted.");
                con.Close();
            }
        }
        void ModifyUser()
        {
            //usp_updateToUserInfo
            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_updateUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = Int64.Parse(IDTBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = UNTBox.Text;
                cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = PasswordTBox.Text;
                if (!String.IsNullOrEmpty(NameTBox.Text.Trim()))
                {
                    cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = NameTBox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }
                if (!String.IsNullOrEmpty(ContactNTBox.Text.Trim()))
                {
                    cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Int32.Parse(ContactNTBox.Text.Trim());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Contact", DBNull.Value);
                }


                displayGridView(cmd);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queries("Insert");
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queries("Update");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queries("Delete");
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queries("Select");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queries("Exit");
        }
        public void displayGridView(SqlCommand cmd)
        {
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;


        }

        public void Queries(string e)
        {
            if (e == "Insert")
            {

                MessageBox.Show("Insert");
                InsertSelect();
            }
            else if (e == "Update")
            {

                MessageBox.Show("Update");
                ModifySelect();
            }
            else if (e == "Delete")
            {

                MessageBox.Show("Delete");
                DeleteSelect();
            }
            else if (e == "Select")
            {
                MessageBox.Show("Select");
                ShowSelect();
            }
            else if (e == "Exit")
            {
                MessageBox.Show("Exit");
                this.Close();
            }
        }

        private void DiverseB_Click(object sender, EventArgs e)
        {
            switch (DiverseB.Text)
            {
                case "Insert":
                    CreateUser();
                    break;

                case "Update":
                    ModifyUser();
                    break;
                case "Delete":
                    DeleteUser();
                    break;

            }
        }
        void SearchUser()
        {
            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_searchUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = Int32.Parse(IDTBox.Text.Trim());
                cmd.ExecuteNonQuery();
                displayGridView(cmd);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
                UNTBox.Text = dt.Rows[0][1].ToString();
                PasswordTBox.Text = dt.Rows[0][2].ToString();
                NameTBox.Text = dt.Rows[0][3].ToString();
                ContactNTBox.Text = dt.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        private void IDTBox_MouseLeave(object sender, EventArgs e)
        {
            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                if (!String.IsNullOrEmpty(IDTBox.Text))
                {
                    SqlCommand cmd = new SqlCommand("usp_checkIDfrmUserInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID",SqlDbType.BigInt).Value = Int32.Parse(IDTBox.Text.Trim());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string row = dt.Rows[0][0].ToString();
                    if (row != "0" )
                    {
                        SearchUser();
                        con.Close( );
                    }
                    else
                    {
                        MessageBox.Show("Account does not exist");
                        SqlCommand cmd2 = new SqlCommand("usp_selectAllFrmUserInfo", con);
                        displayGridView(cmd2);
                        UNTBox.Text = null;
                        NameTBox.Text = null;
                        ContactNTBox.Text = null;
                        PasswordTBox.Text = null;
                        con.Close();
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("usp_selectAllFrmUserInfo", con);
                    displayGridView(cmd);
                    UNTBox.Text = null;
                    NameTBox.Text = null;
                    ContactNTBox.Text = null;
                    PasswordTBox.Text = null;
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}