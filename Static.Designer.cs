namespace CourseWorkPIPS
{
    partial class Static
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
            buttonGenerate = new Button();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(29, 219);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(214, 29);
            buttonGenerate.TabIndex = 0;
            buttonGenerate.Text = "Сформировать отчёт";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(185, 49);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(185, 96);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerStart);
            groupBox1.Controls.Add(dateTimePickerEnd);
            groupBox1.Location = new Point(29, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 164);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Период отчёта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 54);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 3;
            label1.Text = "Начальная дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 4;
            label2.Text = "Конечная дата";
            // 
            // Static
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(542, 302);
            Controls.Add(groupBox1);
            Controls.Add(buttonGenerate);
            Name = "Static";
            Text = "Создание статистики";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGenerate;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
    }

}