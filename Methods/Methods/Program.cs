//int number = 10;

//if(number % 2 == 0) 
//    Console.WriteLine("Cut ededdir");
//else
//    Console.WriteLine("tek ededdir");

//int month = int.Parse(Console.ReadLine());
//string result = string.Empty;
//switch (month)
//{
//    case 1:
//        result = "Yanvar";
//        break;
//    case 2:
//        result = "Fevral";
//        break;
//    case 3:
//        result = "Mart";
//        break;
//    case 4:
//        result = "Aprel";
//        break;
//    default:
//        result = "Diger ay...";
//        break;
//}

//string result = month switch
//{
//    1 => "Yanvar",
//    2 => "Fevral",
//    3 => "Mart",
//    4 => "Aprel",
//    _ => "Diger ay..."
//};

//Console.WriteLine(result);

//while (number <= 9)
//{
//    Console.WriteLine(number);
//    number++;
//}


//while (true)
//{
//    Console.WriteLine("Bir eded daxil edin:");
//    int result = int.Parse(Console.ReadLine());

//    if(result % 2 == 0)
//    {
//        Console.WriteLine("Cut ededdir");
//        break;
//    }

//    Console.WriteLine("Tek ededdir");
//}

//int number = 10;
//do
//{
//    Console.WriteLine(number);
//    number++;
//} while (number < 10);

//for(int i = 0; i < 10; i++)
//{
//    if (i % 2 == 0)
//        continue;

//    Console.WriteLine(i);
//}
//int[] numbers = new int[4];
//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 4;
//numbers[3] = 8;
//Console.WriteLine(numbers[0]);
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//dynamic a = 5;
//a = "";
//a = true;
//a = 'a';
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//string[] names = new string[5];
//names[0] = "Omer";
//names[1] = "Elton";
//names[2] = "Nermin";
//names[3] = "Abdulkerim";
//names[4] = "Senan";

//string[] names = { "Omer", "Elton", "Nermin", "Abdulkerim", null };
//foreach (string name in names)
//{
//    if (name == null)
//        name = "Senan";
//}

//for (int i = 0; i < names.Length; i++)
//{
//    //if (names[i] is null)
//    //    names[i] = "Senan";

//    //names[i] = names[i] ?? "Senan";

//    names[i] ??= "Senan";

//    Console.WriteLine(names[i]);
//}

//int sum(int number1, int number2 = 5) //parameters, optional
//{
//    int result = number1 + number2;
//    return result;
//}

//int sum(int number1, int number2)
//    => number1 + number2;

//int a = 3;
//Console.WriteLine(sum(a)); //arguments

//int sum(int number1 = 2, params int[] numbers)
//{
//    int result = 0;
//    foreach (var number in numbers)
//    {
//        result += number;
//    }
//    return result;
//}

//int[] numbers = { 1, 2, 3, 4, 5 };

//Console.WriteLine(sum(2, 1, 2, 3, 4, 5));

class Program
{
    public static void Main()
    {
        Console.WriteLine(Print("Rehim", "Rehimov", 18));
        //Test(2, 3, 4);
    }

    //static void Test(int a)
    //{
    //    Console.WriteLine("one parameter method");
    //}

    //static void Test(int a, int b = 5)
    //{
    //    Console.WriteLine("optional parameter method");
    //}

    //static void Test(int a, params int[] number)
    //{
    //    Console.WriteLine("params method");
    //}

    //Method signature - Method name, parameters count, parameters type
    static string Print(string name)
    {
        return name;
    }

    static string Print(string name, string surname)
    {
        //return name + " " + surname;
        return $"{Print(name)} {surname}";
    }

    static string Print(string name, string surname, int age)
    {
        return $"{Print(name, surname)} {age}";
    }
}