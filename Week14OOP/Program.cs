Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();
string name = Console.ReadLine();


Dog myDog = new Dog(myDogName);
Dog neighboursdog = new Dog("Fido");


Console.WriteLine($"My dogs name is {myDog._name}");
Console.WriteLine($"My neighbours dogs name is {neighboursdog._name}");

myDog.Rename("Bad Boy");
while (myDog._lvlOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();


class Dog
{
    public string _name;//field
    public int _lvlOfHappiness = 0;
    //constructor

    public Dog(string name)//name-  lets user name the dog
    {
        _name = name;
        _lvlOfHappiness = 0;
    }
    public string name
    {
        get { return _name; }
        
    }
    public int lvlOfHappiness
    {
        get { return _lvlOfHappiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"My dogs new name is {_name}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-Woof");
        _lvlOfHappiness++;
    }
    public void WagTail()
    {
        Console.WriteLine("wiggle-wiggle");
    }




}