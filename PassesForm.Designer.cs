namespace CourseWorkPIPS
{
    partial class PassesForm
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
            dataGridViewPasses = new DataGridView();
            comboBoxType = new ComboBox();
            comboBoxKind = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            buttonMain = new Button();
            button2 = new Button();
            pictureBoxQRCode = new PictureBox();
            button3 = new Button();
            groupBox1 = new GroupBox();
            buttonClear = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            buttonProd = new Button();
            label3 = new Label();
            textBoxCodePr = new TextBox();
            label2 = new Label();
            dateTimePickerDo = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPasses
            // 
            dataGridViewPasses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPasses.BackgroundColor = Color.MediumAquamarine;
            dataGridViewPasses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPasses.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPasses.EnableHeadersVisualStyles = false;
            dataGridViewPasses.Location = new Point(23, 70);
            dataGridViewPasses.Name = "dataGridViewPasses";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPasses.RowHeadersWidth = 51;
            dataGridViewPasses.Size = new Size(1867, 545);
            dataGridViewPasses.TabIndex = 0;
            dataGridViewPasses.CellDoubleClick += dataGridViewPasses_CellDoubleClick;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(239, 40);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 1;
            // 
            // comboBoxKind
            // 
            comboBoxKind.FormattingEnabled = true;
            comboBoxKind.Location = new Point(45, 40);
            comboBoxKind.Name = "comboBoxKind";
            comboBoxKind.Size = new Size(151, 28);
            comboBoxKind.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(762, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 46);
            label1.TabIndex = 3;
            label1.Text = "Управление пропусками";
            // 
            // button1
            // 
            button1.Location = new Point(45, 41);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 4;
            button1.Text = "Создать пропуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCreatePass_Click;
            // 
            // buttonMain
            // 
            buttonMain.Location = new Point(45, 29);
            buttonMain.Name = "buttonMain";
            buttonMain.Size = new Size(113, 29);
            buttonMain.TabIndex = 5;
            buttonMain.Text = "На главную";
            buttonMain.UseVisualStyleBackColor = true;
            buttonMain.Click += returnMain;
            // 
            // button2
            // 
            button2.Location = new Point(239, 41);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 6;
            button2.Text = "Удалить пропуск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnDeletePass_Click;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(23, 26);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(250, 250);
            pictureBoxQRCode.TabIndex = 7;
            pictureBoxQRCode.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(45, 42);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 8;
            button3.Text = "Создать отчёт";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(comboBoxKind);
            groupBox1.Location = new Point(23, 670);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 151);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтрация пропусков";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(45, 92);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(151, 29);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Сбросить фильтры";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(23, 856);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 104);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Управление пропусками";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(pictureBoxQRCode);
            groupBox3.Location = new Point(502, 670);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(275, 285);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Поделиться кодом пропуска";
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(806, 856);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(237, 104);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Инструменты для отчётов";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonProd);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(textBoxCodePr);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(dateTimePickerDo);
            groupBox4.Location = new Point(806, 634);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(388, 175);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Продление пропуска";
            // 
            // buttonProd
            // 
            buttonProd.Location = new Point(14, 122);
            buttonProd.Name = "buttonProd";
            buttonProd.Size = new Size(112, 29);
            buttonProd.TabIndex = 4;
            buttonProd.Text = "Продлить";
            buttonProd.UseVisualStyleBackColor = true;
            buttonProd.Click += buttonProd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 82);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 3;
            label3.Text = "Продлить до:";
            // 
            // textBoxCodePr
            // 
            textBoxCodePr.Location = new Point(121, 36);
            textBoxCodePr.Name = "textBoxCodePr";
            textBoxCodePr.Size = new Size(242, 27);
            textBoxCodePr.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Пропуск:";
            // 
            // dateTimePickerDo
            // 
            dateTimePickerDo.Location = new Point(121, 77);
            dateTimePickerDo.Name = "dateTimePickerDo";
            dateTimePickerDo.Size = new Size(242, 27);
            dateTimePickerDo.TabIndex = 0;
            // 
            // PassesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1902, 1033);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonMain);
            Controls.Add(label1);
            Controls.Add(dataGridViewPasses);
            Name = "PassesForm";
            Text = "Форма пропусков";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPasses;
        private ComboBox comboBoxType;
        private ComboBox comboBoxKind;
        private Label label1;
        private Button button1;
        private Button buttonMain;
        private Button button2;
        private PictureBox pictureBoxQRCode;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Button buttonProd;
        private Label label3;
        private TextBox textBoxCodePr;
        private Label label2;
        private DateTimePicker dateTimePickerDo;
        private Button buttonClear;
    }
}