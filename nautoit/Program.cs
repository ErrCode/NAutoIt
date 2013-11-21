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

            var createdViaManifest = NRegFreeCom.ActivationContext.CreateInstanceWithManifest(new Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}"), "AutoItX3Dependency.manifest");
            var autoItWithManifest = (IAutoItX3)createdViaManifest;
            autoItWithManifest.Run("Notepad");

            var clsid = new Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}");
            var assemblies = new NRegFreeCom.AssemblySystem();
            var module = assemblies.LoadFrom(Path.Combine(Environment.CurrentDirectory, "AutoItX3.dll"));
            var rg = NRegFreeCom.ActivationContext.CreateInstanceDirectly(module, clsid);
            var run = (IAutoItX3)rg;
            try
            {
                var t = Type.GetType("System.OleAutBinder");
                var binder = System.Activator.CreateInstance(t);
                run.GetType().InvokeMember("Run", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, (Binder)binder, run, new object[] { "Notepad", "", 1 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

          
            try
            {
                run.Run("Notepad");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
