using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("132","Nokia","1345ab21",8);
Iphone iphone = new Iphone("456","Iphone","34560lkd3k",4);
Console.WriteLine("Nokia---------------------------------------");
nokia.MostrarInfo();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine("Iphone---------------------------------------");
iphone.MostrarInfo();
iphone.InstalarAplicativo("WhatsApp");