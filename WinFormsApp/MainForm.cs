using BusinessLogic;
using Model;
namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private Logic logic = new Logic();
        /// <summary>
        /// ����������� ��� ������������� ������� MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeListView();
            LoadStudents();
        }
        /// <summary>
        /// ������ ���������� ListView
        /// </summary>
        private void InitializeListView()
        {
            listViewStudents.View = View.Details;
            listViewStudents.FullRowSelect = true;
            listViewStudents.GridLines = true;
            listViewStudents.Columns.Clear();
            listViewStudents.Columns.Add("���", 150);
            listViewStudents.Columns.Add("�������������", 150);
            listViewStudents.Columns.Add("������", 100);
        }

        /// <summary>
        /// ���������� ������ ���������
        /// </summary>
        private void LoadStudents()
        {
            listViewStudents.Items.Clear();

            foreach (var student in logic.GetAllStudents())
            {
                var item = new ListViewItem(student.Name);
                item.SubItems.Add(student.Speciality);
                item.SubItems.Add(student.Group);
                listViewStudents.Items.Add(item);
            }
        }
        /// <summary>
        /// ���������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var addForm = new AddStudentForm(logic);
            addForm.ShowDialog();
            RefreshStudentList();
        }
        /// <summary>
        /// �������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            try { var SelectedIt = listViewStudents.SelectedItems[0]; }
            catch
            {
                MessageBox.Show("����� ������ ��� ������ �� ������?");
                return;
            }
            var SelectedItem = listViewStudents.SelectedItems[0];
            string name = SelectedItem.Text;
            logic.RemoveStudent(name);
            RefreshStudentList();
            
        }
        /// <summary>
        /// ��������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var selecteditem = listViewStudents.SelectedItems[0].Text;
            }
            catch
            {
                MessageBox.Show("����� ������ ��� ������ �� ������?");
                return;
            }
            var updateForm = new UpdateStudentForm(logic, listViewStudents.SelectedItems[0].Text);
            updateForm.ShowDialog();
            RefreshStudentList();
        }
        /// <summary>
        /// ���������� ������ ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListStudents_Click(object sender, EventArgs e)
        {
            RefreshStudentList();
        }
        /// <summary>
        /// ����������� �����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowDistribution_Click(object sender, EventArgs e)
        {
            if(logic.GetSpecialityDistribution().Count!=0)
            {
                var distributionForm = new DistributionForm(logic, logic.GetSpecialityDistribution());
                distributionForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("����������� ������ ��� ��������� �������");
            }
        }
        /// <summary>
        /// ����� ��� ���������� ������ ���������
        /// </summary>
        private void RefreshStudentList()
        {
            listViewStudents.Items.Clear();
            foreach (var student in logic.GetAllStudents())
            {
                var item = new ListViewItem(student.Name);
                item.SubItems.Add(student.Speciality);
                item.SubItems.Add(student.Group);
                listViewStudents.Items.Add(item);
            }
        }
    }
}
