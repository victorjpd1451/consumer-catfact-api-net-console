
using static System.Console;
using ConsumerFactCat.Models;

var enderecoUrl = $"https://catfact.ninja/fact";

WriteLine($"Consumindo api dos gatos");

var client = new HttpClient();

try
{
    HttpResponseMessage response = await client.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();

    string respostaApi = await response.Content.ReadAsStringAsync();
    CatFact? catFact = System.Text.Json.JsonSerializer.Deserialize<CatFact>(respostaApi);

    WriteLine($"\nFato: {catFact?.fact}");
    WriteLine($"Comprimento:  {catFact?.length}");


}

catch (Exception ex)
{

    WriteLine($"Ocorreu um erro ao consultar o endereço: {ex.Message}");
}