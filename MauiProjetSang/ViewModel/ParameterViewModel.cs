

using MauiProjetSang.Service;
using MauiProjetSang.View;
using System.Windows.Input;

namespace MauiProjetSang.ViewModel;

public partial class ParameterViewModel:BaseViewModel
{
    LogoutService logoutService;
    public ICommand LogoutCommand { get; private set; }
    public ICommand NavigateEditCommand { get; private set; }
    
    public ParameterViewModel(LogoutService logoutService)
    {
        this.logoutService=logoutService;
        NavigateEditCommand = new Command(NavigationEditPassword1);
        LogoutCommand=new Command(Logout);
    }
    public async void NavigationEditPassword1()
    {
        await Shell.Current.GoToAsync(nameof(EditPassword1Page));
    }
    public async void Logout()
    {
        var resultlogout = (await logoutService.logout(Constantes.Constants.AuthToken)).Staus;
        if (resultlogout == "true")
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
        else
        {
            await Shell.Current.DisplayAlert("Erreur", "Vous n'etes pas enregistré", "OK");
        }
    }
}
