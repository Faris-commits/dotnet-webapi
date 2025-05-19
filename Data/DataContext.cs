using System;
using dotnet_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_webapi.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Character> Characters => Set<Character>();

    public DbSet<User> Users => Set<User>();

}


