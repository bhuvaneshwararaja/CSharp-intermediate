
public class HttpCookie
{
    private Dictionary<string, string> _dictionary;
    public DateTime ExpiryTime { get; set; }
    public HttpCookie()
    {
        _dictionary = new Dictionary<string, string>();
    }

    public string this[string key] { get { return _dictionary[key]; } set { _dictionary[key] = value; } }
}

internal class Program
{
    private static void Main(string[] args)
    {

        var person = new Person();
        person.setter("bhuvanesh");
        Console.WriteLine(person.getter());

        var person1 = new Person1(new DateTime(2001, 11, 03));
        Console.WriteLine(person1.Age);

        var cookie = new HttpCookie();

        cookie.ExpiryTime = DateTime.Today;
        cookie["name"] = "bhuvanesh";
        cookie["age"] = person1.Age.ToString();

        Console.WriteLine(cookie["name"]);
        Console.WriteLine(cookie["age"]);

    }
}