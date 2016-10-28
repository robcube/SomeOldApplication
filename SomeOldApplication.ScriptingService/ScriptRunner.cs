using System;
using System.Configuration;
using System.IO;
using IronPython.Hosting;

namespace SomeOldApplication.ScriptingService
{
    public class ScriptRunner
    { 
        public string RunScript(string scriptName)
        {
            try
            {
                string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                var pathToScripts = ConfigurationManager.AppSettings["scriptsFolder"]; // so you can switch between 'testscripts' and production 'scripts'

                var ipy = Python.CreateRuntime();

                dynamic run = ipy.UseFile(Path.Combine(appPath, pathToScripts, scriptName));
                run.Run(scriptName);

                return "success";
            }
            catch (Exception ex)
            {
                return "failure: " + ex.Message;
            }
        }
    }
}
