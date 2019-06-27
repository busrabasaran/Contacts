using Contacts.DAL;
using Contacts.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Contacts.WEBAPI.Controllers
{
    public class PhoneController : ApiController
    {
        RepositoryPattern<Phones> repo = new RepositoryPattern<Phones>();

        [HttpGet]
        public List<Phones> GetPhones(int id)
        {
            return repo.List(x => x.PersonID == id); 
        }

        [HttpPost]
        public void AddPhone(Phones phone)
        {
            repo.Add(phone);
        }
    }
}