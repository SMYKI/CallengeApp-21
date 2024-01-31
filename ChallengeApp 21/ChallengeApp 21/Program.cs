var number = 4555;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

var counter0 = 0;
var counter1 = 0;
var counter2 = 0;
var counter3 = 0;
var counter4 = 0;   
var counter5 = 0;
var counter6 = 0;
var counter7 = 0;   
var counter8 = 0;   
var counter9 = 0;

foreach (char sign in letters)
{
    if (sign == '0')
    {
        counter0++;
    }
    else if (sign == '1')
    {
        counter1++;
    }
    else if (sign == '2')
    {
        counter2++;
    }
    else if (sign == '3')
    {
        counter3++;
    }
    else if (sign == '4')
    {
        counter4++;
    }
    else if (sign == '5')
    {
        counter5++;
    }
    else if (sign == '6')
    {
        counter6++;
    }
    else if (sign == '7')
    {
        counter7++; 
    }
    else if (sign == '8')
    {
        counter8++; 
    }
    else if (sign == '9')
    {
        counter9++;
    }
}
Console.WriteLine("");
Console.WriteLine(" Result for number: 4555");
Console.WriteLine("");
Console.WriteLine("Sign 0 = " + counter0 + " times");
Console.WriteLine("Sign 1 = " + counter1 + " times");
Console.WriteLine("Sign 2 = " + counter2 + " times");
Console.WriteLine("Sign 3 = " + counter3 + " times");
Console.WriteLine("Sign 4 = " + counter4 + " times");
Console.WriteLine("Sign 5 = " + counter5 + " times");
Console.WriteLine("Sign 6 = " + counter6 + " times");
Console.WriteLine("Sign 7 = " + counter7 + " times");
Console.WriteLine("Sign 8 = " + counter8 + " times");
Console.WriteLine("Sign 9 = " + counter9 + " times");


