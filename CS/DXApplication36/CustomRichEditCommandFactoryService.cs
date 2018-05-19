using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.XtraRichEdit;
using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.Utils;

namespace DXApplication36 {
    public class CustomRichEditCommandFactoryService : IRichEditCommandFactoryService {
        readonly IRichEditCommandFactoryService service;
        readonly RichEditControl control;

        public CustomRichEditCommandFactoryService(RichEditControl control,
            IRichEditCommandFactoryService service) {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(service, "service");
            this.control = control;
            this.service = service;
        }

        public RichEditCommand CreateCommand(RichEditCommandId id) {
            if(id == RichEditCommandId.FileSave)
                return new CustomSaveDocumentCommand(control);

            return service.CreateCommand(id);
        }
    }
   
    public class CustomSaveDocumentCommand:SaveDocumentCommand{
        public CustomSaveDocumentCommand(IRichEditControl control)
            : base(control)
        {
        }
        protected override void ExecuteCore()
        {
              base.ExecuteCore();
              MessageBox.Show("Custom SaveDocument command was executed");
        }
    }
}
