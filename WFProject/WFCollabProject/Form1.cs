using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;

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
            DiverseB.Text = "Create User";
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
                cmd.ExecuteNonQuery();
                


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
            //usp_insertToUserInfo
            SqlConnection con = SqlConnect();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("usp_insertToUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = Int32.Parse(UNTBox.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = UNTBox.Text.Trim().ToString();
                cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = PasswordTBox.Text.Trim().ToString();

                if (!String.IsNullOrEmpty(NameTBox.Text.Trim().ToString()))
                {
                    cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = NameTBox.Text.Trim().ToString();
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
                    cmd.ExecuteNonQuery();
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
    }
}