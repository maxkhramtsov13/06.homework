//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Enter the number-> ");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
if (num.Length > 2)
{
  Console.WriteLine("Third digit of the number-> " + num[2]);
}
else
{ 
  Console.WriteLine("No third digit ");
}


