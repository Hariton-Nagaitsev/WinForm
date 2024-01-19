namespace Lab1_05
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None; // ������ ����� � �����
            //this.StartPosition = FormStartPosition.CenterScreen; // ������������ ����� ��� �������
            //this.BackColor = Color.White; // ���������� ���� ����

            this.Paint += new PaintEventHandler(Form1_Paint); // �������� ���������� ������� Paint
            this.MouseClick += new MouseEventHandler(Form1_MouseClick); // �������� ���������� ������� MouseClick
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            g.DrawEllipse(Pens.Black, rect); // ���������� �������� ���������
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MessageBox.Show("������� �����?", "�������������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close(); // ������� ����� �� ������ ����� ������� ����
                }
            }
        }
    }
}
