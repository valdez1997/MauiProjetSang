

using CommunityToolkit.Mvvm.ComponentModel;
using MauiProjetSang.Model;

namespace MauiProjetSang.ViewModel;
[QueryProperty("Article","Article")]
public partial class ArticleDetailViewModel:BaseViewModel
{
    public ArticleDetailViewModel()
    {

    }
    [ObservableProperty]
    Articles article;
}
