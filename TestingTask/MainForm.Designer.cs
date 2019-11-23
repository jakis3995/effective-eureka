namespace TestingTask
{
    partial class MainForm
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

        public void StripMenuForSuperUserVisibility(bool mustBeVisible)
        {
            if (mustBeVisible)
            {
                менюСуперпользователяToolStripMenuItem.Visible = true;
            } else
            {
                менюСуперпользователяToolStripMenuItem.Visible = false;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюСуперпользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехЗарплатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеудалениеСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеудалениеСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеДоступомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.менюСуперпользователяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            this.отчётыToolStripMenuItem.Click += new System.EventHandler(this.отчётыToolStripMenuItem_Click_1);
            // 
            // менюСуперпользователяToolStripMenuItem
            // 
            this.менюСуперпользователяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрВсехЗарплатToolStripMenuItem,
            this.добавлениеудалениеСотрудникаToolStripMenuItem,
            this.добавлениеудалениеСотрудниковToolStripMenuItem,
            this.управлениеДоступомToolStripMenuItem});
            this.менюСуперпользователяToolStripMenuItem.Name = "менюСуперпользователяToolStripMenuItem";
            this.менюСуперпользователяToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.менюСуперпользователяToolStripMenuItem.Text = "Меню суперпользователя";
            this.менюСуперпользователяToolStripMenuItem.Visible = false;
            // 
            // просмотрВсехЗарплатToolStripMenuItem
            // 
            this.просмотрВсехЗарплатToolStripMenuItem.Name = "просмотрВсехЗарплатToolStripMenuItem";
            this.просмотрВсехЗарплатToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.просмотрВсехЗарплатToolStripMenuItem.Text = "Просмотр всех зарплат";
            // 
            // добавлениеудалениеСотрудникаToolStripMenuItem
            // 
            this.добавлениеудалениеСотрудникаToolStripMenuItem.Name = "добавлениеудалениеСотрудникаToolStripMenuItem";
            this.добавлениеудалениеСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.добавлениеудалениеСотрудникаToolStripMenuItem.Text = "Редактирование групп";
            // 
            // добавлениеудалениеСотрудниковToolStripMenuItem
            // 
            this.добавлениеудалениеСотрудниковToolStripMenuItem.Name = "добавлениеудалениеСотрудниковToolStripMenuItem";
            this.добавлениеудалениеСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.добавлениеудалениеСотрудниковToolStripMenuItem.Text = "Редактирование сотрудников";
            // 
            // управлениеДоступомToolStripMenuItem
            // 
            this.управлениеДоступомToolStripMenuItem.Name = "управлениеДоступомToolStripMenuItem";
            this.управлениеДоступомToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.управлениеДоступомToolStripMenuItem.Text = "Управление доступом";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваша заработная плата на указанный момент составляет: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = " руб.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подчинённые";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите подчинённого для просмотра е(го/ё) зарплаты";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Подсчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 40);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Суммарная зарплата всех сотрудников:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = " руб.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюСуперпользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеудалениеСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеудалениеСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеДоступомToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехЗарплатToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}