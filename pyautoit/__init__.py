import clr
import System
import sys
from System.Runtime.InteropServices import Marshal
from System import Activator, Type

class AutoIt(object):
  """ Creates and returns AutoItX Object """
  def __init__(self,autoItXManifest = None):
    if autoItXManifest == None:      
      comType = System.Type.GetTypeFromProgID("AutoItX3.Control")
      self.com = System.Activator.CreateInstance(type = comType) 
    else:
      # load reg free com invocation facilities      
      clr.AddReferenceToFile("NRegFreeCom.dll")
      clr.AddReferenceToFile("AutoItX3Lib.dll")
      clr.AddReferenceToFile("nautoit.dll")
      import  NRegFreeCom.ActivationContext
      import  AutoItX3Lib
      import nautoit  
      self.com  =  nautoit.AutoItX3Wrapper()    




  def del__(self):
      if System.Runtime.InteropServices.Marshal.IsComObject(self.com):
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(self.com)

  def ObjCreate(self,className):
    oType = Type.GetTypeFromProgID (className);
    return Activator.CreateInstance(oType)

  def Run(self, program, workingdir = "", show_flag= 1, opt_flag = None):
      if opt_flag is None:
        return self.com.Run(program, workingdir,show_flag)
      else: 
        return self.com.Run(program, workingdir,show_flag,opt_flag) 



  def Send(self,keys):
    return self.com.Send(keys)


  def Sleep(self, timeout):
    return self.com.Sleep(timeout)

  def WinActivate(self, title,  text = ""):
    return self.com.WinActivate(title,text)

  def WinClose(self,title):
    return self.com.WinClose(title)

  def WinWaitActive(self, title , text = "",nTimeout = 0):
    return self.com.WinWaitActive(title,text,nTimeout) 

  def MsgBox(self, flag, title,text):
    # use some python lib to show message box - in this case Windows API
    import ctypes
    MessageBox = ctypes.windll.MessageBoxW
    MessageBox(None, title, text,flag)
  



