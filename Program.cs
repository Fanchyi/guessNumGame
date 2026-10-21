/*Игра «Угадай число»: 
 * Компьютер загадывает число от 1 до 100, 
 * а пользователь пытается его угадать. 
 * Используйте циклы while или do-while и 
 * генератор случайных чисел Random.*/

Random rnd = new();
int num = rnd.Next(1, 101);
int guessedNum = 0;
Console.WriteLine("The computer has picked a number from 1 to 100. Try to guess it!");

guessedNum = Convert.ToInt32(Console.ReadLine());

while (num != guessedNum) 
{
    if(num > guessedNum)
    {
        Console.WriteLine("The chosen number is greater! Try again: ");
    }
    else
    {
        Console.WriteLine("The chosen number is smaller! Try again: ");
    }

    
    guessedNum = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Correct!!! The right number is: {guessedNum}");



