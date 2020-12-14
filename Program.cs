using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console . Clear ();
            Console . WriteLine ( " --- Temperatura do conversor --- " );

            Console . Write ( " Informe a temperatura em ° F: " );
            double  f  =  Convert . ToDouble ( Console . ReadLine ());

            duplo  c  = ( f  -  32 ) /  1,8 ;
            Console . WriteLine ( $ " ° F = { f } " );
            Console . WriteLine ( $ " { f } ° F equivalente a { c } ° C " );
            Console . WriteLine ( " Pressione qualquer tecla para sair " );
            Console . ReadKey ();

        }
    }
}
