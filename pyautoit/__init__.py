import clr
import System
import sys


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
      import  NRegFreeCom.ActivationContext
      import  AutoItX3Lib

      # creates AutoItX using manifest instead of registy
      obj = NRegFreeCom.ActivationContext.CreateInstanceWithManifest(System.Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}"),autoItXManifest) 
      
      #clsid = System.Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}")
      #assemblies = NRegFreeCom.AssemblySystem()
      #module = assemblies.LoadFrom("I:/src/pyautoit/AutoItX3.dll")
      #obj = NRegFreeCom.ActivationContext.CreateInstanceDirectly(module, clsid)
      self.com  =  clr.Convert(obj, AutoItX3Lib.IAutoItX3)
      




  def del__(self):
      System.Runtime.InteropServices.Marshal.FinalReleaseComObject(self.com)

  def Run(self, program, workingdir = "", show_flag= 1, opt_flag = None):
      if opt_flag is None:
        return self.com.Run(program, workingdir,show_flag)
      else: 
        return self.com.Run(program, workingdir,show_flag,opt_flag) 



  def Send(self,keys):
    return self.com.Send(keys)

  def WinClose(self,title):
    return self.com.WinClose(title)

  def WinWaitActive(self, title = None, text = None):
      if text is None:
        return self.com.WinWaitActive(title) 
      else:
        return self.com.WinWaitActive(title,text) 

  def MsgBox(self, flag, title,text):
    # use some python lib to show message box - in this case Windows API
    import ctypes
    MessageBox = ctypes.windll.user32.MessageBoxW
    MessageBox(None, title, text,flag)
  



