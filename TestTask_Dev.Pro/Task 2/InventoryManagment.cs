namespace TestTask_Dev.Pro.Task_2;

public class InventoryManagment
{
    public List<Product> SortProducts(List<Product> products, string key, bool ascending)
    {
        var propertyInfo = typeof(Product).GetProperty(key);

        if (!ascending)
            return products.OrderByDescending(p => propertyInfo.GetValue(p)).ToList();
        return products.OrderBy(p => propertyInfo.GetValue(p)).ToList();
    }
}