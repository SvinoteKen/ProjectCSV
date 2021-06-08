using MaterialSkin;
using MaterialSkin.Controls;
using ProjectCSV.Services;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void updateButton_Click(object sender, System.EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            DeletState();
        }
        private void DeletState()
        {
            if (statesListView.SelectedIndices.Count > 0)
            {
                var idx = int.Parse(statesListView.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show($"Вы действительно хотите удалить эту запись: {idx}.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _stateService.RemoveState(idx);
                    FillStateList();
                }
            }
            else { MessageBox.Show("Выберте запись которую хотите удалить."); }
        }
    }
}
