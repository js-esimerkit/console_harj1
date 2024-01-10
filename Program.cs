// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//ehtorakenne
int number;
Console.WriteLine("Anna luku väliltä 0-10");
number = int.Parse(Console.ReadLine());
if(number < 0){
    Console.WriteLine("Annoit liian pienen luvun");
}
else if (number > 10){
    Console.WriteLine("Luku on liian suuri");
}
else {
    Console.WriteLine("Luku on tarpeeksi suuri");
}
Console.WriteLine("LOPPU 1!");

//sama toisella tavalla
if(number < 0){
    Console.WriteLine("2.Annoit liian pienen luvun");
}
else if (number <= 10){
    Console.WriteLine("2.Luku on tarpeeksi suuri");
}
else {
    Console.WriteLine("2.Luku on liian suuri");
}
Console.WriteLine("LOPPU 2!");

//toistorakenne
for(int x=1; x<5; x++){
    Console.WriteLine("Rivi = "+x);
}