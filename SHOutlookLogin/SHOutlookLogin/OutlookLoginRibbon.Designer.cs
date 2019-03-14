using System.Drawing;

namespace SHOutlookLogin {
    partial class OutlookLoginRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public OutlookLoginRibbon()
            : base(Globals.Factory.GetRibbonFactory()) {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabCustomHome = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.menuButton1 = this.Factory.CreateRibbonMenu();
            this.btnLogin = this.Factory.CreateRibbonButton();
            this.btnLogout = this.Factory.CreateRibbonButton();
            this.tabCustomHome.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomHome
            // 
            this.tabCustomHome.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabCustomHome.ControlId.OfficeId = "TabMail";
            this.tabCustomHome.Groups.Add(this.group1);
            this.tabCustomHome.Label = "TabMail";
            this.tabCustomHome.Name = "tabCustomHome";
            // 
            // group1
            // 
            this.group1.Items.Add(this.menuButton1);
            this.group1.Label = "SalesHandy";
            this.group1.Name = "group1";
            // 
            // menuButton1
            // 
            this.menuButton1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menuButton1.Dynamic = true;
            this.menuButton1.Image = global::SHOutlookLogin.Properties.Resources.SalesHandy;
            this.menuButton1.Label = " ";
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.ShowImage = true;
            // 
            // btnLogin
            // 
            this.btnLogin.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLogin.Label = "Login";
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowImage = true;
            this.btnLogin.Click += BtnLogin_Click;
            // 
            // btnLogout
            // 
            this.btnLogout.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLogout.Label = "Logout";
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShowImage = true;
            this.btnLogout.Click += BtnLogout_Click;
            // 
            // OutlookLoginRibbon
            // 
            this.Name = "OutlookLoginRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tabCustomHome);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OutlookLoginRibbon_Load);
            this.tabCustomHome.ResumeLayout(false);
            this.tabCustomHome.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabCustomHome;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLogin;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLogout;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menuButton1;
        
    }

    partial class ThisRibbonCollection {
        internal OutlookLoginRibbon OutlookTfsConnectorRibbon {
            get { return this.GetRibbon<OutlookLoginRibbon>(); }
        }
    }
}


