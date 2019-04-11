using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string[] Alphabet;
        public string[] States;
        public string[] Mas_chains;
        public string[] Fin_states;
        public string [,] Matrix_trans;
        public string depth = "";
        public string start_state;
        public Form1()
        {
            InitializeComponent();
        }
        private string[] Remove(string[] array, string item)
        {
            int remInd = -1;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == item)
                {
                    remInd = i;
                    break;
                }
            }

            string[] retVal = new string[array.Length - 1];

            for (int i = 0, j = 0; i < retVal.Length; ++i, ++j)
            {
                if (j == remInd)
                    ++j;

                retVal[i] = array[j];
            }

            return retVal;
        }
        private void Form1_Load(object sender, EventArgs e)//заполняем автомат при запуске (цепочки с '00')
        {
            AllocConsole();/*
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //установка столбцов (входы)
            this.dataGridView1.Columns.Add("Column1", "0");
            this.dataGridView1.Columns.Add("Column2", "1");
            this.dataGridView1.Columns.Add("Column3", "2");
            //this.dataGridView1.Columns.Add("Колонка 3", "Заголовок 3");
            //заполнение строк (переходы)
            this.dataGridView1.Rows.Add("B", "", "");
            this.dataGridView1.Rows.Add("", "C", "");
            this.dataGridView1.Rows.Add("D", "D", "D");
            this.dataGridView1.Rows.Add("C", "C", "C");
            //установка заголовков строк (состояния)
            this.dataGridView1.Rows[0].HeaderCell.Value = "A";
            this.dataGridView1.Rows[1].HeaderCell.Value = "B";
            this.dataGridView1.Rows[2].HeaderCell.Value = "C";
            this.dataGridView1.Rows[3].HeaderCell.Value = "D";
            */
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.Write(States[0]);
            //проверка на пустые состояния
            if (this.textBox_start_state.Text == "" || this.textBox_fin_states.Text == "")
            {
                MessageBox.Show("Отсутствует стартовое или конечные состояния");
                return;
            }
            int count_real_states = 0;
            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                if (this.dataGridView1.Rows[i].HeaderCell.Value != null)
                    count_real_states++;
            //заполняю массивы состояний и алфавита
            Alphabet = new string[this.dataGridView1.ColumnCount];
            States = new string[count_real_states];
            
            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
                Alphabet[i] = this.dataGridView1.Columns[i].HeaderText;

            for (int i = 0; i < count_real_states; i++)
                States[i] = this.dataGridView1.Rows[i].HeaderCell.Value.ToString();
                
           
            //Console.Write(States.Length.ToString());


            //Console.Write(States[i]);
            //Console.Write(Alphabet[0] + Alphabet[1]);
            //Console.Write(States.Length);
            //запоняем матрицу переходов
           // Console.Write("\n");
            Matrix_trans = new string[States.Length, Alphabet.Length];
            for (int i = 0; i < States.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                    try { Matrix_trans[i, j] = this.dataGridView1.Rows[i].Cells[j].Value.ToString(); }
                    catch { Matrix_trans[i, j] = ""; }


            for (int i = 0; i < States.Length; i++)
            {
                for (int j = 0; j < Alphabet.Length; j++)
                //Matrix_trans[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                {
                    Console.Write(Matrix_trans[i, j] + " ");
                }
                Console.Write("\n");
            }
            //формируем массив цепочек
            Mas_chains = this.textBox_chains.Text.Split(',');
            Init_some();
            //паихали
            int start = Get_state(start_state);
            for (int i = 0; i < Mas_chains.Length; i++)
            {
                if(!Check_chain_for_alphabet(Mas_chains[i]))
                {
                    this.textBox_result.Text += Mas_chains[i] + " — в данной цепочке присутствуют посторонние символы" + Environment.NewLine;
                    continue;
                }
                Vivod(0, start, Mas_chains[i]);
                this.textBox_result.Text +=  Environment.NewLine;
                depth = "";

            }
             //   for(int j = 0; j < )
        }
        private void Vivod(int cur_symbol_ind, int cur_state, string Chain)
        {
            bool flag_exit = true;
           // int next_state = cur_state;
            this.textBox_result.Text += " Вывод для " + Chain  + " :" + Environment.NewLine;
            if (Chain == "")
            {
                if (Fin_states.Contains(start_state))
                {
                    this.textBox_result.Text += Chain + "Пустая цепочка принадлежит, т.к. начальное состояние совпадает с конечными " + Environment.NewLine;
                    return;
                }
                else {
                    this.textBox_result.Text += Chain + "Пустая цепочка не принадлежит, т.к. начальное состояние не совпадает с конечными" + Environment.NewLine;
                    return;
                }
                
                
            }
            
            //this.textBox_result.Text += depth + "<" + Matrix_trans[cur_state, i] + "," + Get_chain_at_ind(Chain, cur_symbol_ind) + ">" + Environment.NewLine;
            //depth += "-";
            depth += "-";
            while (cur_symbol_ind != Chain.Length)
            {
                flag_exit = true;
                //cur_state = next_state;
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    
                    if (Chain[cur_symbol_ind].ToString() == Alphabet[i])
                    {
                        flag_exit = false;
                        this.textBox_result.Text +=  "Состояние - " + this.dataGridView1.Rows[cur_state].HeaderCell.Value + ". Оставшаяся цепочка - "+ Get_chain_at_ind(Chain, cur_symbol_ind) + Environment.NewLine;
                        //depth += "-";
                        //if (cur_symbol_ind != Chain.Length - 1)
                        if(Matrix_trans[cur_state, i] != "")
                            cur_state = Get_state(Matrix_trans[cur_state, i]);
                        else
                        {
                            this.textBox_result.Text += Chain +  " - данная цепочка не принадлежит, т.к. нет перехода из состояния " + States[cur_state] + "' по символу '" + Alphabet[i].ToString()+ "'" + Environment.NewLine;
                            return;
                        }
                        //next_state = Get_state(Matrix_trans[cur_state, i]);
                        cur_symbol_ind++;
                        break;
                    }
                }
                if (flag_exit)// не нашли переход
                {
                    this.textBox_result.Text += Chain +" - данная цепочка не принадлежит, т.к. не найден переход" + Environment.NewLine;
                    return;
                }
            }
            if (Fin_states.Contains(States[cur_state]))
            {
                //this.textBox_result.Text += depth + "<" + this.dataGridView1.Rows[cur_state].HeaderCell.Value + "," + Get_chain_at_ind(Chain, cur_symbol_ind) + ">" + Environment.NewLine;
                this.textBox_result.Text += Chain + " - данная цепочка принадлежит, т.к. достигнуто конечное состояние " + this.dataGridView1.Rows[cur_state].HeaderCell.Value + Environment.NewLine;
                return;
            }
            else
            {
                //this.textBox_result.Text += depth + "<" + this.dataGridView1.Rows[cur_state].HeaderCell.Value + "," + Get_chain_at_ind(Chain, cur_symbol_ind) + ">" + Environment.NewLine;

                this.textBox_result.Text += Chain + " - данная цепочка не принадлежит, т.к. она дочитана, но состояние " + this.dataGridView1.Rows[cur_state].HeaderCell.Value + " не конечное" + Environment.NewLine;
                return;
            }
            
        }
        private string Get_chain_at_ind(string chain, int ind)
        {
            string str = "";
            for (int i = 0; i < chain.Length; i++)
                if (i >= ind)
                    str += chain[i].ToString();
            return str;
        }

        private int Get_state(string str)
        {
            for (int i = 0; i < States.Length; i++)
            {
                if (str == States[i])
                    return i;
            }
            MessageBox.Show("Get_next_state" + str);
            return -1;
        }

        private void Init_some()
        {
            if (this.textBox_start_state.Text == "" || this.textBox_fin_states.Text == "")
            {
                MessageBox.Show("Отсутствуют стартовое или конечные состояния");
                return;
            }
            Fin_states = this.textBox_fin_states.Text.Split(',');
            Fin_states = Fin_states.Distinct().ToArray();
            start_state = this.textBox_start_state.Text;
            
            foreach (string i in Fin_states)//проверка на совпадения конечных состояний и состояний
            {
                if (!States.Contains(i))
                {
                    MessageBox.Show("Конечное состояние " + i + " отсутствует в обычных состояниях");
                    return;
                }
            }
            if (!States.Contains(start_state))
            {
                MessageBox.Show("Начальное состояние отсутствует в обычных состояниях");
                return;
            }
        }

        private void button_set_table_Click(object sender, EventArgs e)
        {
           
                
            // проверки на ввод

            Alphabet = this.textBox_alphabet.Text.Split(',');
            States = this.textBox_states.Text.Split(',');
            Init_some();
            foreach (string i in Alphabet)//проверка на пустоту строк
            {
                if (i == "")
                    Alphabet = Remove(Alphabet, i);
            }
            Alphabet = Alphabet.Distinct().ToArray();//удаление одинаковых
            foreach (string i in States)//проверка на пустоту строк
            {
                if (i == "")
                    States = Remove(States, i);
            }
            States = States.Distinct().ToArray();//удаление одинаковых
            if (Alphabet.Length == 0)
            {
                MessageBox.Show("Задайте алфавит");
                return;
            }
            foreach (string i in States)//проверка на совпадения в алфавита и состояний
            {
                if (Alphabet.Contains(i))
                {
                    MessageBox.Show("Элемент алфавита " + i + " сопадает с состоянием");
                    return;
                }
            }
            
            //for (int i = 0; i < Alphabet.Length; i++)
            //  MessageBox.Show(Alphabet[i]);
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Rows.Clear();
            //строим таблицу с заданными столбцами и строками
            for (int i = 0; i < Alphabet.Length; i++)
            {
                this.dataGridView1.Columns.Add("Column"+ i.ToString(), Alphabet[i]);      
            }
            for (int i = 0; i < States.Length; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i].HeaderCell.Value = States[i]; 
            }

        }
        private bool Check_chain_for_alphabet(string Chain)
        {
            foreach (char i in Chain)
            {
                if (Alphabet.Contains(i.ToString()) == false)
                    return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init_some();
        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
