﻿#pragma checksum "\\FS\STUDENT$\30021032\Desktop\COMP.6215\OrchardManagment\OrchardManagment\AddSection.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0E5912381A6211C77091D5251CAAB9A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrchardManagment
{
    partial class AddSection : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // AddSection.xaml line 11
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).SizeChanged += this.AddSection_SizeChanged;
                }
                break;
            case 3: // AddSection.xaml line 18
                {
                    this.txtName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // AddSection.xaml line 19
                {
                    this.txtTreeType = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // AddSection.xaml line 20
                {
                    this.txtSize = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // AddSection.xaml line 21
                {
                    this.txtDate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // AddSection.xaml line 22
                {
                    this.txtComment = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // AddSection.xaml line 28
                {
                    this.btnSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSave).Click += this.btnSave_Click;
                }
                break;
            case 9: // AddSection.xaml line 29
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancel_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

