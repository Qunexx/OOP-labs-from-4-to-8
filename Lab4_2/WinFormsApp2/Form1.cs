using System;
using System.Security.Permissions;
using System.Windows.Forms;
using MyClass;


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
        ParentClass calc1 = new Calc1();
        ParentClass calc2 = new Calc2();




        private void button1_Click(object sender, EventArgs e)
        {


            at = Convert.ToDouble(textBox1.Text);
            dt = Convert.ToInt32(textBox4.Text);


            try
            {
                calc2.a = at;
                calc2.d = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
                textBox1.Focus();
                return;
            }

            MessageBox.Show("Параметры считаны!");


            //Вызов метода для расчета
            calc2.CalcValue();
            textBox3.Text = calc2.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            at = Convert.ToDouble(textBox1.Text);
            bt = Convert.ToDouble(textBox2.Text);

            try
            {
                calc1.a = at;
                calc1.b = bt;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка: " + exception.Message);
                textBox1.Focus();
                return;
            }

            MessageBox.Show("Параметры считаны!");
            calc1.CalcValue();
            textBox3.Text = calc1.ToString("Ответ:");


        }
    }
}