import clr
import System
import sys
clr.AddReferenceToFile("nautoit.dll")     
from System import Activator, Type
from nautoit import autoitrt as au

class AutoIt(object):
  """ Creates and returns AutoItX Object """
  def __init__(self):    
     au.Init()

  def ObjCreate(self,className):
    oType = Type.GetTypeFromProgID(className)
    return Activator.CreateInstance(oType)

  def Run(self, program, workingdir = "", show_flag= 1, opt_flag = None):
      if opt_flag is None:
        return au.Run(program, workingdir,show_flag)
      else: 
        return au.Run(program, workingdir,show_flag,opt_flag) 

  def Send(self,keys):
    return au.Send(keys)

  def WinWait(self, title,  text = "", timeout = 0):
      return au.WinWait(title,text,timeout)

  def WinWaitClose(self,title,  text = "", timeout = 0):
      return au.WinWaitClose(title,text,timeout)
    
  def Sleep(self, timeout):
    return au.Sleep(timeout)

  def WinActivate(self, title,  text = ""):
    return au.WinActivate(title,text)

  def WinClose(self,title):
    return au.WinClose(title)

  def WinWaitActive(self, title , text = "",nTimeout = 0):
    return au.WinWaitActive(title,text,nTimeout) 

  def MsgBox(self, flag, title,text):
    # use some python lib to show message box - in this case Windows API
    # AutoItX does not provides this method
    import ctypes
    MessageBox = ctypes.windll.LoadLibrary("User32.dll").MessageBoxW
    MessageBox(None, title, text,flag)
  
