using CharactersRefactored;

var pattern = args[0].ToUpper();
var characters = pattern.Select(Character.Create).ToArray();
while (true)
{
    Console.WriteLine(characters.Select(c=>c.Char).ToArray());
    var index = characters.Length - 1;
    var continueToNextCharacter = true;
    while (continueToNextCharacter)
    {
        var character = characters[index];
        var hasRestarted = character.Next();
        continueToNextCharacter = hasRestarted && index > 0;
        index--;
    }
}