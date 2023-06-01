﻿

using CommunityToolkit.Mvvm.Input;
using MauiProjetSang.View;
using System.Windows.Input;

namespace MauiProjetSang.ViewModel;

public partial class StartViewModel
{
    public ICommand CardTapCommand { get; private set; }
    public ICommand CenterCommand { get; private set; }

    public StartViewModel()
    {


        CardTapCommand = new Command<string>(CardTapAsync);
        CenterCommand = new Command(CenterAsync);

    }

    private async void CardTapAsync(string index)
    {
        var route = "//Home";
        switch (index)
        {
            case "1":
                route = nameof(CentreHospitalierPage);
                break;
            case "2":
                route = nameof(ArticlesPage);
                break;
            case "3":
                route = nameof(RdvPage);
                break;
            case "4":
                route = nameof(FaqPage);
                break;
            case "5":
                route = nameof(Rdv2Page);
                break;
            case "6":
                route = nameof(EditProfilPage);
                break;
            default:
                break;
        }

        await Shell.Current.GoToAsync(route);

    }
    [RelayCommand]
    async void CenterAsync()
    {
        await Shell.Current.GoToAsync(nameof(CentreHospitalierPage));
    }

    //deconnect
}
