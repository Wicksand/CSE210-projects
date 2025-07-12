using System.Data;

class Product
{
    private string name_;
    private string id_;
    private float costPer_;
    private int quantity_;
    public Product() {}
    public Product(string name, string id, float costPer, int quantity)
    {
        name_ = name;
        id_ = id;
        costPer_ = costPer;
        quantity_ = quantity;
    }

    public float GetCost()
    {
        return costPer_ * quantity_;
    }

    public string GetName()
    {
        return name_;
    }
    public string GetId()
    {
        return id_;
    }
    public int GetQuantity()
    {
        return quantity_;
    }

}