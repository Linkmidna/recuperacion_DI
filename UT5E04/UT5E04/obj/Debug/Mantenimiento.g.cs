﻿#pragma checksum "..\..\Mantenimiento.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74D118F1ECE442AA7FC0C84184CB02F7F44E22FA1843BB7115B851540BE9B613"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UT5E04;


namespace UT5E04 {
    
    
    /// <summary>
    /// Mantenimiento
    /// </summary>
    public partial class Mantenimiento : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFiltro;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRegistros;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNueva;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFiltrar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFiltro;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvReservas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem cmiNuevo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem cmiModificar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem cmiBorrar;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem cmiConfirmar;
        
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
            System.Uri resourceLocater = new System.Uri("/UT5E04;component/mantenimiento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Mantenimiento.xaml"
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
            this.lblFiltro = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblRegistros = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnNueva = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Mantenimiento.xaml"
            this.btnNueva.Click += new System.Windows.RoutedEventHandler(this.btnNueva_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnFiltrar = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.txtFiltro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lvReservas = ((System.Windows.Controls.ListView)(target));
            
            #line 23 "..\..\Mantenimiento.xaml"
            this.lvReservas.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lvReservas_DoubleClick);
            
            #line default
            #line hidden
            
            #line 23 "..\..\Mantenimiento.xaml"
            this.lvReservas.ContextMenuOpening += new System.Windows.Controls.ContextMenuEventHandler(this.lvReservas_ContextMenuOpening);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmiNuevo = ((System.Windows.Controls.MenuItem)(target));
            
            #line 35 "..\..\Mantenimiento.xaml"
            this.cmiNuevo.Click += new System.Windows.RoutedEventHandler(this.cmiNueva_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmiModificar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\Mantenimiento.xaml"
            this.cmiModificar.Click += new System.Windows.RoutedEventHandler(this.cmiModificar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmiBorrar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 37 "..\..\Mantenimiento.xaml"
            this.cmiBorrar.Click += new System.Windows.RoutedEventHandler(this.cmiBorrar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cmiConfirmar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\Mantenimiento.xaml"
            this.cmiConfirmar.Click += new System.Windows.RoutedEventHandler(this.cmiConfirmar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

