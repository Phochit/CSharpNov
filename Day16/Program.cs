using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ADO.NET

            // ADO.NET, Linq to SQL, Entity Framework(ORM)

            // DB
            // Query,SP

            // DDL, DML, DQL, TQL

            // select * from table
            // select name,email from table >> name | email
            // select name as UserName, email as UserEmail from table
            // select SUM(salary) as TotalSalary from table

            // insert into table(col1,col2,... col20) values(val1,val2,... val20)
            // insert into table(col1 to col20) values(@v1,@v2.. @v20)

            // update table set col3='val' where id='idvalue'

            // delete from table where id='idvalue'

            // inner join,left join,right join,full join

            // select * from table1 join table2 on table1.ID= table2.ID

            // order by colname asc/desc

            // group by colname

            // Connection ( server,initial catalog,user id,password,integrated security )

            // executenonquery (void)
            // executescalar (one value return)
            // executereader ( return all )

            //string constr = "Data Source=.;Initial Catalog=NovDB;Integrated Security=True;Encrypt=False";

            string constr = ConfigurationManager.ConnectionStrings["novdbConnection"].ConnectionString;
            string lastCusName = "";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = "select * from Tbl_Student where Email='"+em+" and Phone='"+ph+"'";
                cmd.CommandText = "select Top (1) Name from Tbl_Customer order by Name desc";
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lastCusName = reader["Name"].ToString();
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(constr))
            {
                int num = int.Parse( lastCusName[lastCusName.Length - 1].ToString())+1;
                string cname = "CUS00" + num;
                SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = "select * from Tbl_Student where Email='"+em+" and Phone='"+ph+"'";
                cmd.CommandText = "insert into Tbl_Customer(ID,Name) values(@id,@nm)";
                cmd.Parameters.AddWithValue("@id",Guid.NewGuid().ToString());
                cmd.Parameters.AddWithValue("@nm", cname);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }


            Console.Write("Email : ");
            string em=Console.ReadLine();
            Console.Write("Phone : ");
            string ph=Console.ReadLine();

            using(SqlConnection conn = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = "select * from Tbl_Student where Email='"+em+" and Phone='"+ph+"'";
                cmd.CommandText = "select * from Tbl_Student where Email=@em and Phone=@ph";
                cmd.Parameters.AddWithValue("@em", em);
                cmd.Parameters.AddWithValue("@ph",ph);
                cmd.Connection = conn;
                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["ID"]} | {reader["Name"]} | {reader["Age"]} | " +
                            $"{reader["Gender"]} | {reader["Email"]}");
                    }
                }
                conn.Close();
            }
            

        }
    }
}
