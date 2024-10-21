using System.Net.Http.Headers;
Mai();

static void Mai(){
    double andtal = 0;
	double[] temperatur={4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9}; //7
    for(int a = 0; a != 7; a++){
        andtal = temperatur[a] + andtal;
    }
    andtal = andtal / 7;
    Console.WriteLine("medel värdet denna veckan är "+ andtal);
	//Lägg in programkod här för att beräkna medelvärdet…
}

