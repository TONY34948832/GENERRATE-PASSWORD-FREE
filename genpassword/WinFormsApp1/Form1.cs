using System.Diagnostics;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button btnSave;
        private ListBox lstPasswords; // ���� ListBox ���
        Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int passwordLength = Convert.ToInt32(textBox2.Text); // �Ѻ��Ҥ�����Ǣͧ���ʼ�ҹ�ҡ TextBox
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // ��˹�����ѡ�÷��͹حҵ���������ʼ�ҹ

            Random rand = new Random();
            StringBuilder password = new StringBuilder(passwordLength);

            for (int i = 0; i < passwordLength; i++)
            {
                password.Append(allowedChars[rand.Next(allowedChars.Length)]);
            }




            // �����ʼ�ҹ��ѧ TextBox
            textBox3.Text = password.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text); // �Ӥ�Ҩҡ TextBox ��ҧ� Clipboard
            MessageBox.Show("Password copied to clipboard."); // �ʴ���ͤ�������͹��Ҥ�Ҷ١�Ѵ�͡����
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point lastPoint;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                string url = "https://discord.gg/7VnzmupNTF"; // ����¹ URL ���ԧ�����ͧ����Դ

                // �Դ�ԧ�캹���������
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }
    }
}