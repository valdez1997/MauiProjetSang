using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class EditPasswordPage : ContentPage
{
	public EditPasswordPage(EditPasswordViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}