from pyautoit import AutoIt

auto = AutoIt("AutoItX3Dependency.manifest")

def StartExcel():    
    excel = auto.ObjCreate("Excel.Application")
    # Set Excel visible and create a new worksheet
    excel.Visible = 1
    auto.Send("^n")

    # Wait for Excel to be ready, then activate it, then wait a tiny bit longer for the addons to finish loading
    auto.WinWaitActive("Microsoft Excel", "" , 30)
    auto.WinActivate("Microsoft Excel")
    auto.Sleep(1000)
    return excel

def _ExcelBookNew(visible = 1):
	oExcel = auto.ObjCreate("Excel.Application")
	#if Not IsObj($oExcel) Then Return SetError(1, 0, 0)
	#if Not IsNumber($fVisible) Then Return SetError(2, 0, 0)
	if visible > 1: visible = 1
	if visible < 0: visible = 0
	oExcel.Visible = visible
	oExcel.WorkBooks.Add()
	oExcel.ActiveWorkbook.Sheets(1).Select()
	return oExcel

_ExcelBookNew()
    