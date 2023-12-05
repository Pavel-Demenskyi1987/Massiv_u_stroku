
string stroka = "Hello";
bool Palindrom = IsPalindrome(stroka);



bool IsPalindrome(string str)
{
    for (int i = 0; i < str.Length/2; i++)
    {
        if(str[i] != str[str.Length -1 - i])
        {
            return false;
        }
    }
    return true;
}

if(Palindrom) 
{
    System.Console.WriteLine($" Строка {stroka} является палиндромом ");
}
else
{
    System.Console.WriteLine($" Строка {stroka} не является палиндромом ");
}



