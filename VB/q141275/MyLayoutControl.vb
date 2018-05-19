Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins

Namespace DXSample
	Public Class MyLayoutControl
		Inherits LayoutControl
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal fAllowUseSplitters As Boolean, ByVal fAllowTabbedGroups As Boolean)
			MyBase.New(fAllowUseSplitters, fAllowTabbedGroups)
		End Sub
		Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
			Return New MyLayoutControlImplementor(Me)
		End Function
	End Class

	Public Class MyLayoutSkinPaintStyle
		Inherits LayoutSkinPaintStyle
		Public Sub New(ByVal owner As ISupportLookAndFeel)
			MyBase.New(owner)
		End Sub
		Public Overrides Function CreateGroupPainter(ByVal owner As IPanelControlOwner) As GroupObjectPainter
			Return New MyWindowsXPGroupObjectPainter(owner, LookAndFeel)
		End Function
	End Class

	Public Class MyLayoutControlImplementor
		Inherits LayoutControlImplementor
		Public Sub New(ByVal owner As ILayoutControlOwner)
			MyBase.New(owner)
		End Sub

		Protected Overrides Sub InitializePaintStyles()
			Dim lookAndFeelOwner As ISupportLookAndFeel = owner.GetISupportLookAndFeel()
			If lookAndFeelOwner IsNot Nothing Then
				PaintStyles.Add(New LayoutOffice2003PaintStyle(lookAndFeelOwner))
				PaintStyles.Add(New LayoutWindowsXPPaintStyle(lookAndFeelOwner))

				PaintStyles.Add(New MyLayoutSkinPaintStyle(lookAndFeelOwner)) ' This is your custom paint style

				PaintStyles.Add(New Style3DPaintStyle(lookAndFeelOwner))
				PaintStyles.Add(New UltraFlatPaintStyle(lookAndFeelOwner))
				PaintStyles.Add(New FlatPaintStyle(lookAndFeelOwner))
			End If
			lookAndFeelOwner = Nothing
		End Sub
	End Class

	Public Class MyWindowsXPGroupObjectPainter
		Inherits WindowsXPGroupObjectPainter
		Private provider As ISkinProvider
		Public Sub New(ByVal owner As IPanelControlOwner, ByVal provider As ISkinProvider)
			MyBase.New(owner)
		 Me.provider = provider
		End Sub

		Protected Overrides Sub DrawBackground(ByVal info As GroupObjectInfoArgs)
			MyBase.DrawBackground(info)
			Dim back As SkinElement = CommonSkins.GetSkin(provider)(CommonSkins.SkinGroupPanel)
			Dim e As New SkinElementInfo(back, info.Bounds)
			ObjectPainter.DrawObject(info.Cache, SkinElementPainter.Default, e)
		End Sub
	End Class
End Namespace