namespace task3;

public class Dog
{
    private string name;
    private string breed;
    private int age;

    public Dog(string name, string breed, int age)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;   
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetBreed(string breed)
    {
        this.breed = breed;
    }
    public void SetAge(int age)
    {
        this.age = age; 
    }
    public string GetName()
    {
        return name;
    }
    public string GetBreed()
    {
        return breed;
    }
    public int GetAge()
    {
        return age;
    }
    public override string ToString()
    {
        return $"Name: {name}\nBreed: {breed}\nAge: {age}";
    }
}
