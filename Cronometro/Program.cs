Menu();

static void Menu() {
    Console.Clear();
    Console.WriteLine("*Stopwatch Menu*");
    Console.WriteLine("S - Seconds => 10s = 10 seconds");
    Console.WriteLine("M - Minutes => 1m = 1 minute");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("Choose the disered time.");

    string data = Console.ReadLine().ToLower();
    char getLastLetter = char.Parse(data.Substring(data.Length -1, 1)); //pega o último caracter
    int getNumbers = int.Parse(data.Substring(0, data.Length -1)); //pega os números que vem antes do ultimo caractere.
    int multiplier = 1;

    if (getLastLetter == 'm')
        multiplier = 60;

    if(getNumbers == 0)
        Environment.Exit(0);

    PreStart(getNumbers * multiplier);
}

static void PreStart(int timeLimit) {
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Go!!");
    Thread.Sleep(2000);
    Console.Clear();
    Start(timeLimit);
}

//Função para disparar o crônometro.
static void Start(int timeLimit) {
    int currentTime = 0;

    while (currentTime != timeLimit) {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Finished stopwatch.");
    Thread.Sleep(2500);
    Menu();
}