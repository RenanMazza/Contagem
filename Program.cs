
class Program
{
    static void Main(string[] args)
    {

        var numeroCaracteres = 0;
        var numerotres = 0;
        
        
      
            for (int numero = 0; numero <= 50000; numero++)
            {

               if(numero%16 == 0)
               {
                      numeroCaracteres++;
                      
               }      
                if(numero.ToString().Contains("3"))
                {
                    numerotres++;
                }
                
            }
                

            Console.WriteLine("Quantos numeros sao divisiveis por 16: ");
            Console.WriteLine(numeroCaracteres);
            Console.WriteLine("Quantos numeros 3 contem em 50k: ");
            Console.WriteLine(numerotres);
           
            
            
            
            
    }

}   