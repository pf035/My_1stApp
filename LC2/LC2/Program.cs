// See https://aka.ms/new-console-template for more information
//int number;
//string numberAsString = number.ToString();
//char[] letters = numberAsString.ToArray();
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

const int chASCII = 48; //wartość dziesiętna cyfry 0 w kodzie ASCII
const int numDig10 = 10; //liczba cyfr w systemie 10

String ourNum;
byte[] tab = new byte[numDig10];

Console.WriteLine("Wprowadź liczbę: ");
ourNum = Console.ReadLine();

for (int i = 0; i < ourNum.Length; i++) {
    for (int j = 0; j < numDig10; j++)
    {
        if (((int)ourNum[i]) == j + chASCII) 
        {
            tab[j] += 1;
            break;
        };
    };   
};
    
Console.WriteLine("Wyniki dla liczby: " + ourNum);

string zm1 = "";

for (int i = 0; i < numDig10; i++) { 
    zm1 = "";
    if ((int)tab[i] > 0) {
        zm1 = zm1 + tab[i];
    }
    else {
        zm1 = " brak ";
    }
    Console.WriteLine("Cyfra " + i + " - " + zm1 + " wystąpień");
};

