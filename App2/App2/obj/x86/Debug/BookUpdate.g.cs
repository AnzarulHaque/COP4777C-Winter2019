﻿#pragma checksum "C:\tmp\Rasmussen\COP4777C-Winter2019\App2\App2\BookUpdate.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5ECBE5834847CD5CA3845598B9B9AB35"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App2
{
    partial class BookUpdate : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // BookUpdate.xaml line 13
                {
                    this.ListItems = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3: // BookUpdate.xaml line 30
                {
                    this.btnFetchBooks = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnFetchBooks).Click += this.btnViewBookInventory;
                }
                break;
            case 4: // BookUpdate.xaml line 32
                {
                    this.ButtonRefresh = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonRefresh).Click += this.ButtonRefresh_Click;
                }
                break;
            case 5: // BookUpdate.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Button_Click;
                }
                break;
            case 7: // BookUpdate.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element7 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element7).Checked += this.CheckBoxComplete_Checked;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

