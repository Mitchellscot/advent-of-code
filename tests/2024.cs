using Microsoft.Extensions.Configuration;

namespace tests;

public class Tests2024
{
    private readonly IConfiguration _config;
    private readonly string _someSetting;

    public Tests2024()
    {
        _config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
    }

    [Fact]
    public void DayOneTest()
    {
        string[] input = File.ReadAllLines("./Resources/input1.txt");
        var answer = advent_of_code.DayOne.ProblemOne(input);
        var realAnswer = int.Parse(_config["2024:DayOne:ProblemOne"]);
        Assert.Equal(realAnswer, answer);
    }
}
