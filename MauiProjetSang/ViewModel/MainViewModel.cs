

using CommunityToolkit.Mvvm.Input;
using MauiProjetSang.View;

namespace MauiProjetSang.ViewModel;

public partial class MainViewModel
{
    public MainViewModel()
    {

    }
    [RelayCommand]
    async Task Welcome1()
    {
        await Shell.Current.GoToAsync($"{nameof(WelcomePage)}");
    }
}
