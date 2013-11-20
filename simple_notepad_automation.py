from pyautoit import AutoIt

auto = AutoIt()      

auto.Run("notepad.exe")
auto.WinWaitActive("Untitled - Notepad")
auto.Send("This is some text.")
auto.WinClose("Untitled - Notepad")
auto.WinWaitActive("Notepad", "Save")
auto.WinWaitActive("Notepad", "Do you want to save") 
auto.Send("!n")


