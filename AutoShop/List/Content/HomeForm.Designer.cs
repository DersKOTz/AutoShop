namespace AutoShop.List.Content
{
    partial class HomeForm
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
            label2 = new Label();
            startBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 60);
            label1.Name = "label1";
            label1.Size = new Size(857, 62);
            label1.TabIndex = 0;
            label1.Text = "Начните свое будущее вместе с нами!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(247, 165);
            label2.Name = "label2";
            label2.Size = new Size(623, 74);
            label2.TabIndex = 1;
            label2.Text = "Выбери свой автомобиль, выбери свою свободу\r\nМы подберем не просто машину, стиль жизни!";
            // 
            // startBtn
            // 
            startBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            startBtn.BorderRadius = 25;
            startBtn.CustomizableEdges = customizableEdges1;
            startBtn.DisabledState.BorderColor = Color.DarkGray;
            startBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            startBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            startBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            startBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            startBtn.FillColor = Color.FromArgb(58, 179, 153);
            startBtn.FillColor2 = Color.FromArgb(79, 187, 164);
            startBtn.Font = new Font("Segoe UI", 13.2F);
            startBtn.ForeColor = Color.White;
            startBtn.Location = new Point(438, 275);
            startBtn.Name = "startBtn";
            startBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            startBtn.Size = new Size(222, 65);
            startBtn.TabIndex = 2;
            startBtn.Text = "Приступить";
            startBtn.Click += startBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.A220512_web_2880;
            pictureBox1.Location = new Point(139, 427);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(848, 517);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 956);
            Controls.Add(pictureBox1);
            Controls.Add(startBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton startBtn;
        private Label label2;
        private Label label1;
    }
}