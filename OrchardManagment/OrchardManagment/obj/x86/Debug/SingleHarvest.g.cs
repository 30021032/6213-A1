﻿#pragma checksum "\\FS\STUDENT$\30021032\Desktop\COMP.6215\OrchardManagment\OrchardManagment\SingleHarvest.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F10D38AC9865478C72D13876F76ECF1A"
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
    partial class SingleHarvest : 
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
            case 2: // SingleHarvest.xaml line 11
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).SizeChanged += this.SingleHarvest_SizeChanged;
                }
                break;
            case 3: // SingleHarvest.xaml line 12
                {
                    this.btnEdit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnEdit).Click += this.btnEdit_Click;
                }
                break;
            case 4: // SingleHarvest.xaml line 13
                {
                    this.btnBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBack).Click += this.btnBack_Click;
                }
                break;
            case 5: // SingleHarvest.xaml line 18
                {
                    this.txtHarvested = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // SingleHarvest.xaml line 19
                {
                    this.txtDate = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // SingleHarvest.xaml line 20
                {
                    this.txtPriceKg = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // SingleHarvest.xaml line 21
                {
                    this.txtComment = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // SingleHarvest.xaml line 28
                {
                    this.txtTotalIncome = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

