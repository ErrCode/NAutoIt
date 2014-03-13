using System;
using System.IO;
using System.Text;
using AutoItX3Lib;

namespace nautoit
{

    public class AutoItX3Wrapper : IAutoItX3
    {
        //NOTE: next works in C# but fails running under IronPython
        private AutoItX3 _com;

        // creates AutoItX without using registy
        // needs manifest and AutoItX dll located in the same folder
        // needs AutoItX has the same version as in manifest
        // python interpereter should of the same bitness as AutoItX (32 can use 32 bit, 64 can use 64 bit dll only)
        public AutoItX3Wrapper(string manifest)
        {
            var clsid = new Guid("{1A671297-FA74-4422-80FA-6C5D8CE4DE04}");
            // creates AutoItX using manifest instead of registry
            var createdViaManifest = NRegFreeCom.ActivationContext.CreateInstanceWithManifest(clsid, manifest);
            _com = (AutoItX3)createdViaManifest;
        }
    


        public void Init()
        {
            throw new NotImplementedException();
        }

           
  
        
        public int AutoItSetOption(string strOption, int nValue)
        {
            throw new NotImplementedException();
        }

        public void BlockInput(int nFlag)
        {
            throw new NotImplementedException();
        }

        public int CDTray(string strDrive, string strAction)
        {
            throw new NotImplementedException();
        }

        public string ClipGet()
        {
            throw new NotImplementedException();
        }

        public void ClipPut(string strClip)
        {
            throw new NotImplementedException();
        }

        public int ControlClick(string strTitle, string strText, string strControl, string strButton = "LEFT", int nNumClicks = 1,
                                int nX = -2147483647, int nY = -2147483647)
        {
            throw new NotImplementedException();
        }

        public string ControlCommand(string strTitle, string strText, string strControl, string strCommand, string strExtra)
        {
            throw new NotImplementedException();
        }

        public int ControlDisable(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public int ControlEnable(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public int ControlFocus(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public string ControlGetFocus(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public string ControlGetHandle(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public int ControlGetPosX(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public int ControlGetPosY(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public int ControlGetPosHeight(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public int ControlGetPosWidth(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public string ControlGetText(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public int ControlHide(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public string ControlListView(string strTitle, string strText, string strControl, string strCommand, string strExtra1,
                                      string strExtra2)
        {
            throw new NotImplementedException();
        }

        public int ControlMove(string strTitle, string strText, string strControl, int nX, int nY, int nWidth = -1, int nHeight = -1)
        {
            throw new NotImplementedException();
        }

        public int ControlSend(string strTitle, string strText, string strControl, string strSendText, int nMode = 0)
        {
            throw new NotImplementedException();
        }

        public int ControlSetText(string strTitle, string strText, string strControl, string strControlText)
        {
            throw new NotImplementedException();
        }

        public int ControlShow(string strTitle, string strText, string strControl)
        {
            throw new NotImplementedException();
        }

        public string ControlTreeView(string strTitle, string strText, string strControl, string strCommand, string strExtra1,
                                      string strExtra2)
        {
            throw new NotImplementedException();
        }

        public string DriveMapAdd(string strDevice, string strShare, int nFlags = 0, string strUser = "", string strPwd = "")
        {
            throw new NotImplementedException();
        }

        public int DriveMapDel(string strDevice)
        {
            throw new NotImplementedException();
        }

        public string DriveMapGet(string strDevice)
        {
            throw new NotImplementedException();
        }

        public int IniDelete(string strFilename, string strSection, string strKey = "")
        {
            throw new NotImplementedException();
        }

        public string IniRead(string strFilename, string strSection, string strKey, string strDefault)
        {
            throw new NotImplementedException();
        }

        public int IniWrite(string strFilename, string strSection, string strKey, string strValue)
        {
            throw new NotImplementedException();
        }

        public int IsAdmin()
        {
            throw new NotImplementedException();
        }

        public int MouseClick(string strButton = "LEFT", int nX = -2147483647, int nY = -2147483647, int nClicks = 1, int nSpeed = -1)
        {
            throw new NotImplementedException();
        }

        public int MouseClickDrag(string strButton, int nX1, int nY1, int nX2, int nY2, int nSpeed = -1)
        {
            throw new NotImplementedException();
        }

        public void MouseDown(string strButton = "LEFT")
        {
            throw new NotImplementedException();
        }

        public int MouseGetCursor()
        {
            throw new NotImplementedException();
        }

        public int MouseGetPosX()
        {
            throw new NotImplementedException();
        }

        public int MouseGetPosY()
        {
            throw new NotImplementedException();
        }

        public int MouseMove(int nX, int nY, int nSpeed = -1)
        {
            throw new NotImplementedException();
        }

        public void MouseUp(string strButton = "LEFT")
        {
            throw new NotImplementedException();
        }

        public void MouseWheel(string strDirection, int nClicks = 1)
        {
            throw new NotImplementedException();
        }

        public int Opt(string strOption, int nValue)
        {
            throw new NotImplementedException();
        }

        public double PixelChecksum(int nLeft, int nTop, int nRight, int nBottom, int nStep = 1)
        {
            throw new NotImplementedException();
        }

        public int PixelGetColor(int nX, int nY)
        {
            throw new NotImplementedException();
        }

        public object PixelSearch(int nLeft, int nTop, int nRight, int nBottom, int nCol, int nVar = 0, int nStep = 1)
        {
            throw new NotImplementedException();
        }

        public int ProcessClose(string strProcess)
        {
            throw new NotImplementedException();
        }

        public int ProcessExists(string strProcess)
        {
            throw new NotImplementedException();
        }

        public int ProcessSetPriority(string strProcess, int nPriority)
        {
            throw new NotImplementedException();
        }

        public int ProcessWait(string strProcess, int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public int ProcessWaitClose(string strProcess, int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public int RegDeleteKey(string strKeyname)
        {
            throw new NotImplementedException();
        }

        public int RegDeleteVal(string strKeyname, string strValuename)
        {
            throw new NotImplementedException();
        }

        public string RegEnumKey(string strKeyname, int nInstance)
        {
            throw new NotImplementedException();
        }

        public string RegEnumVal(string strKeyname, int nInstance)
        {
            throw new NotImplementedException();
        }

        public string RegRead(string strKeyname, string strValuename)
        {
            throw new NotImplementedException();
        }

        public int RegWrite(string strKeyname, string strValuename, string strType, string strValue)
        {
            throw new NotImplementedException();
        }

        public int Run(string strRun, string strDir = "", int nShowFlags = 1)
        {
            return _com.Run(strRun, strDir, nShowFlags);
        }

        public int RunAsSet(string strUser, string strDomain, string strPassword, int nOptions)
        {
            throw new NotImplementedException();
        }

        public int RunWait(string strRun, string strDir = "", int nShowFlags = 1)
        {
            throw new NotImplementedException();
        }

        public void Send(string strSendText, int nMode = 0)
        {
            throw new NotImplementedException();
        }

        public int Shutdown(int nFlags)
        {
            throw new NotImplementedException();
        }

        public void Sleep(int nMilliseconds)
        {
            throw new NotImplementedException();
        }

        public string StatusbarGetText(string strTitle, string strText = "", int nPart = 1)
        {
            throw new NotImplementedException();
        }

        public void ToolTip(string strTip, int nX = -2147483647, int nY = -2147483647)
        {
            throw new NotImplementedException();
        }

        public void WinActivate(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinActive(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinClose(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinExists(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinGetCaretPosX()
        {
            throw new NotImplementedException();
        }

        public int WinGetCaretPosY()
        {
            throw new NotImplementedException();
        }

        public string WinGetClassList(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinGetClientSizeHeight(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinGetClientSizeWidth(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public string WinGetHandle(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinGetPosX(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinGetPosY(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinGetPosHeight(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinGetPosWidth(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public string WinGetProcess(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinGetState(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public string WinGetText(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public string WinGetTitle(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinKill(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public object WinList(string strTitle, string strText = "")
        {
            throw new NotImplementedException();
        }

        public int WinMenuSelectItem(string strTitle, string strText, string strItem1, string strItem2 = "", string strItem3 = "",
                                     string strItem4 = "", string strItem5 = "", string strItem6 = "", string strItem7 = "",
                                     string strItem8 = "")
        {
            throw new NotImplementedException();
        }

        public void WinMinimizeAll()
        {
            throw new NotImplementedException();
        }

        public void WinMinimizeAllUndo()
        {
            throw new NotImplementedException();
        }

        public int WinMove(string strTitle, string strText, int nX, int nY, int nWidth = -1, int nHeight = -1)
        {
            throw new NotImplementedException();
        }

        public int WinSetOnTop(string strTitle, string strText, int nFlag)
        {
            throw new NotImplementedException();
        }

        public int WinSetState(string strTitle, string strText, int nFlags)
        {
            throw new NotImplementedException();
        }

        public int WinSetTitle(string strTitle, string strText, string strNewTitle)
        {
            throw new NotImplementedException();
        }

        public int WinSetTrans(string strTitle, string strText, int nTrans)
        {
            throw new NotImplementedException();
        }

        public int WinWait(string strTitle, string strText = "", int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public int WinWaitActive(string strTitle, string strText = "", int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public int WinWaitClose(string strTitle, string strText = "", int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public int WinWaitNotActive(string strTitle, string strText = "", int nTimeout = 0)
        {
            throw new NotImplementedException();
        }

        public int error { get; private set; }
        public int SW_HIDE { get; private set; }
        public int SW_MAXIMIZE { get; private set; }
        public int SW_MINIMIZE { get; private set; }
        public int SW_RESTORE { get; private set; }
        public int SW_SHOW { get; private set; }
        public int SW_SHOWDEFAULT { get; private set; }
        public int SW_SHOWMAXIMIZED { get; private set; }
        public int SW_SHOWMINIMIZED { get; private set; }
        public int SW_SHOWMINNOACTIVE { get; private set; }
        public int SW_SHOWNA { get; private set; }
        public int SW_SHOWNOACTIVATE { get; private set; }
        public int SW_SHOWNORMAL { get; private set; }
        public string version { get; private set; }
    }


}
