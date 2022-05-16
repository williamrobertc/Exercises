////Exercise number 1

Console.WriteLine("How many students? ");
int students = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 1; i <= students; i++)
{
    Console.WriteLine("Type the grade of the {0} student", i);
    double grades = double.Parse(Console.ReadLine());

    sum += grades;
}

double average = sum / students;

Console.WriteLine("The averege is {0}", average.ToString("F2"));




//Exercise number 2

Console.WriteLine("How many euros would you like to convert? ");
double euros = double.Parse(Console.ReadLine());

Console.WriteLine("What's the curruncy? ");
double curruncy = double.Parse(Console.ReadLine());

double Total = euros * curruncy;

Console.WriteLine($"The total in reals is : {Total.ToString("F2")}");


//Exercise number 3

Console.WriteLine("How much did you sell? ");
double sales = double.Parse(Console.ReadLine());

double totalSales = sales *= 0.05;

Console.WriteLine("Total sales = {0}", totalSales);





//Exercise number 4


Console.WriteLine("What's the temperature in Celsius?");
int temperauturaC = int.Parse(Console.ReadLine());

int fahreinheit = (9 * temperauturaC + 160) / 5;

Console.WriteLine($"The temperature in Fahreinheit is {fahreinheit.ToString("F2")}");

//Exercise number 5

Console.WriteLine("What's the temperature in Fahreinheit?");
int temperauturaF = int.Parse(Console.ReadLine());

int celsius = (temperauturaF - 32) * 5 / 9;

Console.WriteLine($"The temperature in Fahreinheit is = {celsius.ToString("F2")}");

//Exercise number 6

Console.WriteLine("What's your height");
double height = double.Parse((Console.ReadLine()));

double idealWeight = (72.7 - height) - 58;

Console.WriteLine("Your ideal weight is {0}", idealWeight);





//Exercise number 7

Console.WriteLine("How many grades would you like to add");
int amountofstudens = int.Parse(Console.ReadLine());


double sumUp = 0;

for (int i = 1; i <= amountofstudens; i++)
{
    Console.WriteLine($"Type the {i} grade of the student");
    double valuess = double.Parse(Console.ReadLine());


    sum += valuess;

}

double average2 = sumUp / amountofstudens;

if (average >= 7.0)
{
    Console.WriteLine($"congrats!!! student approved with {average2}");
}
else
{
    Console.WriteLine("student failed! you need to study more! average: {0} ", average);
}




//Exercise number 8

Console.WriteLine("What's the fisrt value");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("What's the second Value? ");
int number2 = int.Parse(Console.ReadLine());

int minus = number1 - number2;

if (minus <= 0)
{
    Console.WriteLine($"Total: {minus} = Negative Value");
}
else
{
    Console.WriteLine("Total: {0} = Positive value", minus);
}

//Exercise number 9

Console.WriteLine("What's the fisrt value");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("What's the second value");
int b = int.Parse(Console.ReadLine());

if(a == 0 || b == 0)
{
    Console.WriteLine("Zero is not accepted! Please type again");
    Console.WriteLine("What's the fisrt value");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("What's the second value");
    b = int.Parse(Console.ReadLine());


}

int division = a / b;

int resto = division % 2;

Console.WriteLine(resto);

















