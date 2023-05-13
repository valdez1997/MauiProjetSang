

using CommunityToolkit.Mvvm.ComponentModel;
using MauiProjetSang.Model;
using MauiProjetSang.Service;
using MauiProjetSang.View;
using System.Windows.Input;

namespace MauiProjetSang.ViewModel;

public partial class EditPassword1ViewModel:BaseViewModel
{
    ServiceCheckMail serviceCheckMail;
    [ObservableProperty]
    public string mail;
    public ICommand CheckCommand { get; private set; }

    public EditPassword1ViewModel(ServiceCheckMail serviceCheckMail)
    {
        this.serviceCheckMail = serviceCheckMail;
        CheckCommand=new Command(CheckMail);
    }
    public async void CheckMail()
    {
        var user = new UserSendEmail
        {
            email=Mail
        };
        var statu = (await serviceCheckMail.PostEmail(user)).status;
        if (statu == "true")
        {
            await Shell.Current.GoToAsync(nameof(EditPasswordPage));
        }
        else
        {
            await Shell.Current.DisplayAlert("Error", "Email non valide", "OK");
        }
    }
}
