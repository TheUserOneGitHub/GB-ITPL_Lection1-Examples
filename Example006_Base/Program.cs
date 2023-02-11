int numberA = 4;
int numberB = 5;
int numberC = 9;
int numberD = 14;
int numberE = 2;

int numberMAX = numberA;

if (numberA > numberMAX) numberMAX = numberA;
if (numberB > numberMAX) numberMAX = numberB;
if (numberC > numberMAX) numberMAX = numberC;
if (numberD > numberMAX) numberMAX = numberD;
if (numberE > numberMAX) numberMAX = numberE;

Console.WriteLine (numberMAX);