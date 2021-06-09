using MaterialSkin;
using MaterialSkin.Controls;
using ProjectCSV.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCSV.Views
{
    public partial class Diagram : MaterialForm
    {
        public Diagram()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900, Primary.Green900, Accent.DeepPurple200, TextShade.WHITE);
            chart1.Titles.Add("Население тыс. чел.");
            chart2.Titles.Add("Площадь тыс. км^2");
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart2.Series["Series1"].IsValueShownAsLabel = true;
            IStateService _stateService = new StateService();
            var states = _stateService.GetState();
            foreach (var state in states) 
            {
                chart1.Series["Series1"].Points.AddXY(state.State, state.Population);
                chart2.Series["Series1"].Points.AddXY(state.State, state.Area);
            }
        }
    }
}
