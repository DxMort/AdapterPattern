using AdapterPattern;
public interface PCGame
{
    string getTitle();
    int getPegiAllowedAge();
    bool isTripleAGame();
    Requirements getRequirements();
}
public class PCGameAdapter: PCGame
{
    private ComputerGame computerGame;

    public PCGameAdapter(ComputerGame computerGame)
    {
        this.computerGame = computerGame;
    }
    public string getTitle()
    {
        return computerGame.getName();
    }
    public int getPegiAllowedAge()
    {
        return (int)computerGame.getPegiAgeRating();
    }
    public bool isTripleAGame()
    {
        return computerGame.getBudgetInMillionsOfDollars() > 50;
    }
    public Requirements getRequirements()
    {
        return new Requirements(
            computerGame.getMinimumGpuMemoryInMegabytes() * 8 / 1024,
            computerGame.getDiskSpaceNeededInGB() * 8,
            computerGame.getRamNeededInGb(),
            computerGame.getCoreSpeedInGhz(),
            computerGame.getCoresNeeded()
        );
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ComputerGame game1 = new ComputerGame("Cyberpunk 2077", PegiAgeRating.P18,
                100,     // бюджет
                8192,    // минимальный объём видеопамяти
                100,     // минимальный объём диска
                16,      // требуется оперативной памяти
                8,       // количество ядер процессора
                3.5);    // частота процессора
        ComputerGame game2 = new ComputerGame("The Witcher 3: Wild Hunt", PegiAgeRating.P16,
                50,      // бюджет
                4096,    // минимальный объём видеопамяти
                50,      // минимальный объём диска
                12,      // требуется оперативной памяти
                4,       // количество ядер процессора
                3.0);    // частота процессора

        ComputerGame game3 = new ComputerGame("Сапер", PegiAgeRating.P18,
                1,       // бюджет
                16384,     // минимальный объём видеопамяти
                1,       // минимальный объём диска
                256,     // требуется оперативной памяти
                64,      // количество ядер процессора
                5.1);    // частота процессора
        List<ComputerGame> games = new List<ComputerGame>();
        games.Add(game1);
        games.Add(game2);
        games.Add(game3);

        foreach (var game in games)
        {
            PCGame adapter = new PCGameAdapter(game);
            Console.WriteLine("Название игры: " + adapter.getTitle());
            Console.WriteLine("Возрастное ограничение: " + adapter.getPegiAllowedAge());
            Console.WriteLine("Triple A игра: " + adapter.isTripleAGame());

            Requirements requirements = adapter.getRequirements();
            Console.WriteLine("\nСистемные требования:");
            Console.WriteLine("Видеокарта: " + requirements.getGpuGb() + " Гб");
            Console.WriteLine("Жесткий диск: " + requirements.getHDDGb() + " Гб");
            Console.WriteLine("Оперативная память: " + requirements.getRAMGb() + " Гб");
            Console.WriteLine("Процессор: " + requirements.getCoresNum() + " ядер, " + requirements.getCpuGhz() + " ГГц\n\n");
        }
    }  
}
