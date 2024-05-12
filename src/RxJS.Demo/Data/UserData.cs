namespace RxJS.Demo.Data;

public static class UserData
{
    public static readonly IEnumerable<User> Users = new List<User>
    {
        new("john.doe", "John", "Doe", 26, EyeColor.Brown),
        new("emma.jones", "Emma", "Jones", 30, EyeColor.Blue),
        new("mike.smith", "Michael", "Smith", 35, EyeColor.Green),
        new("sophia.wilson", "Sophia", "Wilson", 28, EyeColor.Hazel),
        new("william.brown", "William", "Brown", 40, EyeColor.Gray),
        new("olivia.miller", "Olivia", "Miller", 22, EyeColor.Blue),
        new("james.garcia", "James", "Garcia", 45, EyeColor.Brown),
        new("ava.rodriguez", "Ava", "Rodriguez", 32, EyeColor.Green),
        new("alexander.davis", "Alexander", "Davis", 27, EyeColor.Brown),
        new("isabella.martinez", "Isabella", "Martinez", 29, EyeColor.Brown),
        new("david.wilson", "David", "Wilson", 33, EyeColor.Blue),
        new("samantha.anderson", "Samantha", "Anderson", 38, EyeColor.Green),
        new("ryan.thomas", "Ryan", "Thomas", 31, EyeColor.Brown),
        new("emily.hernandez", "Emily", "Hernandez", 24, EyeColor.Brown),
        new("jacob.martin", "Jacob", "Martin", 36, EyeColor.Hazel),
        new("ava.lopez", "Ava", "Lopez", 42, EyeColor.Brown),
        new("oliver.gonzalez", "Oliver", "Gonzalez", 25, EyeColor.Blue),
        new("mia.perez", "Mia", "Perez", 34, EyeColor.Green),
        new("ethan.wright", "Ethan", "Wright", 39, EyeColor.Gray),
        new("emma.king", "Emma", "King", 23, EyeColor.Brown),
        new("noah.scott", "Noah", "Scott", 37, EyeColor.Green),
        new("ava.hall", "Ava", "Hall", 44, EyeColor.Brown),
        new("liam.hill", "Liam", "Hill", 21, EyeColor.Blue),
        new("ava.young", "Ava", "Young", 41, EyeColor.Brown),
        new("sophia.lee", "Sophia", "Lee", 26, EyeColor.Green),
        new("mason.allen", "Mason", "Allen", 28, EyeColor.Brown),
        new("harper.lewis", "Harper", "Lewis", 33, EyeColor.Brown),
        new("amelia.clark", "Amelia", "Clark", 30, EyeColor.Blue),
        new("samuel.harris", "Samuel", "Harris", 27, EyeColor.Brown)
    };
}

public record User(
    string Username,
    string FirstName,
    string LastName,
    int Age,
    EyeColor EyeColor
);

public enum EyeColor
{
    Brown,
    Hazel,
    Green,
    Blue,
    Gray
}