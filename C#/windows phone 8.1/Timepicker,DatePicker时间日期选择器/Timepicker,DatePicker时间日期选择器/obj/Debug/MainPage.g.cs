﻿

#pragma checksum "E:\Microsoft Visual Studio 12.0\Myproject\windows phone 8.1\Timepicker,DatePicker时间日期选择器\Timepicker,DatePicker时间日期选择器\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E71C6DFE5270DFF31DB192386CF485DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Timepicker_DatePicker时间日期选择器
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 13 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TimePicker)(target)).TimeChanged += this.time_TimeChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 16 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.DatePicker)(target)).DateChanged += this.date_DateChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


