using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.Show();
        }

        private void buttonBanker_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            this.Hide();
            orders.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
