namespace CourseWorkPIPS
{
    partial class AddressForm
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
            textBoxAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxNumber = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(141, 55);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(166, 27);
            textBoxAddress.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Адрес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 107);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Номер дома";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(141, 107);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(166, 27);
            textBoxNumber.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.Location = new Point(54, 180);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 47);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(186, 180);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 47);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(363, 286);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAddress);
            Name = "AddressForm";
            Text = "Форма адреса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddress;
        private Label label1;
        private Label label2;
        private TextBox textBoxNumber;
        private Button buttonSave;
        private Button buttonCancel;
    }
}