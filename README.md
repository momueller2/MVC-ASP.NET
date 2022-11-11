**Was ist ASP.NET?**

ASP.NET (Active Server Pages .NET) ist ein Web Application Framework von Microsoft, mit dem sich dynamische Webseiten, Webanwendungen und Webservices entwickeln lassen. Es basiert auf dem .NET-Framework und unterstützt alle Programmiersprachen davon. Als Entwicklungsumgebung wird Visual Studio benutzt.

ASP.NET bietet 3 verschiedene Entwicklungsmodelle an. Web Pages (Single Page Modell), Web Forms (Event Driven Modell) und MVC (Model View Controller).

**MVC in ASP.NET**

Mit ASP.NET gibt es für das MVC Design Pattern sehr viel automatisch generierten Code. So gibt es am Anfang, nachdem der Erstellung des Projektes direkt eine erste „Hello World" Applikation, die voll Funktionsfähig ist und den groben Aufbau einer MVC-Applikation besitzt.

![alt text](https://github.com/momueller2/MVC-ASP.NET/blob/main/Pictures/Bild1.png?raw=true)

Außerdem hat das System schon eigene Designelemente erstellt, die man wenn man möchte auch weiter benutzen kann. So sieht die Website am Anfang des Projektes aus: 
![alt text](https://github.com/momueller2/MVC-ASP.NET/blob/main/Pictures/Bild2.png?raw=true)

**Views**

Die Views in ASP.NET werden mit Razor Pages erstellt. Diese kombinieren die Tags von HTML und die Funktionen von C#. Die Datei ist ähnlich wie eine normale HTML Seite aufgebaut und man kann die Tags wie normal verwenden. Die C# Funktionen kann man nach dem Escapecharacter „@" aufrufen und benutzen. Außerdem wird am Anfang der Datei ein Typ des Models angegeben, den die View von dem Controller überliefert bekommt. Auf diese Model kann in der Razor Page auch zugegriffen werden, um die in dem Model gespeicherten Daten zu lesen.

![alt text](https://github.com/momueller2/MVC-ASP.NET/blob/main/Pictures/Bild3.png?raw=true)

**Models**

Die Models in ASP.NET sind ganz einfache C# Klassen, die als Attribute die gewünschte Struktur der Daten haben, die später auch auf der Datenbank so aufgebaut sein soll. Die Models können in ASP.NET später ganz einfach über ein Entity Framework mit einer Datenbank verbunden werden, die dann die gleiche Struktur wie die Model Klasse aufweist. 
![alt text](https://github.com/momueller2/MVC-ASP.NET/blob/main/Pictures/Bild4.png?raw=true)

**Controller**

Die Controller dienen als empfänger der Http-Requests, die die Applikation annehmen muss. In ASP.NET funktioniert das über die Methoden der Controller Klasse, in denen dann der Ablauf der Aktion festgelegt ist. Der Controller kann alle möglichen Http-Requests entgegennehmen, wobei die GET Methode der Standardwert ist.

Der Name des Controllers sowie dessen Methoden sind Bausteine der URL, mit welcher man die verschiedenen Aktionen aufrufen kann.

https://localhost:5001/Movies/Edit?id=5

Dieser Link wäre zum Beispiel eine funktionierende Anfrage an den „Movies" Controller, in dem dann die Methode „Edit" aufgerufen werden soll. Die „id=5" stellt die Parameter der „Edit" Methode dar, die in der URL mit angegeben werden müssen. Das Framework regelt den Ablauf dann so ab, dass die Methode aufgerufen wird und die richtigen Werte als Parameter übergeben werden.

![alt text](https://github.com/momueller2/MVC-ASP.NET/blob/main/Pictures/Bild5.png?raw=true)

In diesem Fall wäre das die Methode des Controllers, die aufgerufen wird. In diesem Beispiel ist das eine GET Anfrage, da es für das Editieren eine extra Webseite gibt, in der die Daten angegeben werden. Dies ist also nur eine weiterleitung an diese Seite.

Der Return Value bei den Methoden in der Controller Klasse sind in ASP.NET immer die Views, die der User angezeigt bekommen soll. Das Framework hilft dem Entwickler hier sehr weiter, da man in den Methoden immer nur eine „View()" zurückgeben muss und nicht expliziet angeben muss, welche View damit gemeint ist. Das System findet dann über den Namen der Methode, in dem die View erstellt wurde die richtige Razor Page Datei, die erstellt werden soll. Man muss dann nur checken, das die Razor Page Datei den gleichen Namen haben muss, wie die Methode in dem Controller, damit das System die richtige Datei auswählt.

![alt text](https://github.com/momueller2/MVC-ASP.NET/blob/main/Pictures/Bild6.png?raw=true)

Diese Funktion empfängt dann die HttpPost Anfrage, die getätigt wird, wenn der User die Daten der Datenbank wirklich verändern will. Dabei wird als Parameter schon das ganze „Movie" Objekt übergeben, welches das System aus den übergebenen Daten in der Anfrage automatisch erstellt hat, damit man es in der Methode direkt gut verwenden kann. Um zu unterscheiden, dass diese Methode die Post Anfrage entgegennehmen soll, muss eine Annotation über der Methode angegeben werden. Hier ist diese „[HttpPost]".

Nachdem die neue Movie Instanz in der Datenbank gespeichert wurde, gibt die Methode nun wieder eine View zurück. Falls alles normal gelaufen ist, wird hier die „RedirectToAction(nameof(Index))" Funktion verwendet, die die View „Index" zurückliefert, also wieder auf die Standardseite der Website zeigt.
