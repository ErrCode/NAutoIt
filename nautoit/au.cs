using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace nautoit
{
    public static class au
    {
        static au()
        {
            NativeMethods_32.AU3_Init();
        }

        public static int AutoItSetOption(string strOption, int nValue)
        {
            return NativeMethods_32.AU3_AutoItSetOption(strOption, nValue);
        }

        public static void BlockInput(int nFlag)
        {
            NativeMethods_32.AU3_BlockInput(nFlag);
        }

        public static int CDTray(string strDrive, string strAction)
        {
            return NativeMethods_32.AU3_CDTray(strDrive, strAction);
        }

        public static string ClipGet()
        {
            throw new NotImplementedException();
        }

        public static void ClipPut(string strClip)
        {
            throw new NotImplementedException();
        }

        public static int ControlClick(string strTitle, string strText, string strControl, string strButton = "LEFT", int nNumClicks = 1,
                                int nX = -2147483647, int nY = -2147483647)
        {
            return NativeMethods_32.AU3_ControlClick(strTitle, strTitle, strControl, strButton, nNumClicks, nX, nY);
        }

        public static string ControlCommand(string strTitle, string strText, string strControl, string strCommand, string strExtra)
        {
            var bBufSize = 1000;
            var szResult = new StringBuilder(bBufSize);
            NativeMethods_32.AU3_ControlCommand(strTitle, strTitle, strControl, strCommand, strExtra, szResult, bBufSize);
            return szResult.ToString();
        }

        public static int ControlDisable(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static int ControlEnable(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static int ControlFocus(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static string ControlGetFocus(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static string ControlGetHandle(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static int ControlGetPosX(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static int ControlGetPosY(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static int ControlGetPosHeight(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static int ControlGetPosWidth(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static string ControlGetText(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static int ControlHide(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static string ControlListView(string strTitle, string strText, string strControl, string strCommand, string strExtra1,
                                      string strExtra2)
        {
            throw new NotImplementedException();
        }

        public static int ControlMove(string strTitle, string strText, string strControl, int nX, int nY, int nWidth = -1, int nHeight = -1)
        {
            throw new NotImplementedException();
        }

        public static int ControlSend(string strTitle, string strText, string strControl, string strSendText, int nMode = 0)
        {
            throw new NotImplementedException();
        }

        public static int ControlSetText(string strTitle, string strText, string strControl, string strControlText)
        {
            throw new NotImplementedException();
        }

        public static int ControlShow(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public static string ControlTreeView(string strTitle, string strText, string strControl, string strCommand, string strExtra1,
                                      string strExtra2)
        {
            throw new NotImplementedException();
        }

        public static string DriveMapAdd(string strDevice, string strShare, int nFlags = 0, string strUser = "", string strPwd = "")
        {
            throw new NotImplementedException();
        }

        public static int DriveMapDel(string strDevice)
        {
            throw new NotImplementedException();
        }

        public static string DriveMapGet(string strDevice)
        {
            throw new NotImplementedException();
        }

        public static int IniDelete(string strFilename, string strSection, string strKey = "")
        {
            throw new NotImplementedException();
        }

        public static string IniRead(string strFilename, string strSection, string strKey, string strDefault)
        {
            throw new NotImplementedException();
        }

        public static int IniWrite(string strFilename, string strSection, string strKey, string strValue)
        {
            throw new NotImplementedException();
        }

        public static int IsAdmin()
        {
            throw new NotImplementedException();
        }

        public static int MouseClick(string strButton = "LEFT", int nX = -2147483647, int nY = -2147483647, int nClicks = 1, int nSpeed = -1)
        {
            throw new NotImplementedException();
        }

        public static int MouseClickDrag(string strButton, int nX1, int nY1, int nX2, int nY2, int nSpeed = -1)
        {
            throw new NotImplementedException();
        }

        public static void MouseDown(string strButton = "LEFT")
        {
            throw new NotImplementedException();
        }

        public static int MouseGetCursor()
        {
            throw new NotImplementedException();
        }

        public static int MouseGetPosX()
        {
            throw new NotImplementedException();
        }

        public static int MouseGetPosY()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the mouse pointer.
        /// </summary>
        /// <param name="x">The screen x coordinate to move the mouse to.</param>
        /// <param name="y">The screen y coordinate to move the mouse to.</param>
        /// <param name="speed">the speed to move the mouse in the range 1 (fastest) to 100 (slowest). A speed of 0 will move the mouse instantly. Default speed is 10.</param>
        /// <returns></returns>
        public static int MouseMove(int x, int y, int speed = 10)
        {
        	return NativeMethods_32.AU3_MouseMove(x,y,speed);
        }

        public static void MouseUp(string strButton = "LEFT")
        {
            throw new NotImplementedException();
        }

        public static void MouseWheel(string strDirection, int nClicks = 1)
        {
            throw new NotImplementedException();
        }

        public static int Opt(string strOption, int nValue)
        {
            throw new NotImplementedException();
        }

        public static double PixelChecksum(int nLeft, int nTop, int nRight, int nBottom, int nStep = 1)
        {
            throw new NotImplementedException();
        }

        public static int PixelGetColor(int nX, int nY)
        {
            throw new NotImplementedException();
        }

        public static object PixelSearch(int nLeft, int nTop, int nRight, int nBottom, int nCol, int nVar = 0, int nStep = 1)
        {
            throw new NotImplementedException();
        }

        public static int ProcessClose(string strProcess)
        {
            throw new NotImplementedException();
        }

        public static int ProcessExists(string strProcess)
        {
            throw new NotImplementedException();
        }

        public static int ProcessSetPriority(string strProcess, int nPriority)
        {
            throw new NotImplementedException();
        }

        public static int ProcessWait(string strProcess, int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public static int ProcessWaitClose(string strProcess, int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public static int RegDeleteKey(string strKeyname)
        {
            return NativeMethods_32.AU3_RegDeleteKey(strKeyname);
        }

        public static int RegDeleteVal(string strKeyname, string strValuename)
        {
            return NativeMethods_32.AU3_RegDeleteVal(strKeyname, strValuename);
        }

        public static string RegEnumKey(string strKeyname, int nInstance)
        {
            throw new NotImplementedException();
        }

        public static string RegEnumVal(string strKeyname, int nInstance)
        {
            throw new NotImplementedException();
        }

        public static string RegRead(string strKeyname, string strValuename)
        {
            throw new NotImplementedException();
        }

        public static int RegWrite(string strKeyname, string strValuename, string strType, string strValue)
        {
            throw new NotImplementedException();
        }

        public static int Run(string strRun, string strDir = "", int nShowFlags = 1)
        {
            var result = NativeMethods_32.AU3_Run(strRun, strDir, nShowFlags);
            if (result == 0)
            	throw new AutoItException("@error",NativeMethods_32.AU3_error());
            return result;
        }

        public static int RunAsSet(string strUser, string strDomain, string strPassword, int nOptions)
        {
            throw new NotImplementedException();
        }

        public static int RunWait(string strRun, string strDir = "", int nShowFlags = 1)
        {
            throw new NotImplementedException();
        }
        
        public static object ObjCreate(string className){
            Type oType = Type.GetTypeFromProgID(className);	
            return Activator.CreateInstance(oType);
        }
        
        [DllImportAttribute("user32.dll", CharSet=CharSet.Auto)]
        private static extern uint MessageBox(IntPtr hWnd, String text, String caption, int options);
        
        public static uint MsgBox(int flag, string title,string text,int options = 0,long hwnd = 0){
	        // AutoIt(X) does not provides this method
	        var result = MessageBox(new IntPtr(hwnd),text,title,flag);
	        return result;
         }
    


        public static void Send(string strSendText, int nMode = 0)
        {
            NativeMethods_32.AU3_Send(strSendText, nMode);
        }

        public static int Shutdown(int nFlags)
        {
            throw new NotImplementedException();
        }

        public static void Sleep(int nMilliseconds)
        {
            NativeMethods_32.AU3_Sleep(nMilliseconds);
        }

        public static string StatusbarGetText(string strTitle, string strText = "", int nPart = 1)
        {
            throw new NotImplementedException();
        }

        public static void ToolTip(string strTip, int nX = -2147483647, int nY = -2147483647)
        {
            throw new NotImplementedException();
        }

        public static void WinActivate(string strTitle, string strText = "")
        {
            NativeMethods_32.AU3_WinActivate(strTitle, strText);
        }

        public static int WinActive(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinClose(string strTitle, string strText = "")
        {
            return NativeMethods_32.AU3_WinClose(strTitle, strText);
        }

        public static int WinExists(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinGetCaretPosX()
        {
            throw new NotImplementedException();
        }

        public static int WinGetCaretPosY()
        {
            throw new NotImplementedException();
        }

        public static string WinGetClassList(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinGetClientSizeHeight(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinGetClientSizeWidth(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static string WinGetHandle(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinGetPosX(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinGetPosY(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinGetPosHeight(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinGetPosWidth(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static string WinGetProcess(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinGetState(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static string WinGetText(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static string WinGetTitle(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinKill(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static object WinList(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public static int WinMenuSelectItem(string strTitle, string strText, string strItem1, string strItem2 = "", string strItem3 = "",
                                     string strItem4 = "", string strItem5 = "", string strItem6 = "", string strItem7 = "",
                                     string strItem8 = "")
        {
            throw new NotImplementedException();
        }

        public static void WinMinimizeAll()
        {
            throw new NotImplementedException();
        }

        public static void WinMinimizeAllUndo()
        {
            throw new NotImplementedException();
        }

        public static int WinMove(string strTitle, string strText, int nX, int nY, int nWidth = -1, int nHeight = -1)
        {
            throw new NotImplementedException();
        }

        public static int WinSetOnTop(string strTitle, string strText, int nFlag)
        {
            throw new NotImplementedException();
        }

        public static int WinSetState(string strTitle, string strText, int nFlags)
        {
            throw new NotImplementedException();
        }

        public static int WinSetTitle(string strTitle, string strText, string strNewTitle)
        {
            throw new NotImplementedException();
        }

        public static int WinSetTrans(string strTitle, string strText, int nTrans)
        {
            throw new NotImplementedException();
        }

        public static int WinWait(string strTitle, string strText = "", int nTimeout = 0)
        {
            return NativeMethods_32.AU3_WinWait(strTitle, strText, nTimeout);
        }

        public static int WinWaitActive(string strTitle, string strText = "", int nTimeout = 0)
        {
            return NativeMethods_32.AU3_WinWaitActive(strTitle, strText, nTimeout);
        }

        public static int WinWaitClose(string strTitle, string strText = "", int nTimeout = 0)
        {
            return NativeMethods_32.AU3_WinWaitClose(strTitle, strText, nTimeout);
        }

        public static int WinWaitNotActive(string strTitle, string strText = "", int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public static int error { get { return NativeMethods_32.AU3_error(); } }
        //public static int SW_HIDE { get; private set; }
        //public static int SW_MAXIMIZE { get; private set; }
        //public static int SW_MINIMIZE { get; private set; }
        //public static int SW_RESTORE { get; private set; }
        //public static int SW_SHOW { get; private set; }
        //public static int SW_SHOWDEFAULT { get; private set; }
        //public static int SW_SHOWMAXIMIZED { get; private set; }
        //public static int SW_SHOWMINIMIZED { get; private set; }
        //public static int SW_SHOWMINNOACTIVE { get; private set; }
        //public static int SW_SHOWNA { get; private set; }
        //public static int SW_SHOWNOACTIVATE { get; private set; }
        //public static int SW_SHOWNORMAL { get; private set; }
        //public static string version { get; private set; }

    }
}
