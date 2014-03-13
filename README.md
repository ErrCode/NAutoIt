NAutoIt
===========


*AutoItX3_x64.dll or AutoItX3.dll should be located in the same folder as nautoit.dll"
 
*IronPython* interpereter should of the same bitness as AutoItX (32 can use 32 bit, 64 can use 64 bit dll only)

Calling AutoIt from IronPython.



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

Design
===
- Exception raised from method when `@error` detected or returned 
- return (False, Exception) tuple when better not to throw exception (e.g. performance)

- IronPython uses reflection(IDispatch) for invocation of COM interfaces even if object was type casted to interop interfaces.
Which fails to work if using AutoItX COM without registration[1].

[1] http://stackoverflow.com/questions/9209910/how-to-use-registration-free-com-dll-in-dot-net/9229764?noredirect=1#comment29983358_9229764 







