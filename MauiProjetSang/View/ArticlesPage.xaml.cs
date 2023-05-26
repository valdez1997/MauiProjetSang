using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class ArticlesPage : ContentPage
{
	ArticleViewModel articleViewModel;
	public ArticlesPage(ArticleViewModel articleViewModel)
	{
		InitializeComponent();
		this.articleViewModel = articleViewModel;
		BindingContext=articleViewModel;
	}
    protected override void OnAppearing()
    {
		if(articleViewModel.First && articleViewModel.GetArticleCommand.CanExecute(null))
		{
			articleViewModel.GetArticleCommand.Execute(null);
			articleViewModel.First = false;
		}
        base.OnAppearing();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		if (string.IsNullOrWhiteSpace(e.NewTextValue))
		{
			ArticleName.ItemsSource = articleViewModel.Article;

        }
		else
		{
			ArticleName.ItemsSource = articleViewModel.Article.Where(Articles => Articles.title.ToLower().Contains(e.NewTextValue.ToLower()));
        }

    }
}