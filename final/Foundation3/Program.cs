using System;

class Program
{
    static void Main(string[] args)
    {
        //lecture event gen ----------------------------
        Address eventAddress1 = new Address("456", "Eugene", "OR", "USA");
        LectureEvent TalksAreUs = new LectureEvent("Talks are Us", "Come to our lecture on lectures. There will be key insights into how to attend lectures.", "08/30/2025", "11:45 AM", eventAddress1, "Steven J. Talksallot",200);
        Console.WriteLine($"---------------------------\n{TalksAreUs.fullOutdoor()}\n\n{TalksAreUs.Standard()}\n\n{TalksAreUs.Short()}\n---------------------------\n");

        // outdoor event gen ---------------------------
        Address eventAddress3 = new Address("123 Main Street", "Orlando", "FL", "USA");
        OutdoorEvent beachParty = new OutdoorEvent("Beach Bonanza", "Join us for fun at the beach with games and food!", "07/30/2025", "10:00 AM", eventAddress3, "Clear skies and sunny");
        Console.WriteLine($"---------------------------\n{beachParty.fullOutdoor()}\n\n{beachParty.Standard()}\n\n{beachParty.Short()}\n---------------------------\n");
    }
}