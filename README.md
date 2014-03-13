pyautoit
===========

Calling AutoIt from IronPython


```python
from pyautoit import AutoIt

au = AutoIt()     
 
au.Run("notepad.exe")
au.WinWaitActive("Untitled - Notepad")
au.Send("This is some text.")
au.WinClose("Untitled - Notepad")
au.WinWaitActive("Notepad", "Save")
#au.WinWaitActive("Notepad", "Do you want to save") # for windows xp
au.Send("!n")
```

```python
from pyautoit import AutoIt

au = AutoIt()
au.MsgBox(64, "Tutorial", "Hello World!")
```

Design
===
- exception raised from method when `@error` detected or returned 
- return (False, Exception) tuple when better not to throw exception (e.g. performance)

// This generator is used cause IronPython uses reflection(IDispatch) for invocation of COM interfaces even if object was type casted to interop interfaces
       // Which fails to work if using AutoItX COM without registration http://stackoverflow.com/questions/9209910/how-to-use-registration-free-com-dll-in-dot-net/9229764?noredirect=1#comment29983358_9229764
        // Generator creates reflectionable(late binding invocable) C# wrapper above unreflectionable COM object from declaration of COM interop
    	// python interpereter should of the same bitness as AutoItX (32 can use 32 bit, 64 can use 64 bit dll only)






