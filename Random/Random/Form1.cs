namespace Random
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "A14238")
            {
                label1.Text = "You too smart!";
                MessageBox.Show("Yoooo! you too smart");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else if (textBox1.Text == "what languages do you use")
            {
                MessageBox.Show("It C# are u dumb :/");
                Thread.Sleep(1000);
                label1.Text = "Enter Password";
            }
            else
            {
                label1.Text = "You too stupid!";
                MessageBox.Show("Nah you to stupid LOL");
                Thread.Sleep(1000);
                label1.Text = "Enter Password";
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }




        private void label1_Click(object sender, EventArgs e)
        {



        }
    }
}




