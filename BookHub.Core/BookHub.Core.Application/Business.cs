namespace BookHub.Core.Application;

public class Business
{ 
    public string Id { get; }

    public string Name { get; }
    
    public Business(string id, string name)
    {
        Id = id;
        Name = name;
    }
}