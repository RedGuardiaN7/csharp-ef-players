using CS_Entity_Framework_Players;
using System.Linq;

using (PlayerContext db = new PlayerContext())
{

    //Milestone 1: messa in commento per dare spazio alla milestone 3
    /*
    //Milestone 1: Creazione di un nuovo giocatore

    Random random= new Random();
    int RandomPlayedGames1 = random.Next(1, 101);

    Player Player1 =
        new Player
        {
            Name = "Donovan",
            Surname = "Mitchell",
            Rating = random.Next(1, 11),
            PlayedGames = RandomPlayedGames1,
            GamesWon = random.Next(1, RandomPlayedGames1),
            TeamId = 1
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
    */

    //Milestone 3: Creare tre giocatori, una squadra, e aggiungere i tre giocatori alla squadra

    Team Team1 =
        new Team
        {
            Name = "Cleveland Cavaliers",
            City = "Cleveland",
            Coach = "J.B. Bickerstaff",
            Colors = "Gold and wine"
        };
    db.Add(Team1);
    db.SaveChanges();

    Random random = new Random();
    int RandomPlayedGames1 = random.Next(1, 101);

    Player Player1 =
        new Player
        {
            Name = "Donovan",
            Surname = "Mitchell",
            Rating = random.Next(1, 11),
            PlayedGames = RandomPlayedGames1,
            GamesWon = random.Next(1, RandomPlayedGames1),
            TeamId = 1
        };
    db.Add(Player1);
    db.SaveChanges();

    int RandomPlayedGames2 = random.Next(1, 101);

    Player Player2 =
        new Player
        {
            Name = "Jarret",
            Surname = "Allen",
            Rating = random.Next(1, 11),
            PlayedGames = RandomPlayedGames2,
            GamesWon = random.Next(1, RandomPlayedGames2),
            TeamId = 1
        };
    db.Add(Player2);
    db.SaveChanges();

    int RandomPlayedGames3 = random.Next(1, 101);

    Player Player3 =
        new Player
        {
            Name = "Kevin",
            Surname = "Love",
            Rating = random.Next(1, 11),
            PlayedGames = RandomPlayedGames3,
            GamesWon = random.Next(1, RandomPlayedGames3),
            TeamId = 1
        };
    db.Add(Player3);
    db.SaveChanges();

}