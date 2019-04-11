namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_chains = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_alphabet = new System.Windows.Forms.TextBox();
            this.textBox_states = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_set_table = new System.Windows.Forms.Button();
            this.textBox_fin_states = new System.Windows.Forms.TextBox();
            this.textBox_start_state = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(427, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_chains
            // 
            this.textBox_chains.Location = new System.Drawing.Point(427, 30);
            this.textBox_chains.Multiline = true;
            this.textBox_chains.Name = "textBox_chains";
            this.textBox_chains.Size = new System.Drawing.Size(155, 20);
            this.textBox_chains.TabIndex = 2;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(427, 95);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(340, 313);
            this.textBox_result.TabIndex = 3;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // textBox_alphabet
            // 
            this.textBox_alphabet.Location = new System.Drawing.Point(12, 30);
            this.textBox_alphabet.Name = "textBox_alphabet";
            this.textBox_alphabet.Size = new System.Drawing.Size(128, 20);
            this.textBox_alphabet.TabIndex = 4;
            // 
            // textBox_states
            // 
            this.textBox_states.Location = new System.Drawing.Point(186, 30);
            this.textBox_states.Name = "textBox_states";
            this.textBox_states.Size = new System.Drawing.Size(152, 20);
            this.textBox_states.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Алфавит";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Состояния";
            // 
            // button_set_table
            // 
            this.button_set_table.Location = new System.Drawing.Point(12, 126);
            this.button_set_table.Name = "button_set_table";
            this.button_set_table.Size = new System.Drawing.Size(128, 36);
            this.button_set_table.TabIndex = 8;
            this.button_set_table.Text = "Создать таблицу";
            this.button_set_table.UseVisualStyleBackColor = true;
            this.button_set_table.Click += new System.EventHandler(this.button_set_table_Click);
            // 
            // textBox_fin_states
            // 
            this.textBox_fin_states.Location = new System.Drawing.Point(186, 80);
            this.textBox_fin_states.Name = "textBox_fin_states";
            this.textBox_fin_states.Size = new System.Drawing.Size(152, 20);
            this.textBox_fin_states.TabIndex = 9;
            // 
            // textBox_start_state
            // 
            this.textBox_start_state.Location = new System.Drawing.Point(12, 80);
            this.textBox_start_state.Name = "textBox_start_state";
            this.textBox_start_state.Size = new System.Drawing.Size(128, 20);
            this.textBox_start_state.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Конечные состояния";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Начальное состояние";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Изменить состояния";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Цепочка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_start_state);
            this.Controls.Add(this.textBox_fin_states);
            this.Controls.Add(this.button_set_table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_states);
            this.Controls.Add(this.textBox_alphabet);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_chains);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_chains;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_alphabet;
        private System.Windows.Forms.TextBox textBox_states;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_set_table;
        private System.Windows.Forms.TextBox textBox_fin_states;
        private System.Windows.Forms.TextBox textBox_start_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}

