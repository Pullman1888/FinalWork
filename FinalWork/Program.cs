//FinalWork Вывод элементов массива который <=3
string[] Arr;
Console.WriteLine("Введите массив");
string s = Console.ReadLine();
Arr = s.Split(' ');
var res = new string[Arr.Length];
var size = 0;
foreach(var Value in Arr)
    {
    if (Value.Length <=3)
{
    res[size] = Value;
    size++;
}
//Console.WriteLine(res);
}
    
Console.WriteLine(string.Join("\n", res, 0, size));


