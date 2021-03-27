namespace Parser
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
            this.CheckedListBoxEge = new System.Windows.Forms.CheckedListBox();
            this.CheckBoxGos_1 = new System.Windows.Forms.CheckBox();
            this.CheckBoxArmy_2 = new System.Windows.Forms.CheckBox();
            this.CheckBoxDorm_3 = new System.Windows.Forms.CheckBox();
            this.ButtonClearList = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.RadioButtonVUZ1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonProgram2 = new System.Windows.Forms.RadioButton();
            this.GroupBoxSearch1 = new System.Windows.Forms.GroupBox();
            this.ListBoxPars = new System.Windows.Forms.ListBox();
            this.GroupBoxFilterVUZ2 = new System.Windows.Forms.GroupBox();
            this.GroupBoxFilterProg3 = new System.Windows.Forms.GroupBox();
            this.RadioButtonDist5 = new System.Windows.Forms.RadioButton();
            this.RadioButtonZaochno4 = new System.Windows.Forms.RadioButton();
            this.RadioButtonOchno3 = new System.Windows.Forms.RadioButton();
            this.GroupBoxFilterProg6 = new System.Windows.Forms.GroupBox();
            this.RadioButtonPay7 = new System.Windows.Forms.RadioButton();
            this.RadioButtonBudget6 = new System.Windows.Forms.RadioButton();
            this.GroupBoxFilterEge4 = new System.Windows.Forms.GroupBox();
            this.GroupBoxFilterCity5 = new System.Windows.Forms.GroupBox();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.LabelProgress = new System.Windows.Forms.Label();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonClearFilter = new System.Windows.Forms.Button();
            this.GroupBoxSearch1.SuspendLayout();
            this.GroupBoxFilterVUZ2.SuspendLayout();
            this.GroupBoxFilterProg3.SuspendLayout();
            this.GroupBoxFilterProg6.SuspendLayout();
            this.GroupBoxFilterEge4.SuspendLayout();
            this.GroupBoxFilterCity5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckedListBoxEge
            // 
            this.CheckedListBoxEge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckedListBoxEge.FormattingEnabled = true;
            this.CheckedListBoxEge.Items.AddRange(new object[] {
            "Русский язык",
            "Математика",
            "Обществознание",
            "Физика",
            "История",
            "Иностранный язык",
            "Информатика",
            "Биология",
            "Литература",
            "Химия",
            "География"});
            this.CheckedListBoxEge.Location = new System.Drawing.Point(11, 34);
            this.CheckedListBoxEge.Name = "CheckedListBoxEge";
            this.CheckedListBoxEge.Size = new System.Drawing.Size(154, 169);
            this.CheckedListBoxEge.TabIndex = 4;
            // 
            // CheckBoxGos_1
            // 
            this.CheckBoxGos_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxGos_1.AutoSize = true;
            this.CheckBoxGos_1.Location = new System.Drawing.Point(12, 19);
            this.CheckBoxGos_1.Name = "CheckBoxGos_1";
            this.CheckBoxGos_1.Size = new System.Drawing.Size(98, 17);
            this.CheckBoxGos_1.TabIndex = 6;
            this.CheckBoxGos_1.Text = "Аккредитация";
            this.CheckBoxGos_1.UseVisualStyleBackColor = true;
            // 
            // CheckBoxArmy_2
            // 
            this.CheckBoxArmy_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxArmy_2.AutoSize = true;
            this.CheckBoxArmy_2.Location = new System.Drawing.Point(12, 44);
            this.CheckBoxArmy_2.Name = "CheckBoxArmy_2";
            this.CheckBoxArmy_2.Size = new System.Drawing.Size(116, 17);
            this.CheckBoxArmy_2.TabIndex = 7;
            this.CheckBoxArmy_2.Text = "Военная кафедра";
            this.CheckBoxArmy_2.UseVisualStyleBackColor = true;
            // 
            // CheckBoxDorm_3
            // 
            this.CheckBoxDorm_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxDorm_3.AutoSize = true;
            this.CheckBoxDorm_3.Location = new System.Drawing.Point(12, 69);
            this.CheckBoxDorm_3.Name = "CheckBoxDorm_3";
            this.CheckBoxDorm_3.Size = new System.Drawing.Size(86, 17);
            this.CheckBoxDorm_3.TabIndex = 8;
            this.CheckBoxDorm_3.Text = "Общежитие";
            this.CheckBoxDorm_3.UseVisualStyleBackColor = true;
            // 
            // ButtonClearList
            // 
            this.ButtonClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearList.Location = new System.Drawing.Point(1215, 539);
            this.ButtonClearList.Name = "ButtonClearList";
            this.ButtonClearList.Size = new System.Drawing.Size(115, 30);
            this.ButtonClearList.TabIndex = 9;
            this.ButtonClearList.Text = "Очистить лист";
            this.ButtonClearList.UseVisualStyleBackColor = true;
            this.ButtonClearList.Visible = false;
            this.ButtonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(1139, 539);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(76, 30);
            this.ButtonStart.TabIndex = 11;
            this.ButtonStart.Text = "Пуск";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Visible = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // RadioButtonVUZ1
            // 
            this.RadioButtonVUZ1.AutoSize = true;
            this.RadioButtonVUZ1.Location = new System.Drawing.Point(11, 19);
            this.RadioButtonVUZ1.Name = "RadioButtonVUZ1";
            this.RadioButtonVUZ1.Size = new System.Drawing.Size(49, 17);
            this.RadioButtonVUZ1.TabIndex = 13;
            this.RadioButtonVUZ1.TabStop = true;
            this.RadioButtonVUZ1.Text = "Вуза";
            this.RadioButtonVUZ1.UseVisualStyleBackColor = true;
            this.RadioButtonVUZ1.CheckedChanged += new System.EventHandler(this.RadioButtonVUZ1_CheckedChanged);
            // 
            // RadioButtonProgram2
            // 
            this.RadioButtonProgram2.AutoSize = true;
            this.RadioButtonProgram2.Location = new System.Drawing.Point(11, 42);
            this.RadioButtonProgram2.Name = "RadioButtonProgram2";
            this.RadioButtonProgram2.Size = new System.Drawing.Size(103, 17);
            this.RadioButtonProgram2.TabIndex = 14;
            this.RadioButtonProgram2.TabStop = true;
            this.RadioButtonProgram2.Text = "Специальности";
            this.RadioButtonProgram2.UseVisualStyleBackColor = true;
            this.RadioButtonProgram2.CheckedChanged += new System.EventHandler(this.RadioButtonProgram2_CheckedChanged);
            // 
            // GroupBoxSearch1
            // 
            this.GroupBoxSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxSearch1.Controls.Add(this.RadioButtonVUZ1);
            this.GroupBoxSearch1.Controls.Add(this.RadioButtonProgram2);
            this.GroupBoxSearch1.Location = new System.Drawing.Point(1139, 12);
            this.GroupBoxSearch1.Name = "GroupBoxSearch1";
            this.GroupBoxSearch1.Size = new System.Drawing.Size(190, 66);
            this.GroupBoxSearch1.TabIndex = 15;
            this.GroupBoxSearch1.TabStop = false;
            this.GroupBoxSearch1.Text = "Поиск";
            // 
            // ListBoxPars
            // 
            this.ListBoxPars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxPars.FormattingEnabled = true;
            this.ListBoxPars.Location = new System.Drawing.Point(12, 12);
            this.ListBoxPars.Name = "ListBoxPars";
            this.ListBoxPars.Size = new System.Drawing.Size(1100, 654);
            this.ListBoxPars.TabIndex = 0;
            this.ListBoxPars.DoubleClick += new System.EventHandler(this.ListBoxPars_DoubleClick);
            // 
            // GroupBoxFilterVUZ2
            // 
            this.GroupBoxFilterVUZ2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterVUZ2.CausesValidation = false;
            this.GroupBoxFilterVUZ2.Controls.Add(this.CheckBoxGos_1);
            this.GroupBoxFilterVUZ2.Controls.Add(this.CheckBoxArmy_2);
            this.GroupBoxFilterVUZ2.Controls.Add(this.CheckBoxDorm_3);
            this.GroupBoxFilterVUZ2.Location = new System.Drawing.Point(1138, 366);
            this.GroupBoxFilterVUZ2.Name = "GroupBoxFilterVUZ2";
            this.GroupBoxFilterVUZ2.Size = new System.Drawing.Size(191, 98);
            this.GroupBoxFilterVUZ2.TabIndex = 20;
            this.GroupBoxFilterVUZ2.TabStop = false;
            this.GroupBoxFilterVUZ2.Text = "Фильтр";
            this.GroupBoxFilterVUZ2.Visible = false;
            // 
            // GroupBoxFilterProg3
            // 
            this.GroupBoxFilterProg3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterProg3.Controls.Add(this.RadioButtonDist5);
            this.GroupBoxFilterProg3.Controls.Add(this.RadioButtonZaochno4);
            this.GroupBoxFilterProg3.Controls.Add(this.RadioButtonOchno3);
            this.GroupBoxFilterProg3.Controls.Add(this.GroupBoxFilterProg6);
            this.GroupBoxFilterProg3.Location = new System.Drawing.Point(1139, 366);
            this.GroupBoxFilterProg3.Name = "GroupBoxFilterProg3";
            this.GroupBoxFilterProg3.Size = new System.Drawing.Size(190, 154);
            this.GroupBoxFilterProg3.TabIndex = 21;
            this.GroupBoxFilterProg3.TabStop = false;
            this.GroupBoxFilterProg3.Text = "Форма обучения";
            this.GroupBoxFilterProg3.Visible = false;
            // 
            // RadioButtonDist5
            // 
            this.RadioButtonDist5.AutoSize = true;
            this.RadioButtonDist5.Location = new System.Drawing.Point(11, 65);
            this.RadioButtonDist5.Name = "RadioButtonDist5";
            this.RadioButtonDist5.Size = new System.Drawing.Size(99, 17);
            this.RadioButtonDist5.TabIndex = 25;
            this.RadioButtonDist5.TabStop = true;
            this.RadioButtonDist5.Text = "Дистанционно";
            this.RadioButtonDist5.UseVisualStyleBackColor = true;
            // 
            // RadioButtonZaochno4
            // 
            this.RadioButtonZaochno4.AutoSize = true;
            this.RadioButtonZaochno4.Location = new System.Drawing.Point(11, 42);
            this.RadioButtonZaochno4.Name = "RadioButtonZaochno4";
            this.RadioButtonZaochno4.Size = new System.Drawing.Size(61, 17);
            this.RadioButtonZaochno4.TabIndex = 24;
            this.RadioButtonZaochno4.TabStop = true;
            this.RadioButtonZaochno4.Text = "Заочно";
            this.RadioButtonZaochno4.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOchno3
            // 
            this.RadioButtonOchno3.AutoSize = true;
            this.RadioButtonOchno3.Location = new System.Drawing.Point(11, 19);
            this.RadioButtonOchno3.Name = "RadioButtonOchno3";
            this.RadioButtonOchno3.Size = new System.Drawing.Size(50, 17);
            this.RadioButtonOchno3.TabIndex = 23;
            this.RadioButtonOchno3.TabStop = true;
            this.RadioButtonOchno3.Text = "Очно";
            this.RadioButtonOchno3.UseVisualStyleBackColor = true;
            // 
            // GroupBoxFilterProg6
            // 
            this.GroupBoxFilterProg6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterProg6.Controls.Add(this.RadioButtonPay7);
            this.GroupBoxFilterProg6.Controls.Add(this.RadioButtonBudget6);
            this.GroupBoxFilterProg6.Location = new System.Drawing.Point(0, 88);
            this.GroupBoxFilterProg6.Name = "GroupBoxFilterProg6";
            this.GroupBoxFilterProg6.Size = new System.Drawing.Size(190, 66);
            this.GroupBoxFilterProg6.TabIndex = 22;
            this.GroupBoxFilterProg6.TabStop = false;
            this.GroupBoxFilterProg6.Text = "Оплата";
            // 
            // RadioButtonPay7
            // 
            this.RadioButtonPay7.AutoSize = true;
            this.RadioButtonPay7.Location = new System.Drawing.Point(11, 42);
            this.RadioButtonPay7.Name = "RadioButtonPay7";
            this.RadioButtonPay7.Size = new System.Drawing.Size(62, 17);
            this.RadioButtonPay7.TabIndex = 27;
            this.RadioButtonPay7.TabStop = true;
            this.RadioButtonPay7.Text = "Платно";
            this.RadioButtonPay7.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBudget6
            // 
            this.RadioButtonBudget6.AutoSize = true;
            this.RadioButtonBudget6.Location = new System.Drawing.Point(11, 19);
            this.RadioButtonBudget6.Name = "RadioButtonBudget6";
            this.RadioButtonBudget6.Size = new System.Drawing.Size(65, 17);
            this.RadioButtonBudget6.TabIndex = 26;
            this.RadioButtonBudget6.TabStop = true;
            this.RadioButtonBudget6.Text = "Бюджет";
            this.RadioButtonBudget6.UseVisualStyleBackColor = true;
            // 
            // GroupBoxFilterEge4
            // 
            this.GroupBoxFilterEge4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterEge4.Controls.Add(this.CheckedListBoxEge);
            this.GroupBoxFilterEge4.Location = new System.Drawing.Point(1139, 149);
            this.GroupBoxFilterEge4.Name = "GroupBoxFilterEge4";
            this.GroupBoxFilterEge4.Size = new System.Drawing.Size(190, 211);
            this.GroupBoxFilterEge4.TabIndex = 22;
            this.GroupBoxFilterEge4.TabStop = false;
            this.GroupBoxFilterEge4.Text = "Предметы ЕГЭ";
            this.GroupBoxFilterEge4.Visible = false;
            // 
            // GroupBoxFilterCity5
            // 
            this.GroupBoxFilterCity5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterCity5.Controls.Add(this.ComboBoxCity);
            this.GroupBoxFilterCity5.Location = new System.Drawing.Point(1139, 84);
            this.GroupBoxFilterCity5.Name = "GroupBoxFilterCity5";
            this.GroupBoxFilterCity5.Size = new System.Drawing.Size(190, 59);
            this.GroupBoxFilterCity5.TabIndex = 23;
            this.GroupBoxFilterCity5.TabStop = false;
            this.GroupBoxFilterCity5.Text = "Город";
            this.GroupBoxFilterCity5.Visible = false;
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Items.AddRange(new object[] {
            "Все города",
            "Москва",
            "Санкт-Петербург",
            "Екатеринбург",
            "Казань",
            "Новосибирск",
            "Томск",
            "Самара",
            "Ростов",
            "Воронеж",
            "Краснодар",
            "Красноярск"});
            this.ComboBoxCity.Location = new System.Drawing.Point(22, 24);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.Size = new System.Drawing.Size(143, 21);
            this.ComboBoxCity.TabIndex = 0;
            this.ComboBoxCity.Text = "Все города";
            // 
            // LabelProgress
            // 
            this.LabelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelProgress.AutoSize = true;
            this.LabelProgress.Location = new System.Drawing.Point(1162, 625);
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.Size = new System.Drawing.Size(142, 13);
            this.LabelProgress.TabIndex = 24;
            this.LabelProgress.Text = "Выберите элемент поиска";
            // 
            // ButtonStop
            // 
            this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStop.Location = new System.Drawing.Point(1139, 575);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(76, 30);
            this.ButtonStop.TabIndex = 25;
            this.ButtonStop.Text = "Остановить";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Visible = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonClearFilter
            // 
            this.ButtonClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearFilter.Location = new System.Drawing.Point(1215, 575);
            this.ButtonClearFilter.Name = "ButtonClearFilter";
            this.ButtonClearFilter.Size = new System.Drawing.Size(115, 30);
            this.ButtonClearFilter.TabIndex = 26;
            this.ButtonClearFilter.Text = "Очистить фильтры";
            this.ButtonClearFilter.UseVisualStyleBackColor = true;
            this.ButtonClearFilter.Visible = false;
            this.ButtonClearFilter.Click += new System.EventHandler(this.ButtonClearFilter_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1350, 685);
            this.Controls.Add(this.ButtonClearFilter);
            this.Controls.Add(this.GroupBoxFilterVUZ2);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.LabelProgress);
            this.Controls.Add(this.GroupBoxFilterCity5);
            this.Controls.Add(this.GroupBoxFilterEge4);
            this.Controls.Add(this.GroupBoxFilterProg3);
            this.Controls.Add(this.GroupBoxSearch1);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonClearList);
            this.Controls.Add(this.ListBoxPars);
            this.Name = "Form1";
            this.Text = "Помощник в выборе вуза и специальности";
            this.GroupBoxSearch1.ResumeLayout(false);
            this.GroupBoxSearch1.PerformLayout();
            this.GroupBoxFilterVUZ2.ResumeLayout(false);
            this.GroupBoxFilterVUZ2.PerformLayout();
            this.GroupBoxFilterProg3.ResumeLayout(false);
            this.GroupBoxFilterProg3.PerformLayout();
            this.GroupBoxFilterProg6.ResumeLayout(false);
            this.GroupBoxFilterProg6.PerformLayout();
            this.GroupBoxFilterEge4.ResumeLayout(false);
            this.GroupBoxFilterCity5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox CheckedListBoxEge;
        private System.Windows.Forms.CheckBox CheckBoxGos_1;
        private System.Windows.Forms.CheckBox CheckBoxArmy_2;
        private System.Windows.Forms.CheckBox CheckBoxDorm_3;
        private System.Windows.Forms.Button ButtonClearList;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.RadioButton RadioButtonVUZ1;
        private System.Windows.Forms.RadioButton RadioButtonProgram2;
        private System.Windows.Forms.GroupBox GroupBoxSearch1;
        private System.Windows.Forms.ListBox ListBoxPars;
        private System.Windows.Forms.GroupBox GroupBoxFilterVUZ2;
        private System.Windows.Forms.GroupBox GroupBoxFilterProg3;
        private System.Windows.Forms.GroupBox GroupBoxFilterEge4;
        private System.Windows.Forms.GroupBox GroupBoxFilterCity5;
        private System.Windows.Forms.Label LabelProgress;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.ComboBox ComboBoxCity;
        private System.Windows.Forms.RadioButton RadioButtonDist5;
        private System.Windows.Forms.RadioButton RadioButtonZaochno4;
        private System.Windows.Forms.RadioButton RadioButtonOchno3;
        private System.Windows.Forms.GroupBox GroupBoxFilterProg6;
        private System.Windows.Forms.RadioButton RadioButtonPay7;
        private System.Windows.Forms.RadioButton RadioButtonBudget6;
        private System.Windows.Forms.Button ButtonClearFilter;
    }
}
