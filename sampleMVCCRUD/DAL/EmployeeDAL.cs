using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using sampleMVCCRUD.Models;
namespace sampleMVCCRUD.DAL
{
    public class EmployeeDAL
    {
        public string AddNewEmployee (Employee EmployeeDetails)
        {
            try
            {
                SqlConnection con ;
                string lsQuery = "insert into dbo.empdetails(serialno,empid,empname,empadd,desgn,salary) " +
                    "values (" + EmployeeDetails.serialNo + "," + EmployeeDetails.empid + ",'" + EmployeeDetails.empname + "','" 
                    + EmployeeDetails.empadd + "','" + EmployeeDetails.desgn + "'," + EmployeeDetails.salary + ")";
                using(con = new SqlConnection(ConfigurationManager.ConnectionStrings["MVCCRUD"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand(lsQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return "Saved Succesfully";

            } catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<Employee> EmployeeList()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con;
                string lsQuery ="select * from dbo.empdetails";
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["MVCCRUD"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand(lsQuery, con);
                    con.Open();
                    SqlDataAdapter getData = new SqlDataAdapter(cmd);
                    getData.Fill(ds);
                    con.Close();
                }

                 List<Employee> empList = new List<Employee>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    empList.Add(new Employee { serialNo = Convert.ToDecimal(dr["serialNo"]),
                        desgn = Convert.ToString(dr["desgn"]),
                        empadd = Convert.ToString(dr["empadd"]),
                        empname = Convert.ToString(dr["empname"]),
                        empid = Convert.ToString(dr["empid"]),
                        salary = Convert.ToInt32(dr["salary"])
                    });
                }


                return empList;
            }
            catch
            {
                return null;
            }
        }
 

        public Employee editEmployee(int id)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con;
                string lsQuery = "select * from dbo.empdetails where serialNo = "+ id;
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["MVCCRUD"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand(lsQuery, con);
                    con.Open();
                    SqlDataAdapter getData = new SqlDataAdapter(cmd);
                    getData.Fill(ds);
                    con.Close();
                }

                Employee objEmp = new Employee();
                 foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objEmp = new Employee
                    {
                        serialNo = Convert.ToDecimal(dr["serialNo"]),
                        desgn = Convert.ToString(dr["desgn"]),
                        empadd = Convert.ToString(dr["empadd"]),
                        empname = Convert.ToString(dr["empname"]),
                        empid = Convert.ToString(dr["empid"]),
                        salary = Convert.ToInt32(dr["salary"])
                    };
                }


                return objEmp;
            }
            catch
            {
                return null;
            }
        }
    }
}