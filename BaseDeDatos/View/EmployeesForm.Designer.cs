namespace BaseDeDatos
{
    partial class EmployeesForm
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
            empListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            createButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // empListView
            // 
            empListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader6, columnHeader5 });
            empListView.Dock = DockStyle.Fill;
            empListView.FullRowSelect = true;
            empListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            empListView.Location = new Point(10, 10);
            empListView.MultiSelect = false;
            empListView.Name = "empListView";
            empListView.Size = new Size(587, 525);
            empListView.TabIndex = 0;
            empListView.UseCompatibleStateImageBehavior = false;
            empListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "# de Empleado";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Genero";
            columnHeader4.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha de Cumpleaños";
            columnHeader6.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha de Contratación";
            columnHeader5.Width = 180;
            // 
            // createButton
            // 
            createButton.Location = new Point(7, 12);
            createButton.Name = "createButton";
            createButton.Size = new Size(112, 34);
            createButton.TabIndex = 1;
            createButton.Text = "Insertar";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click_1;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(7, 52);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(112, 34);
            updateButton.TabIndex = 2;
            updateButton.Text = "Modificar";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click_1;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(7, 92);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 34);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Borrar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(createButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(607, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 545);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(empListView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(607, 545);
            panel2.TabIndex = 5;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 545);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeesForm";
            Text = "EmployeesForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView empListView;
        private Button createButton;
        private Button updateButton;
        private Button deleteButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel panel1;
        private Panel panel2;
        private ColumnHeader columnHeader6;
    }
}