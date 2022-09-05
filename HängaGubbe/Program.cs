int health = 10;
int points = 0;
bool guessedRight;
bool guessedPreviously;
string wrongGuesses = "";
string currentWord = "";
string previousGuesses = "";
string currentGuess;

Console.WriteLine("P1, Write a Word: ");
string originalWord = Console.ReadLine().ToUpper();
Console.Clear();

foreach(char bkstv in originalWord){
    currentWord += "*";
}

//Replace(currentWord[a], rightGuesses[x]);

while(true){                     //Spel-delen, du gissar och spelet kollar om det är rätt eller inte.
guessedRight = false;

while(true){
guessedPreviously = false;
Console.Clear();
Console.WriteLine("\nCurrent health: " + health);        //skriver ut health
Console.WriteLine(currentWord);
Console.WriteLine("P2, Type a letter to guess: "); //här får spelaren möjlighet att gissa, bokstaven läses in
currentGuess = Console.ReadLine().ToUpper();

for(int b = 0; b < previousGuesses.Length; b++){
    if(previousGuesses[b].ToString() == currentGuess){
        Console.WriteLine("You have already guessed that. Press enter to continue");
        Console.ReadLine();
        guessedPreviously = true;
    }
}

if(!guessedPreviously){
       previousGuesses += currentGuess;
        break;
}
Console.Clear();
}

for (int i = 0; i < currentWord.Length; i++){
if(originalWord[i].ToString() == currentGuess) {
    currentWord = currentWord.Remove(i, 1).Insert(i, currentGuess);
guessedRight = true;
}else{
}
}

if(!guessedRight){      //Kollar om gissningen är fel, isåfall dras ett HP bort.
    health--;
    wrongGuesses += currentGuess;
}

if(currentWord == originalWord){
    break;
}

if (health == 0)
{
break;
}

Console.Clear();
}
if(health == 0){
Console.WriteLine("Game Over, You did not manage to guess the word in time. The word was " + originalWord + ". Better luck next time!");
Console.ReadLine();
}
else{
Console.WriteLine("Congratulations! You guessed the word, " + originalWord + ", right.");
Console.ReadLine();
}
