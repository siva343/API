using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace simpleapi.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<user> usrlst = new List<user>()
        {
            new user(){name="user 1",email="email1@gmail.com"},
            new user(){name="user 2",email="email2@gmail.com"},
            new user(){name="user 3",email="email3@gmail.com"}
        };

        [HttpGet]
        public List<user> GetUserList()
        {
            return usrlst;
        }
    }

    public class user
    {
        public string name { get; set; }
        public string email { get; set; }
    }
}
