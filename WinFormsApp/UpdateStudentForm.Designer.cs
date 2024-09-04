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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 0;
            label1.Text = "Изменение данных студента";
            // 
            // button1
            // 
            button1.Location = new Point(108, 110);
            button1.Name = "button1";
            button1.Size = new Size(185, 23);
            button1.TabIndex = 14;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 62);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 13;
            label4.Text = "Группа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 33);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 12;
            label3.Text = "Специальность";
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(254, 62);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(100, 23);
            txtGroup.TabIndex = 10;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(254, 33);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(100, 23);
            txtSpeciality.TabIndex = 9;
            // 
            // UpdateStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 146);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtGroup);
            Controls.Add(txtSpeciality);
            Controls.Add(label1);
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
    }
}