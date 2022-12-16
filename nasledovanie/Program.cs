using nasledovanie;
var list=new List<Vehical>()
{
   new Car(120,10,"Kazan","Kazan"),
   new Ship(60,5,"Москва","Казань"),
   new Plane(1000,555, "Рязань", "Краснодар"),
};
foreach(var f in list)
{
    Console.WriteLine(f);
}
foreach (var f in list)
{
    f.SpeedUp();
}
foreach (var f in list)
{
    Console.WriteLine(f);
}