using Microsoft.EntityFrameworkCore;
using ApiLogin.Models;

namespace ApiLogin.Data
{
    public class CatalogoDbContext : DbContext
    {
        public CatalogoDbContext(DbContextOptions<CatalogoDbContext> options) : base(options)
        {

        }

    }
}