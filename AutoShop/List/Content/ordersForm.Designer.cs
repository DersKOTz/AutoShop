namespace AutoShop.List.Content
{
    partial class ordersForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            buyBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            label2 = new Label();
            label3 = new Label();
            tovarsTableAdapter1 = new DataSet1TableAdapters.tovarsTableAdapter();
            equipmentTableAdapter1 = new DataSet1TableAdapters.equipmentTableAdapter();
            ordersTableAdapter1 = new DataSet1TableAdapters.ordersTableAdapter();
            serviceTableAdapter1 = new DataSet1TableAdapters.serviceTableAdapter();
            carsTableAdapter1 = new DataSet1TableAdapters.carsTableAdapter();
            clientTableAdapter1 = new DataSet1TableAdapters.clientTableAdapter();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(12, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(802, 866);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(133, 41);
            label1.TabIndex = 2;
            label1.Text = "Корзина";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buyBtn
            // 
            buyBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buyBtn.BorderRadius = 25;
            buyBtn.CustomizableEdges = customizableEdges1;
            buyBtn.DisabledState.BorderColor = Color.DarkGray;
            buyBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            buyBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buyBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            buyBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buyBtn.FillColor = Color.FromArgb(58, 179, 153);
            buyBtn.FillColor2 = Color.FromArgb(79, 187, 164);
            buyBtn.Font = new Font("Segoe UI", 14F);
            buyBtn.ForeColor = Color.White;
            buyBtn.Location = new Point(846, 215);
            buyBtn.Name = "buyBtn";
            buyBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buyBtn.Size = new Size(229, 56);
            buyBtn.TabIndex = 6;
            buyBtn.Text = "Оформить заказ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(830, 78);
            label2.Name = "label2";
            label2.Size = new Size(122, 41);
            label2.TabIndex = 7;
            label2.Text = "Товары";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(830, 150);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 8;
            label3.Text = "Итого: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tovarsTableAdapter1
            // 
            tovarsTableAdapter1.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter1
            // 
            equipmentTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // serviceTableAdapter1
            // 
            serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // carsTableAdapter1
            // 
            carsTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter1
            // 
            clientTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 956);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buyBtn);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ordersForm";
            Text = "ordersForm";
            Load += ordersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton buyBtn;
        private Label label2;
        private Label label3;
        private DataSet1TableAdapters.tovarsTableAdapter tovarsTableAdapter1;
        private DataSet1TableAdapters.equipmentTableAdapter equipmentTableAdapter1;
        private DataSet1TableAdapters.ordersTableAdapter ordersTableAdapter1;
        private DataSet1TableAdapters.serviceTableAdapter serviceTableAdapter1;
        private DataSet1TableAdapters.carsTableAdapter carsTableAdapter1;
        private DataSet1TableAdapters.clientTableAdapter clientTableAdapter1;
    }
}