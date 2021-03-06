﻿#pragma checksum "C:\Users\Eduardo\Desktop\Projeto Reclame4.5\C#\Map\DetalhesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47573B76BDB6B41E09AA486A5A812577"
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
    partial class DetalhesPage : 
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

        private class DetalhesPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IDetalhesPage_Bindings
        {
            private global::Map.DetalhesPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj8;
            private global::Windows.UI.Xaml.Controls.TextBox obj9;
            private global::Windows.UI.Xaml.Controls.TextBox obj10;
            private global::Windows.UI.Xaml.Controls.TextBox obj11;
            private global::Windows.UI.Xaml.Controls.TextBox obj12;
            private global::Windows.UI.Xaml.Controls.TextBox obj13;
            private global::Windows.UI.Xaml.Controls.TextBox obj14;

            private DetalhesPage_obj1_BindingsTracking bindingsTracking;

            public DetalhesPage_obj1_Bindings()
            {
                this.bindingsTracking = new DetalhesPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj8).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoTemporario.IdReclamacao = (global::System.Int32) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Int32), (this.obj8).Text);
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
                                    this.dataRoot.ViewModel.ReclamacaoTemporario.Titulo = (this.obj9).Text;
                                }
                            };
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj10).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoAtual.Data = (this.obj10).Text;
                                }
                            };
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj11).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoTemporario.Bairro = (this.obj11).Text;
                                }
                            };
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj12).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoTemporario.Categoria = (this.obj12).Text;
                                }
                            };
                        break;
                    case 13:
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj13).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoTemporario.Endereco = (this.obj13).Text;
                                }
                            };
                        break;
                    case 14:
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj14).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ReclamacaoTemporario.Desc = (this.obj14).Text;
                                }
                            };
                        break;
                    default:
                        break;
                }
            }

            // IDetalhesPage_Bindings

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

            // DetalhesPage_obj1_Bindings

            public void SetDataRoot(global::Map.DetalhesPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Map.DetalhesPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Map.ViewModels.DetalhesPageViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ReclamacaoTemporario(obj.ReclamacaoTemporario, phase);
                        this.Update_ViewModel_ReclamacaoAtual(obj.ReclamacaoAtual, phase);
                    }
                }
            }
            private void Update_ViewModel_ReclamacaoTemporario(global::Map.Classes.Reclamacao obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ReclamacaoTemporario_IdReclamacao(obj.IdReclamacao, phase);
                        this.Update_ViewModel_ReclamacaoTemporario_Titulo(obj.Titulo, phase);
                        this.Update_ViewModel_ReclamacaoTemporario_Bairro(obj.Bairro, phase);
                        this.Update_ViewModel_ReclamacaoTemporario_Categoria(obj.Categoria, phase);
                        this.Update_ViewModel_ReclamacaoTemporario_Endereco(obj.Endereco, phase);
                        this.Update_ViewModel_ReclamacaoTemporario_Desc(obj.Desc, phase);
                    }
                }
            }
            private void Update_ViewModel_ReclamacaoTemporario_IdReclamacao(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj8, obj.ToString(), null);
                }
            }
            private void Update_ViewModel_ReclamacaoTemporario_Titulo(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj9, obj, null);
                }
            }
            private void Update_ViewModel_ReclamacaoAtual(global::Map.Classes.Reclamacao obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ReclamacaoAtual_Data(obj.Data, phase);
                    }
                }
            }
            private void Update_ViewModel_ReclamacaoAtual_Data(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj10, obj, null);
                }
            }
            private void Update_ViewModel_ReclamacaoTemporario_Bairro(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj11, obj, null);
                }
            }
            private void Update_ViewModel_ReclamacaoTemporario_Categoria(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj12, obj, null);
                }
            }
            private void Update_ViewModel_ReclamacaoTemporario_Endereco(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj13, obj, null);
                }
            }
            private void Update_ViewModel_ReclamacaoTemporario_Desc(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj14, obj, null);
                }
            }

            private class DetalhesPage_obj1_BindingsTracking
            {
                global::System.WeakReference<DetalhesPage_obj1_Bindings> WeakRefToBindingObj; 

                public DetalhesPage_obj1_BindingsTracking(DetalhesPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<DetalhesPage_obj1_Bindings>(obj);
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
                    #line 15 "..\..\..\DetalhesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btSalvar).Click += this.btSalvar_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btRemover = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 16 "..\..\..\DetalhesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btRemover).Click += this.btRemover_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btCancelar = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 17 "..\..\..\DetalhesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btCancelar).Click += this.btCancelar_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.MapDetalhes = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 6:
                {
                    this.textBlockImg = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8:
                {
                    this.textBoxID = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.textTitulo = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.dataTXt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.textBairro = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.textCategoria = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.textBoxEndereco = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.textBoxDescricao = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.checkBoxResolvido = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 43 "..\..\..\DetalhesPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.checkBoxResolvido).Checked += this.Marcado;
                    #line default
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
                    DetalhesPage_obj1_Bindings bindings = new DetalhesPage_obj1_Bindings();
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

