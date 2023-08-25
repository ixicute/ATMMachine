namespace ATMMachine
{
    internal class Program
    {
        /* I den här applikationen implementeras följande designmönster:
         / -Singelton: används för klassen ATM.cs för att säkerställa en enda instans
         /             under hela applikationens livslängd.
         /
         / -Strategy:  Används för att inkapsla dem olika beteenden/valen i ATM-maskinen
         /             (sätta in, kolla saldo, ta ut pengar) till olika klasser där en switch
         /             case används för att returnera rätt klass beroende på vad som väljs.
         /
         / -Factory:   Används för att skapa en instans av något av dem operationer som finns
         /             utifrån vår Strategy utan att behöva specificera vilken klass som ska
         /             skapas.
        */
        static void Main(string[] args)
        {
            ATM.Instance.Start();
        }
    }
}