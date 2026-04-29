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
            DiaryButton = new PictureBox();
            pictureBox1 = new PictureBox();
            PanelOfButton = new Panel();
            panel2 = new Panel();
            overlayButton = new Button();
            rescheduleButton = new Button();
            panel1 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)DiaryButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelOfButton.SuspendLayout();
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
            PanelOfButton.Controls.Add(panel2);
            PanelOfButton.Controls.Add(panel1);
            PanelOfButton.Controls.Add(dataGridView1);
            PanelOfButton.Location = new Point(174, 44);
            PanelOfButton.Name = "PanelOfButton";
            PanelOfButton.Size = new Size(1702, 1016);
            PanelOfButton.TabIndex = 2;
            PanelOfButton.Paint += PanelOfButton_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(252, 255, 242);
            panel2.Controls.Add(overlayButton);
            panel2.Controls.Add(rescheduleButton);
            panel2.Location = new Point(15, 284);
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
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(editButton);
            panel1.Location = new Point(15, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 125);
            panel1.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(38, 77);
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
            editButton.Location = new Point(38, 20);
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
            Text = "DiaryMain";
            FormClosed += DiaryMain_FormClosed;
            Load += DiaryMain_Load;
            ((System.ComponentModel.ISupportInitialize)DiaryButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelOfButton.ResumeLayout(false);
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
    }
}