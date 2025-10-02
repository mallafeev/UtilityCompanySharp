namespace CourseWorkPIPS
{
    partial class AddressesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label1 = new Label();
            buttonAddAddress = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            buttonUsePass = new Button();
            label3 = new Label();
            label2 = new Label();
            dataGridViewBoundPasses = new DataGridView();
            dataGridViewAllPasses = new DataGridView();
            btnRemovePass = new Button();
            btnAddPass = new Button();
            button2 = new Button();
            dataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            label = new Label();
            labelUse = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoundPasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllPasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(782, 27);
            label1.Name = "label1";
            label1.Size = new Size(368, 46);
            label1.TabIndex = 0;
            label1.Text = "Управление адресами";
            // 
            // buttonAddAddress
            // 
            buttonAddAddress.Location = new Point(30, 45);
            buttonAddAddress.Name = "buttonAddAddress";
            buttonAddAddress.Size = new Size(170, 30);
            buttonAddAddress.TabIndex = 2;
            buttonAddAddress.Text = "Добавить адрес";
            buttonAddAddress.UseVisualStyleBackColor = true;
            buttonAddAddress.Click += btnAddAddress_Click;
            // 
            // button1
            // 
            button1.Location = new Point(52, 54);
            button1.Name = "button1";
            button1.Size = new Size(139, 31);
            button1.TabIndex = 3;
            button1.Text = "На главную";
            button1.UseVisualStyleBackColor = true;
            button1.Click += returnMain;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelUse);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(buttonUsePass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridViewBoundPasses);
            groupBox1.Controls.Add(dataGridViewAllPasses);
            groupBox1.Controls.Add(btnRemovePass);
            groupBox1.Controls.Add(btnAddPass);
            groupBox1.Location = new Point(990, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(885, 668);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление/удаление допуска на адрес";
            // 
            // buttonUsePass
            // 
            buttonUsePass.Location = new Point(513, 586);
            buttonUsePass.Name = "buttonUsePass";
            buttonUsePass.Size = new Size(195, 29);
            buttonUsePass.TabIndex = 11;
            buttonUsePass.Text = "Использовать пропуск";
            buttonUsePass.UseVisualStyleBackColor = true;
            buttonUsePass.Click += buttonUsePass_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 40);
            label3.Name = "label3";
            label3.Size = new Size(235, 20);
            label3.TabIndex = 10;
            label3.Text = "Пропуска, допущенные к адресу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 40);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 9;
            label2.Text = "Все доступные пропуска";
            // 
            // dataGridViewBoundPasses
            // 
            dataGridViewBoundPasses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBoundPasses.BackgroundColor = Color.MediumAquamarine;
            dataGridViewBoundPasses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBoundPasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBoundPasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewBoundPasses.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBoundPasses.EnableHeadersVisualStyles = false;
            dataGridViewBoundPasses.Location = new Point(513, 63);
            dataGridViewBoundPasses.Name = "dataGridViewBoundPasses";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewBoundPasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBoundPasses.RowHeadersWidth = 51;
            dataGridViewBoundPasses.Size = new Size(355, 508);
            dataGridViewBoundPasses.TabIndex = 8;
            // 
            // dataGridViewAllPasses
            // 
            dataGridViewAllPasses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAllPasses.BackgroundColor = Color.MediumAquamarine;
            dataGridViewAllPasses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewAllPasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAllPasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewAllPasses.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewAllPasses.EnableHeadersVisualStyles = false;
            dataGridViewAllPasses.Location = new Point(23, 63);
            dataGridViewAllPasses.Name = "dataGridViewAllPasses";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewAllPasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewAllPasses.RowHeadersWidth = 51;
            dataGridViewAllPasses.Size = new Size(388, 508);
            dataGridViewAllPasses.TabIndex = 7;
            // 
            // btnRemovePass
            // 
            btnRemovePass.Location = new Point(445, 291);
            btnRemovePass.Name = "btnRemovePass";
            btnRemovePass.Size = new Size(40, 40);
            btnRemovePass.TabIndex = 3;
            btnRemovePass.Text = "<-";
            btnRemovePass.UseVisualStyleBackColor = true;
            btnRemovePass.Click += BtnRemovePass_Click;
            // 
            // btnAddPass
            // 
            btnAddPass.Location = new Point(445, 234);
            btnAddPass.Name = "btnAddPass";
            btnAddPass.Size = new Size(40, 40);
            btnAddPass.TabIndex = 2;
            btnAddPass.Text = "->";
            btnAddPass.UseVisualStyleBackColor = true;
            btnAddPass.Click += BtnAddPass_Click;
            // 
            // button2
            // 
            button2.Location = new Point(238, 45);
            button2.Name = "button2";
            button2.Size = new Size(170, 30);
            button2.TabIndex = 5;
            button2.Text = "Удалить адрес";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnDeleteAddress_Click;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.MediumAquamarine;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(52, 114);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(885, 569);
            dataGridView.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(buttonAddAddress);
            groupBox2.Location = new Point(52, 712);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 113);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Управление адресами";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(513, 624);
            label.Name = "label";
            label.Size = new Size(192, 20);
            label.TabIndex = 12;
            label.Text = "Использовано пропусков:";
            // 
            // labelUse
            // 
            labelUse.AutoSize = true;
            labelUse.Location = new Point(708, 624);
            labelUse.Name = "labelUse";
            labelUse.Size = new Size(0, 20);
            labelUse.TabIndex = 13;
            // 
            // AddressesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1902, 1033);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "AddressesForm";
            Text = "Форма адресов";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoundPasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllPasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAddAddress;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnRemovePass;
        private Button btnAddPass;
        private Button button2;
        private DataGridView dataGridView;
        private DataGridView dataGridViewBoundPasses;
        private DataGridView dataGridViewAllPasses;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Button buttonUsePass;
        private Label labelUse;
        private Label label;
    }
}