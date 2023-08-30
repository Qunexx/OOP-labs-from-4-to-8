using System;
using System.Security.Permissions;
using System.Windows.Forms;
using MyClass;
using static MyClass.MyCalc;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double at;
        private double bt;
        private int dt;


       

        private void button1_Click(object sender, EventArgs e)
        {


            at = Convert.ToDouble(textBox1.Text);
            dt = Convert.ToInt32(textBox4.Text);


            try
            {
                MyCalc.a = at;
                MyCalc.d = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
                textBox1.Focus();
                return;
            }

            MessageBox.Show("Параметры считаны!");


            //Вызов метода для расчета

            textBox3.Text = calc(a,d).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            try
            {
                MyCalc.a = a;
                MyCalc.b = b;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
                textBox1.Focus();
                return;
            }

            MessageBox.Show("Параметры считаны!");
            textBox3.Text = MyCalc.ToString(calc(a,b));


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}