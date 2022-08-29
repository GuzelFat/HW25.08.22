// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число, которое входит в рамки типа int");
int m = int.Parse(Console.ReadLine());
int n=m;
int i = 0;
while(n>0)
{
    n=n/10;
    i=i+1;
}

Console.WriteLine(i + " цифр в числе");
int[] arr = new int[i];

n=m;
for (int index=0; index<i; index++)
{
  arr[index]=n%10; 
  n=n/10;
}
    bool b=false;
for (int index=0; index<i/2; index++)
{
    if (arr[index]!=arr[i-1-index])
    {
        Console.WriteLine("No");
        b=true;
        break;
    }
}
if (b==false)
{
    Console.WriteLine("Yes");
}



