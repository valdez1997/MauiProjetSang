using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class StartPage : ContentPage
{
	public StartPage(StartViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}