using TestPRoject.Common;
using TestPRoject.DAL;

class Program
{
    static void Main(string[] args)
    {
        // get relative path of file 
        string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

        string sFile = Path.Combine(sCurrentDirectory, @"..\..\..\Data\answers.json");

        string sFilePath = Path.GetFullPath(sFile);



        // read data from file 
        string data = File.ReadAllText(Path.GetFullPath(sFilePath));


        // parse file 
        var parser = new JsonParser(data);
        List<EmployerScores> employerScores = parser.getDataFromJson();


        // filter data
        var filteredData = employerScores.GroupBy(item => item.groupId)
            .Select(group => group.ToList().GroupBy(date => date.answeredOn.Month).Select(mounth => mounth.ToList().Average(x => x.answer1 + x.answer2 + x.answer3 + x.answer4 + x.answer5)).ToList())
            .ToList();

        Console.WriteLine("End task");
    }
}



