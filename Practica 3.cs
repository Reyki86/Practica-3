using System;

class MainClass {
  public static void Main (string[] args) {
    
    Program1();

    Program2();

    Program3();

    Program4();

  }

  public static void Program1(){

    Console.WriteLine("Primer Programa");
    Console.WriteLine();

    float num;
    float total=0;

    do{
      Console.WriteLine("Digite un numero positivo: ");
      num=float.Parse(Console.ReadLine());

      if(num>0)
        total+=num;
    }
    while(num>0);

    Console.WriteLine("La suma de todos los numeros introducidos es "+total);
    Console.WriteLine();
  }

  public static void Program2(){

    int num=1;
    Console.WriteLine("Segundo Programa");
    Console.WriteLine();
    
    do{
      Console.WriteLine(num);
      num+=1;
    }
    while(num<=10);

    Console.WriteLine();
    
  }

  public static void Program3(){

    int contadorNumeroPar=0;
    Console.WriteLine("Tercer Programa");
    Console.WriteLine();

    for(int i=10*10;contadorNumeroPar<10;i++){
      if(i%2 == 0){
        contadorNumeroPar+=1;
        Console.WriteLine(contadorNumeroPar+"° Numero par: "+i);
      }
    }
    Console.WriteLine();

  }

  public static void Program4(){
    
    Console.WriteLine("Cuarto Programa");
    Console.WriteLine();

    for(char l='Z';l>='A';l--)
      Console.WriteLine(l);

    Console.WriteLine();

  }

}