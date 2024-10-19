
// task-1

double pi = Math.PI;
Console.Write("Radiusni kiriting: ");
double radius = Convert.ToDouble(Console.ReadLine());
double S = pi * Math.Pow(radius, 2); 
double L = 2 * pi * radius; 
Console.WriteLine($"S={S}, L={L}");


// task-2

Console.Write("Qiymatni kiriting: ");
double qiymat = Convert.ToDouble(Console.ReadLine());
Console.Write("Valyuta kursini kiriting: ");
double kurs = Convert.ToDouble(Console.ReadLine());
double natija = qiymat * kurs;
Console.WriteLine($"{natija} so'm.");
  

// task-3

Console.Write("Tug'ilgan yilingizni kiriting: ");
int birthYear = Convert.ToInt32(Console.ReadLine());
int currentYear = DateTime.Now.Year;
int ageInDays = (currentYear - birthYear) * 365;
Console.WriteLine($"{ageInDays}");














