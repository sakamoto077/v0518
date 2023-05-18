namespace v0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Left = 0;
            button1.Left = button1.Left = 10;
            button1.Top = button1.Top + 1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left = button2.Left = 0;
            button2.BackColor = Color.Green;
            button2.Top = Top = button2.Top + 30;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Left = button3.Left = 70;
            button3.Top = button3.Top + 10;
            button3.BackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Left = button4.Left = 2;
            button4.Top = button4.Top = -10;
        }
    }
}