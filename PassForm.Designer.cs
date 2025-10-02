namespace CourseWorkPIPS
{
    partial class PassForm
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
            buttonGenerateCode = new Button();
            comboBoxTypes = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerStart = new DateTimePicker();
            label4 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            label5 = new Label();
            comboBoxKind = new ComboBox();
            label6 = new Label();
            comboBoxStatus = new ComboBox();
            label7 = new Label();
            textBoxCode = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonGenerateCode
            // 
            buttonGenerateCode.BackColor = SystemColors.ButtonFace;
            buttonGenerateCode.Location = new Point(34, 266);
            buttonGenerateCode.Name = "buttonGenerateCode";
            buttonGenerateCode.Size = new Size(128, 29);
            buttonGenerateCode.TabIndex = 1;
            buttonGenerateCode.Text = "Сгенерировать ";
            buttonGenerateCode.TextAlign = ContentAlignment.MiddleRight;
            buttonGenerateCode.UseVisualStyleBackColor = false;
            buttonGenerateCode.Click += btnGenerateCode_Click;
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Location = new Point(180, 123);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(184, 28);
            comboBoxTypes.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(34, 131);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Тип пропуска";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(34, 52);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 5;
            label3.Text = "Начало действия";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(180, 45);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(184, 27);
            dateTimePickerStart.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(34, 94);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 7;
            label4.Text = "Конец действия";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(180, 87);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(184, 27);
            dateTimePickerEnd.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(34, 165);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 9;
            label5.Text = "Вид пропуска";
            // 
            // comboBoxKind
            // 
            comboBoxKind.FormattingEnabled = true;
            comboBoxKind.Location = new Point(180, 157);
            comboBoxKind.Name = "comboBoxKind";
            comboBoxKind.Size = new Size(184, 28);
            comboBoxKind.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(34, 204);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 11;
            label6.Text = "Статус пропуска";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(180, 196);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(184, 28);
            comboBoxStatus.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(34, 240);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 13;
            label7.Text = "Уникальный код";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(180, 240);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(184, 27);
            textBoxCode.TabIndex = 14;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.Location = new Point(79, 313);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 42);
            buttonSave.TabIndex = 15;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(209, 313);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 42);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(180, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(184, 27);
            textBoxName.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 18;
            label1.Text = "Название";
            // 
            // PassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(390, 375);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxCode);
            Controls.Add(label7);
            Controls.Add(comboBoxStatus);
            Controls.Add(label6);
            Controls.Add(comboBoxKind);
            Controls.Add(label5);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(label4);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxTypes);
            Controls.Add(buttonGenerateCode);
            Name = "PassForm";
            Text = "Форма пропуска";
            Load += PassForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonGenerateCode;
        private ComboBox comboBoxTypes;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerStart;
        private Label label4;
        private DateTimePicker dateTimePickerEnd;
        private Label label5;
        private ComboBox comboBoxKind;
        private Label label6;
        private ComboBox comboBoxStatus;
        private Label label7;
        private TextBox textBoxCode;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxName;
        private Label label1;
    }
}