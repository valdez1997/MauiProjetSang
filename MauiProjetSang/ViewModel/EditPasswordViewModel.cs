﻿

using CommunityToolkit.Mvvm.ComponentModel;
using MauiProjetSang.Model;
using MauiProjetSang.Service;
using MauiProjetSang.View;
using System.Windows.Input;

namespace MauiProjetSang.ViewModel;

public partial class EditPasswordViewModel:BaseViewModel
{
    ResetPasswordService resetPasswordService;
    public ICommand ResetPasswordCommand { get; private set; }
    [ObservableProperty]
    public string token;
    [ObservableProperty]
    public string password;

    public EditPasswordViewModel(ResetPasswordService resetPasswordService)
    {
        this.resetPasswordService=resetPasswordService;
        ResetPasswordCommand = new Command(ResetPasswordAsync);
    }

    public async void ResetPasswordAsync()
    {
        var user = new ResetSenInfo
        {
            token = Token,
            password = Password
        };
        var statu = (await resetPasswordService.ChangePassword(user)).status;
        if((Token==null)&&(Password==null))
        {
            await Shell.Current.DisplayAlert("Error", "Veuillez remplir les champs mail et password", "OK");

        }
        if (Password.Length < 7)
        {
            await Shell.Current.DisplayAlert("Error", "Mot de passe tres peu sécurisé", "OK");
        }
        else if (statu == "true")
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
    }
}
