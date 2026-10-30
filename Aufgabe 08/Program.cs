Console.WriteLine("Bitte geben Sie einen Kommentar ein: ");
string comment = Console.ReadLine();


string commentLower = comment.ToLower();


string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe",
"arsch", "dummkopf", "hurensohn", "missgeburt", "scheisse", "Hund"
};

bool containsForbiddenWord = false;
string foundWord = "";

foreach (string word in forbiddenWords)
{
    if (commentLower.Contains(word))
    {
        containsForbiddenWord = true;
        foundWord = word;
        break; 
    }
}

if (containsForbiddenWord)
{
    Console.WriteLine("Dein Kommentar enthält ein verbotenes Wort: " + foundWord); 
}
else
{
    Console.WriteLine("Vielen Dank für deinen Kommentar!");
}