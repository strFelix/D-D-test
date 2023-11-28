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

internal partial class ClassViewModel : ObservableObject, IDisposable
{
    private readonly ClassService _classServices;

    [ObservableProperty]
    public string _Index;
    [ObservableProperty]
    public int _Name;
    [ObservableProperty]
    public string _Url;

    [ObservableProperty]
    public ObservableCollection<Class> _classes;

    public ClassViewModel()
    {
        Classes = new ObservableCollection<Class>();
        _classServices = new ClassService();
    }

    public ICommand GetClassesCommand => new Command(async () => await LoadClassesAsync());

    private async Task LoadClassesAsync()
    {
        Classes = await _classServices.GetClassesAsync();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
