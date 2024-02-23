// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) 
//         break;
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") 
//         name = "Sammy";
// }



// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") 
//         names[i] = "Sammy";

// foreach (var name in names) 
//     Console.WriteLine(name); 


// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

string[] sReturn = new string[100];

for (int i = 1; i <= 100; i++)
{
    bool bFlag = false;
    if (i % 3 == 0)
    {
        sReturn[i] = i.ToString() + " Fizz";
        bFlag = true;
    }
    if (i % 5 == 0)
    {
        sReturn[i] = i.ToString() + " Fizz";
        bFlag = true;
    }
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        sReturn[i] = i.ToString() + " FizzBuzz";
        bFlag = true;
    }

    if (!(i % 3 == 0) && (!bFlag))
    {
        sReturn[i] = i.ToString();
    }
    if (!(i % 5 == 0) && (!bFlag))
    {
        sReturn[i] = i.ToString();
    }
    if (!(((i % 3 == 0) && (!bFlag)) && ((i % 5 == 0) && (!bFlag))))
    {
        sReturn[i] = i.ToString();
    }    

    Console.WriteLine(sReturn.Distinct());

    



}