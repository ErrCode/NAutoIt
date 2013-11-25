using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AutoItX3Lib;

namespace nautoit.sample
{
    class Program
    {
        /// testing calls in C# before IronPython
        static void Main(string[] args)
        {
            //var clsid = new Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}");

            //var manifest = "AutoItX3Dependency.manifest";

            //var createdViaManifest = NRegFreeCom.ActivationContext.CreateInstanceWithManifest(clsid, manifest);
            //var autoItWithManifest = (IAutoItX3)createdViaManifest;
            //autoItWithManifest.Run("Notepad");


            //var assemblies = new NRegFreeCom.AssemblySystem();
            //var module = assemblies.LoadFrom(Path.Combine(Environment.CurrentDirectory, "AutoItX3.dll"));
            //var createdDirectly = NRegFreeCom.ActivationContext.CreateInstanceDirectly(module, clsid) as IAutoItX3;
            //createdDirectly.Run("Notepad");

            //var nativeResult = NativeMethods_32.AU3_Run("Notepad", "", 1);

            //var wrapper = new AutoItX3Wrapper(manifest);
            // wrapper.Run("Notepad");

            autoitrt.Run("Notepad");

        }
    }

}
