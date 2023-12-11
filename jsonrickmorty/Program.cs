using System.Net.Http.Headers;
{
    await ProcessRepositoriesAsync(new HttpClient());
}


using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
await ProcessRepositoriesAsync(client);

static async Task ProcessRepositoriesAsync(HttpClient client)
{
    var json = await client.GetStringAsync("https://rickandmortyapi.com/api/character");
    
    var separado = json.Split("id");
    var nombre = "Rick Sanchez";
    var numep = 0;
    
    
    foreach (var lista in separado)
    {
        if (lista.Contains(nombre))
        {
            Console.WriteLine(lista + "\n");
            
                foreach (var ep in lista.Split("/episode/"))
                {
                    numep = + 1;
                }
            
            Console.WriteLine("EPISODIOS -->");
            Console.WriteLine(numep);
        }
    }
    
}