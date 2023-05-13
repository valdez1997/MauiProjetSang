

namespace MauiProjetSang.Constantes;

public class Constants
{
    public const string AUTH_TOKEN_KEY = "Auth_Token";
    public const string AUTH_NAME_KEY = "Auth_name";
    public static int Authid = 10;
    public static string AuthToken
    {

        get => Preferences.Get(Constantes.Constants.AUTH_TOKEN_KEY, string.Empty);
        set => Preferences.Set(Constantes.Constants.AUTH_TOKEN_KEY, value);
    }
    public static string AuthName
    {

        get => Preferences.Get(Constantes.Constants.AUTH_NAME_KEY, string.Empty);
        set => Preferences.Set(Constantes.Constants.AUTH_NAME_KEY, value);
    }
}
