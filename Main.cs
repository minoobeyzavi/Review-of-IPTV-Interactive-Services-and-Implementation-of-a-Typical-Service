using Animaonline.WeatherAPI;
using System.Threading;
using Weather.Properties;

private Animaonline.WeatherAPI.WeatherData wD;
private string City;
private int delay;

delay = Settings.Default.intervalTime;
txtCity.Text = Settings.Default.defaultCity;
this.Location = Settings.Default.windowPosition;
comboBoxEdit1.Text = Settings.Default.intervalText;
timer1.Enabled = Settings.Default.timerOn;

private void getWeather(string City)
        {
            try
            {
                //Get data
                wD = WeatherAPI.GetWeather(LanguageCode.en_US, City);
                
                //Set image positions
                string baseURL = "http://www.google.com";
                string iconToday = baseURL + wD.iconTODAY;
                string icon = baseURL + wD.icon;
                string iconTOMORROW = baseURL + wD.iconTOMORROW;
                string iconDAY2 = baseURL + wD.iconDAY2;
                string iconDAY3 = baseURL + wD.iconDAY3;

                //Set images
                icnCurrent.ImageLocation = icon;
                icnDay2.ImageLocation = iconDAY2;
                icnDay3.ImageLocation = iconDAY3;
                icnToday.ImageLocation = iconToday;
                icnTomorrow.ImageLocation = iconTOMORROW;

                //Current Weather
                lblCity.Text = wD.city;
                lblCurrentCond.Text = wD.condition;
                lblCurrentF.Text = "Temperature: " + wD.temp_c.ToString() + "°C";
                lblWind.Text = wD.humidity;

                //Day 2
                lblDay2.Text = wD.day_of_weekDAY2;
                lblDay2Cond.Text = wD.conditionDAY2;
                lblDay2High.Text = "High:  " + ConvertT(wD.highDAY2).ToString() + "°C";
                lblDay2Low.Text = "Low:  " + ConvertT(wD.lowDAY2).ToString() + "°C";

                //Day 3
                lblDay3.Text = wD.day_of_weekDAY3;
                lblDay3Cond.Text = wD.conditionDAY3;
                lblDay3High.Text = "High:  " + ConvertT(wD.highDAY3).ToString() + "°C";
                lblDay3Low.Text = "Low:  " + ConvertT(wD.lowDAY3).ToString() + "°C";

                //Today
                lblToday.Text = wD.day_of_weekTODAY;
                lblTodayCond.Text = wD.conditionTODAY;
                lblTodayHigh.Text = "High:  " + ConvertT(wD.highTODAY).ToString() + "°C";
                lblTodayLow.Text = "Low:  " + ConvertT(wD.lowTODAY).ToString() + "°C";

                //Tomorrow
                lblTomorrow.Text = wD.day_of_weekTOMORROW;
                lblTomorrowCond.Text = wD.conditionTOMORROW;
                lblTomorrowHigh.Text = "High:  " +ConvertT (wD.highTOMORROW).ToString() + "°C";
                lblTomorrowLow.Text = "Low:  " + ConvertT(wD.lowTOMORROW).ToString() + "°C";

                //Dynamic advertisement corresponding to current weather conditions.
                updateAd(Ad, wD.condition);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check the city name.","Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        
        //Get Initial Weather
        City = txtCity.Text;
        getWeather(City);
        
      
        
        private void getDelay(string Selection)
        {
            //Set the delay based on User Selection
            if (Selection == "Never")
                delay = 1;
            if (Selection == "1 Minute")
                delay = 1;
            if (Selection == "2 Minutes")
                delay = 2;
            if (Selection == "5 Minutes")
                delay = 5;
            if (Selection == "10 Minute")
                delay = 10;
            if (Selection == "30 Minutes")
                delay = 30;
            if (Selection == "1 Hour")
                delay = 1 * 60;
            if (Selection == "2 Hours")
                delay = 2 * 60;
            if (Selection == "4 Hours")
                delay = 4 * 60;
            if (Selection == "Select AutoUpdate Interval")
                delay = 1;
            delay = (delay * 60000);
            
        }

        //Set delay from minutes to milliseconds
        getDelay(comboBoxEdit1.Text);
            
        //Get Weather
        City = txtCity.Text;
        getWeather(City);

        //Set timer1
        if (comboBoxEdit1.Text == "Never")
        {
                timer1.Enabled = false;
        }
        else
        {
                timer1.Interval = delay;
                timer1.Enabled = true;
        }
        
        //Refresh Weather Data
        getWeather(City);
        
        //Save Settings
        Settings.Default.defaultCity = txtCity.Text;
        Settings.Default.intervalText = comboBoxEdit1.Text;
        Settings.Default.windowPosition = this.Location;
        Settings.Default.timerOn = timer1.Enabled;
        Settings.Default.intervalTime = delay;
        Settings.Default.Save();
        
        //Convert Farenheit to Centigrade
        double ConvertT(double f)
        {
             double c = (f - 32) * 5 / 9;
             f = Math.Round(c);
             return f;
        }
        
        //Choose Ad
        void updateAd(PictureBox image, string condition)
        {
            switch (condition)
            {
                case "Clear":
                    {
                        image.Image = Properties.Resources.Clear;
                        break;
                    }
                case "Mostly Sunny":
                    {
                        image.Image = Properties.Resources.MostlySunny;
                        break;
                    }
                case "Partly Cloudy":
                    {
                        image.Image = Properties.Resources.PartlyCloudy;
                        break;
                    }
                case "Mostly Cloudy":
                    {
                        image.Image = Properties.Resources.MostlyCloudy;
                        break;
                    }
                case "Overcast":
                    {
                        image.Image = Properties.Resources.Overcast;
                        break;
                    }
                case "Chance of Rain":
                    {
                        image.Image = Properties.Resources.ChanceofRain;
                        break;
                    }
                case "Partly Sunny":
                    {
                        image.Image = Properties.Resources.PartlySunny;
                        break;
                    }
                case "Cloudy":
                    {
                        image.Image = Properties.Resources.Cloudy;
                        break;
                    }
                case "Thunderstorm":
                    {
                        image.Image = Properties.Resources.Thunderstorm;
                        break;
                    }
                case "Rain":
                    {
                        image.Image=Properties.Resources.Rain;
                        break;
                    }
                case "Showers":
                    {
                        image.Image = Properties.Resources.Showers;
                        break;
                    }
                case "Chance of Storm":
                    {
                        image.Image = Properties.Resources.ChanceofStorm;
                        break;
                    }
                case "Chance of Showers":
                    {
                        image.Image = Properties.Resources.ChanceofShowers;
                        break;
                    }
                case "Fog":
                    {
                        image.Image = Properties.Resources.Fog;
                        break;
                    }
                case "Light rain":
                    {
                        image.Image = Properties.Resources.Lightrain;
                        break;
                    }
                default:
                    {
                        image.Image = Properties.Resources.MostlySunny;
                        break;
                    }
            }

        }
        
