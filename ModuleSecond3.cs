/*

// Task-1

Console.Write("Enter num: ");
int num=Convert.ToInt32(Console.ReadLine());
int count=0;

for (int i=1; i<=num; i++)
{
    if (num%i==0)
    {
        count++;
    }
    else
    {
        count+=0;
    }
}
if (count==2)
{
    Console.Write("Tub");
}
else
{
    Console.Write("Tub emas");
}


// Task-2


Console.Write("Enter num: ");
int num=int.Parse(Console.ReadLine());
List<int> numbers=new List<int>();

for (int i=2; i<num; i++)
{
    if (num%i==0)
    {
        numbers.Add(i);
    }
}

Console.WriteLine($"Bo'luvchilari: {string.Join(", ", numbers)}");


// Task-3. Darajani hisoblash

Console.Write("Sonni kiriting: ");
string a=Console.ReadLine();
double num=Convert.ToDouble(a);
Console.Write("Darajani kiriting: ");
string b=Console.ReadLine();
double daraja=Convert.ToDouble(b);
double result=Math.Pow(num, daraja);
Console.WriteLine($"Result: {result}");



// Task-4

Console.Write("List elementlari sonini kiriting: ");
int listLength=int.Parse(Console.ReadLine());
List<int> numbers=new List<int>();

for (int i=1; i<=listLength; i++)
{
    Console.Write($"Listning {i}-elementini kiriting: ");
    int num=int.Parse(Console.ReadLine());

    numbers.Add(num);
}

int sum=numbers.Sum();
Console.WriteLine($"List elementlari yig'indisi: {sum}");


// Task-5


Console.Write("Enter number: ");
int num=int.Parse(Console.ReadLine());

int originalNum=num;
int sum=0;

while (num>0)
{
    int lenz=num%10;
    sum +=lenz*lenz*lenz;
    num/=10;
}

if (originalNum==sum)
{
    Console.WriteLine("The number is ArmStrong");
}
else
{
    Console.WriteLine("The number is not ArmStrong");
}

// Task-6

Console.Write("Enter num: ");
int num=int.Parse(Console.ReadLine());
int count=0;
for (int i=1; i<num/2; i++)
{
    if (num%i==0)
    {
        count++;
    }
}

Console.WriteLine($"Sifatli bo'luvchilar soni: {count}");

*/









