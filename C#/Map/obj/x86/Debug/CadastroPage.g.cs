﻿#pragma checksum "C:\Users\Eduardo\Desktop\Projeto Reclame4.5\C#\Map\CadastroPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "290CE034C72C9E7717E12C2D04190DE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Map
{
    partial class CadastroPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class CadastroPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICadastroPage_Bindings
        {
            private global::Map.CadastroPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj7;
            private global::Windows.UI.Xaml.Controls.TextBox obj8;
            private global::Windows.UI.Xaml.Controls.TextBox obj9;

            private CadastroPage_obj1_BindingsTracking bindingsTracking;

            public CadastroPage_obj1_Bindings()
            {
                this.bindingsTracking = new CadastroPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj7).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoAtual.Titulo = (this.obj7).Text;
                                }
                            };
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj8).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoAtual.Endereco = (this.obj8).Text;
                                }
                            };
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj9).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoAtual.Desc = (this.obj9).Text;
                                }
                            };
                        break;
                    default:
                        break;
                }
            }

            // ICadastroPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // CadastroPage_obj1_Bindings

            public void SetDataRoot(global::Map.CadastroPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Map.CadastroPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Map.ViewModels.CadastroPageViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ReclamacaoAtual(obj.ReclamacaoAtual, phase);
                    }
                }
            }
            private void Update_ViewModel_ReclamacaoAtual(global::Map.Classes.Reclamacao obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ReclamacaoAtual_Titulo(obj.Titulo, phase);
                        this.Update_ViewModel_ReclamacaoAtual_Endereco(obj.Endereco, phase);
                        this.Update_ViewModel_ReclamacaoAtual_Desc(obj.Desc, phase);
                    }
                }
            }
            private void Update_ViewModel_ReclamacaoAtual_Titulo(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj7, obj, null);
                }
            }
            private void Update_ViewModel_ReclamacaoAtual_Endereco(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_ReclamacaoAtual_Desc(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj9, obj, null);
                }
            }

            private class CadastroPage_obj1_BindingsTracking
            {
                global::System.WeakReference<CadastroPage_obj1_Bindings> WeakRefToBindingObj; 

                public CadastroPage_obj1_BindingsTracking(CadastroPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<CadastroPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.btSalvar = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 15 "..\..\..\CadastroPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btSalvar).Click += this.btSalvar_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btCancelar = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 16 "..\..\..\CadastroPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btCancelar).Click += this.btCancelar_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6:
                {
                    this.textID = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.textTitulo = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.textEndereco = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.textDescricao = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.listBoxCateg = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 11:
                {
                    this.listBoxBairro = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 12:
                {
                    this.DataReclamacao = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 13:
                {
                    this.PickAFileButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 14:
                {
                    this.OutputTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.image1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    CadastroPage_obj1_Bindings bindings = new CadastroPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

