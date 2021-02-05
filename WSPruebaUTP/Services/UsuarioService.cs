using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WSPruebaUTP.Models;
using WSPruebaUTP.Models.Common;
using WSPruebaUTP.Models.Request;
using WSPruebaUTP.Models.Response;
using WSPruebaUTP.Tools;

namespace WSPruebaUTP.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppSettings _appsettings;

        public UsuarioService(IOptions<AppSettings> appsettings)
        {
            this._appsettings = appsettings.Value;
        }

        public UsuarioResponse Autenticacion(AutenRequest model)
        {

            UsuarioResponse UserResponse = new UsuarioResponse();


            using (var db = new BDNotasContext())
            {

                string spassword = Encrypt.GetSha256(model.Password);
                var usuario = db.Usuarios.Where(d => d.Email == model.Email && d.Password == spassword).FirstOrDefault();


                if (usuario == null)
                {
                    return null;
                }

                UserResponse.email = usuario.Email;
                UserResponse.token = GetToken(usuario);
            }


                return UserResponse;
        }
 

        private string GetToken(Usuario model)
        {
            var TokenHandler = new JwtSecurityTokenHandler();
            var llave = Encoding.ASCII.GetBytes(_appsettings.KeyTKN);
            var TokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, model.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, model.Email.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, model.Nombre.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, model.Apellido.ToString()),

                }),
                Expires = DateTime.UtcNow.AddDays(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
            };


            var token = TokenHandler.CreateToken(TokenDescriptor);

            return TokenHandler.WriteToken(token);
        }
    }
}
