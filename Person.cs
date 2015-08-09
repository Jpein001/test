// Define a class called Person here.

public class Person
{
    public string name;

    public Person(string name)
    {
        this.name = name;
    }

    public string getName
    {
        get { return name; }
    }

    public string greet(string message)
    {
        switch (message)
        {
            case "Hello":
                {
                    return "Hi, I'm " + getName;

                }
            case "Goodbye":
                {
                    return "Bye";

                }
            default:
                {
                    return message;

                }

        }
    }

}
