using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Registrator;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;

namespace DXSample {
    public class MyLayoutControl : LayoutControl {
        public MyLayoutControl() : base() { }
        public MyLayoutControl(bool fAllowUseSplitters, bool fAllowTabbedGroups) : base(fAllowUseSplitters, fAllowTabbedGroups) { }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore() { return new MyLayoutControlImplementor(this); }
    }

    public class MyLayoutSkinPaintStyle : LayoutSkinPaintStyle {
        public MyLayoutSkinPaintStyle(ISupportLookAndFeel owner) : base(owner) { }
        public override GroupObjectPainter CreateGroupPainter(IPanelControlOwner owner) { return new MyWindowsXPGroupObjectPainter(owner, LookAndFeel); }
    }

    public class MyLayoutControlImplementor : LayoutControlImplementor {
        public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner) { }

        protected override void InitializePaintStyles() {
            ISupportLookAndFeel lookAndFeelOwner = owner.GetISupportLookAndFeel();
            if (lookAndFeelOwner != null) {
                PaintStyles.Add(new LayoutOffice2003PaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new LayoutWindowsXPPaintStyle(lookAndFeelOwner));

                PaintStyles.Add(new MyLayoutSkinPaintStyle(lookAndFeelOwner)); // This is your custom paint style

                PaintStyles.Add(new Style3DPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new UltraFlatPaintStyle(lookAndFeelOwner));
                PaintStyles.Add(new FlatPaintStyle(lookAndFeelOwner));
            }
            lookAndFeelOwner = null;
        }
    }

    public class MyWindowsXPGroupObjectPainter : WindowsXPGroupObjectPainter {
        private ISkinProvider provider;
        public MyWindowsXPGroupObjectPainter(IPanelControlOwner owner, ISkinProvider provider) : base(owner) { this.provider = provider; }

        protected override void DrawBackground(GroupObjectInfoArgs info) {
            base.DrawBackground(info);
            SkinElement back = CommonSkins.GetSkin(provider)[CommonSkins.SkinGroupPanel];
            SkinElementInfo e = new SkinElementInfo(back, info.Bounds);
            ObjectPainter.DrawObject(info.Cache, SkinElementPainter.Default, e);
        }
    }
}