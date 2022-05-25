using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string cs = "Data Source=SREE;Initial Catalog=ado_example;Integrated Security=true;";
            //conn = new SqlConnection(cs);
            string ConString = ConfigurationManager.ConnectionStrings["sconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConString);            
            conn.Open();


            try
            {
                Console.WriteLine("Connection Established");
                string ans;

                do
                {

                    Console.WriteLine("Select the options :\n1.Insert\n2.View\n3.Update\n4.Delete");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:

                            Console.WriteLine("Employee ID:");
                            int tID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Employee FirstName:");
                            string tFirstName = (Console.ReadLine());
                            Console.WriteLine("Employee LastName:");
                            string tLastName = (Console.ReadLine());
                            Console.WriteLine("Employee City:");
                            string tCity = (Console.ReadLine());
                            string InsertQuery = "INSERT INTO Employee_Details (ID,FirstName,LastName,City) VALUES(" + tID + ",'" + tFirstName + "','" + tLastName + "','" + tCity + "')";
                            SqlCommand Insertcmd = new SqlCommand(InsertQuery, conn);
                            Insertcmd.ExecuteNonQuery();
                            Console.WriteLine("Data inserted into Database successfully");
                            break;

                        case 2:

                            string ViewQuery = "select * from Employee_Details";
                            SqlCommand Viewcmd = new SqlCommand(ViewQuery, conn);
                            SqlDataReader reader = Viewcmd.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine("ID :" + reader.GetValue(0).ToString());
                                Console.WriteLine("FirstName :" + reader.GetValue(1).ToString());
                                Console.WriteLine("LastName :" + reader.GetValue(2).ToString());
                                Console.WriteLine("City :" + reader.GetValue(3).ToString());
                            }
                            reader.Close();
                            break;

                        case 3:

                            Console.WriteLine("Employee ID:");
                            int E_ID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Employee FirstName:");
                            string E_FirstName = (Console.ReadLine());
                            Console.WriteLine("Employee LastName:");
                            string E_LastName = (Console.ReadLine());
                            Console.WriteLine("Employee City:");
                            string E_City = (Console.ReadLine());
                            string UpdateQuery = "update Employee_Details set FirstName= '" + E_FirstName + "', LastName = '" + E_LastName + "', City = '" + E_City + "' where ID = '" + E_ID + "";
                            SqlCommand Updatecmd = new SqlCommand(UpdateQuery, conn);
                            Updatecmd.ExecuteNonQuery();
                            Console.WriteLine("Data Updated into Database Successfully");
                            break;

                        case 4:

                            Console.WriteLine("Enter the Employee ID that want to be deleted");
                            int D_ID = int.Parse(Console.ReadLine());
                            string DeleteQuery = "delete from Employee_Details where ID=  " + D_ID;
                            SqlCommand Deletecmd = new SqlCommand(DeleteQuery, conn);
                            Deletecmd.ExecuteNonQuery();
                            Console.WriteLine("Employee details deleted successfully");
                            break;

                        default:
                            Console.WriteLine("Wroung Input");
                            break;
                    }
                    Console.WriteLine("Do you want to continue (y/n)");
                    ans = Console.ReadLine();
                }
                while (ans != "n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                conn.Close();
            }
           
        }
    }
}   

