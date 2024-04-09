namespace AutoShop.List.items
{
    partial class itemService
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            serviceTableAdapter1 = new DataSet1TableAdapters.serviceTableAdapter();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            buyBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // serviceTableAdapter1
            // 
            serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(358, 22);
            label1.Name = "label1";
            label1.Size = new Size(186, 41);
            label1.TabIndex = 0;
            label1.Text = "Ремонт КПП";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(358, 86);
            label2.Name = "label2";
            label2.Size = new Size(99, 128);
            label2.TabIndex = 1;
            label2.Text = "Полное\r\nа\r\nб\r\nв";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(847, 81);
            label3.Name = "label3";
            label3.Size = new Size(121, 37);
            label3.TabIndex = 2;
            label3.Text = "50 000 ₽";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 353);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(195, 195, 195);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 375);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1075, 2);
            guna2Panel1.TabIndex = 4;
            // 
            // buyBtn
            // 
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
            buyBtn.Location = new Point(827, 235);
            buyBtn.Name = "buyBtn";
            buyBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buyBtn.Size = new Size(166, 56);
            buyBtn.TabIndex = 8;
            buyBtn.Text = "Заказать";
            buyBtn.Click += buyBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(808, 133);
            label5.Name = "label5";
            label5.Size = new Size(202, 84);
            label5.TabIndex = 7;
            label5.Text = "После заказа с вами \r\nсвяжутся и уточнять \r\nмодель авто и цену";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // itemService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 377);
            Controls.Add(buyBtn);
            Controls.Add(label5);
            Controls.Add(guna2Panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "itemService";
            Text = "itemService";
            Load += itemService_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private DataSet1TableAdapters.serviceTableAdapter serviceTableAdapter1;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton buyBtn;
        private Label label5;
    }
}