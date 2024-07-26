using Microsoft.EntityFrameworkCore;

namespace PasswordManager.Data;

public class PasswordManagerDbContext : DbContext
{
    public PasswordManagerDbContext(DbContextOptions options) : base(options)
    {
    }
}