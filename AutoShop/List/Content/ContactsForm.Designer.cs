namespace AutoShop.List.Content
{
    partial class ContactsForm
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
            label1 = new Label();
            emailingBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            contactPic = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            contactTableAdapter1 = new DataSet1TableAdapters.contactTableAdapter();
            ((System.ComponentModel.ISupportInitialize)contactPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(441, 57);
            label1.TabIndex = 0;
            label1.Text = "Центральный офис в ";
            // 
            // emailingBtn
            // 
            emailingBtn.BorderRadius = 25;
            emailingBtn.CustomizableEdges = customizableEdges1;
            emailingBtn.DisabledState.BorderColor = Color.DarkGray;
            emailingBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            emailingBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            emailingBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            emailingBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            emailingBtn.FillColor = Color.FromArgb(58, 179, 153);
            emailingBtn.FillColor2 = Color.FromArgb(79, 187, 164);
            emailingBtn.Font = new Font("Segoe UI", 16F);
            emailingBtn.ForeColor = Color.White;
            emailingBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            emailingBtn.Location = new Point(47, 86);
            emailingBtn.Name = "emailingBtn";
            emailingBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            emailingBtn.Size = new Size(285, 58);
            emailingBtn.TabIndex = 4;
            emailingBtn.Text = "Написать на почту";
            emailingBtn.Click += emailingBtn_Click;
            // 
            // contactPic
            // 
            contactPic.Image = Properties.Resources.free_icon_phone_call_126509;
            contactPic.Location = new Point(47, 182);
            contactPic.Margin = new Padding(6);
            contactPic.Name = "contactPic";
            contactPic.Size = new Size(71, 65);
            contactPic.SizeMode = PictureBoxSizeMode.Zoom;
            contactPic.TabIndex = 6;
            contactPic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_icon_location_5733320;
            pictureBox1.Location = new Point(47, 259);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.free_icon_clock_time_7955852;
            pictureBox2.Location = new Point(47, 336);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(127, 195);
            label2.Name = "label2";
            label2.Size = new Size(357, 41);
            label2.TabIndex = 9;
            label2.Text = "Телефон горячей линии:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(127, 274);
            label3.Name = "label3";
            label3.Size = new Size(115, 41);
            label3.TabIndex = 10;
            label3.Text = "Адресс";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(127, 350);
            label4.Name = "label4";
            label4.Size = new Size(234, 41);
            label4.TabIndex = 11;
            label4.Text = "График работы:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 462);
            label5.Name = "label5";
            label5.Size = new Size(372, 41);
            label5.TabIndex = 12;
            label5.Text = "Реквизиты организации";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(47, 532);
            label6.Margin = new Padding(6);
            label6.Name = "label6";
            label6.Size = new Size(76, 41);
            label6.TabIndex = 13;
            label6.Text = "Имя";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(47, 585);
            label7.Margin = new Padding(6);
            label7.Name = "label7";
            label7.Size = new Size(161, 41);
            label7.TabIndex = 14;
            label7.Text = "ИНН/КПП ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(47, 638);
            label8.Margin = new Padding(6);
            label8.Name = "label8";
            label8.Size = new Size(101, 41);
            label8.TabIndex = 15;
            label8.Text = "ОГРН ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(47, 719);
            label9.Margin = new Padding(6);
            label9.Name = "label9";
            label9.Size = new Size(250, 41);
            label9.TabIndex = 16;
            label9.Text = "Название банка: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(47, 772);
            label10.Margin = new Padding(6);
            label10.Name = "label10";
            label10.Size = new Size(246, 41);
            label10.TabIndex = 17;
            label10.Text = "Расчетный счет: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(47, 825);
            label11.Margin = new Padding(6);
            label11.Name = "label11";
            label11.Size = new Size(160, 41);
            label11.TabIndex = 18;
            label11.Text = "Кор. счет: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(47, 878);
            label12.Margin = new Padding(6);
            label12.Name = "label12";
            label12.Size = new Size(168, 41);
            label12.TabIndex = 19;
            label12.Text = "БИК банка:";
            // 
            // contactTableAdapter1
            // 
            contactTableAdapter1.ClearBeforeFill = true;
            // 
            // ContactsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 956);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(contactPic);
            Controls.Add(emailingBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContactsForm";
            Text = "ContactsForm";
            Load += ContactsForm_Load;
            ((System.ComponentModel.ISupportInitialize)contactPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton emailingBtn;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox contactPic;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataSet1TableAdapters.contactTableAdapter contactTableAdapter1;
    }
}