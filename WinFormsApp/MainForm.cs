using BusinessLogic;
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
            listViewStudents.Columns.Add("�����", 100);
            listViewStudents.Columns.Add("���", 100);
            listViewStudents.Columns.Add("�������������", 100);
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
                var item = new ListViewItem(student[0]);
                item.SubItems.Add(student[1]);
                item.SubItems.Add(student[2]);
                item.SubItems.Add(student[3]);
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
            int SelectedNum = listViewStudents.SelectedItems[0].Index;
            logic.RemoveStudent(SelectedNum);
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
            var updateForm = new UpdateStudentForm(logic, listViewStudents.SelectedItems[0].Index);
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
            try { logic.GetSpecialityDistribution(); }
            catch 
            {
                MessageBox.Show("������!����������� ������!");
                return;
            }
            var distributionForm = new DistributionForm(logic, logic.GetSpecialityDistribution());
            distributionForm.ShowDialog();
        }
        /// <summary>
        /// ����� ��� ���������� ������ ���������
        /// </summary>
        private void RefreshStudentList()
        {
            listViewStudents.Items.Clear();

            foreach (var student in logic.GetAllStudents())
            {
                var item = new ListViewItem(student[0]);
                item.SubItems.Add(student[1]);
                item.SubItems.Add(student[2]);
                item.SubItems.Add(student[3]);
                listViewStudents.Items.Add(item);
            }
        }
    }
}
