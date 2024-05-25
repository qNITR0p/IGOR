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
            // Получение текста из textBox1
            string text = ((TextBox)sender).Text;

            // Проверка, является ли текст числом
            if (!double.TryParse(text, out double parsedValue))
            {
                MessageBox.Show("Введите число!");
                return; // Если текст не является числом, выводим сообщение и прекращаем выполнение метода
            }

            // Сохранение значения в переменную speed1
            speed1 = parsedValue;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Получение текста из textBox2
            string text = ((TextBox)sender).Text;

            // Проверка, является ли текст числом
            if (!double.TryParse(text, out double parsedValue))
            {
                MessageBox.Show("Введите число!");
                return; // Если текст не является числом, выводим сообщение и прекращаем выполнение метода
            }

            // Сохранение значения в переменную speed2
            speed2 = parsedValue;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Получение текста из textBox3
            string text = ((TextBox)sender).Text;

            // Проверка, является ли текст числом
            if (!double.TryParse(text, out double parsedValue))
            {
                MessageBox.Show("Введите число!");
                return; // Если текст не является числом, выводим сообщение и прекращаем выполнение метода
            }

            // Сохранение значения в переменную distant
            distant = parsedValue;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Получение текста из textBox3
            string text = ((TextBox)sender).Text;

            // Проверка, является ли текст числом
            if (!double.TryParse(text, out double parsedValue))
            {
                MessageBox.Show("Введите число!");
                return; // Если текст не является числом, выводим сообщение и прекращаем выполнение метода
            }

            // Сохранение значения в переменную distant
            time = parsedValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Вычисляем общую скорость
            double totalSpeed = (speed1 + speed2) / 2;

            // Вычисляем общий путь
            double totalDistanceTravelled = totalSpeed * time;

            // Вычисляем окончательное расстояние между автомобилями
            double finalDistance = distant + totalDistanceTravelled;

            // Выводим результат в textBox5
            textBox5.Text = $"Расстояние между автомобилями через {time} час(а): {finalDistance} км.";
        }
    }
}
