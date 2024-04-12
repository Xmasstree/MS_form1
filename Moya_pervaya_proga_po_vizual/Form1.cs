using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Смольников Илья 11 вариант (повышенный)
namespace Moya_pervaya_proga_po_vizual
{
    public partial class Form1 : Form
    {
        CheckBox checkBox1 = new CheckBox();
        CheckBox checkBox2 = new CheckBox();
        public bool isALTIPressed = false;
        public bool isALTXPressed = false;
        

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            button1.Click += button1_Click;
            string[] aboba = { "765x405", "800x600", "900x700", "1000x800", "1280x1024", "1280x900", "1600x900", "1920x1080"};
            comboBox1.Items.AddRange(aboba);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyPress += comboBox1_KeyPress;
            
            this.Controls.Add(checkBox1);
            checkBox1.Location = new System.Drawing.Point(583, 259);
            checkBox1.Size = new System.Drawing.Size(161, 17);
            checkBox1.Text = "Изменение выключателей";
            checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            checkBox1.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
            checkBox1.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);

            this.Controls.Add(checkBox2);
            checkBox2.Location = new System.Drawing.Point(583, 282);         
            checkBox2.Size = new System.Drawing.Size(138, 17);
            checkBox2.Text = "Изменение ComboBox";
            checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            checkBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox2_MouseClick);
            checkBox2.MouseEnter += new System.EventHandler(this.checkBox2_MouseEnter);
            checkBox2.MouseLeave += new System.EventHandler(this.checkBox2_MouseLeave);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox1.DropDownHeight = 1;
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                comboBox1.DropDownHeight = int.MaxValue;
                comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void checkBox2_MouseClick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = !checkBox2.Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedItem.ToString();
            string[] resolution = s.Split('x');
            this.Size = new Size(Convert.ToInt32(resolution[0]), Convert.ToInt32(resolution[1]));
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !comboBox1.Items.Contains(comboBox1.Text))
            {
                if (!string.IsNullOrEmpty(comboBox1.Text))
                    if (comboBox1.Text.Contains("x") && comboBox1.Text[0] != 'x' && comboBox1.Text[comboBox1.Text.Count() - 1] != 'x')
                    {
                        int x = Convert.ToInt32(comboBox1.Text.Split('x')[0]);
                        int y = Convert.ToInt32(comboBox1.Text.Split('x')[1]);
                        if ((x > 765 && x <= 1920) || (y > 405 && y <= 1080))
                        {
                            comboBox1.Items.Add(comboBox1.Text);
                            MessageBox.Show("Значение добавлено в список");
                        }
                        else
                            MessageBox.Show("выход за пределы минимальных - максимальных значений");
                    }
                    else
                        MessageBox.Show("Некорректный ввод");
                else
                    MessageBox.Show("Пустой ввод");
            }
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void добавитьЧислоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(Convert.ToDouble(textBox1.Text));
                MessageBox.Show("Значение добавлено в список");
            }
            else
                MessageBox.Show("Пустое поле ввода");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                listBox3.Items.Add(textBox2.Text.Trim(' '));
                MessageBox.Show("Значение добавлено в список");
            }
            else
                MessageBox.Show("Пустое поле ввода");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectionMode = SelectionMode.MultiExtended;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right  || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.Handled = true;
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = textBox1.Text.Length;
        }


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Select(textBox1.Text.Length, 0);
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = textBox1.Text.Length;
        }

       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) 
            {
                e.Handled = true;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) && number == 44)
            {
                e.Handled = true;
            }

            if (textBox1.Text.Contains(",") && number == 44)
            {
                e.Handled = true;
            }

            if ((textBox1.Text == "0" || textBox1.Text == "-0") && number == 48)
            {
                e.Handled = true;
            }

            if (textBox1.Text == "-" && number == 44)
            {
                e.Handled = true;
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && number == 45)
            {
                e.Handled = true;
            }

            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 120)
            {
                e.Handled = true;
            }

            if (string.IsNullOrWhiteSpace(comboBox1.Text) && (number == 120 || number == 48))
            {
                e.Handled = true;
            }

            if (comboBox1.Text.Contains("x") && number == 120)
            {
                e.Handled = true;
            }
        }

        private void удалитьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 0 && listBox2.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Выберите элемент-ы для удаления");
            }
            if (listBox1.SelectedIndices.Count != 0)
            {
                for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = listBox1.SelectedIndices[x];
                    listBox1.Items.RemoveAt(idx);
                }
            }
            
            if (listBox2.SelectedIndices.Count != 0)
                {
                    for (int x = listBox2.SelectedIndices.Count - 1; x >= 0; x--)
                    {
                        int idx = listBox2.SelectedIndices[x];
                        listBox2.Items.RemoveAt(idx);
                    }
                }
            
                
        }

        private void действие1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 3)
            {
                List<int> ind = new List<int>();
                double prod = 1;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    try
                    {
                        double val = Convert.ToDouble(listBox1.Items[i].ToString());
                        if (val > 0 && Convert.ToInt32(Convert.ToString(val).Split(',')[1]) % 2 != 0 && ind.Count != 4)
                        {
                            prod *= val;
                            ind.Add(i);
                        }
                    }
                    catch
                    {
                    }
                    if (ind.Count == 4)
                        break;
                }
                if (ind.Count == 4)
                {
                    MessageBox.Show($"Произведение равно: {prod}");
                    for (int x = ind.Count - 1; x >= 0; x--)
                    {
                        listBox2.Items.Add(listBox1.Items[ind[x]]);
                        listBox1.Items.RemoveAt(ind[x]);
                        MessageBox.Show("Объекты добавлены в список ListBox2");
                    }
                }
                else
                    MessageBox.Show("В списке меньше четырёх элементов подходящих под условие");
            }
            else
                MessageBox.Show("В списке меньше четырёх элементов");
        }

        private void действие2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 1)
            {
                List<int> ind = new List<int>();
                bool flag = false;
                for (int i = 1; i <= listBox1.Items.Count-1 ; i+=2)
                {
                    double val = Convert.ToDouble(listBox1.Items[i].ToString());
                    ind.Add(i);
                    if (val == 0)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    for (int x = ind.Count - 1; x >= 0; x--)
                    {
                        listBox2.Items.Add(listBox1.Items[ind[x]]);
                        listBox1.Items.RemoveAt(ind[x]);
                        MessageBox.Show("Объекты добавлены в список ListBox2");
                    }
                }
                else
                    MessageBox.Show("В списке нет нулевых элементов с чётныими номерами");
            }
            else
                MessageBox.Show("В списке менее двух элементов");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.SelectionMode = SelectionMode.MultiExtended;
        }

        private void удалитьЭлементToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Выберите элемент-ы для удаления");
            }
            else
                for (int x = listBox3.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = listBox3.SelectedIndices[x];
                    listBox3.Items.RemoveAt(idx);
                }
        }

        private void русскаяБукваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count != 0)
            {
                List<string> words = new List<string>();
                for (int i = 0; i < listBox3.Items.Count; i++)
                { 
                    string val = listBox3.Items[i].ToString();
                    if ((int)val[val.Length-1] >= 1040 && (int)val[val.Length - 1] <= 1103)
                    {
                        words.Add(val);
                    }
                }
                if (words.Count != 0)
                {
                    string wor = "";
                    for (int i = 0; i < words.Count; i++)
                    {
                        wor += (words[i] + " | ");
                    }
                    MessageBox.Show($"Искомые строки: {wor}");
                }
                else
                    MessageBox.Show("В списке нет ни одной строки, оканчивающейся на русскую букву");
            }
            else
                MessageBox.Show("Список пуст");
        }

        private void максКолToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count != 0)
            {
                List<string> words = new List<string>();
                int max = -1;
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    string val = listBox3.Items[i].ToString();
                    var c = val.Distinct();
                    if (c.Count() == max)
                    {
                        words.Add(val);
                    }
                    if (c.Count() > max)
                    {
                        max = c.Count();
                        words.Clear();
                        words.Add(val);
                    }
                }
                if (words.Count != 0)
                {
                    string wor = "";
                    for (int i = 0; i < words.Count; i++)
                    {
                        wor += (words[i] + " | ");
                    }
                    MessageBox.Show($"Искомые строки: {wor}");
                }
            }
            else
                MessageBox.Show("Список пуст");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }





        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.I)
            {
                isALTIPressed = true;
            }
            else if (e.Alt && e.KeyCode == Keys.X)
            {
                isALTXPressed = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                isALTXPressed = false;
            }
            else if (e.KeyCode == Keys.I)
            {
                isALTIPressed = false;
            }
            else if (e.KeyCode == Keys.Menu)
            {
                isALTXPressed = false;
                isALTIPressed = false;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
            if (isALTXPressed)
            {
                Close();
            }

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isALTXPressed)
            {
                Close();
            }
        }

        private void checkBox3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{comboBox1.Name} | {comboBox1.Tag}";

        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{listBox1.Name} | {listBox1.Tag}";
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void listBox2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{listBox2.Name} | {listBox2.Tag}";
        }

        private void listBox2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void listBox3_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{listBox3.Name} | {listBox3.Tag}";
        }

        private void listBox3_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{textBox1.Name} | {textBox1.Tag}";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{textBox2.Name} | {textBox2.Tag}";
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void ДобавитьЭлементToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{ДобавитьЭлементToolStripMenuItem.Name} | {ДобавитьЭлементToolStripMenuItem.Tag}";
        }

        private void ДобавитьЭлементToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void удалитьЭлементToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{удалитьЭлементToolStripMenuItem.Name} | {удалитьЭлементToolStripMenuItem.Tag}";
        }

        private void удалитьЭлементToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void действие1ToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{действие1ToolStripMenuItem1.Name} | {действие1ToolStripMenuItem1.Tag}";
        }

        private void действие1ToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void действие2ToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{действие2ToolStripMenuItem1.Name} | {действие2ToolStripMenuItem1.Tag}";
        }

        private void действие2ToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void добавитьСтрокуToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{добавитьСтрокуToolStripMenuItem.Name} | {добавитьСтрокуToolStripMenuItem.Tag}";
        }

        private void добавитьСтрокуToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void удалитьЭлементToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{удалитьЭлементToolStripMenuItem1.Name} | {удалитьЭлементToolStripMenuItem1.Tag}";
        }

        private void удалитьЭлементToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void русскаяБукваToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{русскаяБукваToolStripMenuItem.Name} | {русскаяБукваToolStripMenuItem.Tag}";
        }

        private void русскаяБукваToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void максКолToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{максКолToolStripMenuItem.Name} | {максКолToolStripMenuItem.Tag}";
        }

        private void максКолToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void radioButton1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{radioButton1.Name} | {radioButton1.Tag}";
        }

        private void radioButton1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void radioButton2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{radioButton2.Name} | {radioButton2.Tag}";
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void radioButton3_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{radioButton3.Name} | {radioButton3.Tag}";
        }

        private void radioButton3_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void radioButton4_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{radioButton4.Name} | {radioButton4.Tag}";
        }

        private void radioButton4_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void radioButton5_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{radioButton5.Name} | {radioButton5.Tag}";
        }

        private void radioButton5_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void radioButton6_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{radioButton6.Name} | {radioButton6.Tag}";
        }

        private void radioButton6_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void checkBox1_MouseEnter (object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Запрет изменений в checkBox2";
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }

        private void checkBox2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Запрет изменений в comboBox1";
        }
        
        private void checkBox2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Empty;
        }
    }
}
