pyautoit
===========

Simply calling AutoItX from IronPython


```python
from pyautoit import AutoIt

auto = AutoIt()     
 
auto.Run("notepad.exe")
auto.WinWaitActive("Untitled - Notepad")
auto.Send("This is some text.")
auto.WinClose("Untitled - Notepad")
auto.WinWaitActive("Notepad", "Save")
#auto.WinWaitActive("Notepad", "Do you want to save") # for windows xp
auto.Send("!n")
```

```python
from pyautoit import AutoIt

auto = AutoIt()
# AutoItX does not provides this method, replaced via some python equivalent
auto.MsgBox(64, "Tutorial", "Hello World!")
```

