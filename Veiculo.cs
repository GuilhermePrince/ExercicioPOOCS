
namespace ListaExPOO
{
    public class Veiculo
    {
        public int Velocidade{ private set; get; }

        public Veiculo()
        {
            Velocidade = 0;
        }

        public void medidorVelocidade(int velocidadeCarro)
        {
            if(velocidadeCarro >= 0 && velocidadeCarro <= 200)
            {
            Velocidade = velocidadeCarro;
            }
        }
    }
}
    