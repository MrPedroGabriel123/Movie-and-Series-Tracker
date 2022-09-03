namespace SeriesTracker;

public class User
{
    public string Name { get; set; }
    public List<Shows> Shows { get; set; }
}
public abstract class Shows
{ 
    public string Name { get; set; }
    
}
