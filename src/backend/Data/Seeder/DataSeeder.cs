using System.Security.Cryptography;
using System.Text;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Newtonsoft.Json;

namespace Data.Seeder
{
    public class DataSeeder
    {
        public static async Task SeedUser(AppDbContext dbContext)
        {
            if (await dbContext.AppUsers.AnyAsync()) return;

            var userInfo = await File.ReadAllTextAsync("../Data/Seeder/user.json");
            var newUser = JsonConvert.DeserializeObject<AppUser>(userInfo);

            using var hmac = new HMACSHA512();

            newUser!.Username = newUser.Username.ToLower();
            newUser.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("R@nd0mP@ssw0rd123!"));
            newUser.PasswordSalt = hmac.Key;

            await dbContext.AppUsers.AddAsync(newUser);
            await dbContext.SaveChangesAsync();

        }
    }
}