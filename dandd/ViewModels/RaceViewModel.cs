using CommunityToolkit.Mvvm.ComponentModel;
using dandd.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using dandd.Models;


namespace dandd.ViewModels;
internal partial class RaceViewModel : ObservableObject, IDisposable
{
    private readonly RaceService _raceServices;

    [ObservableProperty]
    public string _Index;
    [ObservableProperty]
    public int _Name;
    [ObservableProperty]
    public string _Url;

    [ObservableProperty]
    public ObservableCollection<Race> _races;

    public RaceViewModel()
    {
        Races = new ObservableCollection<Race>();
        _raceServices = new RaceService();
    }

    public ICommand GetRacesCommand => new Command(async () => await LoadRacesAsync());

    private async Task LoadRacesAsync()
    {
        Races = await _raceServices.GetRacesAsync();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
