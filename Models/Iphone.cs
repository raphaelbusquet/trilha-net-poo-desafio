namespace DesafioPOO.Models

{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo: {nomeApp} foi instalado no Iphone {Modelo} pela AppStore" +
               $" e tem o numero: {Numero} IMEI:{IMEI} com {Memoria}GB de memoria. ");
        }
    }
}