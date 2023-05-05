using System;

namespace SorteioQuermesse
{
    class Program
    {
        static void Main(string[] args) 
        {
            int participante, numParticipante, numeroSorteio;

            Random random = new Random();

            Console.Write("Digite o numero de participantes da festa: ");
            participante = int.Parse(Console.ReadLine());
            
            
            for(numParticipante = 1; numParticipante <= participante ; numParticipante++) 
            {
                numeroSorteio = random.Next(1, participante);
                Console.Write("\nNumero de entrada: " + numParticipante + " : " + numeroSorteio + "\n");
                
                if (numParticipante == numeroSorteio)
                {
                    Console.Write("(O numero vencedor foi: " + numParticipante + ")\n\n");
                }
            }
        }
    }
}