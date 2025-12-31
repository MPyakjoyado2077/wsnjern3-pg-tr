

public class Dog
{private string _name;
private string _breed;
private int _age;
public Dog (string name, string breed, int age)
    {
        _name = name;
        _breed = breed;
        _age = age;
    }
    public void GetName(string name)
    {
        System.Console.WriteLine(name);
    }
    public void GetBreed(string breed)
    {
        System.Console.WriteLine(breed);
    }
    public void GetAge (int age)
    {
        System.Console.WriteLine(age);
    }


}
