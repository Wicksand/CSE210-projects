using System.Numerics;

class Order
{
    private Customer customer_;
    private List<Product> products_;
    public Order(Customer customer, List<Product> products)
    {
        customer_ = customer;
        products_ = products;
    }

    public string PackingLabel()
    {
        string packing = "Packing List:\n";
        foreach (Product product in products_)
        {
            packing += $"- {product.GetName()} ID: {product.GetId()}\n";
        }
        return packing;
    }
    public string ShippingLabel()
    {
        return $"----------------------------------------\n{customer_.GetName()}\n{customer_.GetAddress()}\n----------------------------------------";
    }
    public float GetTotalCost()
    {
        float orderCost = 0;
        foreach (Product product in products_)
        {
            orderCost += product.GetCost();
        }
        if (customer_.IsInUSA())
        {
            orderCost += 5;
        }
        else
        {
            orderCost += 35;
        }
        return orderCost;
    }
}