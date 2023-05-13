using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class WelcomePage : ContentPage
{
	public WelcomePage(WelcomeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}