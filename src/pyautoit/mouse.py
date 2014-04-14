
import clr
clr.AddReferenceToFile("nautoit.dll")     
from nautoit import au

au.MouseMove(10, 100) # Move the mouse cursor to the x, y position of 10, 100.
au.MouseMove(700, 700, 0) # Move the mouse cursor to the x, y position of 700, 700 and move instantly.
