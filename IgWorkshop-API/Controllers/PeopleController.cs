using System;
using System.Web.Http;
using System.Collections.Generic;

using IgWorkshop.Models;
using System.Web.Http.Cors;

namespace IgWorkshop.Controllers
{
  [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
  public class PeopleController : ApiController
  {
    public static List<Person> People = new List<Person>()
    {
      new Person()
      {
        Id = Guid.NewGuid(),
        FirstName = "Ivan",
        LastName = "Penchev",
        BirthDate = new DateTime(1982, 1, 1)
      }
    };

    public IHttpActionResult GetPeople()
    {
      //if (!this.User.Identity.IsAuthenticated)
      //{
      //  return this.Unauthorized();
      //}

      return this.Ok(People);
    }

    public IHttpActionResult Get(Guid id)
    {
      var person = People.Find(p => p.Id == id);
      if (person == null)
      {
        return this.BadRequest();
      }

      return this.Ok(person);
    }
  }
}
