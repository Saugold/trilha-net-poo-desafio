namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        private string Modelo {get;set;}
        private string IMEI{get; set;}
        private int Memoria{get;set;}
        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Numero:{Numero}");
            Console.WriteLine($"Modelo:{Modelo}");
            Console.WriteLine($"IMEI:{IMEI}");
            Console.WriteLine($"Memoria:{Memoria}");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}