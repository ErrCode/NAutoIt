
import clr
clr.AddReferenceToFile("nautoit.dll")     
from nautoit import au

# AutoIt(X) does not provides this method, replaced via some equivalent
au.MsgBox(64, "Tutorial", "Hello World!")