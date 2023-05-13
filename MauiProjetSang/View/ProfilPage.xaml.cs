using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class ProfilPage : ContentPage
{
	public ProfilPage(ProfilViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}