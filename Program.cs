using System;
    class Program
    {
        static void Main()
        {       
            Inicio:
            Console.Clear(); 
            string pergunta;
            int teste;
            int num;  
            Console.WriteLine("Qual foi sua nota?");
            num=int.Parse(Console.ReadLine());
        
            string r = "Aprovado";
            if (num >=60){
            }else
              r="Reprovado";
            Console.WriteLine("Voce foi {0}", r);
    
            {
               //BEM AQUI!!!!!!!!!!!!!!
                 
        Console.WriteLine("Deseja recomeçar?");
                pergunta = Console.ReadLine();

                if(pergunta == "Sim"){
                    goto Inicio;

                }else{

                     Console.ReadLine();
                }


            }
        } 
     
}
    