using Day14.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day14
{
    internal class Program
    {
        class Student
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }

            public string Gender { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public DateTime CreatedDate { get; set; }

            public DateTime UpdatedDate { get; set; }

            public bool IsActive { get; set; }
        }
        static void Main(string[] args)
        {
            // Linq to SQL (ORM)

            // Select(Retrive), Insert(Create), Update, Delete
            // CRUD

            // DDL,DML,DQL,TQL
            // Data Defination Language (Create,Drop) 
            // Data Manipulation Language (Insert,Update,Delete)
            // Data Query Language (Select)
            // Transact SQL (Commit,Rollback)

            // 4th gen (Data) - DBA
            // 3rd gen (C#,Java,C11)
            // 5th gen (AI)

            // Insert Process
            // Student Object(ID,Name,Age,Mobile,Email,Gender) -> Model
            // Data Type
            // Accept Data from User
            // Connect and Insert to DB with this Model

            // Select Process
            // Connect and Loop Datalist

            //Tbl_Student st = new Tbl_Student ();

            //Console.Write("Enter Name : ");
            //st.Name = Console.ReadLine();

            //Console.Write("Enter Age : ");
            //st.Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Gender : ");
            //st.Gender = Console.ReadLine();

            //Console.Write("Enter Email : ");
            //st.Email = Console.ReadLine();

            //Console.Write("Enter Phone : ");
            //st.Phone = Console.ReadLine();

            //st.CreatedDate = DateTime.UtcNow.AddMinutes(390);
            //st.UpdatedDate = DateTime.UtcNow.AddMinutes(390);

            //st.IsActive = true;

            //InsertStudent(st);

            // string (char(10),nchar,varchar,nvarchar) - a

            //ShowAllStudent();
            ShowStudentByID(2);
        }

        static void InsertStudent(Tbl_Student stu)
        {
            // db connection and insert
            try
            {
                using (NovDBDataContext db = new NovDBDataContext())
                {
                    db.Tbl_Students.InsertOnSubmit(stu);
                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                new Tbl_Student();
            }
            
        }

        static void ShowAllStudent()
        {
            try
            {
                using(NovDBDataContext db=new NovDBDataContext ())
                {
                    //var lst = db.Tbl_Students;
                    foreach (var st in db.Tbl_Students)
                    {
                        Console.WriteLine($"{st.ID} | {st.Name} | {st.Age} | {st.Gender} | {st.Email} | {st.Phone}");

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        static void ShowStudentByID(int id)
        {
            try
            {
                using(NovDBDataContext db= new NovDBDataContext ())
                {
                    var obj=db.Tbl_Students.FirstOrDefault(s=>s.ID==id);
                    if(obj==null)
                    {
                        Console.WriteLine("Student does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{obj.ID} | {obj.Name} | {obj.Age} | {obj.Gender} | {obj.Email} | {obj.Phone}");

                    }
                }
            }
            catch ( Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
