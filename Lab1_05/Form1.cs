namespace Lab1_05
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None; // Убрать рамку у формы
            //this.StartPosition = FormStartPosition.CenterScreen; // Центрировать форму при запуске
            //this.BackColor = Color.White; // Установить цвет фона

            this.Paint += new PaintEventHandler(Form1_Paint); // Добавить обработчик события Paint
            this.MouseClick += new MouseEventHandler(Form1_MouseClick); // Добавить обработчик события MouseClick
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            g.DrawEllipse(Pens.Black, rect); // Нарисовать овальное очертание
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MessageBox.Show("Закрыть форму?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close(); // Закрыть форму по щелчку левой кнопкой мыши
                }
            }
        }
    }
}
