using MauiProjetSang.ViewModel;

namespace MauiProjetSang.View;

public partial class CentreHospitalierPage : ContentPage
{
	CenterHospitalierViewModel centerHospitalierViewModel;
	public CentreHospitalierPage(CenterHospitalierViewModel centerHospitalierViewModel)
	{
		InitializeComponent();
		this.centerHospitalierViewModel = centerHospitalierViewModel;
		BindingContext = centerHospitalierViewModel;
	}

    protected override void OnAppearing()
    {
		if(centerHospitalierViewModel.First && centerHospitalierViewModel.GetHospitalCommand.CanExecute(null))
		{
			centerHospitalierViewModel.GetHospitalCommand.Execute(null);
			centerHospitalierViewModel.First= false;
		}
        base.OnAppearing();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Shell.Current.GoToAsync(nameof(Rdv2Page));
    }
}