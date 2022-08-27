public class User
{
    public string Name { get; set; }
    public Shows Shows { get; set; }
}
public class Shows
{
    public string Name { get; set; }
    public int Season { get; set; }
    public int Episode { get; set; }
}

