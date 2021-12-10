// using
//^^ using directive

namespace RockPaperScissors
{
    public class Game
    {
        public string Summary
        {
            get
            {
                return "(not implemented yet)";
            }
        }
         string Player;
         string Computer;
         string Move;
        //  private List<Record> AllRecords = new List<Record>();
        private static Random random = new Random();

private static string ComputerChoice(int length){
    // const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    const string chars = "PRS0";
    string RandomIzer = new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
        //^^ my custom randomizer
        string GameComputer = "";
      switch(RandomIzer){
                case "R":
                    GameComputer = "ROCK";
                    // this.Move = PLayerMove;
                    break;
                case "P":
                   GameComputer = "PAPER";
                    break;
                case "S":
                    GameComputer = "SCISSORS";
                    break;

                default:
                // '0' will be the default case
                    Console.WriteLine("Your Human Intelligence Is Too Much..\n" +
                    " COMPUTER LEFT THE ROOM");
                    return RandomIzer;
            }
            Console.WriteLine("The Computer Randomized To "+RandomIzer+
            " And Choosed "+GameComputer);
            return GameComputer;
            //^^ returning what i made the computer choice to be
    // return new string(Enumerable.Repeat(chars, length)
    //     .Select(s => s[random.Next(s.Length)]).ToArray());
}

        public string PlayRound(){
            //Player Vs. Computer
            Console.WriteLine("Whats Your Name?");
            var Name = Console.ReadLine();
            this.Player = Name;
            Console.WriteLine($"Ok {Player}, Choose 'Rock', 'Paper' Or 'Scissors'");
            string? Choose = Console.ReadLine();
            string PLayerMove = "";
            //^^ dont make these vars
            string NewChoose = Choose.ToUpper();
                while(NewChoose != "ROCK" && NewChoose != "PAPER" && NewChoose != "SCISSORS"){
                     Console.WriteLine("Choose A Real Move");
                     NewChoose = Console.ReadLine().ToUpper();
                     Console.WriteLine(NewChoose);
                }
                this.Computer = ComputerChoice(1);
                Console.WriteLine(Computer);
            switch(NewChoose){
                case "ROCK":
                    PLayerMove = NewChoose;
                    this.Move = PLayerMove;
                    break;
                case "PAPER":
                   PLayerMove = NewChoose;
                    this.Move = PLayerMove;
                    break;
                case "SCISSORS":
                    PLayerMove = NewChoose;
                    this.Move = PLayerMove;
                    break;

                default:
                    return PLayerMove;
            }
            Console.WriteLine(Move);
            return Move;
            // throw new NotImplementedException();
        }
        // private static void WriteHistoryToFile(Game game, string filePath){
        //     string xml = game.SerializeAsXml();
        //     File.WriteAllText(filePath, xml);
        // }

        // private static List<Record> ReadHistoryToFile(Game game, string filePath){

        // }

        // public string SerializeAsXml(){

        // }
    }
}