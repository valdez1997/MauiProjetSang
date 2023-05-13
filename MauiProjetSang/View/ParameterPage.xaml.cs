using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class ParameterPage : ContentPage
{
	public ParameterPage(ParameterViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}
}