using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserDataAccess;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ChatChallenge.Controllers
{
    
    public class UsersController : ApiController
    {
        public IEnumerable<User> Get()
        {
            using (UserDataEntities entities = new UserDataEntities())
            {
                return entities.Users.ToList();
            }
        }

        public void Post([FromBody] User user)
        {

            using (var entities = new UserDataEntities())
            {
                
                user.DateCreated = DateTime.Now;
                entities.Users.Add(user);
                entities.SaveChanges();
                
            }
        }
    }
}
