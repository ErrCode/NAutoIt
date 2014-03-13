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








