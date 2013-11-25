import sys
import clr


clr.AddReference("IronAHK.Rusty")



# next is only half cause needs message loop and freaking hard to invoke
from IronAHK.Rusty.Core import Gui, GuiControl

Gui("Add","GroupBox", "w255 r3 Section", "Select")
Gui("Add", "Text", "xs+10 ys+25 Section", "Time:")
Gui("Add", "Edit", "vTimeValue ys-2 Limit3 gValidate","")
Gui("Add", "UpDown", "vTime Range1-60", "10")
Gui("Add", "Radio", "vSecs", "Seconds")
Gui("Add", "Radio", "vMins xp+65 yp Checked", "Minutes")
Gui("Font", "bold","","")
Gui("Add", "Button", "vRun ys-4 w65 Default gRun", "Start")
Gui( "Font","","","")
Gui("Add", "GroupBox", "xm w255 r4 Section", "Progress")
Gui("Font", "s24 bold", "Calibri","")
Gui("Add", "Text", "vCount xs+10 ys+20 w235 Center", "00:00")
Gui("Add", "Progress", "vProgress wp r0.5 -Smooth","")
Gui( "Font","","","")
GuiControl("Focus","Time", "")
Gui("Show","", "Countdown Timer", "") 


from IronAHK.Rusty.Core import Run, WinWaitActive, Send, WinClose

# out parameter in C# is bad for python
# does not works, but work of AutoItX
r = clr.Reference[int]()
Run("notepad.exe", "","min",r)
WinWaitActive("Untitled - Notepad")
Send("This is some text.")
WinClose("Untitled - Notepad")
WinWaitActive("Notepad", "Save")
#WinWaitActive("Notepad", "Do you want to save") # for windows xp
Send("!n")