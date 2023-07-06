int dec;
int baseNum;

Console.WriteLine("Enter decimal number: ");
dec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter base number: ");
baseNum = Convert.ToInt32(Console.ReadLine());

string digits = "0123456789ABCDEFGHIJ";
string ans = "";

while(dec > 0)
{
    int remainder = dec % baseNum;

    ans = digits[remainder] + ans;

    dec /= baseNum;
}

Console.WriteLine(ans);
