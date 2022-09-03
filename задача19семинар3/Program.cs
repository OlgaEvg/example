// 
Console.Write("введите число: ");
bool palindrome=true;
int n=int.Parse(Console.ReadLine()!);
int c =n.ToString().Length - 1;
string b=n.ToString();
for (int i=0; i<c; i++)
   if (b[i] !=b[c-i])
     palindrome=false;
     if (palindrome == true)
     Console.Write ("yes");
     else Console.Write("No");

