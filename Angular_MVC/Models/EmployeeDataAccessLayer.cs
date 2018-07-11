using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Angular_MVC.Models
{
    public class EmployeeDataAccessLayer
    {
        string connestionString = ConfigurationManager.AppSettings["DefaultConnection"];

        //To view all EMP details
        public IEnumerable<Emaployee> GetAllEmployees()
        {
            try
            {
                IEnumerable<Emaployee> lslEmployee = new List<Emaployee>();
                using (SqlConnection con = new SqlConnection(connestionString))
                {
                    //Tee
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return null;
        }
    }
}