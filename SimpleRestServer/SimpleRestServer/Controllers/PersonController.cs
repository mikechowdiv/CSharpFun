using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleRestServer.Models;

namespace SimpleRestServer.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "Person1", "Person2" };
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            Person person = new Person();
            person.ID = id;
            person.LastName = "Smith";
            person.FirstName = "Sam";
            person.PayRate = 45.45;
            person.StartDate = DateTime.Parse("5/5/1990");
            person.EndDate = DateTime.Parse("5/6/1990");
            return person;
        }

        // POST: api/Person
        public void Post([FromBody]Person value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
