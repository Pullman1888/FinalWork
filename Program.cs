//FinalWork
string[] Arr;
Console.WriteLine("Введите массив");
string s = Console.ReadLine();
Arr = s.Split(' ');
var res = new string[Arr.Length];
var size = 0;
foreach(var v in Arr);
{
    if (v.Length <=3)
{
    res[size] = v
    size++;
}

}