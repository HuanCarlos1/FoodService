using System;
using System.Collections.Generic;
using System.Linq;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Entities.Restaurant;
using Kamall_foods_server_aspNetCore.Data.Models.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;

namespace Kamall_foods_server_aspNetCore.Data.Context;

public class DatabaseContext : DbContext
{
    private readonly string _connectionString;

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        _connectionString = Database.GetDbConnection().ConnectionString;
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<DeliveryUser> DeliveryUsers { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<RestaurantAdmin> RestaurantAdmins { get; set; }
    public DbSet<RestaurantType> RestaurantTypes { get; set; }
    public DbSet<FoodType> FoodTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.DeliveryAdresses)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<string>>(v));

            var valueComparer = new ValueComparer<List<string>>((c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())), c => c.ToList());

            entity.Property(e => e.DeliveryAdresses).Metadata.SetValueComparer(valueComparer);
        });

        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<DeliveryUser>().ToTable("DeliveryUsers");
        modelBuilder.Entity<RestaurantAdmin>().ToTable("RestaurantAdmins");

        //Restaurant
        modelBuilder.Entity<Restaurant>().HasMany(c => c.Foods);
        modelBuilder.Entity<Restaurant>().HasOne(c => c.Owner)
            .WithOne(e => e.Restaurant)
            .HasForeignKey<RestaurantAdmin>(f => f.RestaurantId);
        modelBuilder.Entity<Restaurant>().HasMany(c => c.Types);

        //RestaurantAdmins
        //modelBuilder.Entity<RestaurantAdmin>().HasOne(c => c.Restaurant);

        //RestaurantTypes
        string[] types =
        {
            "AFRICAN", "EUROPEAN",
            "FAST-FOOD", "CHINESE", "INDIAN", "CAFE"
        };
        var data = types.Select(type => new RestaurantType
        {
            ID = Guid.NewGuid().ToString(),
            Name = type
        }).ToList();

        modelBuilder.Entity<RestaurantType>().HasData(data);

        //FoodTypes
        string[] types2 =
        {
            "Burger", "Salade", "Tacos", "Hamburger",
            "Couscous", "Pizza", "Kebab", "Cake", "Sandwich", "Dessert", "Fruits",
            "Viande", "Poulet", "Snacks", "Jus", "Alcool", "Vin", "Champagne",
            "Whisky"
        };
        var data2 = types2.Select(type => new FoodType
        {
            ID = Guid.NewGuid().ToString(),
            Name = type
        }).ToList();

        modelBuilder.Entity<FoodType>().HasData(data2);
    }
}