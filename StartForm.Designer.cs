namespace CourseWorkPIPS
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            label1 = new Label();
            label2 = new Label();
            buttonAddresses = new Button();
            buttonPasses = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(623, 42);
            label1.Name = "label1";
            label1.Size = new Size(646, 39);
            label1.TabIndex = 0;
            label1.Text = "Коммунальная управляющая компания";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20F);
            label2.Location = new Point(852, 81);
            label2.Name = "label2";
            label2.Size = new Size(169, 39);
            label2.TabIndex = 1;
            label2.Text = "Пропуска";
            // 
            // buttonAddresses
            // 
            buttonAddresses.Anchor = AnchorStyles.Top;
            buttonAddresses.Location = new Point(1062, 138);
            buttonAddresses.Name = "buttonAddresses";
            buttonAddresses.Size = new Size(227, 47);
            buttonAddresses.TabIndex = 2;
            buttonAddresses.Text = "Управление адресами";
            buttonAddresses.UseVisualStyleBackColor = true;
            buttonAddresses.Click += OpenAddressesForm;
            // 
            // buttonPasses
            // 
            buttonPasses.Anchor = AnchorStyles.Top;
            buttonPasses.Location = new Point(562, 138);
            buttonPasses.Name = "buttonPasses";
            buttonPasses.Size = new Size(227, 47);
            buttonPasses.TabIndex = 3;
            buttonPasses.Text = "Управление пропусками";
            buttonPasses.UseVisualStyleBackColor = true;
            buttonPasses.Click += OpenPassesForm;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(301, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1279, 676);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pictureBox1);
            Controls.Add(buttonPasses);
            Controls.Add(buttonAddresses);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "Главное меню";
            WindowState = FormWindowState.Maximized;
            Load += StartForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonAddresses;
        private Button buttonPasses;
        private PictureBox pictureBox1;
    }
}