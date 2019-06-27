using Contacts.DAL;
using Contacts.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Contacts.WEBAPI.Controllers
{
    public class PersonController : ApiController
    {
        RepositoryPattern<Persons> repo = new RepositoryPattern<Persons>();

        [HttpGet]
        public List<Persons> GetPersons()
        {
            return repo.List();
        }

        [HttpPost]
        public void AddPerson(Persons person)
        {
            repo.Add(person);
        }

        [HttpGet]
        public void PersonDetail(int personid)
        {
            repo.Find(x => x.PersonID == personid);
        }



    }
}