

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiProjetSang.Constantes;
using MauiProjetSang.Model;
using MauiProjetSang.Service;
using MauiProjetSang.View;
using System.Windows.Input;

namespace MauiProjetSang.ViewModel;

public partial class LoginViewModel:BaseViewModel
{
    LoginService loginService;
    [ObservableProperty]
    public string email;
    [ObservableProperty]
    public string password;

    public ICommand RegisterCommand { get; private set; }
    //public ICommand LoginCommand { get; private set; }
    public LoginViewModel(LoginService loginService)
    {
        this.loginService = loginService;
        RegisterCommand = new Command(Regist);

    }
    [RelayCommand]
    async void EditPassword()
    {
        //Shell.Current.Navigation.PushAsync(new View.EditPasswordPage());
        await Shell.Current.GoToAsync($"{nameof(EditPassword1Page)}");
    }

    async void Regist()
    {
        // await Shell.Current.Navigation.PushAsync(new View.RegisterPage());
        //  await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");
        await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");

    }
    [RelayCommand]
    public async Task Login()
    {

        var user = new UserLoginSen
        {
            email = Email,
            password = Password
        };
        var statu = (await loginService.Postlogin(user)).status;
        var accesToken = (await loginService.Postlogin(user)).token;
        Constants.AuthToken = accesToken;


        Constants.AuthName = (await loginService.Postlogin(user)).name;
        var ids = (await loginService.Postlogin(user)).id;

        Constants.Authid = ids;


        if ((Email == null) && (Password == null))
        {
            await Shell.Current.DisplayAlert("Error", "Veuillez remplir les champs Email et Password", "OK");
        }
        if (Password.Length < 7)
        {
            await Shell.Current.DisplayAlert("Error", "Mot de passe tres peu sécurisé", "OK");
        }

        else if (statu == "true")
        {

            await Shell.Current.GoToAsync($"//Home");

        }
        else if (statu == "false")
        {
            await Shell.Current.DisplayAlert("Error", "Email ou Mot de passe invalide", "OK");
        }
        else
        {
            await Shell.Current.DisplayAlert("Error", "Verifier bien !!!", "OK");
        }

    }
}
