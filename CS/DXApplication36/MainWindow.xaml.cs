using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Ribbon;
using DevExpress.XtraRichEdit;
using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit.Services;
using DevExpress.Xpf.Core;

namespace DXApplication36 {
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow() {
            InitializeComponent();
            richEditControl1.Loaded += richEditControl1_Loaded;
        }
        #region #replace
        void richEditControl1_Loaded(object sender, RoutedEventArgs e) {
            ReplaceRichEditCommandFactoryService(richEditControl1);
        }
        
        void ReplaceRichEditCommandFactoryService(RichEditControl control)
        {
            control.ApplyTemplate();
            IRichEditCommandFactoryService service = control.GetService<IRichEditCommandFactoryService>();
            control.ReplaceService<IRichEditCommandFactoryService>(new CustomRichEditCommandFactoryService(control, service));
        }
        #endregion #replace
    }







}
