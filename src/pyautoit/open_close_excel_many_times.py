
import clr
clr.AddReferenceToFile("nautoit.dll")    
import sys
import time
import random 
from nautoit import au

excelName = "[CLASS:XLMAIN]"

print ('Press CTRL+C to stop')

iters = 50

for i in range(1,iters): 
  print	"Opening Excel ", i
  excelProcess = au.Run("C:/Program Files (x86)/MSOffice/Office14/Excel.exe")
  waitTime = random.randint(1,10) 
  print "Waiting ", waitTime
  time.sleep(waitTime)
  print	"Closing Excel ", i
  au.WinClose(excelName)
  waitTime = random.randint(1,10) 
  print "Waiting ", waitTime
  #TODO: check and kill zombie excelProcess
  #TODO: check daemon zombie process
  time.sleep(waitTime)
