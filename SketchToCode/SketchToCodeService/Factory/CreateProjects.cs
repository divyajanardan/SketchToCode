
using SketchToCodeService.Helper;
using SketchToCodeService.Models;

namespace SketchToCodeService.Factory
{
    public class CreateProjects
    {
        public CreateProjects(){}

        public void CreateProject(ProjectDetails projectDetails)
        {
            if(projectDetails.ProjectType == "0")
            {
                CreateClassLibraryProject();
            }
            else if(projectDetails.ProjectType == "1")
            {
                CreateWebAPI(projectDetails);
            }
          
        }

        private void CreateWebAPI(ProjectDetails projectDetails)
        {
            string projectName = projectDetails.ProjectName;
            // Create a new directory for the project
            string projectDirectory = $"C:/HackthonProjects/{projectName}/";
            Directory.CreateDirectory(projectDirectory);

            // Create a new C# project file
            string projectFile = $"{projectDirectory}/{projectName}.csproj";
            string projectFileContent = $@"<Project Sdk=""Microsoft.NET.Sdk.Web"">
                  <PropertyGroup>
                    <TargetFramework>net6.0</TargetFramework>
                    <Nullable>enable</Nullable>
                    <ImplicitUsings>enable</ImplicitUsings>
                  </PropertyGroup>
                  <ItemGroup>
                    <PackageReference Include=""Swashbuckle.AspNetCore"" Version=""6.2.3"" />
                  </ItemGroup>
                </Project>";
            System.IO.File.WriteAllText(projectFile, projectFileContent);

            // Create a new Program.cs file
            string programFile = $"{projectDirectory}/Program.cs";
            string programFileContent = $@"var builder = WebApplication.CreateBuilder(args);
                builder.Services.AddControllers();
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();
                var app = builder.Build();
                if (app.Environment.IsDevelopment())
                {{
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }}
                app.UseHttpsRedirection();
                app.UseAuthorization();
                app.MapControllers();
                app.Run();";
            
            System.IO.File.WriteAllText(programFile, programFileContent);
            if (projectDetails.ApiProject.Controllers != null)
            {
                foreach(var controller in projectDetails.ApiProject.Controllers)
                {
                    string controllerFile = $"{projectDirectory}/Controllers/{controller.ControllerName}.cs";
                    System.IO.FileInfo file = new System.IO.FileInfo(controllerFile);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.                    
                    string controllerFileContent = $@"using Microsoft.AspNetCore.Mvc;
                        namespace {projectDetails.ProjectName}.Controllers
                        {{
                            [Route(""api/{controller.ControllerName}"")]
                            [ApiController]
                            public class {controller.ControllerName}Controller : ControllerBase
                            {{
                                [HttpGet]
                                public IEnumerable<string> Get()
                                {{
                                    return new string[] {{ ""value1"", ""value2"" }};
                                }}

                                [HttpGet(""{{id}}"")]
                                public string Get(int id)
                                {{
                                    return ""value"";
                                }}

                                [HttpPost]
                                public void Post([FromBody] string value)
                                {{
                                }}

                                [HttpPut(""{{id}}"")]
                                public void Put(int id, [FromBody] string value)
                                {{
                                }}

                                [HttpDelete(""{{id}}"")]
                                public void Delete(int id)
                                {{
                                }}
                            }}
                        }}
                        ";
                    System.IO.File.WriteAllText(file.FullName, controllerFileContent);
                }               
            }
        }

        private void CreateClassLibraryProject()
        {
            string projectName = $"MyTestClassLibraryProject";
            // Create a new directory for the project
            string projectDirectory = $"C:/HackthonProjects/{projectName}/";
            Directory.CreateDirectory(projectDirectory);

            // Create a new C# project file
            string projectFile = $"{projectDirectory}/{projectName}.csproj";
            string projectFileContent = $@"<Project Sdk=""Microsoft.NET.Sdk"">
                        <PropertyGroup>
                            <OutputType>Exe</OutputType>
                            <TargetFramework>netcoreapp3.1</TargetFramework>
                        </PropertyGroup>
                    </Project>";
            System.IO.File.WriteAllText(projectFile, projectFileContent);

            // Create a new Program.cs file
            string programFile = $"{projectDirectory}/Program.cs";
            string programFileContent = $@"using System;

                namespace {projectName}
                {{
                    class Program
                    {{
                        static void Main(string[] args)
                        {{
                            Console.WriteLine(""Hello World!"");
                        }}
                    }}
                }}";
            System.IO.File.WriteAllText(programFile, programFileContent);

        }

        private void CreateSimpleProject()
        {
            string projectName = $"MyTestWebAPIProject";
            // Create a new directory for the project
            string projectDirectory = $"C:/HackthonProjects/{projectName}/";
            Directory.CreateDirectory(projectDirectory);

            // Create a new C# project file
            string projectFile = $"{projectDirectory}/{projectName}.csproj";
            string projectFileContent = $@"<Project Sdk=""Microsoft.NET.Sdk"">
                        <PropertyGroup>
                            <OutputType>Exe</OutputType>
                            <TargetFramework>netcoreapp3.1</TargetFramework>
                        </PropertyGroup>
                    </Project>";
            System.IO.File.WriteAllText(projectFile, projectFileContent);

            // Create a new Program.cs file
            string programFile = $"{projectDirectory}/Program.cs";
            string programFileContent = $@"using System;

                namespace {projectName}
                {{
                    class Program
                    {{
                        static void Main(string[] args)
                        {{
                            Console.WriteLine(""Hello World!"");
                        }}
                    }}
                }}";
            System.IO.File.WriteAllText(programFile, programFileContent);
        }

        private void RunCommand(string dir, string command)
        {
           
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.WorkingDirectory = dir;
            startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/C " + command;
            command = @"/c cd: C:\HackthonProjects & dotnet new webapi --name MyTestWebAPIProject";
            //startInfo.Arguments = "/user:Administrator" + command;
            startInfo.Arguments = command;
            startInfo.UseShellExecute = true;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
