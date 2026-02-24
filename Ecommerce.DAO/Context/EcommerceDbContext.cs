using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DAO.Context;

public class EcommerceDbContext : DbContext
{
    public EcommerceDbContext()
    {
    }

    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
    {
    }
}
