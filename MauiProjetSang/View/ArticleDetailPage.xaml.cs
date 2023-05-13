using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class ArticleDetailPage : ContentPage
{
	public ArticleDetailPage(ArticleDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}