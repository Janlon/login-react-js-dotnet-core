using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ApiLogin.Security;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace ApiLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : Controller
    {
       
         // POST api/logins
         [HttpPost]
          public object Post([FromBody]object ciphertext,[FromServices]AccessManager accessManager){

            dynamic json = JsonConvert.DeserializeObject(ciphertext.ToString());
            string msg  = json.ciphertext;

            byte[] crypt = Convert.FromBase64String(msg);
            byte[] keybytes = Encoding.UTF8.GetBytes("8080808080808080");
            byte[] iv = Encoding.UTF8.GetBytes("8080808080808080");

            // Decrypt
            var decripted = Crypto.Decrypt(crypt, keybytes, iv);
           
            //Enviar para o login
            User user = JsonConvert.DeserializeObject<User>(decripted);
            object obj = Login(user,accessManager);
            string output = JsonConvert.SerializeObject(obj);

            // Encrypt
            byte[] encrypted = Crypto.Encrypt(output, keybytes, iv);
        
            return new
            {
                Message = encrypted
            };
         }  

   
        public object Login([FromBody]User usuario,[FromServices]AccessManager accessManager)
        {
            if (accessManager.ValidateCredentials(usuario))
            {
                return accessManager.GenerateToken(usuario);
            }
            else
            {
                return new
                {
                    Authenticated = false,
                    Message = "Falha ao autenticar"
                };
            }
        }

       
    }
}
