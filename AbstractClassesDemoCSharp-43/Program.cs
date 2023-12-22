
using AbstractClassesDemoCSharp_43;

var beagle = new Dog();

beagle.Move();
beagle.Breathe();

var snake = new Snake();
snake.Move();
snake.Breathe();

var circle = new Circle(25);

Console.WriteLine($"Area of circle is {circle.CalculateArea()}");

