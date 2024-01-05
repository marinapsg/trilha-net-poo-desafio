using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Smartphone Nokia");
        Nokia nokia = new Nokia(numero: "992589658", modelo: "Nokia01", imei: "8585962145", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Instagram");
        nokia.ReceberLigacao();

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone");
        Iphone iphone = new Iphone(numero: "985485486", modelo: "Iphone 15", imei: "8844863254", memoria: 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("Whatsapp");
        iphone.ReceberLigacao();
    }
}

