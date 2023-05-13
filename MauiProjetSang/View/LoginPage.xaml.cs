using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}