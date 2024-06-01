namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO 
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO 

        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine($"Instalando aplicativo: {nomeApp} da loja apple...");

        }

    }
}