string stroka = "Hello";
char[] chararray = stroka.ToCharArray();
for (int i = 0; i < chararray.Length; i++)
{
    if (char.IsUpper(chararray[i]))
        {  
            chararray[i] = (char)(chararray[i] + ('a' - 'A'));
        }
    }
    string result = new string(chararray);

    Console.WriteLine(result);



