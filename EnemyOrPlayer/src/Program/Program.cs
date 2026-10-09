/*
Realizzare la classe Player (analoga alla classe Enemy).

La classe deve rappresentare un giocatore e deve contenere:
-Una proprietà Name per memorizzare il nome del giocatore.
-Una proprietà Level per rappresentare il livello del giocatore. Il valore minimo del livello deve essere 1 e la proprietà deve avere il set privato.
-Una proprietà Experience per rappresentare i punti esperienza. La proprietà deve avere il set privato.
-Una proprietà Health per rappresentare i punti vita del giocatore. La proprietà deve avere il set privato.
-Una proprietà MaxHealth per rappresentare il numero massimo di punti vita. La proprietà deve avere il set privato.
-Una proprietà IsAlive per indicare se il giocatore è vivo. La proprietà deve avere il set privato.
-Una proprietà Gold per rappresentare la quantità di oro posseduta dal giocatore. La proprietà deve avere il set privato.

Nel costruttore Player inizializzare il giocatore con:
il nome ricevuto come parametro;
-livello 1;
-esperienza 0;
-MaxHealth pari a 100;
-Health uguale a MaxHealth;
-IsAlive impostato a true;
-Gold impostato a 0.

Implementare inoltre i seguenti metodi:
AddExperience(int amount) per aggiungere esperienza al giocatore. Ogni volta che il giocatore raggiunge almeno 100 punti esperienza deve aumentare di un livello, mantenendo l'eventuale esperienza rimanente.
ResetExperience() per riportare l'esperienza a 0.
TakeDamage(int amount) per diminuire i punti vita del giocatore. Se i punti vita raggiungono 0, il giocatore deve essere considerato morto.
Heal(int amount) per aumentare i punti vita senza superare MaxHealth.
AddGold(int amount) per aumentare la quantità di oro posseduta.
ResetHealth() per riportare i punti vita a MaxHealth e impostare il giocatore come vivo.
Attenzione ai valori non validi passati come parametri nelle varie funzioni sopra richieste, come quantità negative o nulle per esperienza, danno, cura e oro, devono essere gestiti senza modificare lo stato del giocatore.
*/
using BPascal.LessonEx3.ClassPlayer;
using BPascal.LessonEx3.ClassEnemy;
namespace BPascal.LessonEx3.Domain;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insert your name");
        string name = Console.ReadLine();
        Player You = new Player(name);

        Enemy Slime = new Enemy("Slime", 50, 5);

        Slime.TakeDamage(10);
        Console.WriteLine($"You attacked. {Slime.Name}'s health is now at {Slime.Health}");
        You.TakeDamage(Slime.Damage);
        Console.WriteLine($"{Slime.Name} attacked. Your health is now at {You.Health}");
        Slime.TakeDamage(50);
        Console.WriteLine($"Critical hit! {Slime.Name} is now a pile of ash");
        You.AddExp(120);
        You.GainGold(30);
        You.Heal(10);
        Console.WriteLine("Current stats:");
        Console.WriteLine($"Level {You.Lv}");
        Console.WriteLine($"Experience {You.Exp}");
        Console.WriteLine($"Gold {You.Gold}");
    }
}