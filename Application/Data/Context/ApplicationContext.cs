using Microsoft.EntityFrameworkCore;

namespace Application.Data.Context;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
}