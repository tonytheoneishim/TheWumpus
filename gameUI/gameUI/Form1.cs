using studentInfo;

namespace gameUI
{
    public partial class gameUI : Form
    {
        StudentManager _studentManager = new StudentManager();

        public gameUI()
        {
            InitializeComponent();
        }

        private void getStudent_Click(object sender, EventArgs e)
        {
            Student s = _studentManager.GetStudent();
            getStudentText.Text = s.Name;
            addressText.Text = s.Address;
            emailText.Text = s.Email;
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            string name = getStudentText.Text;
            string address = addressText.Text;
            string email = emailText.Text;

            Student student = new Student(name, address, email);

            _studentManager.AddStudent(student);
        }
    }
}
