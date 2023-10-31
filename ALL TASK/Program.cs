
#region 1.Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.

//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//int count = 0;
//for (int i = n; i <= m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

#endregion

#region 1.1 Verilmiş n və m (n<m) ədədləri arasındakı cüt ədədlərin cəmini tapın.

//int n=int.Parse(Console.ReadLine());
//int m=int.Parse(Console.ReadLine());
//int sum = 0;
//for(int i=n;i<=m;i++)
//{
//    if(i%2==0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

#endregion

#region 1.2 Verilmiş n və m (n<m) ədədləri arasındakı tək ədədlərin hasilini tapın.

//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//int multi = 1;
//if (n > m)
//{
//    Console.WriteLine("diger eded daxil edin");
//}
//else if (n < m)
//{
//    for (int i=n; i <= m; i++)
//    {
//        if (i%2==1)
//        {
//            multi *= i;
//        } 
//    }
//    Console.WriteLine(multi);
//}


#endregion

#region 1.3 Verilmiş n və m (n<m) ədədləri arasında neçə ədəd olduğunu tapın.

//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//int count = 0;
//for (int i = n; i <= m; i++)
//{
//    count++;
//}
//Console.WriteLine(count);

#endregion

#region 1.4 Verilmiş n və m (n<m) ədədləri arasında tək ədədlərin sayı ilə cüt ədədlərinin hasilini tapın.

//int n=int.Parse(Console.ReadLine());
//int m=int.Parse(Console.ReadLine());
//int count = 0;
//int multi = 1;
//if (n>m)
//{
//    Console.WriteLine("duzgun eded daxil edin");
//}
//if (n<m)
//{
//    for (int i = n; i <= m;i++)
//        if (i%2==1)
//        {
//            count++;
//        }
//    else if (i%2==0) 
//        {
//            multi *= i;
//        }
//    Console.WriteLine(count+multi);
//}

#endregion

#region 2. Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın. (2 code)

//int n = int.Parse(Console.ReadLine());
//int count = 0;

//if (n==0 || n==1)
//{
//    Console.WriteLine("diger eded daxil edin..");
//}
//else if (n > 1)
//{
//for (int i = 1; i <= n; i++)
//    {
//        if (n%i==0)
//        count++;
//    }
//if (count >2)
//{
//    Console.WriteLine("murekkeb");
//}
//else
//{
//    Console.WriteLine("sade");
//}
//}

//int n = int.Parse(Console.ReadLine());
//int count = 0;
//for(int i=1;i<=n;i++)
//{
//    if (n % i == 0)
//    {
//        count++;
//        if (count > 2)
//        {
//            break;
//        }
//    }     
//}
//if (count>2)
//{
//    Console.WriteLine("murekkeb...");
//}
//else
//{
//    Console.WriteLine("sade...");
//}

#endregion

#region 3.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın.

//int n=int.Parse(Console.ReadLine());
//while (n % 2 == 0)
//{
//    n /= 2;
//}
//if (n == 1)
//{
//    Console.WriteLine("2-nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("deyil..");
//}

#endregion

#region 4. Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5

//int n =int.Parse(Console.ReadLine());
//int count = 0;

//while (n !=0)
//{
//    n /= 10;
//    count++;
//}
//Console.WriteLine(count);

#endregion

#region C#
//switch
//int day = int.Parse(Console.ReadLine());
//switch (day)
//{
//	case 1:
//        Console.WriteLine("1-ci gun");
//        break;
//    case 2:
//        Console.WriteLine("2-ci gun");
//        break;
//    default:
//        Console.WriteLine("diger");
//		break;
//};


//switch expression
//int day =int.Parse(Console.ReadLine());
//string result = day switch
//{
//    1 => "1-ci gun",
//    2 => "2-ci gun",
//    _ => "diger",
//};
//Console.WriteLine(result);


#endregion

#region LabTasks
//Taks1 Massivide verilen ardicilligin yeri terseden yazin ekrana.
//int[] numbers = { 29, 2, 30, 123 };
//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}


//Task2 Verilen input ad massivindeki adlarin icinde  varsa ekrana tapildi yoxdusa tapilmadi yazilsin. (1defe???)
//Console.WriteLine("Adi daxil edin:");
//string findName = Console.ReadLine();
//Console.WriteLine("Netice:");
//string[] names = { "Nadir", "Shaiq", "Islam", "Teymur" };
//foreach (string name in names)
//{
//    if (findName==name)
//    { Console.WriteLine("tapildi"); }

//    else
//    { Console.WriteLine("tapilmadi"); }

//}


//Task3 Verilen inputun icerisinde a herfi nece dene i herfi nece dene var.
//string name = "lailahiillallah";
string[] name = { "Nasib", "Nadir" };
for (int i = 0; i <= name.Length - 1; i++)
{
    Console.WriteLine(name[i]);
}


#endregion


#region Massive - FOR/FOREACH -Practice 
//string[] cars = { "bmw", "mercedec", "hyundai", "volvo", "mazda", "hyundai" };
//Console.WriteLine(cars[0]);
//Console.WriteLine(cars[cars.Length-1]); 
//Console.WriteLine(cars);
//Console.WriteLine(cars.Length);


//Massive - FOR / FOREACH
//string[] cars = { "bmw", "mercedec", "hyundai", "volvo", "mazda", "hundai" };
//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}
//bool = true;
//foreach (string car in cars)
//{
//    if (car == "volvo")
//    {
//        Console.WriteLine("volvo");
//    }
//    else
//    {
//        Console.WriteLine("tapilmadi");
//    }
//}



//int[] numbers = { 29, 1, 5, 19, 123 };
//for (int i = 0; i < numbers.Length; i++)
//    {
//    Console.WriteLine(numbers[i]);
//    }

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[0]);
//}


//for (int i = 0; i < numbers.Length; i++)
//{
//    if (i == 19) ;
//    Console.WriteLine(numbers[i]);
//}


//foreach (int i in numbers)
//{
//    if (i == 29)
//    { Console.WriteLine(i); }
//}

#endregion

#region Methods

//int FamilyAges(int FatherAge, int MotherAge, int BrotherAge, int MyAge)
//{
//    return FatherAge + MotherAge + BrotherAge+ MyAge;
//}
//Console.WriteLine(FamilyAges(63,59,32,30));

//string FamilyNames (string FatherName,string MotherName,string BroName, string MyName)
//{
//    return FatherName+" "+MotherName+" "+BroName+" "+MyName;
//}
//Console.WriteLine(FamilyNames("Qabil","Gulnara", "Aqil", "Nasib"));

#endregion