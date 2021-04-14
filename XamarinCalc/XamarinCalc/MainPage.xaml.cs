using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace XamarinCalc
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        double temp = 0;
        public string output { get; set; } = "0";
        string operation = "";
        public MainPage()
        {
            InitializeComponent();
           // this.DataContext = this;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void If0()
        {
            if (output == "0")
            {
                output = "";
            }
        }
        private void ThreeBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 3;
            OutputTextBlock.Text = output;
        }

        private void ZeroBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 0;
            OutputTextBlock.Text = output;
        }

        private void TwoBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 2;
            OutputTextBlock.Text = output;
        }

        private void OneBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 1;
            OutputTextBlock.Text = output;
        }

        private void SixBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 6;
            OutputTextBlock.Text = output;
        }

        private void FiveBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 5;
            OutputTextBlock.Text = output;
        }

        private void FourBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 4;
            OutputTextBlock.Text = output;
        }

        private void NineBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 9;
            OutputTextBlock.Text = output;
        }

        private void EightBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 8;
            OutputTextBlock.Text = output;
        }

        private void SevenBtn_Clicked(object sender, EventArgs e)
        {
            If0();
            output = output + 7;
            OutputTextBlock.Text = output;
        }

        private void DivideBtn_Clicked(object sender, EventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";

                operation = "Divide";
            }
        }

        private void SquareBtn_Clicked(object sender, EventArgs e)
        {
            double square = double.Parse(output);
            output = (square * square).ToString();
            OnPropertyChanged("output");
            OutputTextBlock.Text = output;
        }

        private void SqrtBtn_Clicked(object sender, EventArgs e)
        {
            if (output != "")
            {
                double sqrt = Double.Parse(output);

                output = Math.Sqrt(sqrt).ToString();
                OnPropertyChanged("output");
                OutputTextBlock.Text = output;
            }
        }

        private void ClearBtn_Clicked(object sender, EventArgs e)
        {
            output = "0";
            OutputTextBlock.Text = output;
            OnPropertyChanged("output");
        }

        private async void Window2Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }


        private void EqualsBtn_Clicked(object sender, EventArgs e)
        {
            double outputTemp;

            switch (operation)
            {

                case "Minus":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    OnPropertyChanged("output");
                    OutputTextBlock.Text = output;
                    break;
                case "Plus":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    OnPropertyChanged("output");
                    OutputTextBlock.Text = output;
                    break;
                case "Multiply":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    OnPropertyChanged("output");
                    OutputTextBlock.Text = output;
                    break;
                case "Divide":
                    if (double.Parse(output) != 0)
                    {

                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        OnPropertyChanged("output");
                        OutputTextBlock.Text = output;


                    }
                    break;
            }
        }

        private void TimesBtn_Clicked(object sender, EventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";

                operation = "Multiply";
            }
        }

        private void MinusBtn_Clicked(object sender, EventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";

                operation = "Minus";
            }
        }

        private void PlusBtn_Clicked(object sender, EventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";

                operation = "Plus";

            }
        }

        private async void TTS_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync(output, new SpeechOptions
            {
                Volume = .75f,
                Pitch = 1.0f
            });
        }
    }
}
