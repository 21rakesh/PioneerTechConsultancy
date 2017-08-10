using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using PioneerTest.Models;


namespace PioneerDataAccess
{
    public class EmployeeDataAccess
    {
        public int SaveEmployee(EmployeeDetailsModel employee)
        {
            int result = 0;
            try
            {
                
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlemployeedetails = @"INSERT INTO Employee_Details
                                            (First_Name,Last_Name,Email,Mobile_Number,AlternateMobileNumber,Address1,Adress2,Current_Country,Home_Country,ZipCode)VALUES('" + employee.First_Name + "'," + "" + "'" + employee.Last_Name + "'," + "" + "'" + employee.Email + "'," + "" + "" + employee.Mobile_Number + "," + "" + employee.AlternateMobileNumber + "," + "" + "'" + employee.Address1 + "'," + "'" + employee.Address2 + "'," + "" + "" + "'" + employee.Current_Country + "'," + "'" + employee.Home_Country + "'," + "" + employee.ZipCode + ")";
                SqlCommand command;
                command = new SqlCommand(sqlemployeedetails, mysqlconnection);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
       

        }
    }
    public class EducationDataAccess
    {
        public int SaveEducation(EducationDetailsModel education)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqleducationdetails = @"INSERT INTO Education_Details(CourseType,CourseSpecialisation,YearOfPass)VALUES('" + education.CourseType + "'," + "'" + education.CourseSpecialisation + "'," + "" + education.YearOfPass + ")";
                SqlCommand command;
                command = new SqlCommand(sqleducationdetails, mysqlconnection);
                result =command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
    }
    public class TechnicalDataAccess
    {
        public int SaveTechnical(TechnicalDetailsModels technical)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqltechnicaldetails = @"INSERT INTO Technical_Details(UI,Programming_Languages,ORM_Technologies,Databases)VALUES('" + technical.UI + "'," + "'" + technical.Programming_Languages + "'," + "'" + technical.ORM_Technologies + "'," + "'" + technical.Databases + "')";
                SqlCommand command;
                command = new SqlCommand(sqltechnicaldetails, mysqlconnection);
                result=command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
    }
    public class CompanyDataAccess
    {
        public int SaveCompany(CompanyDetailsModel company)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;"+"Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlcompanydetails = @"INSERT INTO Company_Details(Employer_Name,Contact_Number,Location,Website)VALUES('"+company.Employer_Name+"',"+""+company.Contact_Number+"," + "'" + company.Location + "'," + "'" + company.Website + "')";
                SqlCommand command;
                command = new SqlCommand(sqlcompanydetails, mysqlconnection);
                result=command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
    }
    public class ProjectDataAccess
    {
        public int SaveProject(ProjectDetailsModel project)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                   " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlprojectdetails = @"INSERT INTO Project_Details(EmployeeID,Project_Name,Client_Name,Location,Roles)VALUES(" + project.EmployeeID + "," + "'" + project.Project_Name + "'," + "'" + project.Client_Name + "'," + "'" + project.Location + "'," + "'" + project.Roles + "')";
                SqlCommand command;
                command = new SqlCommand(sqlprojectdetails, mysqlconnection);
                result=command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Details have been saved Successfully:");
                }
                mysqlconnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
            return result;
        }
    } 


}


