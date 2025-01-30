using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FBTECHNOLOGIES.ViewModels
{
    public class HomePageDashboardViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ImmobilizeOption> _immobilizeOptions;

        public ObservableCollection<ImmobilizeOption> ImmobilizeOptions
        {
            get => _immobilizeOptions;
            set
            {
                _immobilizeOptions = value;
                OnPropertyChanged(nameof(ImmobilizeOptions));
            }
        }

        public HomePageDashboardViewModel()
        {
            ImmobilizeOptions = new ObservableCollection<ImmobilizeOption>
        {
            new ImmobilizeOption { Text = "Immo OFF", Position = 0 },
            new ImmobilizeOption { Text = "Immo OFF", Position = 1 },
            new ImmobilizeOption { Text = "Immo OFF", Position = 2 }
            // Add more as needed, the margin will be calculated with 
        };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public List<ImmobilizeOption> GetEnabledOptions()
{
    return ImmobilizeOptions.Where(x => x.IsEnabled).ToList();
}
    }
}
