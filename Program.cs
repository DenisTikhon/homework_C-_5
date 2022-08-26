int task;
Console.WriteLine("Выберите задачу от 1 до 5");
task = Convert.ToInt32(Console.ReadLine());
if (task == 1 ){
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
}
if (task == 2 ){
//задача 36
int N = Convert.ToInt32(new Random().Next(1,10));
int[] array1 = new int[N];
int i = 0;
int sum = 0;
while (i < array1.Length)
{
array1[i] = new Random().Next(1,100);
if ((i % 2) != 0) {sum += array1[i];}
Console.Write(array1[i]+" ");
i++;
}
Console.WriteLine("Сумма чисел "+ sum);    
}
if (task == 3 ){
//задача 38
int N = Convert.ToInt32(new Random().Next(1,10));
int[] array1 = new int[N];
int i = 0;
int max = 0;
while (i < array1.Length)
{
array1[i] = new Random().Next(1,100);
Console.Write(array1[i]+" ");
i++;
}
int min = array1[0];
int i1 = 0;
while (i1 < array1.Length){
if (max < array1[i1]) {max = array1[i1];} 
if (min > array1[i1]) {min = array1[i1];}
i1++;
}
int sum = max - min;
Console.WriteLine("Разница чисел "+ sum);
}
if (task == 4 ){
//задача 35
int[] array1 = new int[123];
int i = 0;
int count = 0;
while (i < array1.Length)
{
array1[i] = new Random().Next(1,999);
if (array1[i] > 10 & array1[i] < 99 ) {count++;}
Console.Write(array1[i]+" ");
i++;
}
Console.WriteLine("Количество элементов "+ count);   
}
if (task == 5 ){
//задача 37
int Num = Convert.ToInt32(new Random().Next(1,10));
int[] array1 = new int[Num];
int i = 0;
while (i < array1.Length)
{
array1[i] = new Random().Next(1,999);
Console.Write(array1[i]+" ");
i++;
}
int ind = 0;
int sum = 0;
int N = array1.Length/2;
int Z = array1.Length - 1;
int[] array2 = new int[N];
Console.Write("сумма пар ");
while (ind < N) 
{
sum = array1[ind] + array1[Z];
array2[ind] = sum;
Console.Write(array2[ind]+" ");
Z--;
ind++;
}

}