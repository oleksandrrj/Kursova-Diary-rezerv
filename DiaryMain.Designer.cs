namespace Курсова_Робота__Щоденник_
{
    partial class DiaryMain
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
            components = new System.ComponentModel.Container();
            DiaryButton = new PictureBox();
            pictureBox1 = new PictureBox();
            PanelOfButton = new Panel();
            panel4 = new Panel();
            stopButton = new Button();
            startButton = new Button();
            IntervalTimeBox = new TextBox();
            reminderLabel = new Label();
            planLabel = new Label();
            manageLabel = new Label();
            labelSearch = new Label();
            panel3 = new Panel();
            searchYesterdayButton = new Button();
            searchTomorrowButton = new Button();
            searchButton = new Button();
            searchTimePicker = new DateTimePicker();
            panel2 = new Panel();
            overlayButton = new Button();
            rescheduleButton = new Button();
            panel1 = new Panel();
            cloneButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            dataGridView1 = new DataGridView();
            TitleColumn = new DataGridViewTextBoxColumn();
            DescColumn = new DataGridViewTextBoxColumn();
            PlaceColumn = new DataGridViewTextBoxColumn();
            DateOfColumn = new DataGridViewTextBoxColumn();
            TimeOfColumn = new DataGridViewTextBoxColumn();
            DurationColumn = new DataGridViewTextBoxColumn();
            DateOfEnding = new DataGridViewTextBoxColumn();
            timerRemind = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)DiaryButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelOfButton.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DiaryButton
            // 
            DiaryButton.Anchor = AnchorStyles.None;
            DiaryButton.Image = Properties.Resources.diarybutton1;
            DiaryButton.Location = new Point(12, 78);
            DiaryButton.Name = "DiaryButton";
            DiaryButton.Size = new Size(107, 90);
            DiaryButton.SizeMode = PictureBoxSizeMode.StretchImage;
            DiaryButton.TabIndex = 0;
            DiaryButton.TabStop = false;
            DiaryButton.Click += DiaryButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.diarybackgrou1;
            pictureBox1.Location = new Point(1109, 328);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1058, 1012);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PanelOfButton
            // 
            PanelOfButton.BackColor = Color.FromArgb(255, 251, 232);
            PanelOfButton.Controls.Add(panel4);
            PanelOfButton.Controls.Add(reminderLabel);
            PanelOfButton.Controls.Add(planLabel);
            PanelOfButton.Controls.Add(manageLabel);
            PanelOfButton.Controls.Add(labelSearch);
            PanelOfButton.Controls.Add(panel3);
            PanelOfButton.Controls.Add(panel2);
            PanelOfButton.Controls.Add(panel1);
            PanelOfButton.Controls.Add(dataGridView1);
            PanelOfButton.Location = new Point(174, 44);
            PanelOfButton.Name = "PanelOfButton";
            PanelOfButton.Size = new Size(1702, 1016);
            PanelOfButton.TabIndex = 2;
            PanelOfButton.Paint += PanelOfButton_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(252, 255, 242);
            panel4.Controls.Add(stopButton);
            panel4.Controls.Add(startButton);
            panel4.Controls.Add(IntervalTimeBox);
            panel4.Location = new Point(15, 845);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 127);
            panel4.TabIndex = 3;
            // 
            // stopButton
            // 
            stopButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stopButton.Location = new Point(40, 89);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(120, 29);
            stopButton.TabIndex = 9;
            stopButton.Text = "Стоп";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.Location = new Point(40, 54);
            startButton.Name = "startButton";
            startButton.Size = new Size(120, 29);
            startButton.TabIndex = 3;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // IntervalTimeBox
            // 
            IntervalTimeBox.Location = new Point(38, 12);
            IntervalTimeBox.Name = "IntervalTimeBox";
            IntervalTimeBox.Size = new Size(125, 27);
            IntervalTimeBox.TabIndex = 8;
            IntervalTimeBox.TextChanged += IntervalTimeBox_TextChanged;
            // 
            // reminderLabel
            // 
            reminderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            reminderLabel.ForeColor = Color.FromArgb(74, 0, 4);
            reminderLabel.Location = new Point(42, 781);
            reminderLabel.Name = "reminderLabel";
            reminderLabel.Size = new Size(145, 61);
            reminderLabel.TabIndex = 7;
            reminderLabel.Text = "Автоматичне нагадування";
            // 
            // planLabel
            // 
            planLabel.AutoSize = true;
            planLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            planLabel.ForeColor = Color.FromArgb(74, 0, 4);
            planLabel.Location = new Point(28, 521);
            planLabel.Name = "planLabel";
            planLabel.Size = new Size(192, 28);
            planLabel.TabIndex = 6;
            planLabel.Text = "Планування подій";
            // 
            // manageLabel
            // 
            manageLabel.AutoSize = true;
            manageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            manageLabel.ForeColor = Color.FromArgb(74, 0, 4);
            manageLabel.Location = new Point(53, 277);
            manageLabel.Name = "manageLabel";
            manageLabel.Size = new Size(123, 28);
            manageLabel.TabIndex = 5;
            manageLabel.Text = "Управління";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSearch.ForeColor = Color.FromArgb(74, 0, 4);
            labelSearch.Location = new Point(28, 12);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(173, 28);
            labelSearch.TabIndex = 4;
            labelSearch.Text = "Пошук за датою";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(252, 255, 242);
            panel3.Controls.Add(searchYesterdayButton);
            panel3.Controls.Add(searchTomorrowButton);
            panel3.Controls.Add(searchButton);
            panel3.Controls.Add(searchTimePicker);
            panel3.Location = new Point(15, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 201);
            panel3.TabIndex = 2;
            // 
            // searchYesterdayButton
            // 
            searchYesterdayButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchYesterdayButton.Location = new Point(16, 155);
            searchYesterdayButton.Name = "searchYesterdayButton";
            searchYesterdayButton.Size = new Size(169, 29);
            searchYesterdayButton.TabIndex = 4;
            searchYesterdayButton.Text = "Вчорашні справи";
            searchYesterdayButton.UseVisualStyleBackColor = true;
            searchYesterdayButton.Click += searchYesterdayButton_Click;
            // 
            // searchTomorrowButton
            // 
            searchTomorrowButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchTomorrowButton.Location = new Point(16, 106);
            searchTomorrowButton.Name = "searchTomorrowButton";
            searchTomorrowButton.Size = new Size(169, 29);
            searchTomorrowButton.TabIndex = 3;
            searchTomorrowButton.Text = "Справи на завтра";
            searchTomorrowButton.UseVisualStyleBackColor = true;
            searchTomorrowButton.Click += searchTomorrowButton_Click;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchButton.Location = new Point(38, 62);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(120, 29);
            searchButton.TabIndex = 2;
            searchButton.Text = "Шукати";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTimePicker
            // 
            searchTimePicker.Location = new Point(3, 18);
            searchTimePicker.Name = "searchTimePicker";
            searchTimePicker.Size = new Size(195, 27);
            searchTimePicker.TabIndex = 0;
            searchTimePicker.ValueChanged += searchTimePicker_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(252, 255, 242);
            panel2.Controls.Add(overlayButton);
            panel2.Controls.Add(rescheduleButton);
            panel2.Location = new Point(15, 574);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 155);
            panel2.TabIndex = 2;
            // 
            // overlayButton
            // 
            overlayButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            overlayButton.Location = new Point(38, 87);
            overlayButton.Name = "overlayButton";
            overlayButton.Size = new Size(120, 56);
            overlayButton.TabIndex = 1;
            overlayButton.Text = "Аналіз накладк";
            overlayButton.UseVisualStyleBackColor = true;
            overlayButton.Click += overlayButton_Click;
            // 
            // rescheduleButton
            // 
            rescheduleButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rescheduleButton.Location = new Point(38, 16);
            rescheduleButton.Name = "rescheduleButton";
            rescheduleButton.Size = new Size(120, 55);
            rescheduleButton.TabIndex = 0;
            rescheduleButton.Text = "Перенести на завтра";
            rescheduleButton.UseVisualStyleBackColor = true;
            rescheduleButton.Click += rescheduleButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 255, 242);
            panel1.Controls.Add(cloneButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(editButton);
            panel1.Location = new Point(15, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 201);
            panel1.TabIndex = 1;
            // 
            // cloneButton
            // 
            cloneButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cloneButton.Location = new Point(38, 82);
            cloneButton.Name = "cloneButton";
            cloneButton.Size = new Size(120, 29);
            cloneButton.TabIndex = 2;
            cloneButton.Text = "Дублювати";
            cloneButton.UseVisualStyleBackColor = true;
            cloneButton.Click += cloneButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(38, 47);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(120, 29);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.Location = new Point(40, 12);
            editButton.Name = "editButton";
            editButton.Size = new Size(120, 29);
            editButton.TabIndex = 0;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TitleColumn, DescColumn, PlaceColumn, DateOfColumn, TimeOfColumn, DurationColumn, DateOfEnding });
            dataGridView1.Location = new Point(233, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1469, 1016);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValidating += dataGridView1_CellValidating_1;
            // 
            // TitleColumn
            // 
            TitleColumn.HeaderText = "Назва справи";
            TitleColumn.MinimumWidth = 6;
            TitleColumn.Name = "TitleColumn";
            TitleColumn.ReadOnly = true;
            TitleColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            TitleColumn.Width = 150;
            // 
            // DescColumn
            // 
            DescColumn.HeaderText = "Опис справи";
            DescColumn.MinimumWidth = 6;
            DescColumn.Name = "DescColumn";
            DescColumn.ReadOnly = true;
            DescColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            DescColumn.Width = 600;
            // 
            // PlaceColumn
            // 
            PlaceColumn.HeaderText = "Місце справи";
            PlaceColumn.MinimumWidth = 6;
            PlaceColumn.Name = "PlaceColumn";
            PlaceColumn.ReadOnly = true;
            PlaceColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            PlaceColumn.Width = 175;
            // 
            // DateOfColumn
            // 
            DateOfColumn.HeaderText = "Дата ";
            DateOfColumn.MinimumWidth = 6;
            DateOfColumn.Name = "DateOfColumn";
            DateOfColumn.ReadOnly = true;
            DateOfColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            DateOfColumn.Width = 125;
            // 
            // TimeOfColumn
            // 
            TimeOfColumn.HeaderText = "Час ";
            TimeOfColumn.MinimumWidth = 6;
            TimeOfColumn.Name = "TimeOfColumn";
            TimeOfColumn.ReadOnly = true;
            TimeOfColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            TimeOfColumn.Width = 125;
            // 
            // DurationColumn
            // 
            DurationColumn.HeaderText = "Тривалість";
            DurationColumn.MinimumWidth = 6;
            DurationColumn.Name = "DurationColumn";
            DurationColumn.ReadOnly = true;
            DurationColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            DurationColumn.Width = 125;
            // 
            // DateOfEnding
            // 
            DateOfEnding.HeaderText = "Дата закінчення";
            DateOfEnding.MinimumWidth = 6;
            DateOfEnding.Name = "DateOfEnding";
            DateOfEnding.ReadOnly = true;
            DateOfEnding.SortMode = DataGridViewColumnSortMode.NotSortable;
            DateOfEnding.Width = 125;
            // 
            // timerRemind
            // 
            timerRemind.Tick += timerRemind_Tick;
            // 
            // DiaryMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 237, 243);
            ClientSize = new Size(1924, 1175);
            Controls.Add(PanelOfButton);
            Controls.Add(pictureBox1);
            Controls.Add(DiaryButton);
            Name = "DiaryMain";
            Text = "Щоденник";
            FormClosed += DiaryMain_FormClosed;
            Load += DiaryMain_Load;
            ((System.ComponentModel.ISupportInitialize)DiaryButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelOfButton.ResumeLayout(false);
            PanelOfButton.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DiaryButton;
        private PictureBox pictureBox1;
        private Panel PanelOfButton;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn DescColumn;
        private DataGridViewTextBoxColumn PlaceColumn;
        private DataGridViewTextBoxColumn DateOfColumn;
        private DataGridViewTextBoxColumn TimeOfColumn;
        private DataGridViewTextBoxColumn DurationColumn;
        private DataGridViewTextBoxColumn DateOfEnding;
        private Button editButton;
        private Panel panel2;
        private Button overlayButton;
        private Button rescheduleButton;
        private Button deleteButton;
        private Panel panel3;
        private Button searchButton;
        private DateTimePicker searchTimePicker;
        private Button cloneButton;
        private Label labelSearch;
        private Label manageLabel;
        private Label planLabel;
        private Label reminderLabel;
        private Panel panel4;
        private Button stopButton;
        private Button startButton;
        private TextBox IntervalTimeBox;
        private System.Windows.Forms.Timer timerRemind;
        private Button searchTomorrowButton;
        private Button searchYesterdayButton;
    }
}