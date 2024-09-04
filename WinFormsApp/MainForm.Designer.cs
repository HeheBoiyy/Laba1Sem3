﻿namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewStudents = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new Point(12, 12);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new Size(501, 345);
            listViewStudents.TabIndex = 0;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(559, 12);
            button1.Name = "button1";
            button1.Size = new Size(200, 23);
            button1.TabIndex = 1;
            button1.Text = "Добавить студента";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddStudent_Click;
            // 
            // button2
            // 
            button2.Location = new Point(559, 51);
            button2.Name = "button2";
            button2.Size = new Size(200, 23);
            button2.TabIndex = 2;
            button2.Text = "Удалить выбранного студента";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRemoveStudent_Click;
            // 
            // button3
            // 
            button3.Location = new Point(559, 90);
            button3.Name = "button3";
            button3.Size = new Size(200, 23);
            button3.TabIndex = 3;
            button3.Text = "Изменить выбранного студента";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnUpdateStudent_Click;
            // 
            // button4
            // 
            button4.Location = new Point(559, 298);
            button4.Name = "button4";
            button4.Size = new Size(200, 59);
            button4.TabIndex = 4;
            button4.Text = "Гистаграмма";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnShowDistribution_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewStudents);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewStudents;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
