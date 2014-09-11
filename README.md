NAutoIt
===========

AutoItX NuGet package
===
Use F# interactive to create package

- `scripts\get.fs`
- `scripts\autoit.fs`

NAutoIt
===

.NET and IronPython view onto AutoItX:

- Human comprehencible exception raised from method when `@error` detected or returned 
- Return (False, Exception) tuple when better not to throw exception (e.g. performance)
- Methods available to AutoIt `BASIC`, but not provided via AutoItX, are replaced by .NET counterparts
- `BASIC` scripts which distibuted with AutoIt are reimplemented in IronPython, compiled to module (TODO)
- All methods are IronPython friendly
- TODO: not all methods are covered and thor NotImplementedException

`AutoItX3_x64.dll` or `AutoItX3.dll` should be located in the same folder as `nautoit.dll`
 
All code here is written in `SharpDevelop 4.4`.
 
**IronPython** interpereter should of the same bitness as AutoItX (32 can use 32 bit, 64 can use 64 bit dll only)

Calling AutoIt from IronPython
===
```python
import clr
clr.AddReferenceToFile("nautoit.dll")     
from nautoit import au  
 
au.Run("notepad.exe")
au.WinWaitActive("Untitled - Notepad")
au.Send("This is some text.")
au.WinClose("Untitled - Notepad")
au.WinWaitActive("Notepad", "Save")
#au.WinWaitActive("Notepad", "Do you want to save") # for windows xp
au.Send("!n")
```

```python
import clr
clr.AddReferenceToFile("nautoit.dll")     
from nautoit import au

au = AutoIt()
au.MsgBox(64, "Tutorial", "Hello World!")
```

You can use use avalable .NET techs like MS UI Automation or White if needed
---

```python
import sys
import os
import clr

clr.AddReferenceToFile("nautoit.dll")   

clr.AddReferenceToFile("TestStack.White.dll")     

from nautoit import au
from  TestStack.White import Application
from  TestStack.White.InputDevices import Keyboard

application = Application.Launch("notepad.exe");
window = application.GetWindow("Untitled - Notepad");
window.Focus()
Keyboard.Instance.Enter("This is some text.");
window.Close()
#Allows step by step migration from AutoIt to anything else
close = au.WinWaitActive("Notepad", "Save")
au.Send("!n")
```

I run scripts like that:
```
i:\src\OpenSharp\NAutoIt\build>"c:\Program Files (x86)\IronPython 2.7\ipy.exe" my_first_script.py

i:\src\OpenSharp\NAutoIt\build>"c:\Program Files (x86)\IronPython 2.7\ipy.exe" mouse.py

i:\src\OpenSharp\NAutoIt\build>"c:\Program Files (x86)\IronPython 2.7\ipy.exe" simple_notepad_automation.py
```

Notes
===
- IronPython uses reflection(IDispatch) for invocation of COM interfaces even if object was type casted to interop interfaces.
Which fails to work if using AutoItX COM without registration [1].


Why Python
===
- IronPython allows easier migration from AutoIt and `BASIC` to more modern testing tools and languages
- Python is widely used language in testing [2].
- Python has great pool of developers and other people (e.g. data scientists )
- Writing all in Python will allow to create some abstract modules which represend **logic of test** abstracted of underlying UI technology.
- Unlike C# it is much easirer to develop, tune in runtime and read, which suits more for tests.
- There are **free** Python IDEs to author tests.
- Allows running Cherking Python to allow write **bussiness readable user** steps to allow bussiness users to participate. This steps guide and frame tests allowing greate level of sustainability.[3]

Example
----
Business logic:
```gherkin
Then rows are sorted by 'Count' 
```

Test logic agains abstract table (obtained from service, from Windows or HTML UI):
```
@then('rows are sorted by "{name}"')
def step_impl(context,name):
    assert context.table[name].sorted is True
```

[1]: http://stackoverflow.com/questions/9209910/how-to-use-registration-free-com-dll-in-dot-net/9229764?noredirect=1#comment29983358_9229764 
[2]: https://www.diigo.com/list/dzmitry_lahoda/Python+UI+Automation/2tiwxcs10
[3]: https://github.com/cucumber/cucumber/wiki/Gherkin




TODO
===

* compile Excel and other modules to dll