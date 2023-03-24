Console.Write("Напишите число: ");
int a = int.Parse(Console.ReadLine());
for (int i = 2; i < a + 1; i = i + 2) {
    Console.Write($"{i } ");
}