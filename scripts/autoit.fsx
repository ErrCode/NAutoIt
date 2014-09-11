/// Unzips AutoItX and prepares NuGet package for it
#r @"..\packages\DotNetZip.1.9.2\lib\net20\Ionic.Zip.dll"
open System
open System.IO
open System.Diagnostics
open System.Net
open System.IO.Compression
open Ionic.Zip

let nuget = Path.GetFullPath("nuget.exe")
let packages = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory,"../packages/"))
let packRoot =  Path.GetFullPath(Path.Combine(Environment.CurrentDirectory,"../packaging/"))
let packaging = Path.Combine(packRoot,"AutoItX/lib/")
let sdkpath = "c:/Program Files (x86)/Microsoft SDKs/Windows/v7.0A/Bin/x64/"
printfn "SDK %s" sdkpath
printfn "Target %s" packaging



//delete previous release
if (Directory.Exists(packaging)) then 
  Directory.Delete(packaging,true)

// unpack 
let zipPath = Path.Combine(packages, "autoit-v3.zip")
let zip = ZipFile.Read(zipPath)
for  en in zip do
  if  en.FileName.StartsWith("install/AutoItX/") then
    en.Extract(packages,ExtractExistingFileAction.OverwriteSilently)
zip.Dispose()
let got = Path.Combine(packages,@"install\AutoItX\")
printfn "Source %s" got
Directory.Move (got,packaging)

let license = "License.htm"
File.Copy(packages+license,packaging+license,true)

printfn "Start makeing AutoItX package"
printfn "Nuget path: %s" nuget
printfn "Out folder: %s" packages

// next fails because RegAsm : error RA0000 : The name of the type library cannot be specified for assemblies containing embedded type libraries
//%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe /tlb:"AutoItX3.tlb" "packaging\AutoItX\lib\AutoItX\AutoItX3.dll"

// get current version
let dllName = "AutoItX3_x64.dll";
let dll = Path.Combine(packaging,dllName)
let verInfo =  FileVersionInfo.GetVersionInfo(dll)
let ver = String.Format("{0}.{1}.{2}.{3}",verInfo.FileMajorPart, verInfo.FileMinorPart,verInfo.FileBuildPart,verInfo.FilePrivatePart)

//generate interop dll
let tlbimp = "tlbimp.exe"

let manifestName = dllName + ".manifest"
let interop = Path.Combine(packaging,"AutoItX3.Interop.dll")
let interopCmd =  dll+  " /asmversion:" + ver + " /out:" + interop + " /machine:Agnostic /nologo"
let p = new Process();
p.StartInfo.Arguments <- interopCmd
p.StartInfo.UseShellExecute <- false
p.StartInfo.RedirectStandardOutput <- true
p.StartInfo.FileName <- Path.Combine(sdkpath,tlbimp)
p.Start()

// write down manifests
let dllTemplate= "@dll.name@"
let verTemplate = "@build.number@"
let template = File.ReadAllText(Path.Combine(packRoot,"template.manifest"))
let x64 = Path.Combine(packaging,"AutoItX3_x64.dll.manifest")
let x64Txt = template.Replace(verTemplate,ver).Replace(dllTemplate,"AutoItX3_x64.dll") 
File.WriteAllText(x64,x64Txt)
let x86 = Path.Combine(packaging,"AutoItX3.dll.manifest")
let x86Txt = template.Replace(verTemplate,ver).Replace(dllTemplate,"AutoItX3.dll") 
File.WriteAllText(x86,x86Txt)

// copy scripts for COM un/registration
File.Copy(packRoot+"register.bat",packaging+"register.bat",true)
File.Copy(packRoot+"unregister.bat",packaging+"unregister.bat",true)

// prepare nuspec
let nuTemplate = File.ReadAllText(Path.Combine(packRoot,"template.nuspec"))
let nu = nuTemplate.Replace(verTemplate,ver)
let nuPath = Path.Combine(packRoot,"AutoItX","AutoItX.nuspec")
File.WriteAllText(nuPath,nu)

//create package
Process.Start(nuget,"pack " + nuPath)