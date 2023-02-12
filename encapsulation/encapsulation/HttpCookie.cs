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
