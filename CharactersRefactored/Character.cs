namespace CharactersRefactored
{
    internal class Character
    {
        private readonly string _characters;
        int _index;

        public char Char => _characters[_index];
        public static Character Vowel => new Character("AEIOUYÆØÅ");
        public static Character Consonant => new Character("BCDFGHJKLMNPQRSTVWXZ");

        public Character(string characters)
        {
            _characters = characters;
        }

        public bool Next()
        {
            _index++;
            if (_index < _characters.Length) return false;
            _index = 0;
            return true;
        }
    }
}
