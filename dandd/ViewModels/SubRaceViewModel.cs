using CommunityToolkit.Mvvm.ComponentModel;
using dandd.Models;
using dandd.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dandd.ViewModels
{
    internal partial class SubRaceViewModel : ObservableObject, IDisposable
    {
        private readonly SubRaceService _subRaceServices;

        [ObservableProperty]
        public string _Index;
        [ObservableProperty]
        public int _Name;
        [ObservableProperty]
        public string _Url;

        [ObservableProperty]
        public ObservableCollection<SubRace> _subRaces;

        public SubRaceViewModel()
        {
            SubRaces = new ObservableCollection<SubRace>();
            _subRaceServices = new SubRaceService();
        }

        public ICommand GetSubRacesCommand => new Command(async () => await LoadSubRacesAsync());

        private async Task LoadSubRacesAsync()
        {
            SubRaces = await _subRaceServices.GetSubRacesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
