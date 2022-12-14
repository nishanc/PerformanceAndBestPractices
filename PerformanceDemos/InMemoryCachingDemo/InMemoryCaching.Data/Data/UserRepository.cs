using InMemoryCaching.Data.Models;
using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCaching.Data.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly IMemoryCache _memoryCache;

        public UserRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public List<User> GetUsers()
        {
            List<User> output = new()
            {
                new() { FirstName = "Tim", LastName = "Corey" },
                new() { FirstName = "Sue", LastName = "Storm" },
                new() { FirstName = "Jane", LastName = "Jones" }
            };

            Thread.Sleep(3000);

            return output;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            List<User> output = new()
            {
                new() { FirstName = "Tim", LastName = "Corey" },
                new() { FirstName = "Sue", LastName = "Storm" },
                new() { FirstName = "Jane", LastName = "Jones" }
            };

            await Task.Delay(3000);

            return output;
        }

        public async Task<List<User>> GetUsersCacheAsync()
        {
            var output = _memoryCache.Get<List<User>>("users");

            if (output is not null) return output;

            output = new()
            {
                new() { FirstName = "Tim", LastName = "Corey" },
                new() { FirstName = "Sue", LastName = "Storm" },
                new() { FirstName = "Jane", LastName = "Jones" }
            };

            await Task.Delay(3000); // <-- Simulate network latency

            _memoryCache.Set("users", output,
                TimeSpan.FromMinutes(1));

            return output;
        }
    }
}
