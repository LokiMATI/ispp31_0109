using System.Text;

namespace Task1
{
    public partial class Registration : Form
    {
        private const string LoginFileName = "logins.csv";
        public Registration()
        {
            InitializeComponent();
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void RegisterUser()
        {
            var errors = CheckTextBoxs();
            if (errors != string.Empty)
            {
                MessageBox.Show(errors, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(LoginFileName))
            {
                try
                {
                    CheckLogin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������������ � ����� ������� ��� ���������.",
                            "����� �����������",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    LoginTextBox.Text = string.Empty;
                    PasswordTextBox.Text = string.Empty;
                    return;
                }
            }
            WriteUser();
            MessageBox.Show("����������� �� ���������������� ������ ������������.",
                "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        private string CheckTextBoxs()
        {
            StringBuilder builder = new();
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
                builder.AppendLine("���� '�����' �� ������ ���� ������ ��� �������� �� ��������.");

            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
                builder.AppendLine("���� '������' �� ������ ���� ������ ��� �������� �� ��������.");

            return builder.ToString();
        }

        private void WriteUser()
        {
            using (StreamWriter writer = new(LoginFileName, true))
            {
                writer.WriteLine($"{LoginTextBox.Text};{PasswordTextBox.Text};{DateTime.Now}");
            }
        }

        private void CheckLogin()
        {
            using (StreamReader reader = new(LoginFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    if (line.Split(";")[0] == LoginTextBox.Text)
                        throw new Exception("������������ � ������ ������ ���������.");
            }
        }
    }
}
