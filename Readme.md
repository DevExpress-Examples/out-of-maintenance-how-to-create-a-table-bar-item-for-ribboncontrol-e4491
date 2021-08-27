<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616503/12.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4491)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/testSample/Form1.cs) (VB: [Form1.vb](./VB/testSample/Form1.vb))
* [Program.cs](./CS/testSample/Program.cs) (VB: [Program.vb](./VB/testSample/Program.vb))
* [TableBarItem.cs](./CS/testSample/TableBarItem/CustomBarItem/TableBarItem.cs) (VB: [TableBarItem.vb](./VB/testSample/TableBarItem/CustomBarItem/TableBarItem.vb))
* [TableEventArgs.cs](./CS/testSample/TableBarItem/CustomBarItem/TableEventArgs.cs) (VB: [TableEventArgs.vb](./VB/testSample/TableBarItem/CustomBarItem/TableEventArgs.vb))
* [TableSizePopupControlContainer.cs](./CS/testSample/TableBarItem/CustomBarItem/TableSizePopupControlContainer.cs) (VB: [TableSizePopupControlContainer.vb](./VB/testSample/TableBarItem/CustomBarItem/TableSizePopupControlContainer.vb))
* [MyBarAndDockingController.cs](./CS/testSample/TableBarItem/CustomController/MyBarAndDockingController.cs) (VB: [MyBarAndDockingController.vb](./VB/testSample/TableBarItem/CustomController/MyBarAndDockingController.vb))
* [MyUserControl.cs](./CS/testSample/UserControl/MyUserControl.cs) (VB: [MyUserControl.vb](./VB/testSample/UserControl/MyUserControl.vb))
<!-- default file list end -->
# How to create a Table bar item for RibbonControl


<p>This example demonstrates  how to create a custom TableBarItem for RibbonControl without creating RibbonControl descendants. </p><br />
<p>To  implement this item, we executed the following steps : </p><p> 1) created a custom BarItem descendant</p><p> 2) created a BarAndDockingController descendant with an overridden RegisterPaintStyles method to register your BarItem at design time</p><br />
<p>To add  this functionality to your project, add  all files from the TableBarItem folder. </p><p>Then,  drop the MyBarAndDockingController  and RibbonControl components onto a Form  and set the  RibbonController's Controller property to your custom controller and rebuild the solution. </p><p>After that TableBarItem becomes available in the Ribbon context menu you can add it to the required group. </p><br />
<p>Additionally, you can place a custom UserControl under the table control. To do this, use the InnerPopupControl property.  So, you need to place the existing UserControl onto the form or create a new one and pass it to the InnerPopupControl  property.</p>

<br/>


