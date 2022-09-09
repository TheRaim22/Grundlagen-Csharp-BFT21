
//Aufgabe 1


string a = "hallo";
String b = "H";
b += "allo";  

Console.WriteLine(b);                 // = Hallo

Console.WriteLine(b. Length);         //= 5

Console.WriteLine(a == b);            //= False

Console.WriteLine((object)a == b);    //= False


//Aufgabe 2                                                          Erwartungen Ergebnisse,                      Nach der Überprüfung.

double x = 2.0;                                                      
double y = x * x + 1 + x / 4;                                        // 1,75                                     

double c = 2.0;
double v = c * (c + 1 + c / 4);                                      // 2,5

bool p = true && false || 5 > 6;                                     // False

int j = 50;
bool numeric = j > 47 && j < 58;                                     // True


//Test Task 2
Console.WriteLine(y);
Console.WriteLine(v);
Console.WriteLine(p);
Console.WriteLine(numeric);