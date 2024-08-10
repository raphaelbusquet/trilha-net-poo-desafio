namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo: {nomeApp} foi instalado no Iphone {Modelo} pela AppStore" +
               $" e tem o numero: {Numero} IMEI:{IMEI} com {Memoria}GB de memoria. ");
        }
    }
}