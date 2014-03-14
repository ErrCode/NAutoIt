
#IronPython case use other .NET testing framework which depend on MS UI Automation, can call Automation directly

import sys
import os
path = os.path.dirname(__file__)

sys.path.append(os.getcwd()+"/packages/Castle.Core.3.2.2/lib/net35")
sys.path.append(os.getcwd()+"/packages/TestStack.White.0.12.0/lib/net40")
import clr
clr.AddReference("System")
clr.AddReference("System.Core")
clr.AddReference("System.Windows.Forms")
clr.AddReferenceToFile("Castle.Core.dll")
clr.AddReferenceToFile("TestStack.White.dll")     

from  TestStack.White import Application
from  TestStack.White.InputDevices import Keyboard

application = Application.Launch("notepad.exe");
window = application.GetWindow("Untitled - Notepad");
window.Focus()
Keyboard.Instance.HoldKey(White.Core.WindowsAPI.KeyboardInput.SpecialKeys.CONTROL);
Keyboard.Instance.Enter("E");
window.Close()