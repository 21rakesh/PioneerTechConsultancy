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
using PioneerDataAccess;
using PioneerTest.Models;

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
                EmployeeDetailsModel emp = new EmployeeDetailsModel()
                {
                    First_Name = FirstNametextbox.Text,
                    Last_Name = LastNametextbox.Text,
                    Email = Emailtextbox.Text,
                    Mobile_Number = Convert.ToInt64(MobileNumbertextbox.Text),
                    AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumbertextbox.Text),
                    Address1 = Address1textbox.Text,
                    Address2 = Address2textbox.Text,
                    Current_Country = CurrentCountrytextbox.Text,
                    Home_Country = HomeCountrytextbox.Text,
                    ZipCode = Convert.ToInt32(Zipcodetextbox.Text),

                };
                EmployeeDataAccess employee = new EmployeeDataAccess();
                employee.SaveEmployee(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the values:");
            }


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
                int EmployeeID = Convert.ToInt32(EmployeeComboBox.Text);
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                       " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlEmployeeDetails = ("SELECT * FROM Employee_Details WHERE EmployeeID="+EmployeeID);
                string sqlEducationDetails = ("SELECT * FROM Education_Details WHERE EmployeeID="+EmployeeID);
                string sqlTechnicalDetails = ("SELECT * FROM Technical_Details WHERE EmployeeID="+EmployeeID);
                string sqlCompanyDetails = ("SELECT * FROM Company_Details WHERE EmployeeID=" + EmployeeID);
                string sqlProjectDetails= ("SELECT * FROM Project_Details WHERE EmployeeID=" + EmployeeID);
                SqlCommand command;
                command = new SqlCommand(sqlEmployeeDetails,mysqlconnection);
                SqlDataReader employeeData = command.ExecuteReader();
                BindingSource gridview = new BindingSource();
                gridview.DataSource = employeeData;
                EmployeeDetails.DataSource = gridview;
                employeeData.Close();
                
                command = new SqlCommand(sqlEducationDetails, mysqlconnection);
                SqlDataReader eduacationaldata = command.ExecuteReader();
                BindingSource educationalgridview = new BindingSource();
                educationalgridview.DataSource = eduacationaldata;
                EducationalDetails.DataSource = educationalgridview;
                eduacationaldata.Close();

                command = new SqlCommand(sqlTechnicalDetails, mysqlconnection);
                SqlDataReader technicaldata= command.ExecuteReader();
                BindingSource technicalgridview = new BindingSource();
                technicalgridview.DataSource = technicaldata;
                TechnicalDetails.DataSource = technicalgridview;
                technicaldata.Close();

                command = new SqlCommand(sqlCompanyDetails, mysqlconnection);
                SqlDataReader companydata = command.ExecuteReader();
                BindingSource companygridview= new BindingSource();
                companygridview.DataSource = companydata;
                CompanyDetails.DataSource = companygridview;
                companydata.Close();

                command = new SqlCommand(sqlProjectDetails, mysqlconnection);
                SqlDataReader  projectdata= command.ExecuteReader();
                BindingSource projectgridview = new BindingSource();
                projectgridview.DataSource =projectdata;
                ProjectDetails.DataSource = projectgridview;
                projectdata.Close();

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
                EducationDetailsModel edu = new EducationDetailsModel()
                {
                    CourseType = CourseTypetextbox.Text,
                    CourseSpecialisation = CourseSpecialisationtextbox.Text,
                    YearOfPass = Convert.ToInt32(YearOfPasstextbox.Text),
                };
                EducationDataAccess education = new EducationDataAccess();
                education.SaveEducation(edu);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter the values:");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TechnicalDetailsModels TDModel = new TechnicalDetailsModels()
                {
                UI = UItextbox.Text,
                Programming_Languages = Programmingtextbox.Text,
                ORM_Technologies = ORMtextbox.Text,
                Databases = Databasestextbox.Text,
                };
                TechnicalDataAccess technical = new TechnicalDataAccess();
                technical.SaveTechnical(TDModel);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter the values:");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyDetailsModel com = new CompanyDetailsModel()
                {
                Employer_Name = Employertextbox.Text,
                Contact_Number = Convert.ToInt64(ContactNumbertextbox.Text),
                Location = Locationtextbox.Text,
                Website = Websitetextbox.Text,
                };
                CompanyDataAccess company = new CompanyDataAccess();
                company.SaveCompany(com);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter the values:");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectDetailsModel PDModel = new ProjectDetailsModel()
                {
                EmployeeID = Convert.ToInt32(EmployeeID1textbox.Text),
                Project_Name = ProjectNametextbox.Text,
                Client_Name = ClientNametextbox.Text,
                Location = ProjectLocationtextbox.Text,
                Roles = Roletextbox.Text,
                };
                ProjectDataAccess project = new ProjectDataAccess();
                project.SaveProject(PDModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the values:");
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
