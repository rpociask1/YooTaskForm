using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YooTaskForm.Models;

namespace YooTaskForm.Controllers
{
    public class ProjectController
    {

        Uri uri = new Uri("http://192.168.134.66:8080/project/");
        public async Task<string> CreateProject(Project project)
        {
            string reply;
            

            var json = JsonConvert.SerializeObject(project);
            //  var request = new HttpRequestMessage();
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var client = new HttpClient();
            var response = await client.PostAsync(uri, httpContent);


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

        public async Task<Project> GetProjects(string id)
        {
            Project project = new Project();
            var client = new HttpClient();
            var response = await client.GetAsync(uri + id);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var token = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                 {
                '"'
             });

                project = JsonConvert.DeserializeObject<Project>(token);
            }

            return project;
        }
    }
}
