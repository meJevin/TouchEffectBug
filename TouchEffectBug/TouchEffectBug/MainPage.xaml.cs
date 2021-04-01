using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace TouchEffectBug
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public ObservableCollection<string> Items { get; set; }
        
        public MainPage()
        {
            BindingContext = this;

            InitializeComponent();

            Items = new ObservableCollection<string>();
            for (int i = 0; i < 500; ++i)
            {
                Items.Add("Test");
            }
            OnPropertyChanged(nameof(Items));
        }


        private ICommand longPressCommand;
        public ICommand LongPressCommand
        {
            get
            {
                if (longPressCommand == null)
                {
                    longPressCommand = new Command(LongPress);
                }

                return longPressCommand;
            }
        }

        private void LongPress()
        {
            Application.Current.MainPage.DisplayAlert("Long press", "Long press", "OK");
        }

        private bool hasTouchEffects;

        public bool HasTouchEffects
        {
            get
            {
                return hasTouchEffects;
            }

            set
            {
                hasTouchEffects = value;
                OnPropertyChanged();
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            HasTouchEffects = !HasTouchEffects;
        }
    }
}
