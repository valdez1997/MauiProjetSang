

using MauiProjetSang.Constantes;
using MauiProjetSang.Model;
using Microsoft.VisualBasic;
using System.Net.Http.Json;
using System.Reflection.Metadata;

namespace MauiProjetSang.Service;

public  class ServiceDisplayProfil
{
    HttpClient client;

    public ServiceDisplayProfil()
    {
        client = new HttpClient();
    }

    public async Task<UserProfilEnd> GetProfil()
    {
        var user = new UserProfilEnd();
        var response = await client.GetAsync("https://blooddonation.myhosting.pw/Blood-Donation/public/api/user/" + Constantes.Constants.Authid);
        if (response.IsSuccessStatusCode)
        {
            user = await response.Content.ReadFromJsonAsync<UserProfilEnd>();

        }
        return user;

    }
}
