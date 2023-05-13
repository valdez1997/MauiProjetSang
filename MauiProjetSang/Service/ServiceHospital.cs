

using MauiProjetSang.Model;
using System.Net.Http.Json;

namespace MauiProjetSang.Service;

public class ServiceHospital
{
    HttpClient client;
    List<Hospital> hospitallist = new();
    public ServiceHospital()
    {
        client = new HttpClient();
    }

    public async Task<List<Hospital>> GetHospital()
    {
        var response = await client.GetAsync("https://blooddonation.myhosting.pw/Blood-Donation/public/api/hospitals");
        if (response.IsSuccessStatusCode)
        {
            hospitallist = (await response.Content.ReadFromJsonAsync<StatusHospital>()).hospitals;
        }
        else
        {
            return null;
        }
        return hospitallist;
    }
}
