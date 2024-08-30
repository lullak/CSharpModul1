﻿//Skapa ett program där användaren måste mata in 5 ord. 
//a. Spara ned dessa i en array.. 
//b. Loopa igenom arrayen och ta fram det längsta ordet dvs det med flest bokstäver i. 
//c. Skriv ut det på skärmen. 

string[] words = new string[5];

for (int i = 0; i < words.Length; i++)
{
    Console.Write("Mata in ett ord: ");
    words[i] = Console.ReadLine();
}

string longWord = "";
foreach (string word in words)
{
    if (longWord.Length < word.Length) {
        longWord = word;
    }
}

Console.WriteLine(longWord);
Console.ReadKey();