using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace AuthECAPI.Models
{
    public class TestDeleteme : IdentityDbContext
    {
     
        public TestDeleteme(DbContextOptions<TestDeleteme> options) : base(options)
        {
        }
    }
}
