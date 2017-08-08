using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PioneerTestConsultancySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            
                string First_Name = FirstNametextbox.Text;
                string Last_Name = LastNametextbox.Text;
                string Email = Emailtextbox.Text;
                var Mobile_Number = Convert.ToInt64(MobileNumbertextbox.Text);
                long AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumbertextbox.Text);
                string Address1 = Address1textbox.Text;
                string Address2 = Address2textbox.Text;
                string Current_Country = CurrentCountrytextbox.Text;
                string Home_Country = HomeCountrytextbox.Text;
                int ZipCode = Convert.ToInt32(Zipcodetextbox.Text);
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                    " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = @"INSERT INTO Employee_Details
                                            (First_Name,
                                            Last_Name,
                                            Email,
                                            Mobile_Number,
                                            AlternateMobileNumber,
                                            Address1,
                                            Adress2,
                                            Current_Country,
                                            Home_Country,
                                            Zipcode
                                            )
                                            VALUES
                                            ('"+First_Name+"'," +
                                            ""+"'"+Last_Name+"'," +
                                            ""+"'"+Email+"'," +
                                            ""+Mobile_Number+"," +
                                            ""+AlternateMobileNumber+"," +
                                            ""+"'"+Address1+"'," +
                                            ""+"'"+Address2+"'," +
                                            ""+"'"+Current_Country+"'," +
                                            ""+"'"+Home_Country+"'," +
                                            ""+ZipCode+")";
                SqlCommand command;
                command = new SqlCommand(q, mysqlconnection);
                command.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
           
             
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstNametextbox.Text=String.Empty;
            LastNametextbox.Text=String.Empty;
            Emailtextbox.Text = String.Empty;
            MobileNumbertextbox.Text = String.Empty;
            AlternateMobileNumbertextbox.Text = String.Empty;
            Address1textbox.Text = String.Empty;
            Address2textbox.Text = String.Empty;
            CurrentCountrytextbox.Text = String.Empty;
            HomeCountrytextbox.Text = String.Empty;
            Zipcodetextbox.Text = String.Empty;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int EmployeeID = Convert.ToInt32(EmployeeIDtextbox.Text);
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                       " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string q = ("SELECT * FROM Employee_Details WHERE EmployeeID="+EmployeeID);
                string r = ("SELECT * FROM Education_Details WHERE EmployeeID="+EmployeeID);
                string w = ("SELECT * FROM Technical_Details WHERE EmployeeID="+EmployeeID);
                string p = ("SELECT * FROM Company_Details WHERE EmployeeID=" + EmployeeID);
                string c= ("SELECT * FROM Project_Details WHERE EmployeeID=" + EmployeeID);
                SqlCommand command;
                command = new SqlCommand(q,mysqlconnection);
                SqlDataReader Data = command.ExecuteReader();
                BindingSource s = new BindingSource();
                s.DataSource = Data;
                EmployeeDetails.DataSource = s;
                Data.Close();
               // string r = ("SELECT * FROM Education_Details WHERE EmployeeID=" + EmployeeID);
                
                command = new SqlCommand(r, mysqlconnection);
                SqlDataReader sd = command.ExecuteReader();
                BindingSource b = new BindingSource();
                b.DataSource = sd;
                EducationalDetails.DataSource = b;
                sd.Close();
                command = new SqlCommand(w, mysqlconnection);
                SqlDataReader dr= command.ExecuteReader();
                BindingSource a = new BindingSource();
                a.DataSource = dr;
                TechnicalDetails.DataSource = a;
                dr.Close();
                command = new SqlCommand(p, mysqlconnection);
                SqlDataReader rd = command.ExecuteReader();
                BindingSource i= new BindingSource();
                i.DataSource = rd;
                CompanyDetails.DataSource = i;
                rd.Close();
                command = new SqlCommand(c, mysqlconnection);
                SqlDataReader cd = command.ExecuteReader();
                BindingSource v = new BindingSource();
                v.DataSource = cd;
                ProjectDetails.DataSource = v;
                cd.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            string CourseType = CourseTypetextbox.Text;
            string CourseSpecialisation = CourseSpecialisationtextbox.Text;
            string YearOfPass = YearOfPasstextbox.Text;
            string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                   " Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
                string q = @"INSERT INTO Education_Details(CourseType,CourseSpecialisation,YearOfPass)VALUES('"+CourseType+"',"+"'"+CourseSpecialisation+"',"+"'"+YearOfPass+"')";
            SqlCommand command;
            command = new SqlCommand(q, mysqlconnection);
            command.ExecuteNonQuery();
            mysqlconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            string UI = UItextbox.Text;
            string Programming_Languages = Programmingtextbox.Text;
            string ORM_Technologies = ORMtextbox.Text;
            string Databases = Databasestextbox.Text;
            string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                   " Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string q = @"INSERT INTO Technical_Details(UI,Programming_Languages,ORM_Technologies,Databases)VALUES('"+UI+"',"+"'"+Programming_Languages+"',"+"'"+ORM_Technologies+"',"+"'"+Databases+"')";
            SqlCommand command;
            command = new SqlCommand(q, mysqlconnection);
            command.ExecuteNonQuery();
            mysqlconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
            string Employer_Name = Employertextbox.Text;
            long Contact_NUmber = Convert.ToInt64(ContactNumbertextbox.Text);
            string Location = Locationtextbox.Text;
            var Website = Websitetextbox.Text;
            string Databases = Databasestextbox.Text;
            string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                   " Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string q = @"INSERT INTO Company_Details(Employer_Name,Contact_Number,Location,Website)VALUES('"+Employer_Name+"',"+""+Contact_NUmber+"," + "'"+Location+"',"+"'"+Website+"')";
            SqlCommand command;
            command = new SqlCommand(q, mysqlconnection);
            command.ExecuteNonQuery();
            mysqlconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            int EmployeeID = Convert.ToInt32(EmployeeID1textbox.Text);
            string Project_Name = ProjectNametextbox.Text;
            string Client_Name = ClientNametextbox.Text;
            string Location = ProjectLocationtextbox.Text;
            string Roles = Roletextbox.Text;
            string Databases = Databasestextbox.Text;
            string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                   " Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string q = @"INSERT INTO Project_Details(EmployeeID,Project_Name,Client_Name,Location,Roles)VALUES("+EmployeeID+","+"'"+Project_Name+"',"+"'"+Client_Name+"',"+"'"+Location+"',"+"'"+Roles+"')";
            SqlCommand command;
            command = new SqlCommand(q, mysqlconnection);
            command.ExecuteNonQuery();
            mysqlconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CourseTypetextbox.Text = String.Empty;
            CourseSpecialisationtextbox.Text = String.Empty;
            YearOfPasstextbox.Text = String.Empty;
        }

        private void Clear2_Click(object sender, EventArgs e)
        {
            UItextbox.Text = String.Empty;
            Programmingtextbox.Text = String.Empty;
            ORMtextbox.Text = String.Empty;
            Databasestextbox.Text = String.Empty;
        }

        private void Clear3_Click(object sender, EventArgs e)
        {
            EmployeeID1textbox.Text = String.Empty;
            ProjectNametextbox.Text = String.Empty;
            ClientNametextbox.Text = String.Empty;
            ProjectLocationtextbox.Text = String.Empty;
            Roletextbox.Text = String.Empty;
        }

        private void Clear4_Click(object sender, EventArgs e)
        {

            Employertextbox.Text = String.Empty;
            ContactNumbertextbox.Text = String.Empty;
            Locationtextbox.Text = String.Empty;
            Websitetextbox.Text = String.Empty;
            MessageBox.Show("You have cleared:");
        }
    }
}
