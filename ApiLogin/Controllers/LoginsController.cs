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
       
        // // POST api/logins
        // [HttpPost]
        //  public string Post(string data){
                 
        //     // if (string.IsNullOrEmpty(data)){
        //          string retorno = "{\"Authenticated\":false, \"Message\": \"Falha ao autenticar\" }";
        //         using (AesCryptoServiceProvider myAes = new AesCryptoServiceProvider())
        //         { 
        //             // Encrypt the string to an array of bytes.
        //             byte[] encrypted = CryptDecript.EncryptStringToBytes_Aes(retorno, myAes.Key, myAes.IV);
        //             string strEncrypted = Encoding.ASCII.GetString(encrypted);

        //             return strEncrypted;
        //     //    }
        //     }

        //     // Create a new instance of the AesCryptoServiceProvider
        //     // class.  This generates a new key and initialization 
        //     // vector (IV).
        //     // using (AesCryptoServiceProvider myAes = new AesCryptoServiceProvider())
        //     // { 
        //     //     byte[] bytes = Encoding.ASCII.GetBytes(data);
                
        //     //     // Decrypt the bytes to a string.
        //     //     string roundtrip = CryptDecript.DecryptStringFromBytes_Aes(bytes, myAes.Key, myAes.IV);
              
        //     //     // //Enviar para  o login
        //     //     // var user = JsonConvert.DeserializeObject<User>(roundtrip);
        //     //     // var retorno = Login(user, null);
        //     //     // string strRetorno = retorno.ToString();

        //     //     // // Encrypt the string to an array of bytes.
        //     //     // byte[] encrypted = CryptDecript.EncryptStringToBytes_Aes(strRetorno, myAes.Key, myAes.IV);
        //     //     // string strEncrypted = Encoding.ASCII.GetString(bytes);

        //     //     return roundtrip;
     
        //     // }
        
        // }  

   
        public object Post([FromBody]User usuario,[FromServices]AccessManager accessManager)
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
