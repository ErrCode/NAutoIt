from pyautoit import AutoIt

# creates AutoItX without using registy
# needs manifest and AutoItX dll located in the same folder
# needs AutoItX has the same version as in manifest
# python interpereter should of the same bitness as AutoItX (32 can use 32 bit, 64 can use 64 bit dll only)
auto = AutoIt("i:\\src\\pyautoit\\AutoIt3Dependency.manifest","i:\\src\\pyautoit\\")    
  
auto.Run("notepad.exe")
auto.WinWaitActive("Untitled - Notepad")
auto.Send("This is some text.")
auto.WinClose("Untitled - Notepad")
auto.WinWaitActive("Notepad", "Save")
#auto.WinWaitActive("Notepad", "Do you want to save") # for windows xp
auto.Send("!n")