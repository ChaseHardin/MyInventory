namespace MyInventory.Data.Infrastructure
{
    public class Application
    {
        public static MyInventoryEntity GetDatabaseInstance()
        {
            return new MyInventoryEntity();
        }
    }
}