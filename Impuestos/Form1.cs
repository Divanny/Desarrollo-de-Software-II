namespace Impuestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sueldoBruto = Convert.ToInt32(textBox1.Text);

            float deducciones = (float)((sueldoBruto * 0.0304) + (sueldoBruto * 0.0287));
            label6.Text = Convert.ToString((sueldoBruto * 0.0304));
            label7.Text = Convert.ToString((sueldoBruto * 0.0287));
    
            float sueldoNeto = sueldoBruto - deducciones;

            if (sueldoNeto * 12 < 416220)
            {
                label8.Text = Convert.ToString(0);
                label10.Text = Convert.ToString((sueldoNeto));
            }

            else if (sueldoNeto * 12 > 416220 && sueldoNeto * 12 <= 624329)
            {
                float temp = (float)((sueldoNeto * 12) - 416220.01);
                temp = (float)(temp * 0.15);
                temp /= 12;
                sueldoNeto -= temp;
                label8.Text = Convert.ToString(temp);
                label10.Text = Convert.ToString((sueldoNeto));
            }

            else if (sueldoNeto * 12 > 624329 && sueldoNeto * 12 <= 867123)
            {
                float temp = (float)((sueldoNeto * 12) - 624329.01);
                temp = (float)(temp * 0.20);
                temp += 31216;
                temp /= 12;
                sueldoNeto -= temp;
                label8.Text = Convert.ToString(temp);
                label10.Text = Convert.ToString((sueldoNeto));
            }

            else
            {
                float temp = (float)((sueldoNeto * 12) - 867123.01);
                temp = (float)(temp * 0.25);
                temp += 79776;
                temp /= 12;
                sueldoNeto -= temp;
                label8.Text = Convert.ToString(temp);
                label10.Text = Convert.ToString((sueldoNeto));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label10.Text = "";
        }
    }
}