// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

const int c1 = 48; //wartość dziesiętna cyfry 0 w kodzie ASCII
const int c2 = 10; //liczba cyfr w systemie 10

String licCal;
byte[] tab = new byte[c2];

Console.WriteLine("Wprowadź liczbę: ");
licCal = Console.ReadLine();

for (int i = 0; i < licCal.Length; i++) {
    for (int j = 0; j < c2; j++)
    {
        if (((int)licCal[i]) == j + c1) 
        {
            tab[j] += 1;
            break;
        };
    };   
};
    
Console.WriteLine("Wyniki dla liczby: " + licCal);

string zm1 = "";

for (int i = 0; i < c2; i++) { 
    zm1 = "";
    if ((int)tab[i] > 0) {
        zm1 = zm1 + tab[i];
    }
    else {
        zm1 = " brak ";
    }
    Console.WriteLine("Cyfra " + i + " - " + zm1 + " wystąpień");
};

