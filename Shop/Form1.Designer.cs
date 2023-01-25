namespace Shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShopContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Dental_Products = new System.Windows.Forms.Button();
            this.Btn_Meat_Products = new System.Windows.Forms.Button();
            this.Btn_Dairy_Products = new System.Windows.Forms.Button();
            this.Btn_Soft_Drinks = new System.Windows.Forms.Button();
            this.Btn_Shower_Products = new System.Windows.Forms.Button();
            this.Btn_Vegetables = new System.Windows.Forms.Button();
            this.Btn_Coffee_Products = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_All_Items = new System.Windows.Forms.Button();
            this.Panel_Cart_Small = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPricePanel = new System.Windows.Forms.Panel();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.Btn_ClearOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Panel_Cart_Small.SuspendLayout();
            this.TotalPricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopContainer
            // 
            resources.ApplyResources(this.ShopContainer, "ShopContainer");
            this.ShopContainer.BackColor = System.Drawing.Color.White;
            this.ShopContainer.Name = "ShopContainer";
            this.ShopContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.ShopContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Dental_Products);
            this.panel1.Controls.Add(this.Btn_Meat_Products);
            this.panel1.Controls.Add(this.Btn_Dairy_Products);
            this.panel1.Controls.Add(this.Btn_Soft_Drinks);
            this.panel1.Controls.Add(this.Btn_Shower_Products);
            this.panel1.Controls.Add(this.Btn_Vegetables);
            this.panel1.Controls.Add(this.Btn_Coffee_Products);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Controls.Add(this.Btn_Load);
            this.panel1.Controls.Add(this.Btn_All_Items);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Btn_Dental_Products
            // 
            resources.ApplyResources(this.Btn_Dental_Products, "Btn_Dental_Products");
            this.Btn_Dental_Products.Name = "Btn_Dental_Products";
            this.Btn_Dental_Products.UseVisualStyleBackColor = true;
            this.Btn_Dental_Products.Click += new System.EventHandler(this.Btn_Dental_Products_Click);
            // 
            // Btn_Meat_Products
            // 
            resources.ApplyResources(this.Btn_Meat_Products, "Btn_Meat_Products");
            this.Btn_Meat_Products.Name = "Btn_Meat_Products";
            this.Btn_Meat_Products.UseVisualStyleBackColor = true;
            this.Btn_Meat_Products.Click += new System.EventHandler(this.Btn_Meat_Products_Click);
            // 
            // Btn_Dairy_Products
            // 
            resources.ApplyResources(this.Btn_Dairy_Products, "Btn_Dairy_Products");
            this.Btn_Dairy_Products.Name = "Btn_Dairy_Products";
            this.Btn_Dairy_Products.UseVisualStyleBackColor = true;
            this.Btn_Dairy_Products.Click += new System.EventHandler(this.Btn_Dairy_Products_Click);
            // 
            // Btn_Soft_Drinks
            // 
            resources.ApplyResources(this.Btn_Soft_Drinks, "Btn_Soft_Drinks");
            this.Btn_Soft_Drinks.Name = "Btn_Soft_Drinks";
            this.Btn_Soft_Drinks.UseVisualStyleBackColor = true;
            this.Btn_Soft_Drinks.Click += new System.EventHandler(this.Btn_Soft_Drinks_Click);
            // 
            // Btn_Shower_Products
            // 
            resources.ApplyResources(this.Btn_Shower_Products, "Btn_Shower_Products");
            this.Btn_Shower_Products.Name = "Btn_Shower_Products";
            this.Btn_Shower_Products.UseVisualStyleBackColor = true;
            this.Btn_Shower_Products.Click += new System.EventHandler(this.Btn_Hygenic_Products_Click);
            // 
            // Btn_Vegetables
            // 
            resources.ApplyResources(this.Btn_Vegetables, "Btn_Vegetables");
            this.Btn_Vegetables.Name = "Btn_Vegetables";
            this.Btn_Vegetables.UseVisualStyleBackColor = true;
            this.Btn_Vegetables.Click += new System.EventHandler(this.Btn_Vegetables_Click);
            // 
            // Btn_Coffee_Products
            // 
            resources.ApplyResources(this.Btn_Coffee_Products, "Btn_Coffee_Products");
            this.Btn_Coffee_Products.Name = "Btn_Coffee_Products";
            this.Btn_Coffee_Products.UseVisualStyleBackColor = true;
            this.Btn_Coffee_Products.Click += new System.EventHandler(this.Btn_Coffee_Products_Click);
            // 
            // Btn_Save
            // 
            resources.ApplyResources(this.Btn_Save, "Btn_Save");
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click_1);
            // 
            // Btn_Load
            // 
            resources.ApplyResources(this.Btn_Load, "Btn_Load");
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click_1);
            // 
            // Btn_All_Items
            // 
            resources.ApplyResources(this.Btn_All_Items, "Btn_All_Items");
            this.Btn_All_Items.Name = "Btn_All_Items";
            this.Btn_All_Items.UseVisualStyleBackColor = true;
            this.Btn_All_Items.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Panel_Cart_Small
            // 
            resources.ApplyResources(this.Panel_Cart_Small, "Panel_Cart_Small");
            this.Panel_Cart_Small.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Cart_Small.Controls.Add(this.button1);
            this.Panel_Cart_Small.Controls.Add(this.label2);
            this.Panel_Cart_Small.Controls.Add(this.label1);
            this.Panel_Cart_Small.Name = "Panel_Cart_Small";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalPricePanel
            // 
            this.TotalPricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPricePanel.Controls.Add(this.TotalPriceLabel);
            resources.ApplyResources(this.TotalPricePanel, "TotalPricePanel");
            this.TotalPricePanel.Name = "TotalPricePanel";
            this.TotalPricePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TotalPricePanel_Paint);
            // 
            // TotalPriceLabel
            // 
            resources.ApplyResources(this.TotalPriceLabel, "TotalPriceLabel");
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            // 
            // Btn_ClearOrder
            // 
            resources.ApplyResources(this.Btn_ClearOrder, "Btn_ClearOrder");
            this.Btn_ClearOrder.Name = "Btn_ClearOrder";
            this.Btn_ClearOrder.UseVisualStyleBackColor = true;
            this.Btn_ClearOrder.Click += new System.EventHandler(this.Btn_ClearOrder_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Btn_ClearOrder);
            this.Controls.Add(this.TotalPricePanel);
            this.Controls.Add(this.Panel_Cart_Small);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShopContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.Panel_Cart_Small.ResumeLayout(false);
            this.Panel_Cart_Small.PerformLayout();
            this.TotalPricePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel ShopContainer;
        private Panel panel1;
        private Button Btn_Meat_Products;
        private Button Btn_Dairy_Products;
        private Button Btn_Soft_Drinks;
        private Button Btn_Shower_Products;
        private Button Btn_Vegetables;
        private Button Btn_Coffee_Products;
        private Button Btn_Save;
        private Button Btn_Load;
        private Button Btn_All_Items;
        private Button Btn_Dental_Products;
        private Panel Panel_Cart_Small;
        private Label label2;
        private Label label1;
        private Panel TotalPricePanel;
        private Label TotalPriceLabel;
        private Button button1;
        private Button Btn_ClearOrder;
    }
}