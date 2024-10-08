
//задание 1
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите число: ");
//         int chiclo=int.Parse(Console.ReadLine());
//         if(chiclo<1|| chiclo>100)
//         {
//             Console.WriteLine("Ошибка");
//         }
//         else
//         {

//             if(chiclo%3==0 && chiclo%5==0)
//             {
//                 Console.WriteLine("Fizz Buzz");
//             }
//             else if(chiclo%5==0)
//             {
//                 Console.WriteLine("Buzz");
//             }
//             else if(chiclo%3==0)
//             {
//                 Console.WriteLine("Fizz");
//             }
//             else 
//             {
//                 Console.WriteLine(chiclo);
//             }
//         }
//     }

// }


// задание 2

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Значение: ");
//         double znachenie=double.Parse(Console.ReadLine());
//         Console.WriteLine("Процент: ");
//         double procent=double.Parse(Console.ReadLine());
//         double res= (znachenie/100)*procent;
//         Console.WriteLine(res);
//     }
// }     
            
            
//задание 3

// class Program
// {
//     static void Main()
//     {         
//         Console.WriteLine("Значение: ");
//         string znachenie=Console.ReadLine();  
//         Console.WriteLine("Значение: ");
//         string znachenie1=Console.ReadLine();  
//         Console.WriteLine("Значение: ");
//         string znachenie2=Console.ReadLine();  
//         Console.WriteLine("Значение: ");
//         string znachenie3=Console.ReadLine();  
//         string res=znachenie+znachenie1+znachenie2+znachenie3;
//         Console.WriteLine(res);
//     }
// }    




// задание 4
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("число: ");
//         string number = Console.ReadLine();
//         if (number.Length != 6)
//         {
//             Console.WriteLine("Ошибка");
          
//         }
//         Console.WriteLine("номера: ");
//         string[] positions = Console.ReadLine().Split(' ');
//         if (positions.Length != 2 || 
//             int.Parse(positions[0]) < 1 || 
//             int.Parse(positions[0]) > 6 || 
//             int.Parse(positions[1]) < 1 || 
//             int.Parse(positions[1]) > 6)
//         {
//             Console.WriteLine("Ошибка");
//             return;
//         }
//         int pos1 = int.Parse(positions[0]) - 1; 
//         int pos2 = int.Parse(positions[1]) - 1;
//         char[] a = number.ToCharArray();
//         char temp = a[pos1];
//         a[pos1] = a[pos2];
//         a[pos2] = temp;
//         string result = new string(a);
//         Console.WriteLine(result);
//     }
// }



//задание 5
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("дата: ");
//         string data = Console.ReadLine();
//         if (DateTime.TryParse(data, out DateTime date))
//         {
//             string sezon;
//             if (date.Month == 12 || date.Month == 1 || date.Month == 2)
//             {
//                 sezon = "зима";
//             }
//             else if (date.Month >= 3 && date.Month <= 5)
//             {
//                 sezon = "весна";
//             }
//             else if (date.Month >= 6 && date.Month <= 8)
//             {
//                 sezon = "лето";
//             }
//             else
//             {
//                 sezon = "осень";
//             }
//             string dayWeek = date.DayOfWeek.ToString();
//             Console.WriteLine(sezon + " " + dayWeek);
//         }
//     }
// }



//задание 6
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите число (1-Цельсия; 2-Фарингейта): ");
//         int chiclo=int.Parse(Console.ReadLine());
//         if(chiclo==1)
//         {
//             double res;
//             Console.WriteLine("Цельсия: ");
//             double celsia=double.Parse(Console.ReadLine());
//             res=(celsia*9/5)+32;
//             Console.WriteLine("В Фарингейтах: "+ res);
//         }
//         else if(chiclo==2)
//         {
//             double res2;
//             Console.WriteLine("Фарингейты: ");
//             double faringeit=double.Parse(Console.ReadLine());
//             res2=(faringeit-32)*5/9;
//             Console.WriteLine("В Цельсиях: "+ res2);
//         }
//     }
// }


//задание 7
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("два числа:");
//         int a = int.Parse(Console.ReadLine());
//         int b = int.Parse(Console.ReadLine());
//         if (a > b)
//         {
//             int temp = a;
//             a = b;
//             b = temp;
//         }
//         Console.WriteLine("Четные числа в  от " + a + " до " + b);
//         for (int i = a; i <= b; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }