public class StackOverflowPost
{
    private int vote { get; set; }

    private Dictionary<string, string> _dictionary;

    public StackOverflowPost()
    {
        this._dictionary = new Dictionary<string, string>();
        this._dictionary["voting"] = "0";
    }

    public string this[string key]
    {
        get
        {
            return _dictionary[key];
        }
        set
        {
            this._dictionary[key] = value;
        }
    }

    public void CreatePost()
    {
        this._dictionary["CreatedAt"] = DateTime.Now.ToString();
    }

    public void ViewPost()
    {
        foreach (KeyValuePair<string, string> kvp in this._dictionary)
        {
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
    }

    public void UpVotePost()
    {
        _dictionary["voting"] = string.IsNullOrEmpty(_dictionary["voting"]) ? "0" : (Convert.ToInt32(_dictionary["voting"])+1).ToString();
        Console.WriteLine("Successfully upvoted");
    }

    public void DownVotePost()
    {
        _dictionary["voting"] = string.IsNullOrEmpty(_dictionary["voting"]) ? "0" : (Convert.ToInt32(_dictionary["voting"]) - 1).ToString();
        Console.WriteLine("Successfully downvoted");
    }


}
