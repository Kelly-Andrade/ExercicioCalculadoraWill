namespace ExercicioCalculadoraWill
{
    public class Calculadora
    {
        private double Resultado = 0;

        public Calculadora()
        {
            Console.WriteLine("| Calculadora |");
            int continuar = 1;
            while (continuar == 1)
            {
                Menu();
                Console.Write("\nDigite 1 para continuar e 2 para sair: ");
                continuar = int.Parse(Console.ReadLine());
            }                            
        }

        private void Menu()

        {
            //Console.Clear();
            Console.WriteLine("\n----\nMENU\n----\n1-Somar\n2-Subtrair\n3-Dividir\n4-Multiplicar\n5-Zerar calculadora\n");
            Console.Write("Escolha a operação: ");
            //Console.WriteLine("Resultado: " + Resultado);
            int escolha = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor: ");
            string Valor1 = Console.ReadLine();
            double ValorInserido;
            bool Converter = double.TryParse(Valor1, out ValorInserido);
            
            try
            {
                if (Converter == false)
                {
                    throw new Exception("\nERRO! Insira apenas números");
                }
                else
                {
                    ValorInserido = Convert.ToDouble (Valor1);
                }
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
            //double ValorInserido;


            switch (escolha)
            {
                case 1:                    
                    Somar(ValorInserido);
                    break;
                case 2:
                    Subtrair(ValorInserido);
                    break;
                case 3:
                    Dividir(ValorInserido);
                    break;
                case 4:
                    Multiplicar(ValorInserido);
                    break;
                case 5:
                    Reiniciar(ValorInserido);
                    break;
                default:
                    Menu();
                    break;
            }
            
            Console.Write("\nTOTAL: " + Resultado);
            Console.WriteLine();

        }

        private void Somar(double Valor)
        {
             Resultado += Valor;
        }

        private void Subtrair(double Valor)
        {
            Resultado -= Valor;
        }

        private void Dividir(double Valor)
        {
            try
            {
                if(Valor == 0)
                {
                    throw new Exception("\nERRO! Não é possível dividir por 0");
                }
                else
                {
                    Resultado /= Valor;
                }
                
            }

            catch(Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
            
            
        }

        private void Multiplicar(double Valor)
        {
            Resultado *= Valor;
        }

        private void Reiniciar(double Valor)
        {
            Resultado = 0;
        }
    }
}
