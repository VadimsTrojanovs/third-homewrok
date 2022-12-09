Console.Write("Введите число: ");
string number = Console.ReadLine();
int num = number.Length;
if (num == 5)

{
  if (number[0]==number[4]){
    Console.WriteLine("Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine("Ваше число: {number} - НЕ палиндром.");
}
else Console.WriteLine("Введенно неверное число");
