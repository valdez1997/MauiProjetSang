

using CommunityToolkit.Mvvm.ComponentModel;
using MauiProjetSang.Model;
using MauiProjetSang.Service;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MauiProjetSang.ViewModel;

public partial class CenterHospitalierViewModel:BaseViewModel
{
    public ObservableCollection<Hospital> Hospitals { get; set; } = new();
    ServiceHospital serviceHospital;

    public bool First { get; set; } = true;

    [ObservableProperty]
    bool isRefreshing;

    public ICommand GetHospitalCommand { get; private set; }

    public CenterHospitalierViewModel(ServiceHospital serviceHospital)
    {
        this.serviceHospital= serviceHospital;
        GetHospitalCommand = new Command(GetHospitalAsync);
    }

    private async void GetHospitalAsync()
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;
            var listhospital = await serviceHospital.GetHospital();
            if (Hospitals.Count != 0)
                Hospitals.Clear();
            foreach(var hospital in listhospital)
            {
                Hospitals.Add(hospital);
            }
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Erreur", "Impossible de recuperer la liste des hopitaux", "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }
    }
}
