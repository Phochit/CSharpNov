using Day15.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15.Controller
{
    public class CustomerController
    {
        // 5 Functions
        // Insert,Update,Delete,SelectAll,SelectByID

        public async Task<Tbl_Customer> InsertCustomer(Tbl_Customer customer)
        {
            try
            {
                using(NovDBDataContext db=new NovDBDataContext ())
                {
                    db.Tbl_Customers.InsertOnSubmit (customer);
                    db.SubmitChanges ();
                    await Task.Delay(100);
                    return customer;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                customer=new Tbl_Customer ();
            }
        }

        public Tbl_Customer InsertCustomerByStoreProcedure(Tbl_Customer customer)
        {
            using(NovDBDataContext db=new NovDBDataContext ())
            {
                db.SP_InsertCustomer(customer.ID,customer.Name);
                db.SubmitChanges();
                return customer;
            }

        }

        public void InsertProduct(tbl_product pro)
        {
            using(SaleDBDataContext db=new SaleDBDataContext ())
            {
                db.tbl_products.InsertOnSubmit (pro);
                db.SubmitChanges ();
            }
        }

        public void UpdateCustomerByID(string id,string nm)
        {
            try
            {
                using(NovDBDataContext db=new NovDBDataContext ())
                {
                    var obj=db.Tbl_Customers.FirstOrDefault(c=>c.ID==id);
                    if(obj!=null)
                    {
                        obj.Name= nm;
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception)
            {
                // Log
            }
        }

        public void DeleteCustomerByID(string id)
        {
            try
            {
                using(NovDBDataContext db=new NovDBDataContext ())
                {
                    var obj = db.Tbl_Customers.FirstOrDefault(c => c.ID == id);
                    if (obj != null)
                    {
                        db.Tbl_Customers.DeleteOnSubmit (obj);
                        db.SubmitChanges ();
                    }
                }
            }
            catch (Exception)
            {

                //Log
            }
        }

        public IEnumerable<Tbl_Customer> SelectAllCustomer()
        {
            try
            {
                List<Tbl_Customer> ls= new List<Tbl_Customer>(); 
                using(NovDBDataContext db=new NovDBDataContext ())
                {
                    var res= db.Tbl_Customers;
                    foreach(var c in res)
                    {
                        ls.Add(c);
                    }
                }
                return ls;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Tbl_Customer SelectCustomerByID(string id)
        {
            try
            {
                using(NovDBDataContext db=new NovDBDataContext ())
                {
                    return db.Tbl_Customers.FirstOrDefault (c => c.ID == id);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
