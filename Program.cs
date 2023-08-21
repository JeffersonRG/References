// See https://aka.ms/new-console-template for more information

using References;

//makes reference for myfirstsedan
Sedan myFirstSedan = new Sedan(0);
IAutomobile myAutomobile = myFirstSedan;

//makes reference for myothersedan
Sedan myOtherSedan = new Sedan(0);

// write down the speed for my first sedan and my other sedan and compares them
myFirstSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myAutomobile.Speed);
Console.WriteLine(myFirstSedan.Equals(myAutomobile));

// write down the speed for my first sedan and my other sedan and compares them
myOtherSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myOtherSedan.Speed);
Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

//changes the weight,speed, and licenseplate of the truck
Truck myTruck = new Truck(50, 500, "MyTruck");

//calls upon the stringify from other classes
myFirstSedan.Stringify();
myAutomobile.Stringify();
myOtherSedan.Stringify();
myTruck.Stringify();
