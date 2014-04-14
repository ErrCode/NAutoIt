using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//////////////////////////////////////////////
//GENERATED VIA PINVOKE INTEROP ASSISTANT 1.0
//////////////////////////////////////////////
namespace AutoIt
{

    
    internal partial class NativeConstants
    {

        /// __AUTOIT3_H -> 
        /// Error generating expression: Value cannot be null.
        ///Parameter name: node
        public const string @__AUTOIT3_H = "";

        /// AU3_API -> 
        /// Error generating expression: Value cannot be null.
        ///Parameter name: node
        public const string AU3_API = "";

        /// AU3_INTDEFAULT -> (-2147483647)
        public const int AU3_INTDEFAULT = -2147483647;
    }


    internal partial class NativeMethods_32
    {

        /// Return Type: int
        ///szOption: LPCWSTR->WCHAR*
        ///nValue: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_AutoItSetOption")]
        public static extern int AU3_AutoItSetOption([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szOption, int nValue);





  
        /// Return Type: void
        ///szClip: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ClipGet")]
        public static extern void AU3_ClipGet([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szClip, int nBufSize);


        /// Return Type: void
        ///szClip: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ClipPut")]
        public static extern void AU3_ClipPut([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szClip);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///szButton: LPCWSTR->WCHAR*
        ///nNumClicks: int
        ///nX: int
        ///nY: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlClick")]
        public static extern int AU3_ControlClick([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szButton, int nNumClicks, int nX, int nY);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///szCommand: LPCWSTR->WCHAR*
        ///szExtra: LPCWSTR->WCHAR*
        ///szResult: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlCommand")]
        public static extern void AU3_ControlCommand([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szCommand, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szExtra, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szResult, int nBufSize);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///szCommand: LPCWSTR->WCHAR*
        ///szExtra1: LPCWSTR->WCHAR*
        ///szExtra2: LPCWSTR->WCHAR*
        ///szResult: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlListView")]
        public static extern void AU3_ControlListView([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szCommand, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szExtra1, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szExtra2, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szResult, int nBufSize);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlDisable")]
        public static extern int AU3_ControlDisable([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlEnable")]
        public static extern int AU3_ControlEnable([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlFocus")]
        public static extern int AU3_ControlFocus([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControlWithFocus: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlGetFocus")]
        public static extern void AU3_ControlGetFocus([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szControlWithFocus, int nBufSize);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///szRetText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlGetHandle")]
        public static extern void AU3_ControlGetHandle([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szRetText, int nBufSize);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlGetPosX")]
        public static extern int AU3_ControlGetPosX([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlGetPosY")]
        public static extern int AU3_ControlGetPosY([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlGetPosHeight")]
        public static extern int AU3_ControlGetPosHeight([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlGetPosWidth")]
        public static extern int AU3_ControlGetPosWidth([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///szControlText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlGetText")]
        public static extern void AU3_ControlGetText([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szControlText, int nBufSize);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlHide")]
        public static extern int AU3_ControlHide([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///nX: int
        ///nY: int
        ///nWidth: int
        ///nHeight: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlMove")]
        public static extern int AU3_ControlMove([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, int nX, int nY, int nWidth, int nHeight);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///szSendText: LPCWSTR->WCHAR*
        ///nMode: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlSend")]
        public static extern int AU3_ControlSend([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szSendText, int nMode);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///szControlText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlSetText")]
        public static extern int AU3_ControlSetText([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControlText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlShow")]
        public static extern int AU3_ControlShow([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szControl: LPCWSTR->WCHAR*
        ///szCommand: LPCWSTR->WCHAR*
        ///szExtra1: LPCWSTR->WCHAR*
        ///szExtra2: LPCWSTR->WCHAR*
        ///szResult: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ControlTreeView")]
        public static extern void AU3_ControlTreeView([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szControl, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szCommand, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szExtra1, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szExtra2, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szResult, int nBufSize);


        /// Return Type: void
        ///szDevice: LPCWSTR->WCHAR*
        ///szShare: LPCWSTR->WCHAR*
        ///nFlags: int
        ///szUser: LPCWSTR->WCHAR*
        ///szPwd: LPCWSTR->WCHAR*
        ///szResult: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_DriveMapAdd")]
        public static extern void AU3_DriveMapAdd([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szDevice, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szShare, int nFlags, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szUser, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szPwd, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szResult, int nBufSize);


        /// Return Type: int
        ///szDevice: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_DriveMapDel")]
        public static extern int AU3_DriveMapDel([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szDevice);


        /// Return Type: void
        ///szDevice: LPCWSTR->WCHAR*
        ///szMapping: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_DriveMapGet")]
        public static extern void AU3_DriveMapGet([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szDevice, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szMapping, int nBufSize);


        /// Return Type: int
        ///szFilename: LPCWSTR->WCHAR*
        ///szSection: LPCWSTR->WCHAR*
        ///szKey: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_IniDelete")]
        public static extern int AU3_IniDelete([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szFilename, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szSection, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szKey);


        /// Return Type: void
        ///szFilename: LPCWSTR->WCHAR*
        ///szSection: LPCWSTR->WCHAR*
        ///szKey: LPCWSTR->WCHAR*
        ///szDefault: LPCWSTR->WCHAR*
        ///szValue: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_IniRead")]
        public static extern void AU3_IniRead([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szFilename, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szSection, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szKey, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szDefault, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szValue, int nBufSize);


        /// Return Type: int
        ///szFilename: LPCWSTR->WCHAR*
        ///szSection: LPCWSTR->WCHAR*
        ///szKey: LPCWSTR->WCHAR*
        ///szValue: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_IniWrite")]
        public static extern int AU3_IniWrite([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szFilename, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szSection, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szKey, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szValue);


        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_IsAdmin")]
        public static extern int AU3_IsAdmin();


        /// Return Type: int
        ///szButton: LPCWSTR->WCHAR*
        ///nX: int
        ///nY: int
        ///nClicks: int
        ///nSpeed: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseClick")]
        public static extern int AU3_MouseClick([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szButton, int nX, int nY, int nClicks, int nSpeed);


        /// Return Type: int
        ///szButton: LPCWSTR->WCHAR*
        ///nX1: int
        ///nY1: int
        ///nX2: int
        ///nY2: int
        ///nSpeed: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseClickDrag")]
        public static extern int AU3_MouseClickDrag([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szButton, int nX1, int nY1, int nX2, int nY2, int nSpeed);


        /// Return Type: void
        ///szButton: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseDown")]
        public static extern void AU3_MouseDown([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szButton);


        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseGetCursor")]
        public static extern int AU3_MouseGetCursor();


        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseGetPosX")]
        public static extern int AU3_MouseGetPosX();


        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseGetPosY")]
        public static extern int AU3_MouseGetPosY();


        /// Return Type: int
        ///nX: int
        ///nY: int
        ///nSpeed: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseMove")]
        public static extern int AU3_MouseMove(int nX, int nY, int nSpeed);


        /// Return Type: void
        ///szButton: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseUp")]
        public static extern void AU3_MouseUp([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szButton);


        /// Return Type: void
        ///szDirection: LPCWSTR->WCHAR*
        ///nClicks: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_MouseWheel")]
        public static extern void AU3_MouseWheel([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szDirection, int nClicks);


        /// Return Type: int
        ///szOption: LPCWSTR->WCHAR*
        ///nValue: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_Opt")]
        public static extern int AU3_Opt([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szOption, int nValue);


        /// Return Type: unsigned int
        ///nLeft: int
        ///nTop: int
        ///nRight: int
        ///nBottom: int
        ///nStep: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_PixelChecksum")]
        public static extern uint AU3_PixelChecksum(int nLeft, int nTop, int nRight, int nBottom, int nStep);


        /// Return Type: int
        ///nX: int
        ///nY: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_PixelGetColor")]
        public static extern int AU3_PixelGetColor(int nX, int nY);


        /// Return Type: void
        ///nLeft: int
        ///nTop: int
        ///nRight: int
        ///nBottom: int
        ///nCol: int
        ///nVar: int
        ///nStep: int
        ///pPointResult: LPPOINT->tagPOINT*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_PixelSearch")]
        public static extern void AU3_PixelSearch(int nLeft, int nTop, int nRight, int nBottom, int nCol, int nVar, int nStep, ref AutoItX_DLLImport.POINT pPointResult);


        /// Return Type: int
        ///szProcess: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ProcessClose")]
        public static extern int AU3_ProcessClose([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szProcess);


        /// Return Type: int
        ///szProcess: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ProcessExists")]
        public static extern int AU3_ProcessExists([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szProcess);


        /// Return Type: int
        ///szProcess: LPCWSTR->WCHAR*
        ///nPriority: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ProcessSetPriority")]
        public static extern int AU3_ProcessSetPriority([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szProcess, int nPriority);


        /// Return Type: int
        ///szProcess: LPCWSTR->WCHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ProcessWait")]
        public static extern int AU3_ProcessWait([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szProcess, int nTimeout);


        /// Return Type: int
        ///szProcess: LPCWSTR->WCHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ProcessWaitClose")]
        public static extern int AU3_ProcessWaitClose([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szProcess, int nTimeout);


 
        /// Return Type: void
        ///szKeyname: LPCWSTR->WCHAR*
        ///nInstance: int
        ///szResult: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_RegEnumKey")]
        public static extern void AU3_RegEnumKey([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szKeyname, int nInstance, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szResult, int nBufSize);


        /// Return Type: void
        ///szKeyname: LPCWSTR->WCHAR*
        ///nInstance: int
        ///szResult: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_RegEnumVal")]
        public static extern void AU3_RegEnumVal([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szKeyname, int nInstance, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szResult, int nBufSize);


        /// Return Type: void
        ///szKeyname: LPCWSTR->WCHAR*
        ///szValuename: LPCWSTR->WCHAR*
        ///szRetText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_RegRead")]
        public static extern void AU3_RegRead([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szKeyname, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szValuename, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szRetText, int nBufSize);


        /// Return Type: int
        ///szKeyname: LPCWSTR->WCHAR*
        ///szValuename: LPCWSTR->WCHAR*
        ///szType: LPCWSTR->WCHAR*
        ///szValue: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_RegWrite")]
        public static extern int AU3_RegWrite([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szKeyname, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szValuename, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szType, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szValue);


        /// Return Type: int
        ///szRun: LPCWSTR->WCHAR*
        ///szDir: LPCWSTR->WCHAR*
        ///nShowFlags: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_Run")]
        public static extern int AU3_Run([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szRun, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szDir, int nShowFlags);


        /// Return Type: int
        ///szUser: LPCWSTR->WCHAR*
        ///szDomain: LPCWSTR->WCHAR*
        ///szPassword: LPCWSTR->WCHAR*
        ///nOptions: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_RunAsSet")]
        public static extern int AU3_RunAsSet([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szUser, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szDomain, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szPassword, int nOptions);


        /// Return Type: int
        ///szRun: LPCWSTR->WCHAR*
        ///szDir: LPCWSTR->WCHAR*
        ///nShowFlags: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_RunWait")]
        public static extern int AU3_RunWait([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szRun, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szDir, int nShowFlags);


        /// Return Type: void
        ///szSendText: LPCWSTR->WCHAR*
        ///nMode: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_Send")]
        public static extern void AU3_Send([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szSendText, int nMode);


        /// Return Type: void
        ///szSendText: LPCSTR->CHAR*
        ///nMode: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_SendA")]
        public static extern void AU3_SendA([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szSendText, int nMode);


        /// Return Type: int
        ///nFlags: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_Shutdown")]
        public static extern int AU3_Shutdown(int nFlags);


        /// Return Type: void
        ///nMilliseconds: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_Sleep")]
        public static extern void AU3_Sleep(int nMilliseconds);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nPart: int
        ///szStatusText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_StatusbarGetText")]
        public static extern void AU3_StatusbarGetText([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nPart, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szStatusText, int nBufSize);


        /// Return Type: void
        ///szTip: LPCWSTR->WCHAR*
        ///nX: int
        ///nY: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_ToolTip")]
        public static extern void AU3_ToolTip([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTip, int nX, int nY);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinActivate")]
        public static extern void AU3_WinActivate([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinActive")]
        public static extern int AU3_WinActive([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinClose")]
        public static extern int AU3_WinClose([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinExists")]
        public static extern int AU3_WinExists([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetCaretPosX")]
        public static extern int AU3_WinGetCaretPosX();


        /// Return Type: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetCaretPosY")]
        public static extern int AU3_WinGetCaretPosY();


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szRetText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetClassList")]
        public static extern void AU3_WinGetClassList([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szRetText, int nBufSize);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetClientSizeHeight")]
        public static extern int AU3_WinGetClientSizeHeight([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetClientSizeWidth")]
        public static extern int AU3_WinGetClientSizeWidth([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szRetText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetHandle")]
        public static extern void AU3_WinGetHandle([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szRetText, int nBufSize);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetPosX")]
        public static extern int AU3_WinGetPosX([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetPosY")]
        public static extern int AU3_WinGetPosY([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetPosHeight")]
        public static extern int AU3_WinGetPosHeight([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetPosWidth")]
        public static extern int AU3_WinGetPosWidth([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szRetText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetProcess")]
        public static extern void AU3_WinGetProcess([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szRetText, int nBufSize);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetState")]
        public static extern int AU3_WinGetState([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szRetText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetText")]
        public static extern void AU3_WinGetText([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szRetText, int nBufSize);


        /// Return Type: void
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szRetText: LPWSTR->WCHAR*
        ///nBufSize: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinGetTitle")]
        public static extern void AU3_WinGetTitle([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] System.Text.StringBuilder szRetText, int nBufSize);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinKill")]
        public static extern int AU3_WinKill([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szItem1: LPCWSTR->WCHAR*
        ///szItem2: LPCWSTR->WCHAR*
        ///szItem3: LPCWSTR->WCHAR*
        ///szItem4: LPCWSTR->WCHAR*
        ///szItem5: LPCWSTR->WCHAR*
        ///szItem6: LPCWSTR->WCHAR*
        ///szItem7: LPCWSTR->WCHAR*
        ///szItem8: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinMenuSelectItem")]
        public static extern int AU3_WinMenuSelectItem([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szItem1, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szItem2, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szItem3, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szItem4, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szItem5, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szItem6, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szItem7, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szItem8);


        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinMinimizeAll")]
        public static extern void AU3_WinMinimizeAll();


        /// Return Type: void
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinMinimizeAllUndo")]
        public static extern void AU3_WinMinimizeAllUndo();


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nX: int
        ///nY: int
        ///nWidth: int
        ///nHeight: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinMove")]
        public static extern int AU3_WinMove([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nX, int nY, int nWidth, int nHeight);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nFlag: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinSetOnTop")]
        public static extern int AU3_WinSetOnTop([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nFlag);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nFlags: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinSetState")]
        public static extern int AU3_WinSetState([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nFlags);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///szNewTitle: LPCWSTR->WCHAR*
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinSetTitle")]
        public static extern int AU3_WinSetTitle([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szNewTitle);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nTrans: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinSetTrans")]
        public static extern int AU3_WinSetTrans([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nTrans);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinWait")]
        public static extern int AU3_WinWait([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nTimeout);


        /// Return Type: int
        ///szTitle: LPCSTR->CHAR*
        ///szText: LPCSTR->CHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinWaitA")]
        public static extern int AU3_WinWaitA([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szText, int nTimeout);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinWaitActive")]
        public static extern int AU3_WinWaitActive([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nTimeout);


        /// Return Type: int
        ///szTitle: LPCSTR->CHAR*
        ///szText: LPCSTR->CHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinWaitActiveA")]
        public static extern int AU3_WinWaitActiveA([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szText, int nTimeout);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinWaitClose")]
        public static extern int AU3_WinWaitClose([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nTimeout);


        /// Return Type: int
        ///szTitle: LPCSTR->CHAR*
        ///szText: LPCSTR->CHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinWaitCloseA")]
        public static extern int AU3_WinWaitCloseA([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szText, int nTimeout);


        /// Return Type: int
        ///szTitle: LPCWSTR->WCHAR*
        ///szText: LPCWSTR->WCHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinWaitNotActive")]
        public static extern int AU3_WinWaitNotActive([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string szText, int nTimeout);


        /// Return Type: int
        ///szTitle: LPCSTR->CHAR*
        ///szText: LPCSTR->CHAR*
        ///nTimeout: int
        [System.Runtime.InteropServices.DllImportAttribute("AutoItX3", EntryPoint = "AU3_WinWaitNotActiveA")]
        public static extern int AU3_WinWaitNotActiveA([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szTitle, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string szText, int nTimeout);

    }

}
