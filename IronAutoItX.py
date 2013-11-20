
import autoitx

t = System.Type.GetTypeFromProgID("AutoItX3.Control")
oAutoItX = System.Activator.CreateInstance(t)

oAutoItX.Opt("WinTitleMatchMode", 2)

width = oAutoItX.WinGetClientSizeWidth("IronPythonApplication1 - Microsoft Visual Studio (Administrator)")
height = oAutoItX.WinGetClientSizeHeight("IronPythonApplication1 - Microsoft Visual Studio (Administrator)")

print width, height

print('Hello world')