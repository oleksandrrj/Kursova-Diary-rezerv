using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Курсова_Робота__Щоденник_
{
    public partial class DiaryMain : Form
    {
        public class DiaryEntry
        {
            public string Number { get; set; } = "";
            public string Title { get; set; } = "";
            public string Description { get; set; } = "";
            public string Place { get; set; } = "";
            public DateTime Date { get; set; }
            public string Time { get; set; } = "";
            public string Duration { get; set; } = "";
            public string DateOfEnd { get; set; } = "";
        }

        List<DiaryEntry> entries = new List<DiaryEntry>();
        private string filePath = "diary_data.xml";

        public DiaryMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            PanelOfButton.Visible = false;


            dataGridView1.ReadOnly = true;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void SaveData()
        {
            try
            {
                dataGridView1.EndEdit();
                DataTable dt = new DataTable("DiaryEntries");

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    dt.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dr = dt.NewRow();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dr[cell.ColumnIndex] = cell.Value ?? string.Empty;
                        }
                        dt.Rows.Add(dr);
                    }
                }
                dt.WriteXml(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні: " + ex.Message);
            }
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    DataTable dt = new DataTable("DiaryEntries");

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        dt.Columns.Add(col.Name);
                    }

                    dt.ReadXml(filePath);

                    dataGridView1.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        // Додаємо знак оклику після ItemArray
                        dataGridView1.Rows.Add(dr.ItemArray!);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні: " + ex.Message);
                }
            }
        }
        private void DiaryMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveData();
            Application.Exit();

        }

        private void DiaryButton_Click(object sender, EventArgs e)
        {
            PanelOfButton.Visible = !PanelOfButton.Visible;
        }



        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.CurrentCell.ReadOnly = false;
                dataGridView1.BeginEdit(true);
            }
        }



        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Робимо таблицю знову тільки для читання
            dataGridView1.ReadOnly = true;

            // Забираємо фокус, щоб клітинка не "світилася"
            dataGridView1.ClearSelection();
            editButton.Focus();
        }


        private void DiaryMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void PanelOfButton_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView1_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Перевіряємо, чи клітинка зараз редагується
            if (dataGridView1.IsCurrentCellInEditMode)
            {

                DialogResult result = MessageBox.Show(
                    "Ви впевнені, що хочете зберегти ці зміни?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {

                    e.Cancel = true;
                }

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибрано хоча б одну клітинку
            if (dataGridView1.SelectedCells.Count > 0)
            {
                bool hasContent = false;

                // Перевіряємо, чи є хоч в одній із вибраних клітинок якийсь текст
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        hasContent = true;
                        break;
                    }
                }

                // Якщо всі вибрані клітинки порожні
                if (!hasContent)
                {
                    MessageBox.Show("Видалити пусті клітинки неможливо!", "Увага",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Якщо є що видаляти запитуємо підтвердження
                DialogResult result = MessageBox.Show($"Ви впевнені, що хочете видалити вміст {dataGridView1.SelectedCells.Count} виділених клітинок?",
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Видаляємо текст у кожній виділеній клітинці
                    foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                    {
                        cell.Value = string.Empty;
                    }

                    // Очищуємо виділення та повертаємо фокус
                    dataGridView1.ClearSelection();
                    editButton.Focus();
                }
            }
            else
            {
                MessageBox.Show("Спочатку виберіть клітинки для видалення!");
            }
        }

        private void rescheduleButton_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи є виділені клітинки
            if (dataGridView1.SelectedCells.Count > 0)
            {
                bool atLeastOneDateProcessed = false;

                // Проходимо по ВСІХ виділених клітинках
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {

                        if (DateTime.TryParse(cell.Value.ToString(), out DateTime currentDate))
                        {
                            // Додаємо 1 день і записуємо назад
                            cell.Value = currentDate.AddDays(1).ToShortDateString();
                            atLeastOneDateProcessed = true;
                        }
                    }
                }


                if (!atLeastOneDateProcessed)
                {
                    MessageBox.Show("Серед виділеного немає жодної коректної дати!", "Помилка");
                }


            }
            else
            {
                MessageBox.Show("Спочатку виберіть клітинку або кілька клітинок з датою!");
            }
        }

        private void overlayButton_Click(object sender, EventArgs e)
        {
            var intervals = new List<(int RowIndex, string Title, DateTime Start, DateTime End)>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var row = dataGridView1.Rows[i];
                if (row.IsNewRow) continue;

                try
                {


                    string title = row.Cells["TitleColumn"].Value?.ToString()?.Trim() ?? "Без назви";
                    string dateStr = row.Cells["DateOfColumn"].Value?.ToString()?.Trim() ?? "";
                    string timeStr = row.Cells["TimeOfColumn"].Value?.ToString()?.Trim() ?? "";
                    string durationStr = row.Cells["DurationColumn"].Value?.ToString()?.Trim() ?? "";

                    // Якщо основні дані порожні  йдемо далі
                    if (string.IsNullOrEmpty(dateStr) || string.IsNullOrEmpty(timeStr) || string.IsNullOrEmpty(durationStr))
                        continue;

                    
                    DateTime start = DateTime.Parse($"{dateStr} {timeStr}");
                    TimeSpan duration = TimeSpan.Parse(durationStr);
                    DateTime end = start.Add(duration);

                    intervals.Add((i + 1, title, start, end));
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Помилка в рядку {i + 1}: {ex.Message}\nПеревір, чи вірно вказано (Name) стовпців у дизайнері!");
                    return;
                }
            }

            StringBuilder report = new StringBuilder();
            bool hasOverlay = false;

            for (int i = 0; i < intervals.Count; i++)
            {
                for (int j = i + 1; j < intervals.Count; j++)
                {
                    var t1 = intervals[i];
                    var t2 = intervals[j];

                    if (t1.Start.Date == t2.Start.Date)
                    {
                        // Головна умова накладки
                        if (t1.Start < t2.End && t2.Start < t1.End)
                        {
                            hasOverlay = true;
                            report.AppendLine($"⚠️ НАКЛАДКА: рядок {t1.RowIndex} та {t2.RowIndex}");
                            report.AppendLine($"   \"{t1.Title}\" ({t1.Start:HH:mm} - {t1.End:HH:mm})");
                            report.AppendLine($"   \"{t2.Title}\" ({t2.Start:HH:mm} - {t2.End:HH:mm})");
                            report.AppendLine("-----------------------------------------");
                        }
                    }
                }
            }

            if (hasOverlay)
            {
                MessageBox.Show(report.ToString(), "Знайдено накладки!");
            }
            else
            {
                MessageBox.Show($"Перевірено {intervals.Count} справ. Накладок не виявлено.", "Результат");
            }
        }

        private void searchTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e) // Кнопка пошуку
        {
            // 1. Отримуємо дату, яку ти вибрав у searchTimePicker (тільки число, місяць, рік)
            DateTime targetDate = searchTimePicker.Value.Date;

            bool isFound = false;

            // 2. Знімаємо виділення з усіх рядків 
            dataGridView1.ClearSelection();

            // 3. Проходимо циклом по всіх рядках таблиці
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Пропускаємо порожній рядок в кінці таблиці
                if (row.IsNewRow) continue;

                // Беремо значення з нашого стовпця з датою
                var dateCellValue = row.Cells["DateOfColumn"].Value;

                if (dateCellValue != null)
                {
                    // Намагаємося перетворити текст із клітинки в дату
                    if (DateTime.TryParse(dateCellValue.ToString(), out DateTime rowDate))
                    {
                        // 4. Порівнюємо дату в рядку з обраною датою
                        if (rowDate.Date == targetDate)
                        {

                            row.Selected = true;

                            // Якщо це перший знайдений рядок  прокручуємо таблицю до нього
                            if (!isFound)
                            {
                                dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                            }

                            isFound = true;
                        }
                    }
                }
            }


            if (!isFound)
            {
                MessageBox.Show("Справ на вибрану дату не знайдено.", "Пошук");
            }
            else
            {
                MessageBox.Show($"Знайдено та виділено справи на {targetDate.ToShortDateString()}", "Успіх");
            }
        }

        private void cloneButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // 1. Групуємо всі виділені клітинки за їхніми рядками
                var selectedRowsGroups = dataGridView1.SelectedCells
                    .Cast<DataGridViewCell>()
                    .GroupBy(c => c.RowIndex)
                    .OrderBy(g => g.Key)
                    .ToList();

                // Список для нових клітинок (використовуємо nullable типи)
                List<DataGridViewCell> cellsToSelect = new List<DataGridViewCell>();

                foreach (var rowGroup in selectedRowsGroups)
                {
                    int sourceRowIndex = rowGroup.Key;
                    DataGridViewRow sourceRow = dataGridView1.Rows[sourceRowIndex];
                    if (sourceRow.IsNewRow) continue;

                    // Дозволяємо null значення в нашому списку (object?)
                    var copiedData = new List<(string colName, object? value)>();
                    foreach (DataGridViewCell cell in rowGroup)
                    {
                        copiedData.Add((dataGridView1.Columns[cell.ColumnIndex].Name!, cell.Value));
                    }

                    // 2. Шукаємо вільне місце нижче
                    int targetRowIndex = -1;
                    for (int i = sourceRowIndex + 1; i < dataGridView1.Rows.Count; i++)
                    {
                        var row = dataGridView1.Rows[i];
                        if (row.IsNewRow) continue;

                        bool canInsertHere = true;
                        foreach (var item in copiedData)
                        {
                            var targetValue = row.Cells[item.colName].Value;
                            if (targetValue != null && !string.IsNullOrWhiteSpace(targetValue.ToString()))
                            {
                                canInsertHere = false;
                                break;
                            }
                        }

                        if (canInsertHere)
                        {
                            targetRowIndex = i;
                            break;
                        }
                    }

                    // 3. Якщо місця немає то додаємо в кінець
                    if (targetRowIndex == -1)
                    {
                        targetRowIndex = dataGridView1.Rows.Add();
                    }

                    // 4. Вставляємо дані
                    DataGridViewRow targetRow = dataGridView1.Rows[targetRowIndex];
                    foreach (var item in copiedData)
                    {
                        targetRow.Cells[item.colName].Value = item.value;
                        cellsToSelect.Add(targetRow.Cells[item.colName]);
                    }
                }

                // 5. Оновлюємо виділення
                dataGridView1.ClearSelection();
                foreach (var newCell in cellsToSelect)
                {
                    newCell.Selected = true;
                }

                dataGridView1.Focus();
            }
        }


        private void IntervalTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Перевіряємо формат 00:00 у полі IntervalTimeBox
            if (DateTime.TryParseExact(IntervalTimeBox.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime parsedTime))
            {
                int totalMilliseconds = (parsedTime.Hour * 3600 + parsedTime.Minute * 60) * 1000;

                if (totalMilliseconds > 0)
                {
                    timerRemind.Interval = totalMilliseconds;
                    timerRemind.Start();
                    MessageBox.Show($"Нагадування увімкнено! Буду перевіряти справи кожні {IntervalTimeBox.Text}", "Таймер");
                }
                else
                {
                    MessageBox.Show("Час інтервалу має бути більшим за нуль.");
                }
            }
            else
            {
                MessageBox.Show("Введіть час у форматі ГГ:ХХ (наприклад, 00:10)");
            }
        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            timerRemind.Stop();
            MessageBox.Show("Автоматичне нагадування вимкнено.");
        }

        private void timerRemind_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DataGridViewRow nearestRow = null!;
            TimeSpan minDiff = TimeSpan.MaxValue;

            // 1. Шукаємо НАЙБЛИЖЧУ справу серед усіх записів
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                var dateVal = row.Cells["DateOfColumn"].Value?.ToString();
                var timeVal = row.Cells["TimeOfColumn"].Value?.ToString();

                if (!string.IsNullOrEmpty(dateVal) && !string.IsNullOrEmpty(timeVal))
                {
                    try
                    {
                        DateTime eventTime = DateTime.Parse($"{dateVal} {timeVal}");
                        TimeSpan diff = eventTime - now;

                        // Нас цікавлять тільки справи у майбутньому
                        if (diff.TotalSeconds > 0 && diff < minDiff)
                        {
                            minDiff = diff;
                            nearestRow = row;
                        }
                    }
                    catch { continue; }
                }
            }

            // 2. Якщо найближчу справу знайдено виводимо нагадування
            if (nearestRow != null)
            {
                string title = nearestRow.Cells["TitleColumn"].Value?.ToString() ?? "Подія";

                // Формуємо текст, каже скільки залишилося (дні, години, хвилини)
                string timeLeft = "";
                if (minDiff.Days > 0) timeLeft += $"{minDiff.Days} дн. ";
                timeLeft += $"{minDiff.Hours} год. {minDiff.Minutes} хв.";

                // Зупиняємо таймер на час показу вікна, щоб вони не накопичувались
                timerRemind.Stop();

                MessageBox.Show(
                    $"НАЙБЛИЖЧА СПРАВА: {title}\n\nДо неї залишилось: {timeLeft}",
                    "Нагадування",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                timerRemind.Start();
            }
        }
    }
    }
