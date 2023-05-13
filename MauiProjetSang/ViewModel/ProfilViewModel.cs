

using CommunityToolkit.Mvvm.ComponentModel;
using MauiProjetSang.Model;
using MauiProjetSang.Service;
using System.Diagnostics;
using System.Windows.Input;

namespace MauiProjetSang.ViewModel;

public partial class ProfilViewModel:BaseViewModel
{
    ServiceDisplayProfil serviceDisplayProfil;
    [ObservableProperty]
    bool isRefreshing;

    public bool First { get; set; } = true;
    [ObservableProperty]
    UserProfilEnd userProfil;

    public ICommand ProfilCommand { get; private set; }

    public ProfilViewModel(ServiceDisplayProfil serviceDisplayProfil)
    {
        this.serviceDisplayProfil = serviceDisplayProfil;
        ProfilCommand = new Command(GetProfilAsync);
    }
    public async void GetProfilAsync()
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;
            UserProfil = await serviceDisplayProfil.GetProfil();
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Erreur", "imposssible d'afficher votre profil", "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }
    }
}
