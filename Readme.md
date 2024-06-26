<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607815/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T466861)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomRichEditCommandFactoryService.cs](./CS/DXApplication36/CustomRichEditCommandFactoryService.cs) (VB: [CustomRichEditCommandFactoryService.vb](./VB/DXApplication36/CustomRichEditCommandFactoryService.vb))
* [MainWindow.xaml](./CS/DXApplication36/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXApplication36/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXApplication36/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXApplication36/MainWindow.xaml.vb))
<!-- default file list end -->
# How to replace standard DXRichEdit command with your own custom command


This example illustrates the technique used to modify the functionality of existing DXRichEdit commands.<br> The RichEditControl exposes the IRichEditCommandFactoryService interface that enables you to substitute default command with your own custom command. <br> First, create a command class, inherited from the command that you've decided to replace. Override its methods. The main functionality and command specifics is located in the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressUtilsCommandsCommand_Executetopic">Execute</a> or the<strong> ExecuteCore</strong> method (the latter does not check for the command availability). <br> Then, create a class implementing the IRichEditCommandFactoryService. You should override the CreateCommand method to create an instance of a custom command class if an identifier of a certain command is passed as a parameter. So, instead of the default command, a custom command will be used by the RichEditControl.<br> Finally we use this class to substitute the default RichEditControl's service.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-richedit-replace-standard-command-with-custom-command&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-richedit-replace-standard-command-with-custom-command&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
