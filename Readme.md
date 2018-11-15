<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/q141275/Form1.cs) (VB: [Form1.vb](./VB/q141275/Form1.vb))
* [MyLayoutControl.cs](./CS/q141275/MyLayoutControl.cs) (VB: [MyLayoutControl.vb](./VB/q141275/MyLayoutControl.vb))
* [Program.cs](./CS/q141275/Program.cs) (VB: [Program.vb](./VB/q141275/Program.vb))
<!-- default file list end -->
# OBSOLETE: How to register your own GroupObjectPainter in the LayoutControl.


<p><strong>Starting with version 16.2, LayoutControl provides the possibility to custom paint individual items out-of-the-box. Handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraLayoutLayoutControl_CustomDrawtopic">LayoutControl.CustomDraw</a> event for this.</strong></p>
<p><br>These are the steps required to accomplish this task:</p>
<p>1. Create a custom painter for the necessary element.<br> 2. Inherit from the LayoutPaintStyle object and override, as appropriate, either the GetXXXPainter() or the CreateXXXPainter() method.<br> 3. Create the LayoutControlImplementor descendant and override its InitializePaintStyles() method. Within this method replace any paint style with your own.<br> 4. Create the LayoutControl descendant and override its CreateILayoutControlImplementorCore method to return your own LayoutControlImplementor object.</p>
<p>Please see the code example for detail.</p>

<br/>


