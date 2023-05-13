using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class EditPassword1Page : ContentPage
{
	public EditPassword1Page(EditPassword1ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}