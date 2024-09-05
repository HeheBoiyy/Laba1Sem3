namespace WinFormsApp
{
    partial class UpdateStudentForm
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
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            txtGroup = new TextBox();
            txtSpeciality = new TextBox();
            label2 = new Label();
            NameTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 12);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 0;
            label1.Text = "Изменение данных студента";
            // 
            // button1
            // 
            button1.Location = new Point(123, 166);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(211, 31);
            button1.TabIndex = 14;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 123);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 13;
            label4.Text = "Группа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 84);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 12;
            label3.Text = "Специальность";
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(290, 123);
            txtGroup.Margin = new Padding(3, 4, 3, 4);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(114, 27);
            txtGroup.TabIndex = 10;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(290, 84);
            txtSpeciality.Margin = new Padding(3, 4, 3, 4);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(114, 27);
            txtSpeciality.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 43);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 15;
            label2.Text = "Имя";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(290, 40);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(112, 27);
            NameTextBox.TabIndex = 16;
            // 
            // UpdateStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 219);
            Controls.Add(NameTextBox);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtGroup);
            Controls.Add(txtSpeciality);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateStudentForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label4;
        private Label label3;
        private TextBox txtGroup;
        private TextBox txtSpeciality;
        private Label label2;
        private TextBox NameTextBox;
    }
}