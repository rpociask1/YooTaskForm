using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using YooTaskForm.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Net.Http.Headers;

namespace YooTaskForm.Controllers
{
    public class UserController
    {
        Uri uri = new Uri("http://192.168.134.66:8080/user/");


        public async Task<string> Login(string email, string password)
        {
            string reply;
            LoginModel user = new LoginModel();
            user.email = email;
            user.password = password;

            var json = JsonConvert.SerializeObject(user);
            //  var request = new HttpRequestMessage();
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var client = new HttpClient();
            var response = await client.PostAsync(uri+"login", httpContent);


            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var token = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                {
                '"'


            });


                reply = token;
                return reply;
            }
            else
            {
                var errorMessage1 = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                {
                '"'
                });

                reply = "";
                return reply;
            }
        }

        public async Task<string> SignUp(string email, string password)
        {
            string reply;
            LoginModel user = new LoginModel();
            user.email = email;
            user.password = password;

            var json = JsonConvert.SerializeObject(user);
            //  var request = new HttpRequestMessage();
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var client = new HttpClient();
            var response = await client.PostAsync(uri + "signup", httpContent);


            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var token = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                {
                '"'


            });


                reply = token;
                return reply;
            }
            else
            {
                var errorMessage1 = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                {
                '"'
                });

                reply = "";
                return reply;
            }
        }

        public async Task<User> GetId(string email)
        {
            User user = new User(); 
            var client = new HttpClient();
            var response = await client.GetAsync(uri + email);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
               var token = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                {
                '"'
            });

                 user = JsonConvert.DeserializeObject<User>(token);
            }
            
            return user;
        }
    }
}
