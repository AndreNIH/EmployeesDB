namespace BaseDeDatos
{
    partial class EmployeDataForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            employeeNumTextbox = new TextBox();
            firstNameTextbox = new TextBox();
            lastNameTextbox = new TextBox();
            birthDatePicker = new DateTimePicker();
            hireDatePicker = new DateTimePicker();
            okButton = new Button();
            cancelButton = new Button();
            genderBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 0;
            label1.Text = "Numero de Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 187);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 233);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 4;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 283);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(192, 25);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Contratacion:";
            // 
            // employeeNumTextbox
            // 
            employeeNumTextbox.Location = new Point(206, 33);
            employeeNumTextbox.Margin = new Padding(4, 5, 4, 5);
            employeeNumTextbox.Name = "employeeNumTextbox";
            employeeNumTextbox.Size = new Size(313, 31);
            employeeNumTextbox.TabIndex = 0;
            // 
            // firstNameTextbox
            // 
            firstNameTextbox.Location = new Point(206, 127);
            firstNameTextbox.Margin = new Padding(4, 5, 4, 5);
            firstNameTextbox.Name = "firstNameTextbox";
            firstNameTextbox.Size = new Size(313, 31);
            firstNameTextbox.TabIndex = 2;
            // 
            // lastNameTextbox
            // 
            lastNameTextbox.Location = new Point(206, 173);
            lastNameTextbox.Margin = new Padding(4, 5, 4, 5);
            lastNameTextbox.Name = "lastNameTextbox";
            lastNameTextbox.Size = new Size(313, 31);
            lastNameTextbox.TabIndex = 3;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(206, 80);
            birthDatePicker.Margin = new Padding(4, 5, 4, 5);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(313, 31);
            birthDatePicker.TabIndex = 1;
            // 
            // hireDatePicker
            // 
            hireDatePicker.Location = new Point(206, 270);
            hireDatePicker.Margin = new Padding(4, 5, 4, 5);
            hireDatePicker.Name = "hireDatePicker";
            hireDatePicker.Size = new Size(313, 31);
            hireDatePicker.TabIndex = 5;
            // 
            // okButton
            // 
            okButton.Location = new Point(416, 532);
            okButton.Margin = new Padding(4, 5, 4, 5);
            okButton.Name = "okButton";
            okButton.Size = new Size(107, 38);
            okButton.TabIndex = 12;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(300, 532);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(107, 38);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // genderBox
            // 
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Hombre", "Mujer" });
            genderBox.Location = new Point(206, 220);
            genderBox.Margin = new Padding(4, 5, 4, 5);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(313, 33);
            genderBox.TabIndex = 4;
            // 
            // EmployeDataForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 590);
            Controls.Add(genderBox);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(hireDatePicker);
            Controls.Add(birthDatePicker);
            Controls.Add(lastNameTextbox);
            Controls.Add(firstNameTextbox);
            Controls.Add(employeeNumTextbox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmployeDataForm";
            Text = "Datos de Empleado";
            Load += EmployeDataForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox employeeNumTextbox;
        private TextBox firstNameTextbox;
        private TextBox lastNameTextbox;
        private DateTimePicker birthDatePicker;
        private DateTimePicker hireDatePicker;
        private Button okButton;
        private Button cancelButton;
        private ComboBox genderBox;
    }
}