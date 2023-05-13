

using CommunityToolkit.Mvvm.Input;
using MauiProjetSang.View;

namespace MauiProjetSang.ViewModel;

public partial class WelcomeViewModel:BaseViewModel
{
    public WelcomeViewModel()
    {
    }
    [RelayCommand]
    async Task Login1()
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}
