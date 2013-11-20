import clr
import System
import sys


class AutoIt(object):
  """ Creates and returns AutoItX Object """
  def __init__(self,autoItXManifest = None,dllLocation = None):
    if autoItXManifest == None and dllLocation == None:      
      comType = System.Type.GetTypeFromProgID("AutoItX3.Control")
      self.com = System.Activator.CreateInstance(type = comType) 
    else:
      # load reg free com invocation facilities
      sys.path.append(dllLocation)
      clr.AddReferenceToFile("NRegFreeCom.dll")
      import  NRegFreeCom.ActivationContext
    
      # creates AutoItX using manifest instead of registy
      #next fails for some reason
      self.com = NRegFreeCom.ActivationContext.CreateInstanceWithManifest(System.Guid.Parse("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}"),autoItXManifest) 
      
      
      #def OtherMethod():
      #   clr.AddReference('System.Core')
      #   clr.AddReferenceToFile("AutoItX3Lib.dll")
      #   self.com = AutoItX3()
      #NRegFreeCom.UsingManifestDo(autoItXManifest,NRegFreeCom.ActivationContext.doSomething(OtherMethod) )



  def del__(self):
      System.Runtime.InteropServices.Marshal.FinalReleaseComObject(self.com)

  def Run(self, program, workingdir = None, show_flag= None, opt_flag = None):
      if workingdir is None:
        return self.com.Run(program)
      elif show_flag is None:
        return self.com.Run(program, workingdir)
      elif opt_flag is None:
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
  



