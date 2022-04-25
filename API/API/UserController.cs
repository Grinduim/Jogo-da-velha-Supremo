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
            Usuario logado = entities.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            if (logado == null)
            {
                return new  
                {
                    message = "email ou senha incorretos."
                };
            }
            return new
            {
                nick = logado.Nick,
                email = logado.Email,
                id = logado.Id
            };
        }

        public int Post(string email, string senha, string nick)
        {
            JogoDaVelhaEntities entities = new JogoDaVelhaEntities();
            Usuario valido = entities.Usuario.FirstOrDefault(u => u.Email == email);

            if(valido == null)
            {
                return 300;
                // terminar a parte de tratamento de erros no jogo
            }
            else
            {
                return 404;
            }
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