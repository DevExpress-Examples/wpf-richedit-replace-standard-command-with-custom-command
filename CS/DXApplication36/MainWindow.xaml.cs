using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Ribbon;
using DevExpress.XtraRichEdit;
using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit.Services;


namespace DXApplication36 {
    public partial class MainWindow : DXRibbonWindow {
        public MainWindow() {
            InitializeComponent();
            ribbonControl1.SelectedPage = pageHome;
            richEditControl1.Loaded += richEditControl1_Loaded;
        }

        void richEditControl1_Loaded(object sender, RoutedEventArgs e) {
            ReplaceRichEditCommandFactoryService(richEditControl1);
        }
        
        void ReplaceRichEditCommandFactoryService(RichEditControl control)
        {
            control.ApplyTemplate();
            IRichEditCommandFactoryService service = control.GetService<IRichEditCommandFactoryService>();
            control.ReplaceService<IRichEditCommandFactoryService>(new CustomRichEditCommandFactoryService(control, service));
        }
        void richEditControl1_StartHeaderFooterEditing(object sender, HeaderFooterEditingEventArgs e) {
            catHeaderFooterTools.IsVisible = true;
            ribbonControl1.SelectedPage = pageHeaderFooterToolsDesign;
        }

        void richEditControl1_FinishHeaderFooterEditing(object sender, HeaderFooterEditingEventArgs e) {
            catHeaderFooterTools.IsVisible = false;
        }

        void richEditControl1_SelectionChanged(object sender, EventArgs e) {
            bool isSelectionInTable = richEditControl1.IsSelectionInTable();
            if(catTableTools.IsVisible != isSelectionInTable) {
                catTableTools.IsVisible = isSelectionInTable;
                if(isSelectionInTable)
                    ribbonControl1.SelectedPage = pageTableToolsDesign;
            }

            bool isSelectionInFloatingObject = richEditControl1.IsFloatingObjectSelected;
            if(catPictureTools.IsVisible != isSelectionInFloatingObject) {
                catPictureTools.IsVisible = isSelectionInFloatingObject;
                if(isSelectionInFloatingObject)
                    ribbonControl1.SelectedPage = pagePictureToolsFormat;
            }
        }

    }


    


   

}
