using MaterialSkin;
using MaterialSkin.Controls;
using ProjectCSV.Services;
using ProjectCSV.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectCSV
{
    public partial class MainForm : MaterialForm
    {
        IStateService _stateService = new StateService();
        private ListViewColumnSorter lvwColumnSorter;
        public MainForm()
        {
            InitializeComponent();
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
    }
}
