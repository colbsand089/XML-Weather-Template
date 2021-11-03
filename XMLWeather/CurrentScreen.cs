using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            conditionLabel.Text = Form1.days[0].condition;
            
            if (conditionLabel.Text == "clear sky")
            {
                todayConditionbox.Image = Properties.Resources.sunny;
            }
            if (conditionLabel.Text == "overcast clouds")
            {
                todayConditionbox.Image = Properties.Resources.cloudy;
            }
            if (conditionLabel.Text == "snow")
            {
                todayConditionbox.Image = Properties.Resources.snow;
            }
            if (conditionLabel.Text == "thunderstorm")
            {
                todayConditionbox.Image = Properties.Resources.stormy;
            }
            if (conditionLabel.Text == "rain")
            {
                todayConditionbox.Image = Properties.Resources.rainy;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
