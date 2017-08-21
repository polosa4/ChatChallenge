using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserDataAccess;

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
    }
}
