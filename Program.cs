using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Json;

namespace p511_oop
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UpdatedAt { get; set; }
        public string CreatedAt { get; set; }
    }

    public class RegisterDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    internal class Program
    {
        private static readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:8080")
        };

        static async Task Main(string[] args)
        {
            var newUser = new RegisterDto()
            {
                Username = "bob12",
                Email = "bobdev12@mail.ru",
                Password = "12345"
            };

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("/api/auth/register", newUser);

            UserDto created = await response.Content.ReadFromJsonAsync<UserDto>();

            Console.WriteLine($"{created.Username} {created.Email}");

            List<UserDto> users = await _httpClient.GetFromJsonAsync<List<UserDto>>("/api/users");

            if (users is null)
            {
                Console.WriteLine("Пустой ответ");
                return;
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Username);
            }
        }   
    }
}
