

using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiProjetSang.ViewModel;

public partial class BaseViewModel:ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;
    [ObservableProperty]
    string title;
    [ObservableProperty]
    string authName;

   public bool IsNotBusy => !IsBusy;

    
}
