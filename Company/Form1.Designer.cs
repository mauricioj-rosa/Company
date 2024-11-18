namespace Company
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSearch = new System.Windows.Forms.ToolStripComboBox();
            this.btnManager = new System.Windows.Forms.ToolStripSplitButton();
            this.btnManagerEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerGoals = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerServices = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerPurcharsing = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnManagerEmployeeReports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerGoalsSales = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerGoalsDeliveries = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerGoalsProd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManagerGoalsSallers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.ToolStripSplitButton();
            this.btnLoginPass = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoginSallerNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCostumers = new System.Windows.Forms.ToolStripSplitButton();
            this.btnCostumersAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCostumersEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.ToolStripLabel();
            this.btnInventory = new System.Windows.Forms.ToolStripButton();
            this.btnManagerMeetings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAppointments = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManagerEmployeesPasswords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout,
            this.btnSearch,
            this.toolStripSearch,
            this.btnManager,
            this.toolStripSeparator1,
            this.lblUser,
            this.btnLogin,
            this.btnCostumers,
            this.btnInventory,
            this.btnAppointments});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLogout
            // 
            this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(49, 22);
            this.btnLogout.Text = "Logout";
            // 
            // btnSearch
            // 
            this.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::Company.Properties.Resources.loupe;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.Text = "toolStripButton2";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(121, 25);
            // 
            // btnManager
            // 
            this.btnManager.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnManager.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManagerEmployee,
            this.btnManagerGoals,
            this.btnManagerProducts,
            this.btnManagerServices,
            this.btnManagerBackup,
            this.btnManagerInventory,
            this.btnManagerPurcharsing,
            this.btnManagerOrders,
            this.btnManagerMeetings});
            this.btnManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnManager.Image = ((System.Drawing.Image)(resources.GetObject("btnManager.Image")));
            this.btnManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(70, 22);
            this.btnManager.Text = "Manager";
            // 
            // btnManagerEmployee
            // 
            this.btnManagerEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManagerEmployeeReports,
            this.btnManagerEmployeesPasswords});
            this.btnManagerEmployee.Name = "btnManagerEmployee";
            this.btnManagerEmployee.Size = new System.Drawing.Size(180, 22);
            this.btnManagerEmployee.Text = "Employees";
            // 
            // btnManagerGoals
            // 
            this.btnManagerGoals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManagerGoalsSales,
            this.btnManagerGoalsDeliveries,
            this.btnManagerGoalsProd,
            this.btnManagerGoalsSallers});
            this.btnManagerGoals.Name = "btnManagerGoals";
            this.btnManagerGoals.Size = new System.Drawing.Size(180, 22);
            this.btnManagerGoals.Text = "Goals";
            // 
            // btnManagerProducts
            // 
            this.btnManagerProducts.Name = "btnManagerProducts";
            this.btnManagerProducts.Size = new System.Drawing.Size(180, 22);
            this.btnManagerProducts.Text = "Products";
            // 
            // btnManagerServices
            // 
            this.btnManagerServices.Name = "btnManagerServices";
            this.btnManagerServices.Size = new System.Drawing.Size(180, 22);
            this.btnManagerServices.Text = "Services";
            // 
            // btnManagerBackup
            // 
            this.btnManagerBackup.Name = "btnManagerBackup";
            this.btnManagerBackup.Size = new System.Drawing.Size(180, 22);
            this.btnManagerBackup.Text = "Backup";
            // 
            // btnManagerInventory
            // 
            this.btnManagerInventory.Name = "btnManagerInventory";
            this.btnManagerInventory.Size = new System.Drawing.Size(180, 22);
            this.btnManagerInventory.Text = "Inventory";
            // 
            // btnManagerPurcharsing
            // 
            this.btnManagerPurcharsing.Name = "btnManagerPurcharsing";
            this.btnManagerPurcharsing.Size = new System.Drawing.Size(180, 22);
            this.btnManagerPurcharsing.Text = "Purcharsing";
            // 
            // btnManagerOrders
            // 
            this.btnManagerOrders.Name = "btnManagerOrders";
            this.btnManagerOrders.Size = new System.Drawing.Size(180, 22);
            this.btnManagerOrders.Text = "Orders";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnManagerEmployeeReports
            // 
            this.btnManagerEmployeeReports.Name = "btnManagerEmployeeReports";
            this.btnManagerEmployeeReports.Size = new System.Drawing.Size(180, 22);
            this.btnManagerEmployeeReports.Text = "Reports";
            // 
            // btnManagerGoalsSales
            // 
            this.btnManagerGoalsSales.Name = "btnManagerGoalsSales";
            this.btnManagerGoalsSales.Size = new System.Drawing.Size(189, 22);
            this.btnManagerGoalsSales.Text = "Sales";
            // 
            // btnManagerGoalsDeliveries
            // 
            this.btnManagerGoalsDeliveries.Name = "btnManagerGoalsDeliveries";
            this.btnManagerGoalsDeliveries.Size = new System.Drawing.Size(189, 22);
            this.btnManagerGoalsDeliveries.Text = "Deliveries";
            // 
            // btnManagerGoalsProd
            // 
            this.btnManagerGoalsProd.Name = "btnManagerGoalsProd";
            this.btnManagerGoalsProd.Size = new System.Drawing.Size(189, 22);
            this.btnManagerGoalsProd.Text = "Products and Services";
            // 
            // btnManagerGoalsSallers
            // 
            this.btnManagerGoalsSallers.Name = "btnManagerGoalsSallers";
            this.btnManagerGoalsSallers.Size = new System.Drawing.Size(189, 22);
            this.btnManagerGoalsSallers.Text = "Sallers";
            // 
            // btnLogin
            // 
            this.btnLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoginPass,
            this.btnLoginSallerNumber});
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(53, 22);
            this.btnLogin.Text = "Login";
            // 
            // btnLoginPass
            // 
            this.btnLoginPass.Name = "btnLoginPass";
            this.btnLoginPass.Size = new System.Drawing.Size(180, 22);
            this.btnLoginPass.Text = "Password";
            // 
            // btnLoginSallerNumber
            // 
            this.btnLoginSallerNumber.Name = "btnLoginSallerNumber";
            this.btnLoginSallerNumber.Size = new System.Drawing.Size(180, 22);
            this.btnLoginSallerNumber.Text = "Saller Number";
            // 
            // btnCostumers
            // 
            this.btnCostumers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCostumers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCostumersAdd,
            this.btnCostumersEdit});
            this.btnCostumers.Image = ((System.Drawing.Image)(resources.GetObject("btnCostumers.Image")));
            this.btnCostumers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCostumers.Name = "btnCostumers";
            this.btnCostumers.Size = new System.Drawing.Size(80, 22);
            this.btnCostumers.Text = "Costumers";
            // 
            // btnCostumersAdd
            // 
            this.btnCostumersAdd.Name = "btnCostumersAdd";
            this.btnCostumersAdd.Size = new System.Drawing.Size(185, 22);
            this.btnCostumersAdd.Text = "Add a new Costumer";
            // 
            // btnCostumersEdit
            // 
            this.btnCostumersEdit.Name = "btnCostumersEdit";
            this.btnCostumersEdit.Size = new System.Drawing.Size(185, 22);
            this.btnCostumersEdit.Text = "Edit a Custumer";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 22);
            this.lblUser.Text = "Welcome User";
            // 
            // btnInventory
            // 
            this.btnInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(61, 22);
            this.btnInventory.Text = "Inventory";
            // 
            // btnManagerMeetings
            // 
            this.btnManagerMeetings.Name = "btnManagerMeetings";
            this.btnManagerMeetings.Size = new System.Drawing.Size(180, 22);
            this.btnManagerMeetings.Text = "Meetings";
            // 
            // btnAppointments
            // 
            this.btnAppointments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAppointments.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointments.Image")));
            this.btnAppointments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(87, 22);
            this.btnAppointments.Text = "Appointments";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnManagerEmployeesPasswords
            // 
            this.btnManagerEmployeesPasswords.Name = "btnManagerEmployeesPasswords";
            this.btnManagerEmployeesPasswords.Size = new System.Drawing.Size(180, 22);
            this.btnManagerEmployeesPasswords.Text = "Passwords";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnManager;
        private System.Windows.Forms.ToolStripMenuItem btnManagerEmployee;
        private System.Windows.Forms.ToolStripMenuItem btnManagerGoals;
        private System.Windows.Forms.ToolStripMenuItem btnManagerProducts;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripComboBox toolStripSearch;
        private System.Windows.Forms.ToolStripMenuItem btnManagerServices;
        private System.Windows.Forms.ToolStripMenuItem btnManagerBackup;
        private System.Windows.Forms.ToolStripMenuItem btnManagerInventory;
        private System.Windows.Forms.ToolStripMenuItem btnManagerPurcharsing;
        private System.Windows.Forms.ToolStripMenuItem btnManagerOrders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnManagerEmployeeReports;
        private System.Windows.Forms.ToolStripMenuItem btnManagerGoalsSales;
        private System.Windows.Forms.ToolStripMenuItem btnManagerGoalsDeliveries;
        private System.Windows.Forms.ToolStripMenuItem btnManagerGoalsProd;
        private System.Windows.Forms.ToolStripMenuItem btnManagerGoalsSallers;
        private System.Windows.Forms.ToolStripSplitButton btnLogin;
        private System.Windows.Forms.ToolStripMenuItem btnLoginPass;
        private System.Windows.Forms.ToolStripMenuItem btnLoginSallerNumber;
        private System.Windows.Forms.ToolStripMenuItem btnManagerMeetings;
        private System.Windows.Forms.ToolStripLabel lblUser;
        private System.Windows.Forms.ToolStripSplitButton btnCostumers;
        private System.Windows.Forms.ToolStripMenuItem btnCostumersAdd;
        private System.Windows.Forms.ToolStripMenuItem btnCostumersEdit;
        private System.Windows.Forms.ToolStripButton btnInventory;
        private System.Windows.Forms.ToolStripButton btnAppointments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem btnManagerEmployeesPasswords;
    }
}

