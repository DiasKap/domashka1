Console.Write("Напишите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Напишите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Напишите число c: ");
int c = int.Parse(Console.ReadLine());
if (a>b) {
    if (a>c) {
        Console.Write("Число a больше всех");
    }
    else {
        Console.Write("Число c больше всех");
    }
}
else {
    if (b > c) {
    Console.Write("Число b больше всех");
}
else {
    Console.Write("Число c больше всех");
}
}