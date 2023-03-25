using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WFCollabProject
{

    

    public partial class Form1 : Form
    {
        private static string mode = "";



        public SqlConnection SqlConnect()
        {
            //Put your Data info inside SqlConnection
            /*@"Data Source=MAT-MAT;Initial Catalog=DemoDB;User ID=sa;Password=rownie29"*/
            //return new SqlConnection(@"Data Source=MAT-MAT;Initial Catalog=DemoDb;User ID=sa;Password=rownie29");

            return new SqlConnection(@"Data Source=SWINDZ\SQLEXPRESS;Initial Catalog=DemoDb;User ID=sa;Password=john29");
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
            UNLabel.Visible= false;
            UNTBox.Visible= false;
            IDLabel.Visible= false;
            IDTBox.Visible= false;
            NameL.Visible= false;
            NameTBox.Visible= false;
            PasswordL.Visible= false;
            PasswordTBox.Visible= false;
            ContactL.Visible= false;
            ContactNTBox.Visible= false;
            DiverseB.Visible= false;
            dataGridView1.Visible= false;
            return;
        }
        void ShowSelect()
        {
            //if Select is selected
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
            DiverseB.Text = "Create User";
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
            DiverseB.Text = "Delete User";
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
            DiverseB.Text = "Modify User";
            return;
        }
        void CreateUser()
        {

            //usp_insertToUserInfo

            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_insertToUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username",SqlDbType.NVarChar).Value = UNTBox.Text.Trim().ToString();
                cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = PasswordTBox.Text.Trim().ToString();

                if (!String.IsNullOrEmpty(NameTBox.Text.Trim().ToString())) 
                {
                    cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value =NameTBox.Text.Trim().ToString();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                }
                if (!String.IsNullOrEmpty(ContactNTBox.Text.Trim().ToString()))
                {
                    cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = ContactNTBox.Text.Trim().ToString();
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
                MessageBox.Show("User has been created.");
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
                cmd.Parameters.AddWithValue("@ID",SqlDbType.BigInt).Value = Int32.Parse(UNTBox.Text.Trim().ToString());
                cmd.ExecuteNonQuery();

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
                    cmd.Parameters.AddWithValue("@Contact", SqlDbType.Int).Value = Int64.Parse(ContactNTBox.Text.Trim());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Contact", DBNull.Value);
                }
                cmd.ExecuteNonQuery();

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

        private void DiverseB_Click(object sender, EventArgs e)
        {
            switch (mode) {
                case "Insert":
                    CreateUser();
                    break;

                case "Update":
                    ModifyUser();
                    break;
            }
         
        }

        public void displayGridView(SqlCommand cmd)
        {
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

      


        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "Insert";
            Queries(mode);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "Update";
            Queries("Update");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "Delete";
            Queries(mode);
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "Select";
            Queries(mode);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "Exit";
            Queries(mode);
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
             
            }
            else if (e == "Delete")
            {
                MessageBox.Show("Delete");
                
            }
            else if (e == "Select")
            {
                MessageBox.Show("Select");
                
            }
            else if (e == "Exit")
            {
                MessageBox.Show("Exit");
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}