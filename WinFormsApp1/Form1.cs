namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        string operation = "";
        double result_Value = 0;
        bool is_Operation_Performed = false;
        bool is_Equal_Performed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (tb_Result.Text == "0" || is_Operation_Performed || is_Equal_Performed)
            {
                tb_Result.Clear();
            }
            is_Equal_Performed = false;
            Button btn = (Button)sender;

            if(btn.Text == ".")
            {
                if (!tb_Result.Text.Contains("."))
                {
                    tb_Result.Text = tb_Result.Text + btn.Text;
                }
                 
            }
            

          
            else
            {
                tb_Result.Text = tb_Result.Text + btn.Text;
            }
            
            is_Operation_Performed = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void operation_Perform(object sender, EventArgs e)
        {
            if (result_Value !=0)
            {
                button33.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(tb_Result.Text);
                lb_Result.Text = result_Value + operation;
                is_Operation_Performed = true;
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(tb_Result.Text);
                lb_Result.Text = result_Value + operation;
                is_Operation_Performed = true;
            }
            

        }

        private void button21_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
            lb_Result.Text = "";
            result_Value = 0;
            operation = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    tb_Result.Text = (result_Value + double.Parse(tb_Result.Text)).ToString();
                    break;
                case "-":
                    tb_Result.Text = (result_Value - double.Parse(tb_Result.Text)).ToString();
                    break;
                case "*":
                    tb_Result.Text = (result_Value * double.Parse(tb_Result.Text)).ToString();
                    break;
                case "/":
                    tb_Result.Text = (result_Value / double.Parse(tb_Result.Text)).ToString();
                    break;
            }
        }
    }
}
