private static readonly HttpClient client = new HttpClient();

//POST

var values = new Dictionary<string, string>
{
{ "thing1", "hello" },
{ "thing2", "world" }
};

var content = new FormUrlEncodedContent(values);

var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

var responseString = await response.Content.ReadAsStringAsync();

//GET

var responseString = await client.GetStringAsync("http://www.example.com/recepticle.aspx");