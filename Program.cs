//1. Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm misal:input 6, output quvveti deyil.  input 8 output quvvetidir


Console.Write("Ededi daxil edin :");
int num = int.Parse(Console.ReadLine());
while (num < 1)
{
    Console.Write("Yeniden daxil edin :");
    num = int.Parse(Console.ReadLine());
}

while (number % 2 == 0)
{
    number /= 2;
    number %= 2;
    if (number == 0)
    {
        Console.WriteLine("Quvvetidir");
        return;
    }
}
Console.WriteLine("Quvveti deyil");

//2. Ədədlərdən ibarət arrayın ən kiçik elementini tapın

int[] numbers = { 7, 2, 5, 15, 10, 1 };
int smallest = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (smallest > numbers[i])
    {
        smallest = numbers[i];
    }
}
Console.WriteLine(smallest);

//2ci usul
for (int i = 0; i < numbers.Length; i++)
{
    Array.Sort(numbers);

}
Console.WriteLine(numbers[0]);

//3. Sozlerden ibaret arrayde uzunlugu 4-den boyuk olan sozleri ekrana çap edin

string[] words = { "salam", "alma", "necesen", "adam" };
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length > 4)
    {
        Console.WriteLine(words[i]);
    }
}

//4.(optional) 1-den 10 qeder olan arrayda bir reqem eskikdir.
//Eskik olan reqemi tapan algorithm yazin ve nezere alin ki verilen arrayda reqemler siralanmadan duzulub misal: input {4, 1, 9, 6, 10, 2, 5, 8, 3} output 7

int[] numbers = { 4, 1, 9, 7, 10, 2, 5, 8, 3 };
int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numbers.Length; i++)
{
    Array.Sort(numbers);



    if (numbers[i] != numbers2[i])
    {
        Console.WriteLine(numbers2[i]);
        return;
    }

}
