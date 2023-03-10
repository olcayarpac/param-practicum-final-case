namespace ShopListAPI.Models;

public class DatabaseSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string ListsCollectionName { get; set; } = null!;
    public string UsersCollectionName { get; set; } = null!;
    public string APILogsCollectionName { get; set; } = null!;

}