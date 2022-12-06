using System;
//Laço de repetição IF - Verificar a media de um aluno e ver se ele foi aprovado
class Aula12
{
    static void Main(string[]args){

        double n1, n2, n3, n4, media;
        n1=n2=n3=n4=media=0;
        string resultado = "REPROVADO"; 

        Console.Write("1° nota: ");
        n1 = double.Parse(Console.ReadLine());
        
        Console.Write("2° nota: ");
        n2 = double.Parse(Console.ReadLine());
        
        Console.Write("3° nota: ");
        n3 = double.Parse(Console.ReadLine());
        
        Console.Write("4° nota: ");
        n4 = double.Parse(Console.ReadLine());

        media = (n1+n2+n3+n4)/4;

        if(media>=7){
            resultado="APROVADO";
        }
        Console.WriteLine($"Media: {media}\nResultado: {resultado}");
        
      
    }
}
