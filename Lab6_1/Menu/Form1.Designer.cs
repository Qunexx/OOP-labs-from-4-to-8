namespace Menu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗагрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вФорматеJPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вФорматеBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.график1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.график2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваГрафикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокГрафикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.контекст1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контекст2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.описаниеГрафикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокГрафикаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.ФайлToolStripMenuItem, this.ЗагрузитьToolStripMenuItem, this.графикToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ФайлToolStripMenuItem
            // 
            this.ФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.ВыходToolStripMenuItem });
            this.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem";
            this.ФайлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ФайлToolStripMenuItem.Text = "Файл";
            // 
            // ВыходToolStripMenuItem
            // 
            this.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem";
            this.ВыходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ВыходToolStripMenuItem.Text = "Выход";
            this.ВыходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // ЗагрузитьToolStripMenuItem
            // 
            this.ЗагрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.открытьИзображениеToolStripMenuItem });
            this.ЗагрузитьToolStripMenuItem.Name = "ЗагрузитьToolStripMenuItem";
            this.ЗагрузитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.ЗагрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // открытьИзображениеToolStripMenuItem
            // 
            this.открытьИзображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.вФорматеJPEGToolStripMenuItem, this.вФорматеBMPToolStripMenuItem });
            this.открытьИзображениеToolStripMenuItem.Name = "открытьИзображениеToolStripMenuItem";
            this.открытьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.открытьИзображениеToolStripMenuItem.Text = "Открыть изображение";
            // 
            // вФорматеJPEGToolStripMenuItem
            // 
            this.вФорматеJPEGToolStripMenuItem.Name = "вФорматеJPEGToolStripMenuItem";
            this.вФорматеJPEGToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.вФорматеJPEGToolStripMenuItem.Text = "В формате JPEG";
            this.вФорматеJPEGToolStripMenuItem.Click += new System.EventHandler(this.вФорматеJPEGToolStripMenuItem_Click);
            // 
            // вФорматеBMPToolStripMenuItem
            // 
            this.вФорматеBMPToolStripMenuItem.Name = "вФорматеBMPToolStripMenuItem";
            this.вФорматеBMPToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.вФорматеBMPToolStripMenuItem.Text = "В формате BMP";
            this.вФорматеBMPToolStripMenuItem.Click += new System.EventHandler(this.вФорматеBMPToolStripMenuItem_Click);
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.график1ToolStripMenuItem, this.график2ToolStripMenuItem });
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.графикToolStripMenuItem.Text = "График";
            // 
            // график1ToolStripMenuItem
            // 
            this.график1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.описаниеГрафикаToolStripMenuItem, this.рисунокГрафикаToolStripMenuItem1 });
            this.график1ToolStripMenuItem.Name = "график1ToolStripMenuItem";
            this.график1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.график1ToolStripMenuItem.Text = "График 1";
            // 
            // график2ToolStripMenuItem
            // 
            this.график2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.свойстваГрафикаToolStripMenuItem, this.рисунокГрафикаToolStripMenuItem });
            this.график2ToolStripMenuItem.Name = "график2ToolStripMenuItem";
            this.график2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.график2ToolStripMenuItem.Text = "График 2";
            // 
            // свойстваГрафикаToolStripMenuItem
            // 
            this.свойстваГрафикаToolStripMenuItem.Name = "свойстваГрафикаToolStripMenuItem";
            this.свойстваГрафикаToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.свойстваГрафикаToolStripMenuItem.Text = "Описание графика";
            this.свойстваГрафикаToolStripMenuItem.Click += new System.EventHandler(this.свойстваГрафикаToolStripMenuItem_Click);
            // 
            // рисунокГрафикаToolStripMenuItem
            // 
            this.рисунокГрафикаToolStripMenuItem.Name = "рисунокГрафикаToolStripMenuItem";
            this.рисунокГрафикаToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.рисунокГрафикаToolStripMenuItem.Text = "Рисунок графика";
            this.рисунокГрафикаToolStripMenuItem.Click += new System.EventHandler(this.график2рисунокToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(10, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 163);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.контекст1ToolStripMenuItem, this.контекст2ToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 48);
            // 
            // контекст1ToolStripMenuItem
            // 
            this.контекст1ToolStripMenuItem.Name = "контекст1ToolStripMenuItem";
            this.контекст1ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.контекст1ToolStripMenuItem.Text = "Контекст 1";
            this.контекст1ToolStripMenuItem.Click += new System.EventHandler(this.контекст1ToolStripMenuItem_Click);
            // 
            // контекст2ToolStripMenuItem
            // 
            this.контекст2ToolStripMenuItem.Name = "контекст2ToolStripMenuItem";
            this.контекст2ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.контекст2ToolStripMenuItem.Text = "Контекст2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripStatusLabel1, this.toolStripStatusLabel2 });
            this.statusStrip1.Location = new System.Drawing.Point(0, 249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(608, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "Строка статуса";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Строка 1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel2.Text = "Строка 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(207, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripButton1, this.toolStripButton2 });
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(608, 36);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 42);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.вФорматеJPEGToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(42, 42);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.вФорматеBMPToolStripMenuItem_Click);
            // 
            // описаниеГрафикаToolStripMenuItem
            // 
            this.описаниеГрафикаToolStripMenuItem.Name = "описаниеГрафикаToolStripMenuItem";
            this.описаниеГрафикаToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.описаниеГрафикаToolStripMenuItem.Text = "Описание графика";
            // 
            // рисунокГрафикаToolStripMenuItem1
            // 
            this.рисунокГрафикаToolStripMenuItem1.Name = "рисунокГрафикаToolStripMenuItem1";
            this.рисунокГрафикаToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.рисунокГрафикаToolStripMenuItem1.Text = "Рисунок графика";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 271);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem описаниеГрафикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокГрафикаToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem свойстваГрафикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокГрафикаToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem график1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem график2ToolStripMenuItem;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВыходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЗагрузитьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem контекст1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контекст2ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вФорматеJPEGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вФорматеBMPToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

