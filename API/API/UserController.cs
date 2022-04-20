using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API
{
    public class UserController : ApiController
    {
        // GET api/<controller>
        public object Get(string email, string senha)
        {
            JogoDaVelhaEntities entities = new JogoDaVelhaEntities();
            Usuario logado = entities.Usuario.FirstOrDefault(u => u.email == email && u.senha == senha);
            if (logado == null)
            {
                return new
                {
                    message = "email ou senha incorretos."
                };
            }
            return new
            {
                nick = logado.nick,
                email = logado.email,
                id = logado.Id
            };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post(string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}