//  Напишите программу, которая по заданному номеру четверти, 
//  показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine ("Введите номер четверти");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
case 1:
Console.WriteLine("возможные координаты в данной плоскости x > 0 ; y > 0");
break;

case 2:
Console.WriteLine("возможные координаты в данной плоскости x < 0 ; y > 0");
break;

case 3:
Console.WriteLine("возможные координаты в данной плоскости x < 0 ; y < 0");
break;

case 4:
Console.WriteLine("возможные координаты в данной плоскости x > 0 ; y < 0");
break;

default:
Console.WriteLine("такой плоскости не существует");
break;
}