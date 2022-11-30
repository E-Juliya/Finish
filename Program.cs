string[] Array = new string[8] {"abc", "13579", "bye", "second", "May", "day", "first", "123"};
string[] ArrayEnd = new string[8];
void ResArrayEnd(string[] Array, string[] ArrayEnd)
{
    int s = 0;
    for (int i = 0; i < Array.Length; i++)
    {
    if(Array[i].Length <= 3)
        {
        ArrayEnd[s] = Array[i];
        s++;
        }
    }
}
void PrintArray(string[] ArrayEnd)
{Console.Write($"[ ");
    for (int i = 0; i < ArrayEnd.Length; i++)
    { 
        if (ArrayEnd[i] == null) 
        {break;} 
        else { if (ArrayEnd[i+1] == null)
            {Console.Write($"{ArrayEnd[i]} ");}
            else {Console.Write($"{ArrayEnd[i]}, ");}
            }
}   
Console.Write($"]");
}
 ResArrayEnd(Array, ArrayEnd);
 PrintArray(ArrayEnd);
