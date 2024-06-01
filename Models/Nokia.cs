namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO 
    public class Nokia : Smartphone 
    {
        public Nokia(string numero, string modelo,  int imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO 

        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine($"Instalando app: {nomeApp} da loja Nokia");

        }

    }
}