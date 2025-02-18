using System;
    class Program
    {
        static void Main()
        {       
            I:
            Console.Clear(); 
            string pergunta;
            int teste;
            int num, num2, num3, num4;
              
            Console.WriteLine("Qual foi sua nota? (1 bimestre)");
            num=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual foi sua nota? (2 bimestre)");
            num2=int.Parse(Console.ReadLine());
          
            Console.WriteLine("Qual foi sua nota? (3 bimestre)");
            num3=int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi sua nota? (4 bimestre)");
            num4=int.Parse(Console.ReadLine());

            Console.Clear();
            int soma = num + num2 + num3 + num4;

                string r = "Aprovado";
                if (soma >=60){
                }else
                r="Reprovado";
                Console.WriteLine("Nota final: {0} | Voce foi {1}",soma, r); 
               {

               //BEM AQUI!!!!!!!!!!!!!!

                Console.WriteLine(" ");
                Console.WriteLine("Deseja recomeçar? (Sim/Não)");
                pergunta = Console.ReadLine();

                    if(pergunta == "Sim"){
                    goto I;
                    }else{
                     Console.ReadLine();

                }
            }
        } 
     
}
    