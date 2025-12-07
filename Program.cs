//ClassTask
// Task1
// int[] arr1 = new int[] { 1, 2, 3, 4, 2, 1, 3, 0 };
// int max = arr1[0];
// for (int i = 1; i < arr1.Length; i++)
// {
//     if (arr1[i] > max)
//     {
//         max = arr1[i];
//     }
// }
// Console.WriteLine(max);


//Task2


//Task3
// int[] arr2 = new int[] { 1, 2, 0, 3, 4, 0, 5, 0, 0 };
// int sum = 0;
// for(int i = 0; i < arr2.Length; i++)
// {
//     sum += arr2[i];
// }
// System.Console.WriteLine(sum);


//Task4

//Task5
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i < a; i++)
// {
//     int cnt = 0;
//     for(int j = 0; j < a; j++)
//     {
//         if(arr[i] == arr[j])
//         {
//             cnt++;
//         }
//     }
//     if(cnt > 1)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


//Task6
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr4 = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr4[i] = Convert.ToInt32(Console.ReadLine());
// }

// int min = arr4[0];
// for(int i = 1; i < arr4.Length; i++)
// {
//     if(arr4[i] < min)
//     {
//         min = arr4[i];
//     }
// }
// Console.WriteLine(min);


//Task7
// int sum = 0;
// int count = 0;
// for(;;)
// {
//     Console.Write("Give a number: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if(a == 0)
//     {
//         break;
//     }
//     else
//     {
//         sum += a;
//         count++;
//     }
// }
// Console.WriteLine($"Sum of numbers: {sum}");
// Console.WriteLine($"Count of numbers: {count}");


//Task8


//Task9
// string number = Console.ReadLine()!;
// for(int i = number.Length - 1; i >= 0; i--)
// {
//     Console.Write(number[i]);
// }


//Task10


//HomeTask
//Task1
// int num = Convert.ToInt32(Console.ReadLine());
// int sum;
// if (num < 100)
// {
//     sum = num + num * 5 / 100;
// }
// else if (num >= 100 && num <= 200)
// {
//     sum = num + num * 7 / 100;
// }
// else
// {
//     sum = num + num * 10 / 100;
// }
// Console.Write(sum);

//Task2
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int zarb = 1;
// for(int i = 0; i < a; i++)
// {
//     zarb *= arr[i];
// }
// Console.Write(zarb);


//Task3
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int max = arr[0];
// int index = 0;
// for(int i = 1; i < arr.Length; i++)
// {
//     if(arr[i] > max)
//     {
//         max = arr[i];
//         index = i;
//     }
// }
// Console.Write(index);


//Task4
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < a; i++)
// {
//     int cnt = 0;
//     for (int j = 0; j < a; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             cnt++;
//         }
//     }
//     if (cnt == 1)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

//Task5
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int min = arr[0];
// int index = 0;
// for(int i = 1; i < arr.Length; i++)
// {
//     if(arr[i] < min)
//     {
//         min = arr[i];
//         index = i;
//     }
// }
// Console.Write(index);


//Task6
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i = 0; i < a; i ++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int cnt = 0;
// for(int i = 1; i < a - 1; i++)
// {
//     if(arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
//     {
//         cnt++;
//     }
// }
// Console.Write(cnt);


//Task7
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int first = 0;
// int second = 0;
// for (int i = 0; i < a - 1; i++)
// {
//     if ((arr[i] > 0 && arr[i + 1] > 0) || (arr[i] < 0 && arr[i + 1] < 0))
//     {
//         first = arr[i];
//         second = arr[i + 1];
//     }
// }
// Console.Write($"{first} {second}");


//Task8
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < a; i++)
// {
//     if (arr[i] % 2 != 0)
//     {
//         Console.Write(i + " ");
//     }
// }


//Task9
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// for(int i = a; i <= b; i++)
// {
//     if(arr[i] % 2 != 0)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


//Task10
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for(int i = 0; i < n; i ++)
// {
//     if(arr[i] % 2 != 0)
//     {
//         Console.Write(arr[i] * arr[i] + " ");
//     }
// }
