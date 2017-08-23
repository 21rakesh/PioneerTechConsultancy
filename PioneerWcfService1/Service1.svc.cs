using PioneerDataAccess;
using PioneerTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PioneerWcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        
        public int insertemployee(EmployeeDetailsModel employee)
        {
            EmployeeDataAccess acces = new EmployeeDataAccess();
            int emp = acces.SaveEmployee(employee);
            return emp;
        }
        public int inserteducation(EducationDetailsModel education)
        {
            EducationDataAccess edacces = new EducationDataAccess();
            int edu = edacces.SaveEducation(education);
            return edu;
        }
    }
}
