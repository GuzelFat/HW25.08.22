
// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64,125

int[] GetSquares(int n){
        int[] arr = new int[n];
    for(int i=1;i<=n;i++){
        arr[i-1]=i*i*i;
    }
       return arr;       
}

int n=10;
int[] arr= GetSquares(n);
for(int i=0;i<n;i++)
{
    if( i<n-1)  {
    System.Console.Write(arr[i] + ", ");
    }
    else { 
        System.Console.Write(arr[i] + "."); 
    }
}
