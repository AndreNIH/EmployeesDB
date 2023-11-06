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
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 84);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 112);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 140);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 170);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Contratacion:";
            // 
            // employeeNumTextbox
            // 
            employeeNumTextbox.Location = new Point(144, 20);
            employeeNumTextbox.Name = "employeeNumTextbox";
            employeeNumTextbox.Size = new Size(220, 23);
            employeeNumTextbox.TabIndex = 0;
            // 
            // firstNameTextbox
            // 
            firstNameTextbox.Location = new Point(144, 76);
            firstNameTextbox.Name = "firstNameTextbox";
            firstNameTextbox.Size = new Size(220, 23);
            firstNameTextbox.TabIndex = 2;
            // 
            // lastNameTextbox
            // 
            lastNameTextbox.Location = new Point(144, 104);
            lastNameTextbox.Name = "lastNameTextbox";
            lastNameTextbox.Size = new Size(220, 23);
            lastNameTextbox.TabIndex = 3;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(144, 48);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(220, 23);
            birthDatePicker.TabIndex = 1;
            // 
            // hireDatePicker
            // 
            hireDatePicker.Location = new Point(144, 162);
            hireDatePicker.Name = "hireDatePicker";
            hireDatePicker.Size = new Size(220, 23);
            hireDatePicker.TabIndex = 5;
            // 
            // okButton
            // 
            okButton.Location = new Point(291, 319);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 12;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(210, 319);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
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
            genderBox.Location = new Point(144, 132);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(220, 23);
            genderBox.TabIndex = 4;
            // 
            // EmployeDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 354);
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