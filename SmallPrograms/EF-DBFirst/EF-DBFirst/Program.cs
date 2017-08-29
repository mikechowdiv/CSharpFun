using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new AdventureWorksLT2012Entities())
            {
                DoCustomerActions();             
            }
        }

        private static void DoCustomerActions()
        {
            using (var ctx = new AdventureWorksLT2012Entities())
            {
                Commit(ctx);
            }
        }

        private static void CreateCustomer(AdventureWorksLT2012Entities ctx)
        {
            var customer = new Customer()
            {
                FirstName = "John",
                LastName = "Smith",
                PasswordHash = "xyz",
                PasswordSalt = "abc",
                rowguid = Guid.NewGuid()
            };
            ctx.Customers.Add(customer);
        }

        private static void Commit(AdventureWorksLT2012Entities ctx)
        {
            try
            {
                ctx.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}
