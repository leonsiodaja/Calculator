namespace scCal
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 308;
            textBox1.Width = 246;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Width = 604;
            textBox1.Width = 513;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 294;
            textBox1.Width = 246;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (enter_value))
                textBox1.Text = "";
            enter_value = false;

            Button num = (Button)sender;

            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void Arithmetic_operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";

            label1.Text = System.Convert.ToString(results) + "" + operation;


        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;

                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;

                case "Exp":

                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
 

        }

        private void button38_Click(object sender, EventArgs e)
        {
             double sq = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Sqrt" + "(" + (textBox1.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
 
        }

        private void button36_Click(object sender, EventArgs e)
        {

            double qSinh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sinh" + "(" + (textBox1.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = System.Convert.ToString(qSinh);

        }

        private void button35_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text) + ")");
            qSin = Math.Sinh(qSin);
            textBox1.Text = System.Convert.ToString(qSin);

        }

        private void button32_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Cosh" + "(" + (textBox1.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            textBox1.Text = System.Convert.ToString(qCosh);

        }

        private void button31_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Cos" + "(" + (textBox1.Text) + ")");
            qCos = Math.Cos(qCos);
            textBox1.Text = System.Convert.ToString(qCos);

        }

        private void button28_Click(object sender, EventArgs e)
        {
            double qtanh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("tanh" + "(" + (textBox1.Text) + ")");
            qtanh = Math.Tanh(qtanh);
            textBox1.Text = System.Convert.ToString(qtanh);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double qtan = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("tan" + "(" + (textBox1.Text) + ")");
            qtan = Math.Tan(qtan);
            textBox1.Text = System.Convert.ToString(qtan);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }
           private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);


            textBox1.Text = System.Convert.ToString(a);

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);


            textBox1.Text = System.Convert.ToString(a);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0/  Convert.ToDouble(textBox1.Text));


            textBox1.Text = System.Convert.ToString(a);

        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);


            textBox1.Text = System.Convert.ToString(a);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}