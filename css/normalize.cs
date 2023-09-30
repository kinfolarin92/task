double total = 0;
double apples = 1.50;
double oranges = 2.12; 
double grapes = 5.99;

total += apples;
total = total + oranges;

//Console.WriteLine(total);

int numberOfSocks = 0;
numberOfSocks++;
numberOfSocks++;
//Console.WriteLine(numberOfSocks);

float numberFloat = 1.1f;
double numberDouble = (double)numberFloat;

int numberSix = 6;


int grandTotal = 43564;

string grandTotalString = grandTotal.ToString("C");

//Console.WriteLine(grandTotalString);

int multipler = 3;

int total100 = 100;
int totalMultipled100 = MultiplierMethod(multipler, total100);

int total50 = 50;
int totalMultipled50 = MultiplierMethod(multipler, total50);

int total75 = 75;
int totalMultiplied_75 = MultiplierMethod(multipler, total75);

Console.WriteLine(totalMultiplied_75);

int MultiplierMethod(int multiplierNumber, int number)
{
    int total = multiplierNumber * number;
    return total;
}

Console.BackgroundColor = ConsoleColor.Blue;
Console.Clear();