using Microsoft.AspNetCore.Mvc;
using SketchToCodeService.Factory;
using SketchToCodeService.Models;
using System.IO.Compression;
using System.Net;
using System.Net.Http.Headers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SketchToCodeService.Controllers
{
    [Route("api/project")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        // GET: api/<ProjectController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProjectController>
        [HttpPost]
        //public void Post([FromBody] ProjectDetails projectDetails)
        public void Post([FromBody] ProjectDetails projectDetails)
        {
            CreateProjects createProjects = new CreateProjects();
            createProjects.CreateProject(projectDetails);
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("downloadproject")]        
        public dynamic DownloadProject(string projectName)
        {
            string projectDirectory = $"C:/HackthonProjects/{projectName}";
            if (!System.IO.Directory.Exists(projectDirectory))
                return this.NotFound();

            var tempFile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), Guid.NewGuid().ToString()); // might want to clean this up if there are a lot of downloads
            ZipFile.CreateFromDirectory(projectDirectory, tempFile);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StreamContent(new FileStream(tempFile, FileMode.Open, FileAccess.Read));
            response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = projectName;
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/zip");

            return response;
        }
    }
}
