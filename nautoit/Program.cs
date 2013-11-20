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

namespace ConsoleApplication1
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint DllGetClassObject(
        [MarshalAs(UnmanagedType.LPStruct)]
    Guid rclsid,
        [MarshalAs(UnmanagedType.LPStruct)]
    Guid riid,
        [MarshalAs(UnmanagedType.IUnknown, IidParameterIndex = 1)]
    out object ppv
    );

    class Program
    {


        static void Main(string[] args)
        {
            //NRegFreeCom.AssemblySystem a = new AssemblySystem();
            //var lib = a.LoadFrom(Environment.CurrentDirectory, "AutoItX3.dll");
            //var d = lib.GetDelegate<DllGetClassObject>();
            //object c = null;

            //var result = d.Invoke(clsid,
            //         new Guid("{00000001-0000-0000-C000-000000000046}"), out c);
            //IClassFactory f = c as IClassFactory;
            //var inf = new Guid("{3D54C6B8-D283-40E0-8FAB-C97F05947EE8}");
            //IntPtr created;
            //var result2 = f.CreateInstance(IntPtr.Zero, ref inf, out created);
            //var o2= Marshal.GetObjectForIUnknown(created);
            //Console.WriteLine(typeof(AutoItX3Lib.IAutoItX3));
           // o2.GetType().InvokeMember("Run", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, (Binder)null, o2, new object[] { "Notepad" });

            var clsid = new Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}");
            var module = ComWithoutRegisteringExample.LibraryModule.LoadModule(Path.Combine(Environment.CurrentDirectory,"AutoItX3.dll"));
            var rg = ComWithoutRegisteringExample.ComHelper.CreateInstance(module, clsid);
            rg.GetType().InvokeMember("Run", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, (Binder)null, rg, new object[] { "Notepad" });
            Console.WriteLine(rg);
             var obj= NRegFreeCom.ActivationContext.CreateInstanceWithManifest(new Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}"), "i:\\src\\pyautoit\\AutoItX3.dll.manifest");
            //var qwe = obj as IAutoItX3;
            //object obj = null;
            
            //NRegFreeCom.ActivationContext.UsingManifestDo("AutoItX3.dll.manifest",()=>
            //     {
            //         obj = new AutoItX3Lib.AutoItX3Class();
            //     }
            //     );
            //dynamic qwe = obj ;
            //qwe.Run("Notepad");
            //obj.GetType().InvokeMember("Run", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod,(Binder) null, obj, new object[] {"Notepad"});
            //Console.WriteLine(obj);
        }
    }
}
