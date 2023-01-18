using Microsoft.AspNetCore.Mvc;
using SketchToCodeService.Models;

namespace SketchToCodeService.Factory
{
    public class AngularProjectTemplate
    {
        public void CreateAngularProject(ProjectDetails projectDetails)
        {
            string projectName = projectDetails.ProjectName;
            // Create a new directory for the project
            string projectDirectory = $"C:/HackthonProjects/{projectName}/";
            Directory.CreateDirectory(projectDirectory);

            #region angular.json
            string angularJsonFile = $"{projectDirectory}/angular.json";
            string angularJsonFileContent = $@"{{
  ""$schema"": ""./node_modules/@angular/cli/lib/config/schema.json"",
  ""version"": 1,
  ""newProjectRoot"": ""projects"",
  ""projects"": {{
    ""test-angular-sketch"": {{
      ""projectType"": ""application"",
      ""schematics"": {{}},
      ""root"": """",
      ""sourceRoot"": ""src"",
      ""prefix"": ""app"",
      ""architect"": {{
        ""build"": {{
          ""builder"": ""@angular-devkit/build-angular:browser"",
          ""options"": {{
            ""outputPath"": ""dist/test-angular-sketch"",
            ""index"": ""src/index.html"",
            ""main"": ""src/main.ts"",
            ""polyfills"": ""src/polyfills.ts"",
            ""tsConfig"": ""tsconfig.app.json"",
            ""assets"": [
              ""src/favicon.ico"",
              ""src/assets""
            ],
            ""styles"": [
              ""src/styles.css""
            ],
            ""scripts"": []
          }},
          ""configurations"": {{
            ""production"": {{
              ""budgets"": [
                {{
                  ""type"": ""initial"",
                  ""maximumWarning"": ""500kb"",
                  ""maximumError"": ""1mb""
                }},
                {{
                  ""type"": ""anyComponentStyle"",
                  ""maximumWarning"": ""2kb"",
                  ""maximumError"": ""4kb""
                }}
              ],
              ""fileReplacements"": [
                {{
                  ""replace"": ""src/environments/environment.ts"",
                  ""with"": ""src/environments/environment.prod.ts""
                }}
              ],
              ""outputHashing"": ""all""
            }},
            ""development"": {{
              ""buildOptimizer"": false,
              ""optimization"": false,
              ""vendorChunk"": true,
              ""extractLicenses"": false,
              ""sourceMap"": true,
              ""namedChunks"": true
            }}
          }},
          ""defaultConfiguration"": ""production""
        }},
        ""serve"": {{
          ""builder"": ""@angular-devkit/build-angular:dev-server"",
          ""configurations"": {{
            ""production"": {{
              ""browserTarget"": ""test-angular-sketch:build:production""
            }},
            ""development"": {{
              ""browserTarget"": ""test-angular-sketch:build:development""
            }}
          }},
          ""defaultConfiguration"": ""development""
        }},
        ""extract-i18n"": {{
          ""builder"": ""@angular-devkit/build-angular:extract-i18n"",
          ""options"": {{
            ""browserTarget"": ""test-angular-sketch:build""
          }}
        }},
        ""test"": {{
          ""builder"": ""@angular-devkit/build-angular:karma"",
          ""options"": {{
            ""main"": ""src/test.ts"",
            ""polyfills"": ""src/polyfills.ts"",
            ""tsConfig"": ""tsconfig.spec.json"",
            ""karmaConfig"": ""karma.conf.js"",
            ""assets"": [
              ""src/favicon.ico"",
              ""src/assets""
            ],
            ""styles"": [
              ""src/styles.css""
            ],
            ""scripts"": []
          }}
        }}
      }}
    }}
  }}
}}";
            
            System.IO.File.WriteAllText(angularJsonFile, angularJsonFileContent);

            #endregion

            #region package.json
            string packageJsonFile = $"{projectDirectory}/package.json";
            string packageJsonFileContent = $@"{{
  ""name"": ""test-angular-sketch"",
  ""version"": ""0.0.0"",
  ""scripts"": {{
    ""ng"": ""ng"",
    ""start"": ""ng serve"",
    ""build"": ""ng build"",
    ""watch"": ""ng build --watch --configuration development"",
    ""test"": ""ng test""
  }},
  ""private"": true,
  ""dependencies"": {{
    ""@angular/animations"": ""^14.0.0"",
    ""@angular/common"": ""^14.0.0"",
    ""@angular/compiler"": ""^14.0.0"",
    ""@angular/core"": ""^14.0.0"",
    ""@angular/forms"": ""^14.0.0"",
    ""@angular/platform-browser"": ""^14.0.0"",
    ""@angular/platform-browser-dynamic"": ""^14.0.0"",
    ""@angular/router"": ""^14.0.0"",
    ""rxjs"": ""~7.5.0"",
    ""tslib"": ""^2.3.0"",
    ""zone.js"": ""~0.11.4""
  }},
  ""devDependencies"": {{
    ""@angular-devkit/build-angular"": ""^14.2.1"",
    ""@angular/cli"": ""~14.2.1"",
    ""@angular/compiler-cli"": ""^14.0.0"",
    ""@types/jasmine"": ""~4.0.0"",
    ""jasmine-core"": ""~4.3.0"",
    ""karma"": ""~6.4.0"",
    ""karma-chrome-launcher"": ""~3.1.0"",
    ""karma-coverage"": ""~2.2.0"",
    ""karma-jasmine"": ""~5.1.0"",
    ""karma-jasmine-html-reporter"": ""~2.0.0"",
    ""typescript"": ""~4.7.2""
  }}
}}";

            System.IO.File.WriteAllText(packageJsonFile, packageJsonFileContent);

            #endregion

            #region tsconfig.app.json
            string tsConfigAppJsonFile = $"{projectDirectory}/tsconfig.app.json";
            string tsConfigAppJsonFileContent = $@"{{
  ""extends"": ""./tsconfig.json"",
  ""compilerOptions"": {{
    ""outDir"": ""./out-tsc/app"",
    ""types"": []
  }},
  ""files"": [
    ""src/main.ts"",
    ""src/polyfills.ts""
  ],
  ""include"": [
    ""src/**/*.d.ts""
  ]
}}";
            System.IO.File.WriteAllText(tsConfigAppJsonFile, tsConfigAppJsonFileContent);
            #endregion

            #region tsconfig.json
            string tsConfigJsonFile = $"{projectDirectory}/tsconfig.json";
            string tsConfigJsonFileContent = $@"{{
  ""compileOnSave"": false,
  ""compilerOptions"": {{
    ""baseUrl"": ""./"",
    ""outDir"": ""./dist/out-tsc"",
    ""forceConsistentCasingInFileNames"": true,
    ""strict"": true,
    ""noImplicitOverride"": true,
    ""noPropertyAccessFromIndexSignature"": true,
    ""noImplicitReturns"": true,
    ""noFallthroughCasesInSwitch"": true,
    ""sourceMap"": true,
    ""declaration"": false,
    ""downlevelIteration"": true,
    ""experimentalDecorators"": true,
    ""moduleResolution"": ""node"",
    ""importHelpers"": true,
    ""target"": ""es2020"",
    ""module"": ""es2020"",
    ""lib"": [
      ""es2020"",
      ""dom""
    ]
  }},
  ""angularCompilerOptions"": {{
    ""enableI18nLegacyMessageIdFormat"": false,
    ""strictInjectionParameters"": true,
    ""strictInputAccessModifiers"": true,
    ""strictTemplates"": true
  }}
}}
";
            System.IO.File.WriteAllText(tsConfigJsonFile, tsConfigJsonFileContent);
            #endregion

            #region tsconfig.spec.json
            string tsConfigSpecJsonFile = $"{projectDirectory}/tsconfig.spec.json";
            string tsConfigSpecJsonFileContent = $@"{{
  ""extends"": ""./tsconfig.json"",
  ""compilerOptions"": {{
    ""outDir"": ""./out-tsc/spec"",
    ""types"": [
      ""jasmine""
    ]
  }},
  ""files"": [
    ""src/test.ts"",
    ""src/polyfills.ts""
  ],
  ""include"": [
    ""src/**/*.spec.ts"",
    ""src/**/*.d.ts""
  ]
}}
";
            System.IO.File.WriteAllText(tsConfigSpecJsonFile, tsConfigSpecJsonFileContent);
            #endregion

            #region karma.conf.js
            string karmaConfJsFile = $"{projectDirectory}/karma.conf.js";
            string karmaConfJsFileContent = $@"module.exports = function (config) {{
  config.set({{
    basePath: '',
    frameworks: ['jasmine', '@angular-devkit/build-angular'],
    plugins: [
      require('karma-jasmine'),
      require('karma-chrome-launcher'),
      require('karma-jasmine-html-reporter'),
      require('karma-coverage'),
      require('@angular-devkit/build-angular/plugins/karma')
    ],
    client: {{
      jasmine: {{
        // you can add configuration options for Jasmine here
        // the possible options are listed at https://jasmine.github.io/api/edge/Configuration.html
        // for example, you can disable the random execution with `random: false`
        // or set a specific seed with `seed: 4321`
      }},
      clearContext: false // leave Jasmine Spec Runner output visible in browser
    }},
    jasmineHtmlReporter: {{
      suppressAll: true // removes the duplicated traces
    }},
    coverageReporter: {{
      dir: require('path').join(__dirname, './coverage/test-angular-sketch'),
      subdir: '.',
      reporters: [
        {{ type: 'html' }},
        {{ type: 'text-summary' }}
      ]
    }},
    reporters: ['progress', 'kjhtml'],
    port: 9876,
    colors: true,
    logLevel: config.LOG_INFO,
    autoWatch: true,
    browsers: ['Chrome'],
    singleRun: false,
    restartOnFileChange: true
  }});
}};";
            System.IO.File.WriteAllText(karmaConfJsFile, karmaConfJsFileContent);
            #endregion

            #region .vscode
            #region extensions.json
            string extensionsJsonFile = $"{projectDirectory}/.vscode/extensions.json";
            System.IO.FileInfo vscodefolder = new System.IO.FileInfo(extensionsJsonFile);
            vscodefolder.Directory.Create();
            string extensionsJsonFileContent = $@"{{
  // For more information, visit: https://go.microsoft.com/fwlink/?linkid=827846
  ""recommendations"": [""angular.ng-template""]
}}";
            System.IO.File.WriteAllText(vscodefolder.FullName, extensionsJsonFileContent);
            #endregion

            #region launch.json
            string launchJsonFile = $"{projectDirectory}/.vscode/launch.json";
            string launchJsonFileContent = $@"{{
  // For more information, visit: https://go.microsoft.com/fwlink/?linkid=830387
  ""version"": ""0.2.0"",
  ""configurations"": [
    {{
      ""name"": ""ng serve"",
      ""type"": ""pwa-chrome"",
      ""request"": ""launch"",
      ""preLaunchTask"": ""npm: start"",
      ""url"": ""http://localhost:4200/""
    }},
    {{
      ""name"": ""ng test"",
      ""type"": ""chrome"",
      ""request"": ""launch"",
      ""preLaunchTask"": ""npm: test"",
      ""url"": ""http://localhost:9876/debug.html""
    }}
  ]
}}";
            System.IO.File.WriteAllText(launchJsonFile, launchJsonFileContent);

            #endregion

            #endregion

            #region src/app
            #region app-routing.module.ts
            string appRoutingModule = $"{projectDirectory}/src/app/app-routing.module.ts";
            System.IO.FileInfo srcAppFolder = new System.IO.FileInfo(appRoutingModule);
            srcAppFolder.Directory.Create();
            string appRoutingModuleContent = $@"import {{ NgModule }} from '@angular/core';
import {{ RouterModule, Routes }} from '@angular/router';

const routes: Routes = [];

@NgModule({{
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
}})
export class AppRoutingModule {{ }}";

            System.IO.File.WriteAllText(srcAppFolder.FullName, appRoutingModuleContent);
            #endregion

            #region app.component.html
            string appComponentHtml = $"{projectDirectory}/src/app/app.component.html";
            string appComponentHtmlString = projectDetails.ProjectName + "<router-outlet></router-outlet>";
            string appComponentHtmlContent = appComponentHtmlString;
            System.IO.File.WriteAllText(appComponentHtml, appComponentHtmlContent);
            #endregion

            #region app.component.spec.ts
            string appComponentSpecTs = $"{projectDirectory}/src/app/app.component.spec.ts";
            string appComponentSpecTsContent = $@"import {{ TestBed }} from '@angular/core/testing';
import {{ RouterTestingModule }} from '@angular/router/testing';
import {{ AppComponent }} from './app.component';

describe('AppComponent', () => {{
  beforeEach(async () => {{
    await TestBed.configureTestingModule({{
      imports: [
        RouterTestingModule
      ],
      declarations: [
        AppComponent
      ],
    }}).compileComponents();
  }});

  it('should create the app', () => {{
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  }});

  it(`should have as title 'test-angular-sketch'`, () => {{
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('test-angular-sketch');
  }});

  it('should render title', () => {{
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('.content span')?.textContent).toContain('test-angular-sketch app is running!');
  }});
}});";
            System.IO.File.WriteAllText(appComponentSpecTs, appComponentSpecTsContent);

            #endregion

            #region app.component.ts

            string appComponentTs = $"{projectDirectory}/src/app/app.component.ts";
            string appComponentString = "import { Component } from '@angular/core';\r\n\r\n@Component({\r\n  selector: 'app-root',\r\n  templateUrl: './app.component.html',\r\n  styleUrls: ['./app.component.css']\r\n})\r\nexport class AppComponent {\r\n  title = '" + projectDetails.ProjectName + "';\r\n}";
            string appComponentTsContent = appComponentString;
            System.IO.File.WriteAllText(appComponentTs, appComponentTsContent);

            #endregion

            #region app.module.ts

            string appModuleTs = $"{projectDirectory}/src/app/app.module.ts";
            string appModuleTsContent = $@"import {{ NgModule }} from '@angular/core';
import {{ BrowserModule }} from '@angular/platform-browser';

import {{ AppRoutingModule }} from './app-routing.module';
import {{ AppComponent }} from './app.component';

@NgModule({{
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
}})
export class AppModule {{ }}";
            System.IO.File.WriteAllText(appModuleTs, appModuleTsContent);
            #endregion

            #region 
            string appComponentCss = $"{projectDirectory}/src/app/app.component.css";
            string appComponentCssContent = $@"";
            System.IO.File.WriteAllText(appComponentCss, appComponentCssContent);
            #endregion

            #endregion

            #region src/environment
            #region environment.prod.ts
            string envProdTs = $"{projectDirectory}/src/environments/environment.prod.ts";
            System.IO.FileInfo srcEnvFolder = new System.IO.FileInfo(envProdTs);
            srcEnvFolder.Directory.Create();
            string envProdTsContent = $@"export const environment = {{production: true
}};";
            System.IO.File.WriteAllText(srcEnvFolder.FullName, envProdTsContent);

            #endregion
            #region environment.ts
            string envTs = $"{projectDirectory}/src/environments/environment.ts";
            string envTsContent = $@"export const environment = {{production: false
}};";
            System.IO.File.WriteAllText(envTs, envTsContent);
            #endregion

            #endregion

            #region src index.html
            string indexHtml = $"{projectDirectory}/src/index.html";
            string indexHtmlString = "<!doctype html>\r\n<html lang=\"en\">\r\n<head>\r\n  <meta charset=\"utf-8\">\r\n  <title>" + projectDetails.ProjectName + "</title>\r\n  <base href=\"/\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n  <link rel=\"icon\" type=\"image/x-icon\" href=\"favicon.ico\">\r\n</head>\r\n<body>\r\n  <app-root></app-root>\r\n</body>\r\n</html>";
            string indexHtmlContent = indexHtmlString;
            System.IO.File.WriteAllText(indexHtml, indexHtmlContent);
            #endregion
            
            #region src main.ts
            string mainTs = $"{projectDirectory}/src/main.ts";
            string mainTsContent = $@"import {{ enableProdMode }} from '@angular/core';
import {{ platformBrowserDynamic }} from '@angular/platform-browser-dynamic';

import {{ AppModule }} from './app/app.module';
import {{ environment }} from './environments/environment';

if (environment.production) {{
  enableProdMode();
}}

platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));";
            System.IO.File.WriteAllText(mainTs, mainTsContent);
            #endregion

            #region src polyfills
            string polyfills = $"{projectDirectory}/src/polyfills.ts";
            string polyfillsContent = $@"import 'zone.js';";
            System.IO.File.WriteAllText(polyfills, polyfillsContent);
            #endregion

            #region src styles
            string styles = $"{projectDirectory}/src/styles.css";
            string stylesContent = $@"/* You can add global styles to this file, and also import other style files */";
            System.IO.File.WriteAllText(styles, stylesContent);
            #endregion

        }
    }
}
