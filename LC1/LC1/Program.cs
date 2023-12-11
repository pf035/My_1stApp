// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

String licCal;
byte[] tab = new byte[10];

Console.WriteLine("Wprowadź liczbę: ");
licCal = Console.ReadLine();

for (int i = 0; i < licCal.Length; i++)
{

    switch ((byte)licCal[i])
    {
        case ((byte)('0')):

            tab[0] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('1')):

            tab[1] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('2')):

            tab[2] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('3')):

            tab[3] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('4')):

            tab[4] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('5')):

            tab[5] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('6')):

            tab[6] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('7')):

            tab[7] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('8')):

            tab[8] += 1; break;
    }
    switch ((byte)licCal[i])
    {
        case ((byte)('9')):

            tab[9] += 1; break;
    }
};
Console.WriteLine("Wyniki dla liczby: " + licCal);

string zm1 = "";

for (int i = 0; i < 10; i++)
{
    zm1 = "";
    if ((int)tab[i] > 0)
    {
        zm1 = zm1 + tab[i];
    }
    else
    {
        zm1 = " brak ";
    }
    Console.WriteLine("Cyfra " + i + " - " + zm1 + " wystąpień");
};

