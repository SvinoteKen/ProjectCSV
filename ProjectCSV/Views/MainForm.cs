using MaterialSkin;
using MaterialSkin.Controls;
using ProjectCSV.Services;
using ProjectCSV.Views;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace ProjectCSV
{
    public partial class MainForm : MaterialForm
    {
        IStateService _stateService = new StateService();
        private ListViewColumnSorter lvwColumnSorter;
        private ToDoc doc = new ToDoc();
        private PrintDocument docToPrint = new PrintDocument();
        private string stringToPrint;
        public MainForm()
        {
            InitializeComponent();
            var old = _stateService.CopyOldState();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900, Primary.Green900, Accent.DeepPurple200, TextShade.WHITE);
            lvwColumnSorter = new ListViewColumnSorter();
            this.statesListView.ListViewItemSorter = lvwColumnSorter;
            FillStateList();
        }
        private void FillStateList()
        {
            statesListView.Items.Clear();
            statesListView.GridLines = true;
            var states = _stateService.GetState();
            foreach (var state in states)
            {
                var lvi = new ListViewItem(new[]
                {
                    state.Id.ToString(),
                    state.Region,
                    state.State,
                    state.Area.ToString(),
                    state.Population.ToString()
                });
                statesListView.Items.Add(lvi);
            }
        }
        private void statesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.statesListView.Sort();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddState add = new AddState();
            if (add.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newStates = add.States;
            _stateService.AddState(newStates);
            FillStateList();
        }

        private void updateButton_Click(object sender, System.EventArgs e)
        {
            UpdateState();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            DeletState();
        }
        private void DeletState()
        {
            if (statesListView.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < statesListView.SelectedIndices.Count; i++)
                {
                    if (MessageBox.Show($"Вы действительно хотите удалить эту запись. {statesListView.SelectedItems[i].SubItems[0].Text}", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var idx = int.Parse(statesListView.SelectedItems[i].SubItems[0].Text);
                        _stateService.RemoveState(idx);
                    }
                }
                FillStateList();
            }
            else { MessageBox.Show("Выберте запись которую хотите удалить."); }
        }
        private void UpdateState()
        {
            if (statesListView.SelectedIndices.Count > 0)
            {
                var idx = int.Parse(statesListView.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show($"Вы действительно хотите отредактировать эту запись: {idx}.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Status.Update = true;
                    Status.ID = idx;
                    AddState update = new AddState
                    {
                        Text = "Обновить штат"
                    };
                    if (update.ShowDialog() != DialogResult.OK)
                    {
                        Status.Update = false;
                        return;
                    }
                    var newState = update.States;
                    newState.Id = idx;
                    _stateService.UpdateState(newState, idx);
                    FillStateList();
                    Status.Update = false;
                }

            }
            else { MessageBox.Show("Выберте запись которую хотите отредактировать."); }
        }
        private void deletMenuItem_Click(object sender, System.EventArgs e)
        {
            DeletState();
        }
        private void updateMenuItem_Click(object sender, System.EventArgs e)
        {
            UpdateState();
        }

        private void findRadioButton_Click(object sender, System.EventArgs e)
        {
            if (findTextBox.Text == "")
            {
                MessageBox.Show("Поле для пойска пустое",
                "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<ListViewItem> mass = new List<ListViewItem>();
            foreach (ListViewItem itm in statesListView.Items)
            {
                for (int i = 0; i < itm.SubItems.Count; i++)
                {
                    if (itm.SubItems[i].Text.IndexOf(findTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        mass.Add(itm);
                    }
                }
            }
            if (mass.Count == 0)
            {
                MessageBox.Show("Совпадений не найдено",
                "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            statesListView.Items.Clear();
            for (int i = 0; i < mass.Count; i++)
            {
                if (statesListView.Items.Contains(mass[i]))
                {
                    continue;
                }
                statesListView.Items.Add(mass[i]);
            }
        }

        private void cancelRadioButton_Click(object sender, System.EventArgs e)
        {
            findTextBox.Text = null;
            FillStateList();
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                FileName = "export.docx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (toolStripComboBox1.SelectedIndex == 0)
                {
                    int index = statesListView.Items.Count + 1;
                    string[,] items = new string[index, 5];
                    items[0, 0] = "Код"; items[0, 1] = "Регион"; items[0, 2] = "Штат"; items[0, 3] = "Площадь тыс. км^2";
                    items[0, 4] = "Население тыс. чел.";
                    int rows = 1;
                    for (int i = 0; i < index - 1; i++)
                    {
                        items[rows, 0] = statesListView.Items[i].SubItems[0].Text;
                        items[rows, 1] = statesListView.Items[i].SubItems[1].Text;
                        items[rows, 2] = statesListView.Items[i].SubItems[2].Text;
                        items[rows, 3] = statesListView.Items[i].SubItems[3].Text;
                        items[rows, 4] = statesListView.Items[i].SubItems[4].Text;
                        rows++;
                    }
                    if (!doc.IsFileInUse(sfd.FileName))
                    {
                        doc.CreateWordprocessingDocument(sfd.FileName, 0, items);
                    }
                    else
                    {
                        MessageBox.Show("Закройте файл в который вы хотите добавить таблицу!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    var oldState = _stateService.GetOldState();
                    int index = 1;
                    foreach (var state in oldState)
                    {
                        index++;
                    }
                    string[,] items = new string[index, 5];
                    items[0, 0] = "Код"; items[0, 1] = "Регион"; items[0, 2] = "Штат"; items[0, 3] = "Площадь тыс. км^2";
                    items[0, 4] = "Население тыс. чел.";
                    int rows = 1;
                    foreach (var state in oldState)
                    {
                        items[rows, 0] = state.Id.ToString();
                        items[rows, 1] = state.Region;
                        items[rows, 2] = state.State;
                        items[rows, 3] = state.Area.ToString();
                        items[rows, 4] = state.Population.ToString();
                        rows++;
                    }
                    if (!doc.IsFileInUse(sfd.FileName))
                    {
                        doc.CreateWordprocessingDocument(sfd.FileName, 1, items);
                    }
                    else
                    {
                        MessageBox.Show("Закройте файл в который вы хотите добавить таблицу!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                printDialog1.AllowSomePages = true;
                printDialog1.ShowHelp = true;
                printDialog1.Document = docToPrint;
                printDocument1.DocumentName = Path.GetFileName(sfd.FileName);
                using (FileStream stream = new FileStream(Path.GetFullPath(sfd.FileName), FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    stringToPrint = reader.ReadToEnd();
                }
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    docToPrint.Print();
                }
            }

        }

        private void diagramMenuItem_Click(object sender, EventArgs e)
        {
            Diagram diagramForm = new Diagram();
            diagramForm.ShowDialog();
        }
    }
}