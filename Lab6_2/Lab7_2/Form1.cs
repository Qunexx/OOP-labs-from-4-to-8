using System;
using System.Windows.Forms;

namespace Lab7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выберите пункт меню";
        }

        private void ОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для пункта "Объект"
            MessageBox.Show("Выбран раздел 'Объект'");
            toolStripStatusLabel1.Text = "Данные об объекте";
        }

        private void СотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Сотрудник"
            MessageBox.Show("Выбран подпункт 'Сотрудник'");
            toolStripStatusLabel1.Text = "Данные о сотруднике";
        }

        private void КлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Клиент"
            MessageBox.Show("Выбран подпункт 'Клиент'");
            toolStripStatusLabel1.Text = "Данные о клиенте";
        }

        private void ДоговорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Договор"
            MessageBox.Show("Выбран подпункт 'Договор'");
            toolStripStatusLabel1.Text = "Данные о договоре";
        }

        private void ПоручениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Поручение"
            MessageBox.Show("Выбран подпункт 'Поручение'");
            toolStripStatusLabel1.Text = "Данные о поручении";
        }

        private void СделкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Сделка"
            MessageBox.Show("Выбран подпункт 'Сделка'");
            toolStripStatusLabel1.Text = "Данные о сделке";
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Выход"
            MessageBox.Show("Выбран подпункт 'Выход'");
        }

        private void СправочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для пункта "Справочник"
            MessageBox.Show("Выбран раздел 'Справочник'");
            toolStripStatusLabel1.Text = "Данные о справочнике";
        }

        private void ДолжностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Должность"
            MessageBox.Show("Выбран подпункт 'Должность'");
            toolStripStatusLabel1.Text = "Данные о должности";
        }

        private void СтранаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Страна"
            MessageBox.Show("Выбран подпункт 'Страна'");
            toolStripStatusLabel1.Text = "Данные о стране";
        }

        private void РегионToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Регион"
            MessageBox.Show("Выбран подпункт 'Регион'");
            toolStripStatusLabel1.Text = "Данные о регионе";
        }

        private void ГородToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "Город"
            MessageBox.Show("Выбран подпункт 'Город'");
            toolStripStatusLabel1.Text = "Данные о городе";
        }

        private void ИМНСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "ИМНС"
            MessageBox.Show("Выбран подпункт 'ИМНС'");
            toolStripStatusLabel1.Text = "Данные об ИМНС";
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для пункта "Справка"
            MessageBox.Show("Выбран раздел 'Справка'");
            toolStripStatusLabel1.Text = "Данные о справке";
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события для подпункта "О программе"
            MessageBox.Show("Выбран подпункт 'О программе'");
            toolStripStatusLabel1.Text = "Данные о программе";
        }
    }
}
