#pragma checksum "..\..\FinestraDiGioco.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "807DDEC8B32BF72D507B9DA23B1E0DC35B6F7F33277EFBF3C7FD18EA481DE4CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using ProgettoMonopoly;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProgettoMonopoly {
    
    
    /// <summary>
    /// FinestraDiGioco
    /// </summary>
    public partial class FinestraDiGioco : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgTabellone;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLanciaDadi;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDado1;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDado2;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCompra;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNonComprare;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIpoteca;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgP1;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgP2;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgP3;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\FinestraDiGioco.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgP4;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProgettoMonopoly;component/finestradigioco.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FinestraDiGioco.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgTabellone = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btnLanciaDadi = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\FinestraDiGioco.xaml"
            this.btnLanciaDadi.Click += new System.Windows.RoutedEventHandler(this.btnLanciaDadi_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.imgDado1 = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.imgDado2 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.btnCompra = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\FinestraDiGioco.xaml"
            this.btnCompra.Click += new System.Windows.RoutedEventHandler(this.btnCompra_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnNonComprare = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\FinestraDiGioco.xaml"
            this.btnNonComprare.Click += new System.Windows.RoutedEventHandler(this.btnNonComprare_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnIpoteca = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\FinestraDiGioco.xaml"
            this.btnIpoteca.Click += new System.Windows.RoutedEventHandler(this.btnIpoteca_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.imgP1 = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.imgP2 = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.imgP3 = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.imgP4 = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

