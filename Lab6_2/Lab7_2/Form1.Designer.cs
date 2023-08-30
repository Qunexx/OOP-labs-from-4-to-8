namespace Lab7_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.объектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поручениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.странаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регионToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.городToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имнсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.объектToolStripMenuItem, this.справочникToolStripMenuItem, this.справкаToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // объектToolStripMenuItem
            // 
            this.объектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.сотрудникToolStripMenuItem, this.клиентToolStripMenuItem, this.договорToolStripMenuItem, this.поручениеToolStripMenuItem, this.сделкаToolStripMenuItem, this.выходToolStripMenuItem });
            this.объектToolStripMenuItem.Name = "объектToolStripMenuItem";
            this.объектToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.объектToolStripMenuItem.Text = "Объект";
            // 
            // сотрудникToolStripMenuItem
            // 
            this.сотрудникToolStripMenuItem.Name = "сотрудникToolStripMenuItem";
            this.сотрудникToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.сотрудникToolStripMenuItem.Text = "Сотрудник";
            this.сотрудникToolStripMenuItem.Click += new System.EventHandler(this.СотрудникToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.клиентToolStripMenuItem.Text = "Клиент";
            this.клиентToolStripMenuItem.Click += new System.EventHandler(this.КлиентToolStripMenuItem_Click);
            // 
            // договорToolStripMenuItem
            // 
            this.договорToolStripMenuItem.Name = "договорToolStripMenuItem";
            this.договорToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.договорToolStripMenuItem.Text = "Договор";
            this.договорToolStripMenuItem.Click += new System.EventHandler(this.ДоговорToolStripMenuItem_Click);
            // 
            // поручениеToolStripMenuItem
            // 
            this.поручениеToolStripMenuItem.Name = "поручениеToolStripMenuItem";
            this.поручениеToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.поручениеToolStripMenuItem.Text = "Поручение";
            this.поручениеToolStripMenuItem.Click += new System.EventHandler(this.ПоручениеToolStripMenuItem_Click);
            // 
            // сделкаToolStripMenuItem
            // 
            this.сделкаToolStripMenuItem.Name = "сделкаToolStripMenuItem";
            this.сделкаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.сделкаToolStripMenuItem.Text = "Сделка";
            this.сделкаToolStripMenuItem.Click += new System.EventHandler(this.СделкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.должностьToolStripMenuItem, this.странаToolStripMenuItem, this.регионToolStripMenuItem, this.городToolStripMenuItem, this.имнсToolStripMenuItem });
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.должностьToolStripMenuItem.Text = "Должность";
            this.должностьToolStripMenuItem.Click += new System.EventHandler(this.ДолжностьToolStripMenuItem_Click);
            // 
            // странаToolStripMenuItem
            // 
            this.странаToolStripMenuItem.Name = "странаToolStripMenuItem";
            this.странаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.странаToolStripMenuItem.Text = "Страна";
            this.странаToolStripMenuItem.Click += new System.EventHandler(this.СтранаToolStripMenuItem_Click);
            // 
            // регионToolStripMenuItem
            // 
            this.регионToolStripMenuItem.Name = "регионToolStripMenuItem";
            this.регионToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.регионToolStripMenuItem.Text = "Регион";
            this.регионToolStripMenuItem.Click += new System.EventHandler(this.РегионToolStripMenuItem_Click);
            // 
            // городToolStripMenuItem
            // 
            this.городToolStripMenuItem.Name = "городToolStripMenuItem";
            this.городToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.городToolStripMenuItem.Text = "Город";
            this.городToolStripMenuItem.Click += new System.EventHandler(this.ГородToolStripMenuItem_Click);
            // 
            // имнсToolStripMenuItem
            // 
            this.имнсToolStripMenuItem.Name = "имнсToolStripMenuItem";
            this.имнсToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.имнсToolStripMenuItem.Text = "ИМНС";
            this.имнсToolStripMenuItem.Click += new System.EventHandler(this.ИМНСToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.оПрограммеToolStripMenuItem });
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripStatusLabel1 });
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 397);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сотрудник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.СотрудникToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Клиент";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.КлиентToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "YourAppName";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem объектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поручениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem странаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регионToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem городToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имнсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
