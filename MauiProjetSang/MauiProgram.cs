using MauiProjetSang.Service;
using MauiProjetSang.View;
using MauiProjetSang.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;


namespace MauiProjetSang;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//View

		builder.Services.AddTransient<MainPage>();
        builder.Services.AddSingleton<ApropoPage>();
        builder.Services.AddSingleton<ArticleDetailPage>();
        builder.Services.AddSingleton<ArticlesPage>();
        builder.Services.AddSingleton<CentreHospitalierPage>();
        builder.Services.AddSingleton<EditPassword1Page>();
        builder.Services.AddSingleton<EditPasswordPage>();
        builder.Services.AddSingleton<EditProfilPage>();
        builder.Services.AddSingleton<FaqPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<ParameterPage>();
        builder.Services.AddSingleton<ProfilPage>();
        builder.Services.AddSingleton<Rdv2Page>();
        builder.Services.AddSingleton<RdvPage>();
        builder.Services.AddSingleton<Register2Page>();
        builder.Services.AddSingleton<RegisterPage>();
        builder.Services.AddSingleton<StartPage>();
        builder.Services.AddSingleton<TestdePredonPage>();
        builder.Services.AddSingleton<WelcomePage>();

        //ViewModel
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddSingleton<ArticleDetailViewModel>();
        builder.Services.AddSingleton<ArticleViewModel>();
        builder.Services.AddSingleton<BaseViewModel>();
        builder.Services.AddSingleton<CenterHospitalierViewModel>();
        builder.Services.AddSingleton<EditPassword1ViewModel>();
        builder.Services.AddSingleton<EditPasswordViewModel>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<ParameterViewModel>();
        builder.Services.AddSingleton<ProfilViewModel>();
        builder.Services.AddSingleton<Register2ViewModel>();
        builder.Services.AddSingleton<RegisterViewModel>();
        builder.Services.AddSingleton<StartViewModel>();
        builder.Services.AddSingleton<WelcomeViewModel>();

        // Services

        builder.Services.AddTransient<LoginService>();
        builder.Services.AddSingleton<ArticleService>();
        builder.Services.AddSingleton<ServiceHospital>();
        builder.Services.AddSingleton<LogoutService>();
        builder.Services.AddSingleton<ResetPasswordService>();
        builder.Services.AddSingleton<ServiceCheckMail>();
        builder.Services.AddSingleton<ServiceDisplayProfil>();



#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
