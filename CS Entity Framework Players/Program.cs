using CS_Entity_Framework_Players;
using System.Linq;

using (PlayerContext db = new PlayerContext())
{   
    //Milestone 1: Creazione di un nuovo giocatore

    Random random= new Random();
    int RandomPlayedGames = random.Next(1, 101);

    Player Player1 =
        new Player
        {
            Name = "Donovan",
            Surname = "Mitchell",
            Rating = random.Next(1, 11),
            PlayedGames = RandomPlayedGames,
            GamesWon = random.Next(1, RandomPlayedGames)
        };
        db.Add(Player1);
        db.SaveChanges();
    

    //Visualizzazione del nuovo giocatore

    Console.WriteLine("Il nuovo giocatore:");
    List<Player> players = db.Players.OrderBy(player => player.Name).ToList<Player>();
    Console.WriteLine("Nome: " + players[0].Name);
    Console.WriteLine("Cognome: " + players[0].Surname);
    Console.WriteLine("Valutazione: " + players[0].Rating);
    Console.WriteLine("Partite giocate: " + players[0].PlayedGames);
    Console.WriteLine("Partite vinte: " + players[0].GamesWon);

    //Modifica nome e cognome del giocatore

    Player1.Name = "Jarrett";
    Player1.Surname = "Allen";
    db.SaveChanges();

    //Eliminazione del giocatore

    db.Remove(Player1);
    db.SaveChanges();

}