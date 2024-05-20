namespace rppoon_dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory factory = new FireCharacterFactory();
            GameManager gameManager = new GameManager();
            gameManager.Create(factory);
        }
    }
}