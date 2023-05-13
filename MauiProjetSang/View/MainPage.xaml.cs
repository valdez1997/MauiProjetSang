using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}

	
}

