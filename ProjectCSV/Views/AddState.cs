using MaterialSkin;
using MaterialSkin.Controls;
using ProjectCSV.Services;
using ProjectCSV.Entities;
using System; 
using System.Linq;

namespace ProjectCSV.Views
{
    public partial class AddState : MaterialForm
    {
        IStateService _stateService = new StateService();
        public States States { get; set; }
        public AddState()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900, Primary.Green900, Accent.DeepPurple200, TextShade.WHITE);
            if (Status.Update == true)
            {
                States = _stateService.GetState().FirstOrDefault(x => x.Id == Status.ID);
                regionComboBox.SelectedItem = States.Region;
                stateText.Text = States.State;
                areaText.Text = States.Area.ToString();
                populationText.Text = States.Population.ToString();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool succeess = double.TryParse(areaText.Text, out _);
            if (!succeess)
            {
                MessageBox.Show("Поле \"Площадь\" должно иметь вещественное значение",
                    "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool succeess = double.TryParse(populationText.Text, out _);
            if (!succeess)
            {
                MessageBox.Show("Поле \"Население\" должно иметь вещественное значение",
                    "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var id = _stateService.GetMaxId();
            States = new States
            {
                Id = id + 1,
                Region = regionComboBox.Text,
                State = stateText.Text,
                Area = double.Parse(areaText.Text),
                Population = double.Parse(populationText.Text)
            };
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
