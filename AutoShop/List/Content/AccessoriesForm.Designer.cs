namespace AutoShop.List.Content
{
    partial class AccessoriesForm
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
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2vTrackBar1 = new Guna.UI2.WinForms.Guna2VTrackBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2vTrackBar1
            // 
            guna2vTrackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            guna2vTrackBar1.Location = new Point(1108, 65);
            guna2vTrackBar1.Name = "guna2vTrackBar1";
            guna2vTrackBar1.Size = new Size(20, 879);
            guna2vTrackBar1.TabIndex = 2;
            guna2vTrackBar1.ThumbColor = Color.FromArgb(160, 113, 255);
            guna2vTrackBar1.Value = 0;
            guna2vTrackBar1.Scroll += guna2vTrackBar1_Scroll;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(12, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1079, 879);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AccessoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 956);
            Controls.Add(guna2vTrackBar1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccessoriesForm";
            Text = "Accessories";
            Load += AccessoriesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2VTrackBar guna2vTrackBar1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}