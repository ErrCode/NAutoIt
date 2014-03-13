import clr
clr.AddReference("System")
clr.AddReferenceToFile("nautoit.dll")     
from nautoit import au
     
au.Run("notepad.exe")
au.WinWaitActive("Untitled - Notepad")
au.Send("This is some text.")
au.WinClose("Untitled - Notepad")
au.WinWaitActive("Notepad", "Save")
#auto.WinWaitActive("Notepad", "Do you want to save") # for windows xp
au.Send("!n")

