
namespace Moya_pervaya_proga_po_vizual
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЭлементToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскаяБукваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максКолToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ДобавитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действие1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действие1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.действие2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(636, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "Выбор размера формы";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.comboBox1.MouseEnter += new System.EventHandler(this.comboBox1_MouseEnter);
            this.comboBox1.MouseLeave += new System.EventHandler(this.comboBox1_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтрокуToolStripMenuItem,
            this.удалитьЭлементToolStripMenuItem1,
            this.найтиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // добавитьСтрокуToolStripMenuItem
            // 
            this.добавитьСтрокуToolStripMenuItem.Name = "добавитьСтрокуToolStripMenuItem";
            this.добавитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьСтрокуToolStripMenuItem.Tag = "Добавить элемент в ListBox3";
            this.добавитьСтрокуToolStripMenuItem.Text = "Добавить элемент";
            this.добавитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтрокуToolStripMenuItem_Click);
            this.добавитьСтрокуToolStripMenuItem.MouseEnter += new System.EventHandler(this.добавитьСтрокуToolStripMenuItem_MouseEnter);
            this.добавитьСтрокуToolStripMenuItem.MouseLeave += new System.EventHandler(this.добавитьСтрокуToolStripMenuItem_MouseLeave);
            // 
            // удалитьЭлементToolStripMenuItem1
            // 
            this.удалитьЭлементToolStripMenuItem1.Name = "удалитьЭлементToolStripMenuItem1";
            this.удалитьЭлементToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.удалитьЭлементToolStripMenuItem1.Tag = "Удалить выделенные элементы из ListBox3";
            this.удалитьЭлементToolStripMenuItem1.Text = "Удалить элемент";
            this.удалитьЭлементToolStripMenuItem1.Click += new System.EventHandler(this.удалитьЭлементToolStripMenuItem1_Click);
            this.удалитьЭлементToolStripMenuItem1.MouseEnter += new System.EventHandler(this.удалитьЭлементToolStripMenuItem1_MouseEnter);
            this.удалитьЭлементToolStripMenuItem1.MouseLeave += new System.EventHandler(this.удалитьЭлементToolStripMenuItem1_MouseLeave);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскаяБукваToolStripMenuItem,
            this.максКолToolStripMenuItem});
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.найтиToolStripMenuItem.Tag = "";
            this.найтиToolStripMenuItem.Text = "Найти";
            // 
            // русскаяБукваToolStripMenuItem
            // 
            this.русскаяБукваToolStripMenuItem.Name = "русскаяБукваToolStripMenuItem";
            this.русскаяБукваToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.русскаяБукваToolStripMenuItem.Tag = "строки, оканчивающиеся на русскую букву";
            this.русскаяБукваToolStripMenuItem.Text = "русская буква";
            this.русскаяБукваToolStripMenuItem.Click += new System.EventHandler(this.русскаяБукваToolStripMenuItem_Click);
            this.русскаяБукваToolStripMenuItem.MouseEnter += new System.EventHandler(this.русскаяБукваToolStripMenuItem_MouseEnter);
            this.русскаяБукваToolStripMenuItem.MouseLeave += new System.EventHandler(this.русскаяБукваToolStripMenuItem_MouseLeave);
            // 
            // максКолToolStripMenuItem
            // 
            this.максКолToolStripMenuItem.Name = "максКолToolStripMenuItem";
            this.максКолToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.максКолToolStripMenuItem.Tag = "строки в которых содержится максимальное количество различных символов";
            this.максКолToolStripMenuItem.Text = "макс. кол.";
            this.максКолToolStripMenuItem.Click += new System.EventHandler(this.максКолToolStripMenuItem_Click);
            this.максКолToolStripMenuItem.MouseEnter += new System.EventHandler(this.максКолToolStripMenuItem_MouseEnter);
            this.максКолToolStripMenuItem.MouseLeave += new System.EventHandler(this.максКолToolStripMenuItem_MouseLeave);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "Стиль рамки 1";
            this.radioButton1.Text = "Стиль 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.MouseEnter += new System.EventHandler(this.radioButton1_MouseEnter);
            this.radioButton1.MouseLeave += new System.EventHandler(this.radioButton1_MouseLeave);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "Стиль рамки 2";
            this.radioButton2.Text = "Стиль 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.MouseEnter += new System.EventHandler(this.radioButton2_MouseEnter);
            this.radioButton2.MouseLeave += new System.EventHandler(this.radioButton2_MouseLeave);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "Стиль рамки 3";
            this.radioButton3.Text = "Стиль 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton3.MouseEnter += new System.EventHandler(this.radioButton3_MouseEnter);
            this.radioButton3.MouseLeave += new System.EventHandler(this.radioButton3_MouseLeave);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(101, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "Стиль рамки 4";
            this.radioButton4.Text = "Стиль 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            this.radioButton4.MouseEnter += new System.EventHandler(this.radioButton4_MouseEnter);
            this.radioButton4.MouseLeave += new System.EventHandler(this.radioButton4_MouseLeave);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(101, 40);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(64, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "Стиль рамки 5";
            this.radioButton5.Text = "Стиль 5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            this.radioButton5.MouseEnter += new System.EventHandler(this.radioButton5_MouseEnter);
            this.radioButton5.MouseLeave += new System.EventHandler(this.radioButton5_MouseLeave);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(101, 63);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(64, 17);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "Стиль рамки 6";
            this.radioButton6.Text = "Стиль 6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            this.radioButton6.MouseEnter += new System.EventHandler(this.radioButton6_MouseEnter);
            this.radioButton6.MouseLeave += new System.EventHandler(this.radioButton6_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ДобавитьЭлементToolStripMenuItem,
            this.удалитьЭлементToolStripMenuItem,
            this.действие1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(365, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ДобавитьЭлементToolStripMenuItem
            // 
            this.ДобавитьЭлементToolStripMenuItem.Name = "ДобавитьЭлементToolStripMenuItem";
            this.ДобавитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.ДобавитьЭлементToolStripMenuItem.Tag = "Добавление элемента в ListBox1 из TextBox1";
            this.ДобавитьЭлементToolStripMenuItem.Text = "Добавить элемент";
            this.ДобавитьЭлементToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧислоToolStripMenuItem_Click);
            this.ДобавитьЭлементToolStripMenuItem.MouseEnter += new System.EventHandler(this.ДобавитьЭлементToolStripMenuItem_MouseEnter);
            this.ДобавитьЭлементToolStripMenuItem.MouseLeave += new System.EventHandler(this.ДобавитьЭлементToolStripMenuItem_MouseLeave);
            // 
            // удалитьЭлементToolStripMenuItem
            // 
            this.удалитьЭлементToolStripMenuItem.Name = "удалитьЭлементToolStripMenuItem";
            this.удалитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.удалитьЭлементToolStripMenuItem.Tag = "Удаление выделенных элементов из ListBox1";
            this.удалитьЭлементToolStripMenuItem.Text = "Удалить элемент";
            this.удалитьЭлементToolStripMenuItem.Click += new System.EventHandler(this.удалитьЭлементToolStripMenuItem_Click);
            this.удалитьЭлементToolStripMenuItem.MouseEnter += new System.EventHandler(this.удалитьЭлементToolStripMenuItem_MouseEnter);
            this.удалитьЭлементToolStripMenuItem.MouseLeave += new System.EventHandler(this.удалитьЭлементToolStripMenuItem_MouseLeave);
            // 
            // действие1ToolStripMenuItem
            // 
            this.действие1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действие1ToolStripMenuItem1,
            this.действие2ToolStripMenuItem1});
            this.действие1ToolStripMenuItem.Name = "действие1ToolStripMenuItem";
            this.действие1ToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.действие1ToolStripMenuItem.Text = "Действия (ListBox2)";
            // 
            // действие1ToolStripMenuItem1
            // 
            this.действие1ToolStripMenuItem1.Name = "действие1ToolStripMenuItem1";
            this.действие1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.действие1ToolStripMenuItem1.Tag = "произведение первых 4 положительных чисел, у которых дробная часть";
            this.действие1ToolStripMenuItem1.Text = "Действие 1 (b)";
            this.действие1ToolStripMenuItem1.Click += new System.EventHandler(this.действие1ToolStripMenuItem1_Click);
            this.действие1ToolStripMenuItem1.MouseEnter += new System.EventHandler(this.действие1ToolStripMenuItem1_MouseEnter);
            this.действие1ToolStripMenuItem1.MouseLeave += new System.EventHandler(this.действие1ToolStripMenuItem1_MouseLeave);
            // 
            // действие2ToolStripMenuItem1
            // 
            this.действие2ToolStripMenuItem1.Name = "действие2ToolStripMenuItem1";
            this.действие2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.действие2ToolStripMenuItem1.Tag = "есть ли среди элементов списка с четными номерами хоть один";
            this.действие2ToolStripMenuItem1.Text = "Действие 2 (h)";
            this.действие2ToolStripMenuItem1.Click += new System.EventHandler(this.действие2ToolStripMenuItem1_Click);
            this.действие2ToolStripMenuItem1.MouseEnter += new System.EventHandler(this.действие2ToolStripMenuItem1_MouseEnter);
            this.действие2ToolStripMenuItem1.MouseLeave += new System.EventHandler(this.действие2ToolStripMenuItem1_MouseLeave);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(162, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 147);
            this.listBox1.TabIndex = 11;
            this.listBox1.Tag = "Хранит действительные числа из TextBox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(354, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(186, 147);
            this.listBox2.TabIndex = 12;
            this.listBox2.Tag = "Хранит числа после действий";
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.MouseEnter += new System.EventHandler(this.listBox2_MouseEnter);
            this.listBox2.MouseLeave += new System.EventHandler(this.listBox2_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.textBox1.Location = new System.Drawing.Point(162, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Tag = "Ввод действительных чисел";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(546, 27);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(186, 147);
            this.listBox3.TabIndex = 15;
            this.listBox3.Tag = "Хранит строки из TextBox2";
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            this.listBox3.MouseEnter += new System.EventHandler(this.listBox3_MouseEnter);
            this.listBox3.MouseLeave += new System.EventHandler(this.listBox3_MouseLeave);
            // 
            // textBox2
            // 
            this.textBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox2.Location = new System.Drawing.Point(546, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Tag = "Ввод строк для TextBox3";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.MouseEnter += new System.EventHandler(this.textBox2_MouseEnter);
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(0, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стили рамки";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(749, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(749, 366);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ДобавитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действие1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действие1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem действие2ToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЭлементToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскаяБукваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максКолToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

