using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp
{
    public partial class UpdateStudentForm : Form
    {
        private Logic logic;
        private string name;
        /// <summary>
        /// Конструктор для инициализации UpdateStudentForm
        /// </summary>
        /// <param name="logic">Бизнес логика</param>
        /// <param name="name">Имя студента</param>
        public UpdateStudentForm(Logic logic,string name)
        {
            InitializeComponent();
            this.logic = logic;
            this.name = name;
        }
        /// <summary>
        /// Метод для обновления данных о студенте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newSpeciality = txtSpeciality.Text;
            string newGroup = txtGroup.Text;
            if (newSpeciality == string.Empty || newGroup == string.Empty)
            {
                MessageBox.Show("Ошибка! Одно из полей пустое! Повторите заново");
            }
            else
            {
                logic.UpdateStudent(name, newSpeciality, newGroup);
                MessageBox.Show("Данные студента обновлены.");
                this.Close();
            }
            
        }
    }
}
