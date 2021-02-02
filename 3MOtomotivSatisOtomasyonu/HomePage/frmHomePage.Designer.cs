namespace _3MOtomotivSatisOtomasyonu
{
    partial class frmHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnStock = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompany = new DevExpress.XtraBars.BarButtonItem();
            this.btnHomePage = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonnel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpenditure = new DevExpress.XtraBars.BarButtonItem();
            this.btnCase = new DevExpress.XtraBars.BarButtonItem();
            this.btnNote = new DevExpress.XtraBars.BarButtonItem();
            this.btnBank = new DevExpress.XtraBars.BarButtonItem();
            this.btnDirectory = new DevExpress.XtraBars.BarButtonItem();
            this.btnBilling = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnProduct,
            this.btnStock,
            this.btnCustomer,
            this.btnCompany,
            this.btnHomePage,
            this.btnPersonnel,
            this.btnExpenditure,
            this.btnCase,
            this.btnNote,
            this.btnBank,
            this.btnDirectory,
            this.btnBilling,
            this.btnSetting,
            this.btnTransaction,
            this.btnReport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1924, 227);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnProduct
            // 
            this.btnProduct.ActAsDropDown = true;
            this.btnProduct.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnProduct.Caption = "ÜRÜNLER";
            this.btnProduct.Id = 1;
            this.btnProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.Image")));
            this.btnProduct.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.LargeImage")));
            this.btnProduct.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProduct.ItemAppearance.Disabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnProduct.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnStock
            // 
            this.btnStock.Caption = "STOKLAR";
            this.btnStock.Id = 3;
            this.btnStock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.ImageOptions.Image")));
            this.btnStock.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStock.ImageOptions.LargeImage")));
            this.btnStock.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStock.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStock.Name = "btnStock";
            this.btnStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStock_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "MÜŞTERİLER";
            this.btnCustomer.Id = 4;
            this.btnCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.Image")));
            this.btnCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ImageOptions.LargeImage")));
            this.btnCustomer.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCustomer.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnCompany
            // 
            this.btnCompany.Caption = "FİRMALAR";
            this.btnCompany.Id = 5;
            this.btnCompany.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCompany.ImageOptions.Image")));
            this.btnCompany.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCompany.ImageOptions.LargeImage")));
            this.btnCompany.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCompany.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompany_ItemClick);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Caption = "ANA SAYFA";
            this.btnHomePage.Id = 6;
            this.btnHomePage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.ImageOptions.Image")));
            this.btnHomePage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHomePage.ImageOptions.LargeImage")));
            this.btnHomePage.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHomePage.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHomePage.Name = "btnHomePage";
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Caption = "PERSONELLER";
            this.btnPersonnel.Id = 7;
            this.btnPersonnel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.ImageOptions.Image")));
            this.btnPersonnel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.ImageOptions.LargeImage")));
            this.btnPersonnel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnPersonnel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonnel_ItemClick);
            // 
            // btnExpenditure
            // 
            this.btnExpenditure.Caption = "GİDERLER";
            this.btnExpenditure.Id = 8;
            this.btnExpenditure.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenditure.ImageOptions.Image")));
            this.btnExpenditure.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExpenditure.ImageOptions.LargeImage")));
            this.btnExpenditure.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnExpenditure.ItemAppearance.Normal.Options.UseFont = true;
            this.btnExpenditure.Name = "btnExpenditure";
            this.btnExpenditure.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpenditure_ItemClick);
            // 
            // btnCase
            // 
            this.btnCase.Caption = "KASA";
            this.btnCase.Id = 9;
            this.btnCase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCase.ImageOptions.Image")));
            this.btnCase.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCase.ImageOptions.LargeImage")));
            this.btnCase.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCase.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCase.Name = "btnCase";
            // 
            // btnNote
            // 
            this.btnNote.Caption = "NOTLAR";
            this.btnNote.Id = 10;
            this.btnNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNote.ImageOptions.Image")));
            this.btnNote.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNote.ImageOptions.LargeImage")));
            this.btnNote.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnNote.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNote.Name = "btnNote";
            this.btnNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNote_ItemClick);
            // 
            // btnBank
            // 
            this.btnBank.Caption = "BANKALAR";
            this.btnBank.Id = 11;
            this.btnBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBank.ImageOptions.Image")));
            this.btnBank.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBank.ImageOptions.LargeImage")));
            this.btnBank.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnBank.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBank.Name = "btnBank";
            this.btnBank.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBank_ItemClick);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Caption = "REHBER";
            this.btnDirectory.Id = 12;
            this.btnDirectory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectory.ImageOptions.Image")));
            this.btnDirectory.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDirectory.ImageOptions.LargeImage")));
            this.btnDirectory.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDirectory.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDirectory_ItemClick);
            // 
            // btnBilling
            // 
            this.btnBilling.Caption = "FATURALAR";
            this.btnBilling.Id = 13;
            this.btnBilling.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBilling.ImageOptions.Image")));
            this.btnBilling.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBilling.ImageOptions.LargeImage")));
            this.btnBilling.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnBilling.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBilling_ItemClick);
            // 
            // btnSetting
            // 
            this.btnSetting.Caption = "AYARLAR";
            this.btnSetting.Id = 14;
            this.btnSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.ImageOptions.Image")));
            this.btnSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.ImageOptions.LargeImage")));
            this.btnSetting.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSetting.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetting_ItemClick);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Caption = "HAREKETLER\r\n";
            this.btnTransaction.Id = 15;
            this.btnTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.ImageOptions.Image")));
            this.btnTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTransaction.ImageOptions.LargeImage")));
            this.btnTransaction.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTransaction.ItemAppearance.Normal.Options.UseFont = true;
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTransaction_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.Caption = "RAPORLAR";
            this.btnReport.Id = 16;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.LargeImage")));
            this.btnReport.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnReport.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport.ItemAppearance.Normal.Options.UseFont = true;
            this.btnReport.Name = "btnReport";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "BURSA 3M OTOMOTİV";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHomePage);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStock);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomer);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCompany);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersonnel);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExpenditure);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNote);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBank);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDirectory);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBilling);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTransaction);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReport);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSetting);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "HAREKETLER\r\n";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3M OTOMOTİV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarButtonItem btnStock;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarButtonItem btnCompany;
        private DevExpress.XtraBars.BarButtonItem btnHomePage;
        private DevExpress.XtraBars.BarButtonItem btnPersonnel;
        private DevExpress.XtraBars.BarButtonItem btnExpenditure;
        private DevExpress.XtraBars.BarButtonItem btnCase;
        private DevExpress.XtraBars.BarButtonItem btnNote;
        private DevExpress.XtraBars.BarButtonItem btnBank;
        private DevExpress.XtraBars.BarButtonItem btnDirectory;
        private DevExpress.XtraBars.BarButtonItem btnBilling;
        private DevExpress.XtraBars.BarButtonItem btnSetting;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnTransaction;
        private DevExpress.XtraBars.BarButtonItem btnReport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

