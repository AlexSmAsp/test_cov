using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static test_cov.Models.RateInfo;

namespace test_cov.Models
{
    public class RateViewModel : INotifyPropertyChanged
    {

            private int value_c;
            private int value_r;
            private int value_d;

            /// ///////////////////confirmed///////////////////////////////
            public int Value_c
            {
                get { return value_c; }
                private set
                {
                    this.value_c = value;
                    OnPropertyChanged("Value_c");
                }

            }
            /// ///////////////////recovered///////////////////////////////
            public int Value_r
            {
                get { return value_r; }
                private set
                {
                    this.value_r = value;
                    OnPropertyChanged("Value_r");
                }

            }
            /// ///////////////////deaths///////////////////////////////
            public int Value_d
            {
                get { return value_d; }
                private set
                {
                    this.value_d = value;
                    OnPropertyChanged("Value_d");
                }

            }

            /// ///////////////////LoadDataCommand///////////////////////////////
            public ICommand LoadDataCommand { protected set; get; }

            public RateViewModel()
            {
                this.LoadDataCommand = new Command(LoadData);
            }

            private async void LoadData()
            {
                string url = "https://covid19.mathdro.id/api";

                try
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(url);
                    var response = await client.GetAsync(client.BaseAddress);
                    response.EnsureSuccessStatusCode(); // выброс исключения, если произошла ошибка

                    // десериализация ответа в формате json
                    var content = await response.Content.ReadAsStringAsync();
                    JObject o = JObject.Parse(content);

                    var str = o.SelectToken(@"$.confirmed");
                    var rateConfirmed = JsonConvert.DeserializeObject<Confirmed>(str.ToString());

                    var stb = o.SelectToken(@"$.recovered");
                    var rateRecovered = JsonConvert.DeserializeObject<Recovered>(stb.ToString());

                    var stm = o.SelectToken(@"$.deaths");
                    var rateDeaths = JsonConvert.DeserializeObject<Deaths>(stm.ToString());

                    this.Value_c = rateConfirmed.value;
                    this.Value_r = rateRecovered.value;
                    this.Value_d = rateDeaths.value;





                }
                catch (Exception)
                { }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged(string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }

