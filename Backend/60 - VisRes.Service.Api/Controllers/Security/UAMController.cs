using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

using VisRes.Models.Model;

namespace VisRes.Service.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/UAM")]
    public class UAMController : Controller
    {
        private IConfiguration _config;

        public UAMController(IConfiguration config)
        {
            _config = config;
        }

        // GET: api/UAM
        [HttpGet]
        public UserUamModel Get(string username, string password)  
        {
            UserUamModel uam = new UserUamModel();

            Stopwatch stopWatch = Stopwatch.StartNew();
            try
            {
                var responseString = CheckUserAccessWithUamService(_config["Uam:Address"], username, password);

                if (string.IsNullOrEmpty(responseString))
                {
                    // ERROR! (204) --> null
                    // return uam;
                }
                else
                {
                    // SUCCESS (200)! --> return a few items
                    uam = JsonConvert.DeserializeObject<UserUamModel>(responseString);
                }
            }
            catch (Exception ex)
            {
                uam.ErrorException = ex.Message;                
            }

            stopWatch.Stop();
            TimeSpan timespan = stopWatch.Elapsed;
            uam.Milliseconds = $"{stopWatch.ElapsedMilliseconds} ms";

            return uam;
        }

        #region "Private"

        private string CheckUserAccessWithUamService(string url, string userName, string password)
        {
            var value = this.IsValidUser(url, userName, password).Result;
            return value;
        }

        private async Task<string> IsValidUser(string url, string user, string password)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(BuildUriWithQueryString(url, user, password));
                    response.EnsureSuccessStatusCode(); // Throw in not success

                    var responseUam = await response.Content.ReadAsStringAsync();
                    return responseUam;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"UAM error: {e.Message}");
                    return null;
                }
            }
        }

        private string BuildUriWithQueryString(string url, string userName, string password)
        {
            var parametersToAdd = new System.Collections.Generic.Dictionary<string, string> {
                {   "name", userName        },
                {   "password", password    },
                {   "loginid", userName     }
            };

            var newUri = Microsoft.AspNetCore.WebUtilities.QueryHelpers.AddQueryString(url, parametersToAdd);
            return newUri;
        }

        #endregion

        //// GET: api/UAM/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/UAM
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/UAM/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
