//задача 34
int N = Convert.ToInt32(new Random().Next(1,10));
int[] array1 = new int[N];
int i = 0;
int count = 0;
while (i < array1.Length)
{
array1[i] = new Random().Next(100,999);
if ((array1[i] % 2) == 0) {count++;}
Console.Write(array1[i]+" ");
i++;
}
Console.WriteLine("Чётных чисел "+ count);
