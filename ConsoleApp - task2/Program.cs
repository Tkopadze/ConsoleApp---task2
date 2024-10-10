using System;
class Program
{
    static void Main(string[] args)
    {
Console.OutputEncoding = System.Text.Encoding.UTF8;
// 	მეორე დავალება C#
//1) შექმენით კონსოლური აპლიკაცია, რომელიც შეასრულებს მარტივ არითმეტიკულ ოპერაციებს რიცხვებზე.
// * გამოაცხადეთ ორი ცვლადი
// * შეასრულეთ მიმატების, გამოკლების, გამრავლების, გაყოფისა და ნაშთის ოპერაციები.
// * შედეგები დაბეჭდეთ კონსოლში

short a = 13;
short b = 14;

int sum = a + b;
int subtraction = a - b;
int multiplication = a * b;
float division = (float)(a * b) / sum;
int remainder = b % a;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Subtraction: " + subtraction);
Console.WriteLine("Multiplication: " + multiplication);
Console.WriteLine("Division: " + division);
Console.WriteLine("Remainder: " + remainder);

//----------------------------------------------------------------------------------------------------------------------
//2) წარმოაჩინეთ float, double და decimal შორის სიზუსტის სხვაობა:
// *შექმენით სამი ცვლადი float, double და decimal ტიპებით. თითოეულს მიანიჭეთ მნიშვნელობად 1.0/7.0 ზე
// * თითოეული ცვლადი გაამრავლეთ 7 ზე
// * დაბეჭდეთ თითოეული შედეგი და შეადარეთ

float c = 1.0f / 7.0f;
double d = 1.0 / 7.0;
decimal e = 1.0m / 7.0m;


float c7times = c * 7;
double d7times = d * 7;
decimal e7times = e * 7;


Console.WriteLine("float: "+ c7times);
Console.WriteLine("double: "  + d7times);
Console.WriteLine("decimal: "  + e7times);


Console.WriteLine("Comparing float (c7times) and double (d7times):");
if (c7times > d7times)
{
    Console.WriteLine("float > double");
}
else if (c7times < d7times)
{
    Console.WriteLine("float < double");
}
else
{
    Console.WriteLine("float == double");
}

Console.WriteLine("Comparing decimal (e7times) and double (d7times):");
if (e7times > (decimal)d7times)
{
    Console.WriteLine("decimal > double");
}
else if (e7times < (decimal)d7times)
{
    Console.WriteLine("decimal < double");
}
else
{
    Console.WriteLine("decimal == double");
}


Console.WriteLine("Comparing decimal (e7times) and float (c7times):");
if (e7times > (decimal)c7times)
{
    Console.WriteLine("decimal > float");
}
else if (e7times < (decimal)c7times)
{
    Console.WriteLine("decimal < float");
}
else
{
    Console.WriteLine("decimal == float");
}

//---------------------------------------------------------------------------------------------

//გადაიყვანეთ სხვადასხვა მონაცემთა ტიპები განსხვავებულ ტიპებში
// *გამოაცხადეთ int, double, float და decimal ტიპის ცვლადები
// * მიანიჭეთ თითეულ მათგანს მნიშვნელობები
// * შეასრულეთ explicit და implicit კონვერტაციებით ამ ტიპებს შორის (სადაც რომელია შესაძლებელი)

int num1;
double num2;
float num3;
decimal num4;
num1 = 5;
num2 = 6.2;
num3 = 7.2f;
num4 = 8.4m;

//explicit კოვერტაცია
int num5 = (int)num3;
int num6 = (int)num4;
int num7 = (int)num2;
double num10 = (double)num1;
float num11 = (float)num1;
// implicit კონვერტაცია
float num8 = num1;
double num9 = num1;

Console.WriteLine("explicit: " + num5);
Console.WriteLine("explicit: " + num6);
Console.WriteLine("explicit: " + num7);
Console.WriteLine("implicit: " + num8);
Console.WriteLine("implicit: " + num9);
Console.WriteLine("explicit: " + num10);
Console.WriteLine("explicit: " + num11);


//-------------------------------------------------------------------------------------------------------

//4) შექმენით კონსოლური აპლიკაცია, როკმელიც ორ ცვლადს მნიშვნელობას გაუცვლის.


int x = 5;
int y = 10;

int z = x;

x = y;
y = z;
Console.WriteLine("x: " + x);
Console.WriteLine("y: " + y);

//-----------------------------------------------------------------------------------------------------
//შექმენით კონსოლური აპლიკაცია, რომელიც დაითვლის BMI (Body Mass Index) მნიშვნელობას და ამის შესაბამისად დაბეჭდავს რჩევებს.
// *შემოატანინეთ მომხმარებელს კონსოლიდან ინფორმაცია - სიმაღლე და წონა (https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/)
// *დაითვალეთ BMI https://en.wikipedia.org/wiki/Body_mass_index
// *მიღებული შედეგების მიხედვით დაბეჭდეთ სხვადასხვა რჩევები

Console.WriteLine("შეიყვანეთ თქვენი წონა კილოგრამებში: ");
string weightInput = Console.ReadLine();

Console.WriteLine("შეიყვანეთ თქვენი სიმაღლე მეტრებში: ");
string heightInput = Console.ReadLine();
if (weightInput != null && heightInput != null)
{
    decimal weight = Convert.ToDecimal(weightInput.Replace('.', ','));
    decimal height = Convert.ToDecimal(heightInput.Replace('.', ','));
    decimal bmi;

    bmi = weight / (height * height);
    Console.WriteLine("bmi: " + bmi);

            if (bmi < 18.5m)
            {
                Console.WriteLine("თქვენ გაქვთ  წონის დეფიციტი(underweight). რეკომენდებულია სწორი კვების რაციონის დაცვა და ფიზიკური აქტივობა.");
            }
            else if (bmi < 24.9m)
            {
                Console.WriteLine("თქვენი წონა ნორმაშია. რეკომენდებულია ჯანსაღი ცხოვრების წესის შენარჩუნება.");
            }
            else if (bmi < 29.9m)
            {
                Console.WriteLine("თქვენ გაქვთ ჭარბი წონა (overweight).");
                Console.WriteLine("რეკომენდაციები: დაიწყეთ აქტიურ ცხოვრების წესი, დაიცავით დაბალკალორიული, დაბალნახშირწყლოვანი დიეტა.");
            }
            else if (bmi < 34.9m)
            {
                Console.WriteLine("თქვენ გაქვთ პირველი ხარისხის სიმსუქნე (Obesity Class I).");
                Console.WriteLine("რეკომენდაციები:  მიმართეთ პროფესიონალს  კვების რაციონის შესადგენად და აუცილებელია რეგულარული ფიზიკური აქტივობა.");
            }
            else if (bmi < 39.9m)
            {
                Console.WriteLine("თქვენ გაქვთ მეორე ხარისხის სიმსუქნე (Obesity Class II).");
                Console.WriteLine("რეკომენდაციები: საჭიროა მკაცრი სამედიცინო კონტროლი. აუცილებლად მიმართეთ ენდოკრინოლოგს და დიეტოლოგს.");
            }
            else
            {
                Console.WriteLine("თქვენ გაქვთ მესამე ხარისხის სიმსუქნე (Obesity Class III).");
                Console.WriteLine("რეკომენდაციები: თქვენი მდგომარეობა მოითხოვს დაუყოვნებლივ სამედიცინო ჩარევას");
            }
        }
    }
}
