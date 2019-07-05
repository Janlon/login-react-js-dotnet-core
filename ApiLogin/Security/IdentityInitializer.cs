using System;
using Microsoft.AspNetCore.Identity;
using ApiLogin.Data;
using ApiLogin.Models;


namespace ApiLogin.Security
{
   
    public class IdentityInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityInitializer(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            if (_context.Database.EnsureCreated())
            {
                if (!_roleManager.RoleExistsAsync(Roles.RoleApiUsuarios).Result)
                {
                    var resultado = _roleManager.CreateAsync(
                        new IdentityRole(Roles.RoleApiUsuarios)).Result;
                    if (!resultado.Succeeded)
                    {
                        throw new Exception(
                            $"Erro durante a criação da role {Roles.RoleApiUsuarios}.");
                    }
                }

                CreateUser(
                    new ApplicationUser()
                    {
                        UserName = "Admin123", // UserID
                        Email = "admin@teste.com.br",
                        EmailConfirmed = true
                    }, "Senha@123", Roles.RoleApiUsuarios); //Password

                    // {
                    // 	"UserID" : "Admin123",
                    // 	"Password" :"Senha@123"
                    // }

                CreateUser(
                    new ApplicationUser()
                    {
                        UserName = "usrinvalido_api",
                        Email = "usrinvalido_api@teste.com.br",
                        EmailConfirmed = true
                    }, "Usrinvalido_api123");
            }
        }
        private void CreateUser(
            ApplicationUser user,
            string password,
            string initialRole = null)
        {
            if (_userManager.FindByNameAsync(user.UserName).Result == null)
            {
                var resultado = _userManager
                    .CreateAsync(user, password).Result;

                if (resultado.Succeeded &&
                    !String.IsNullOrWhiteSpace(initialRole))
                {
                    _userManager.AddToRoleAsync(user, initialRole).Wait();
                }
            }
        }
    }
}