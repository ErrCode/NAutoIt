using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using AutoItX3Lib;
using NRegFreeCom;
using NRegFreeCom.Interop.ComTypes;

namespace nautoit
{

    class Program
    {

        /// testing calls in C# before python
        static void Main(string[] args)
        {

            var obj22 = NRegFreeCom.ActivationContext.CreateInstanceWithManifest(new Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}"), "i:\\src\\pyautoit\\AutoItX3Dependency.manifest");
            var obbb = obj22 as IAutoItX3;
            obbb.Run("Notepad");

            var clsid = new Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}");
            var assemblies = new NRegFreeCom.AssemblySystem();
            var module = assemblies.LoadFrom(Path.Combine(Environment.CurrentDirectory, "AutoItX3.dll"));

            NRegFreeCom.ActivationContext.UsingManifestDo("i:\\src\\pyautoit\\AutoItX3Dependency.manifest", () =>
                {
                    //                  var rg = NRegFreeCom.ActivationContext.CreateInstanceDirectly(module, clsid);
                    //                    rg.GetType().InvokeMember("Run", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, (Binder)null, rg, new object[] { "Notepad" });        
                });

        }
    }
}
