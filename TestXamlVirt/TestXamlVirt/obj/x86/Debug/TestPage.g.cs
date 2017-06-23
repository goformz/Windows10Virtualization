﻿#pragma checksum "C:\Development\GoFormzGitHub\Windows10Virtualization\TestXamlVirt\TestXamlVirt\TestPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E8ACF74266EE1CE6E0AC84FCEF0E27DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestXamlVirt
{
    partial class TestPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Width(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                obj.Width = value;
            }
            public static void Set_Windows_UI_Xaml_FrameworkElement_Height(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                obj.Height = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Canvas_Left(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                global::Windows.UI.Xaml.Controls.Canvas.SetLeft(obj, value);
            }
            public static void Set_Windows_UI_Xaml_Controls_Canvas_Top(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Double value)
            {
                global::Windows.UI.Xaml.Controls.Canvas.SetTop(obj, value);
            }
        };

        private class TestPage_obj6_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITestPage_Bindings
        {
            private global::TestXamlVirt.TextItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj6;

            public TestPage_obj6_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6:
                        this.obj6 = new global::System.WeakReference((global::TestXamlVirt.TestControl)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::TestXamlVirt.TextItem data = args.NewValue as global::TestXamlVirt.TextItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::TestXamlVirt.TextItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = 2;
                        this.SetDataRoot(args.Item as global::TestXamlVirt.TextItem);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::TestXamlVirt.TestControl)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                    case 2:
                        Windows.UI.Xaml.Markup.XamlBindingHelper.ResumeRendering(this.obj6.Target as global::TestXamlVirt.TestControl);
                        nextPhase = -1;
                        break;
                }
                this.Update_((global::TestXamlVirt.TextItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Windows.UI.Xaml.Markup.XamlBindingHelper.SuspendRendering(this.obj6.Target as global::TestXamlVirt.TestControl);
            }

            // ITestPage_Bindings

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
            }

            // TestPage_obj6_Bindings

            public void SetDataRoot(global::TestXamlVirt.TextItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TestXamlVirt.TextItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0) | (1 << 2))) != 0)
                    {
                        this.Update_W(obj.W, phase);
                        this.Update_H(obj.H, phase);
                        this.Update_X(obj.X, phase);
                        this.Update_Y(obj.Y, phase);
                    }
                }
            }
            private void Update_W(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 2) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Width(this.obj6.Target as global::TestXamlVirt.TestControl, obj);
                }
            }
            private void Update_H(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 2) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_Height(this.obj6.Target as global::TestXamlVirt.TestControl, obj);
                }
            }
            private void Update_X(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 2) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Canvas_Left(this.obj6.Target as global::TestXamlVirt.TestControl, obj);
                }
            }
            private void Update_Y(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 2) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Canvas_Top(this.obj6.Target as global::TestXamlVirt.TestControl, obj);
                }
            }
        }

        private class TestPage_obj4_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITestPage_Bindings
        {
            private global::TestXamlVirt.ExampleItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ItemsControl obj5;

            public TestPage_obj4_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ItemsControl)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::TestXamlVirt.ExampleItem data = args.NewValue as global::TestXamlVirt.ExampleItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::TestXamlVirt.ExampleItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = 1;
                        this.SetDataRoot(args.Item as global::TestXamlVirt.ExampleItem);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.StackPanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                    case 1:
                        Windows.UI.Xaml.Markup.XamlBindingHelper.ResumeRendering(this.obj5);
                        nextPhase = -1;
                        break;
                }
                this.Update_((global::TestXamlVirt.ExampleItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Windows.UI.Xaml.Markup.XamlBindingHelper.SuspendRendering(this.obj5);
            }

            // ITestPage_Bindings

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
            }

            // TestPage_obj4_Bindings

            public void SetDataRoot(global::TestXamlVirt.ExampleItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TestXamlVirt.ExampleItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0) | (1 << 1))) != 0)
                    {
                        this.Update_TextItems(obj.TextItems, phase);
                    }
                }
            }
            private void Update_TextItems(global::System.Collections.ObjectModel.ObservableCollection<global::TestXamlVirt.TextItem> obj, int phase)
            {
                if((phase & ((1 << 1) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                }
            }
        }

        private class TestPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITestPage_Bindings
        {
            private global::TestXamlVirt.TestPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj3;

            public TestPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // ITestPage_Bindings

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
            }

            // TestPage_obj1_Bindings

            public void SetDataRoot(global::TestXamlVirt.TestPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TestXamlVirt.TestPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::TestXamlVirt.ExampleItemViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ExampleItems(obj.ExampleItems, phase);
                    }
                }
            }
            private void Update_ViewModel_ExampleItems(global::System.Collections.ObjectModel.ObservableCollection<global::TestXamlVirt.ExampleItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
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
                    global::Windows.UI.Xaml.Controls.TextBlock element2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 20 "..\..\..\TestPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element2).Tapped += this.BackClick;
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
                    TestPage_obj1_Bindings bindings = new TestPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element4 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    TestPage_obj4_Bindings bindings = new TestPage_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::TestXamlVirt.ExampleItem) element4.DataContext);
                    element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                }
                break;
            case 6:
                {
                    global::TestXamlVirt.TestControl element6 = (global::TestXamlVirt.TestControl)target;
                    TestPage_obj6_Bindings bindings = new TestPage_obj6_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::TestXamlVirt.TextItem) element6.DataContext);
                    element6.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element6, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

