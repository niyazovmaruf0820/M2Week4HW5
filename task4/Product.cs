namespace task4;

public class Product
{
    private string name;
    private double price;
    private int quantity;

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;   
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public void SetQuantity(int quantity)
    {
        this.quantity = quantity; 
    }
    public string GetName()
    {
        return name;
    }
    public double GetPrice()
    {
        return price;
    }
    public int GetQuantity()
    {
        return quantity;
    }
    public override string ToString()
    {
        return $"Name: {name}\nPrice: {price}\nQuantity: {quantity}";
    }
}
