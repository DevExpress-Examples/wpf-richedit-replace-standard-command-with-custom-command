<!-- default file list -->
*Files to look at*:

* [CustomRichEditCommandFactoryService.cs](./CS/DXApplication36/CustomRichEditCommandFactoryService.cs) (VB: [CustomRichEditCommandFactoryService.vb](./VB/DXApplication36/CustomRichEditCommandFactoryService.vb))
* [MainWindow.xaml](./CS/DXApplication36/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXApplication36/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXApplication36/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXApplication36/MainWindow.xaml.vb))
<!-- default file list end -->
# How to replace standard DXRichEdit command with your own custom command


This example illustrates the technique used to modify the functionality of existing DXRichEdit commands.<br> The RichEditControl exposes the IRichEditCommandFactoryService interface that enables you to substitute default command with your own custom command. <br> First, create a command class, inherited from the command that you've decided to replace. Override its methods. The main functionality and command specifics is located in the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressUtilsCommandsCommand_Executetopic">Execute</a> or the<strong> ExecuteCore</strong> method (the latter does not check for the command availability). <br> Then, create a class implementing the IRichEditCommandFactoryService. You should override the CreateCommand method to create an instance of a custom command class if an identifier of a certain command is passed as a parameter. So, instead of the default command, a custom command will be used by the RichEditControl.<br> Finally we use this class to substitute the default RichEditControl's service.

<br/>


