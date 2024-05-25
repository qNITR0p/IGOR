namespace IGOR
{
    public partial class Form1 : Form
    {

        private double speed1 = 0;

        private double speed2 = 0;

        private double distant = 0;

        private double time = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ��������� ������ �� textBox1
            string text = ((TextBox)sender).Text;

            // ��������, �������� �� ����� ������
            if (!double.TryParse(text, out double parsedValue))
            {
                MessageBox.Show("������� �����!");
                return; // ���� ����� �� �������� ������, ������� ��������� � ���������� ���������� ������
            }

            // ���������� �������� � ���������� speed1
            speed1 = parsedValue;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // ��������� ������ �� textBox2
            string text = ((TextBox)sender).Text;

            // ��������, �������� �� ����� ������
            if (!double.TryParse(text, out double parsedValue))
            {
                MessageBox.Show("������� �����!");
                return; // ���� ����� �� �������� ������, ������� ��������� � ���������� ���������� ������
            }

            // ���������� �������� � ���������� speed2
            speed2 = parsedValue;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // ��������� ������ �� textBox3
            string text = ((TextBox)sender).Text;

            // ��������, �������� �� ����� ������
            if (!double.TryParse(text, out double parsedValue))
            {
                MessageBox.Show("������� �����!");
                return; // ���� ����� �� �������� ������, ������� ��������� � ���������� ���������� ������
            }

            // ���������� �������� � ���������� distant
            distant = parsedValue;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // ��������� ������ �� textBox3
            string text = ((TextBox)sender).Text;

            // ��������, �������� �� ����� ������
            if (!double.TryParse(text, out double parsedValue))
            {
                MessageBox.Show("������� �����!");
                return; // ���� ����� �� �������� ������, ������� ��������� � ���������� ���������� ������
            }

            // ���������� �������� � ���������� distant
            time = parsedValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��������� ����� ��������
            double totalSpeed = (speed1 + speed2) / 2;

            // ��������� ����� ����
            double totalDistanceTravelled = totalSpeed * time;

            // ��������� ������������� ���������� ����� ������������
            double finalDistance = distant + totalDistanceTravelled;

            // ������� ��������� � textBox5
            textBox5.Text = $"���������� ����� ������������ ����� {time} ���(�): {finalDistance} ��.";
        }
    }
}
