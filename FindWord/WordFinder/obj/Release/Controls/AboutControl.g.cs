﻿

#pragma checksum "c:\Users\biche_000\wordfinder\FindWord\WordFinder\Controls\AboutControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1003FF678C554B3199C8260AB8E7B6D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindWord.Controls
{
    partial class AboutControl : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 6 "..\..\Controls\AboutControl.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.AboutLoaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 40 "..\..\Controls\AboutControl.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.OverlayTapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 62 "..\..\Controls\AboutControl.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.BackButtonClick;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


