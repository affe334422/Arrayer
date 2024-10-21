

using System.Formats.Asn1;

uppgift4();
static void uppgift4(){
    int går_det = 0;
    int om = 0;
    int tid = 50;

    char[,] gameboard = new char[,]{{'-','-','-',},
                                    {'-','-','-',},
                                    {'-','-','-',}};
    
    if(1 == 2){
        gameboard[0,1] ='x';
        gameboard[1,1] ='o';
        gameboard[0,2] ='x';
    }
    Console.WriteLine("Tictac toe");

    for(int c = 1; c != 20; c++){
        
        if(c == 1){
            for(int a = 0; a < gameboard.GetLength(0); a++){

                for(int b = 0; b < gameboard.GetLength(1); b++){

                    Console.Write(gameboard[a,b]);
                }
                Console.WriteLine();
            }
        }

       

        string mes1 = "Spelare 1 : var vill du placera x ";
        string mes2 = "Skriv vilken rad 1, 2 eller 3 :";
        string mes3 = "Skriv vilken kolumn 1, 2 eller 3 :";
        string mes4 = "Spelare 2 : var vill du placera o ";
        string mes5 = "Det går inte ";
        int rad;
        int kolumn;

        do{
        
        sakta(mes1, tid);    
        sakta(mes2, tid);
        rad = int.Parse(Console.ReadLine()); 
        sakta(mes3, tid);
        kolumn = int.Parse(Console.ReadLine());

        if(rad-1 >= 3 || kolumn- 1 >= 3){
            sakta(mes5,tid);
            Console.WriteLine("");
        }
        else if(gameboard[rad-1, kolumn-1] == '-'){
            gameboard[rad -1, kolumn -1] = 'x';
            går_det = 1;
        }
        else{
            sakta(mes5,tid);
            Console.WriteLine("");
        }
        
        }while(går_det != 1);
        går_det = 0;

        for(int a = 0; a < gameboard.GetLength(0); a++){

            for(int b = 0; b < gameboard.GetLength(1); b++){

                Console.Write(gameboard[a,b]);
            }
            Console.WriteLine();
        }

        for(int har = 0; har != 3; har++){

            if(gameboard[har,0] == 'x' && gameboard[har,1] == 'x' && gameboard[har,2] == 'x'){
                om = 1;
                break;
            }
            if(gameboard[0,har] == 'x' && gameboard[1,har] == 'x' && gameboard[2, har] == 'x'){
                om = 1;
                break;
            }
        }
        if(om == 1){
            break;
        }
        if(gameboard[0,0] == 'x' && gameboard[1,1] == 'x' && gameboard[2,2] == 'x' ){
           om = 1;
           break; 
        }
        if(gameboard[0,2] == 'x' && gameboard[1,1] == 'x' && gameboard[2,0] == 'x' ){
           om = 1;
           break; 
        }


      
        do{
        sakta(mes4, tid);
        sakta(mes2, tid);
        rad = int.Parse(Console.ReadLine());
        sakta(mes3, tid);
        kolumn = int.Parse(Console.ReadLine());

        if(gameboard[rad-1, kolumn-1] == '-'){
            gameboard[rad -1, kolumn -1] = 'o';
            går_det = 1;
        }
        else{
            sakta(mes5,tid);
            Console.WriteLine("");
        }
        }while(går_det != 1);
        går_det = 0;

        for(int a = 0; a < gameboard.GetLength(0); a++){

            for(int b = 0; b < gameboard.GetLength(1); b++){

                Console.Write(gameboard[a,b]);
            }
            Console.WriteLine();
        }

        for(int har = 0; har != 3; har++){

            if(gameboard[har,0] == 'o' && gameboard[har,1] == 'o' && gameboard[har,2] == 'o'){
                om = 2;
                break;
            }
            if(gameboard[0,har] == 'o' && gameboard[1,har] == 'o' && gameboard[2, har] == 'o'){
                om = 2;
                break;
            }
        }
        if(om == 2){
            break;
        }
        if(gameboard[0,0] == 'o' && gameboard[1,1] == 'o' && gameboard[2,2] == 'o' ){
           om = 1;
           break; 
        }
        if(gameboard[0,2] == 'o' && gameboard[1,1] == 'o' && gameboard[2,0] == 'o' ){
           om = 1;
           break; 
        }
    }
    if(om == 1){
        Console.WriteLine("Spelare 1 van");
    }
    if(om == 2){
        Console.WriteLine("Spelare 2 van");
    }
}

static void sakta(string mes, int tid){
    foreach (char c in mes){
            Console.Write(c);
            Thread.Sleep(tid);
    }
}

static void uppgift3(){
    double[] tem = {4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9};
    
    for(int c = 0; c != 7; c++){
        for(int a = 0; a != 6; a++){
            
            if(tem[a] >= tem[a+1]){
                double b = tem[a];
                tem[a] = tem[a+1];
                tem[a+1] = b;
            }
            
        }
    }
    for(int a = 0; a != 7; a++){
        Console.WriteLine(tem[a]);
    }
}

static void uppgift2(){

    double andtal = 0;
	double[] temperatur={4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9}; //7
    for(int a = 0; a != 7; a++){
        andtal = temperatur[a] + andtal;
    }
    andtal = andtal / 7;
    Console.WriteLine("medel värdet denna veckan är "+ andtal);
	//Lägg in programkod här för att beräkna medelvärdet…
}

static void uppgift1(){
    int[] a = new int[5];

    for(int b = 0; b != 5; b++){
        Console.Write("Skriv ett heltal: ");
        a[b] = int.Parse(Console.ReadLine());
        
    }

    Console.WriteLine("Dina tall");
    
    
    for(int b = 0; b != 5; b++){
        Console.Write(a[b] + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("Dina tall i omvänd ordning: ");
    
    for(int b = 5; b != 0; b--){
        
        Console.Write(a[b-1]+ " ");
    }


}