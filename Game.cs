namespace challenge
{
    public class Game
    {
        public Dictionary<string, User> Users {get; set;} = new Dictionary<string, User>();
        public void Login(){
            System.Console.WriteLine("Login Game");
        }
    }
}