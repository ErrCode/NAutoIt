from pyautoit import AutoIt



class Excel(object):
  def __init__(self):    
     self.aut = AutoIt()

  def _ExcelBookNew(self, visible = 1):
    oExcel = self.aut.ObjCreate("Excel.Application")
    #TODO: return False, Exception tuple
    #if Not IsObj($oExcel) Then Return SetError(1, 0, 0)
    #if Not IsNumber($fVisible) Then Return SetError(2, 0, 0)
    if visible > 1: visible = 1
    if visible < 0: visible = 0
    oExcel.Visible = visible
    oExcel.WorkBooks.Add()
    oExcel.ActiveWorkbook.Sheets(1).Select()
    return oExcel


