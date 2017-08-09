using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PioneerDataAccess
{
    public class EmployeeDataAccess
    {
        public int SaveEmployee(string First_Name, string Last_Name, string Email, long Mobile_Number, long AlternateMobileNumber,
            string Address1, string Address2, string Current_Country, string Home_Country, int ZipCode)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlemployeedetails = @"INSERT INTO Employee_Details
                                            (First_Name,Last_Name,Email,Mobile_Number,AlternateMobileNumber,Address1,Adress2,Current_Country,Home_Country,ZipCode)VALUES('" + First_Name + "'," + "" + "'" + Last_Name + "'," + "" + "'" + Email + "'," + "" + "" + Mobile_Number + "," + "" + AlternateMobileNumber + "," + "" + "'" + Address1 + "'," + "'" + Address2 + "'," + "" + "" + "'" + Current_Country + "'," + "'" + Home_Country + "'," + "" + ZipCode + ")";
                SqlCommand command;
                command = new SqlCommand(sqlemployeedetails, mysqlconnection);
                result = command.ExecuteNonQuery();
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
        public int SaveEducation(string CourseType, string CourseSpecialisation, int YearOfPass)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqleducationdetails = @"INSERT INTO Education_Details(CourseType,CourseSpecialisation,YearOfPass)VALUES('" + CourseType + "'," + "'" + CourseSpecialisation + "'," + "" + YearOfPass + ")";
                SqlCommand command;
                command = new SqlCommand(sqleducationdetails, mysqlconnection);
                result=command.ExecuteNonQuery();
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
        public int SaveTechnical(string UI, string Programming_Languages, string ORM_Technologies, string Databases)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" + "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqltechnicaldetails = @"INSERT INTO Technical_Details(UI,Programming_Languages,ORM_Technologies,Databases)VALUES('" + UI + "'," + "'" + Programming_Languages + "'," + "'" + ORM_Technologies + "'," + "'" + Databases + "')";
                SqlCommand command;
                command = new SqlCommand(sqltechnicaldetails, mysqlconnection);
                result=command.ExecuteNonQuery();
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
        public int SaveCompany(string Employer_Name,long Contact_Number,string Location,string Website,string Databases)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;"+"Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlcompanydetails = @"INSERT INTO Company_Details(Employer_Name,Contact_Number,Location,Website)VALUES('"+Employer_Name+"',"+""+Contact_Number+"," + "'" + Location + "'," + "'" + Website + "')";
                SqlCommand command;
                command = new SqlCommand(sqlcompanydetails, mysqlconnection);
                result=command.ExecuteNonQuery();
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
        public int SaveProject(int EmployeeID,string Project_Name,string Client_Name,string Location,string Roles,string Databases)
        {
            int result = 0;
            try
            {
                string connectionstring = "Data Source=RAKI;Initial Catalog=PioneerEmployeeDB;" +
                   " Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string sqlprojectdetails = @"INSERT INTO Project_Details(EmployeeID,Project_Name,Client_Name,Location,Roles)VALUES(" + EmployeeID + "," + "'" + Project_Name + "'," + "'" + Client_Name + "'," + "'" + Location + "'," + "'" + Roles + "')";
                SqlCommand command;
                command = new SqlCommand(sqlprojectdetails, mysqlconnection);
                command.ExecuteNonQuery();
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


