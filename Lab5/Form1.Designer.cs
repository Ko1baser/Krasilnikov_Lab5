namespace Lab5
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
            this.first_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_permission = new System.Windows.Forms.CheckBox();
            this.second_number = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first_number
            // 
            this.first_number.Location = new System.Drawing.Point(185, 43);
            this.first_number.Name = "first_number";
            this.first_number.Size = new System.Drawing.Size(58, 20);
            this.first_number.TabIndex = 0;
            this.first_number.TextChanged += new System.EventHandler(this.first_number_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите два любых числа\r\n(для работы с дробными\r\nчислами при вводе исполь-\r\nзуйте" +
    " запятую вместо точки)";
            // 
            // cbx_permission
            // 
            this.cbx_permission.AutoSize = true;
            this.cbx_permission.Location = new System.Drawing.Point(376, 41);
            this.cbx_permission.Name = "cbx_permission";
            this.cbx_permission.Size = new System.Drawing.Size(97, 30);
            this.cbx_permission.TabIndex = 2;
            this.cbx_permission.Text = "Подключить \r\nбиблиотеку dll";
            this.cbx_permission.UseVisualStyleBackColor = true;
            this.cbx_permission.CheckedChanged += new System.EventHandler(this.cbx_permission_CheckedChanged);
            // 
            // second_number
            // 
            this.second_number.Location = new System.Drawing.Point(250, 42);
            this.second_number.Name = "second_number";
            this.second_number.Size = new System.Drawing.Size(58, 20);
            this.second_number.TabIndex = 3;
            this.second_number.TextChanged += new System.EventHandler(this.second_number_TextChanged);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(185, 83);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(123, 23);
            this.btnAddition.TabIndex = 4;
            this.btnAddition.Text = "Сложение";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.Location = new System.Drawing.Point(185, 112);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(123, 23);
            this.btnSubstraction.TabIndex = 5;
            this.btnSubstraction.Text = "Вычитание";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(185, 141);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(123, 23);
            this.btnMultiplication.TabIndex = 6;
            this.btnMultiplication.Text = "Умножение";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(185, 171);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(123, 23);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "Деление";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Число А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Число B";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(414, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(376, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 219);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.second_number);
            this.Controls.Add(this.cbx_permission);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.first_number);
            this.Name = "Form1";
            this.Text = "Математические операции с двумя числами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_permission;
        private System.Windows.Forms.TextBox second_number;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

