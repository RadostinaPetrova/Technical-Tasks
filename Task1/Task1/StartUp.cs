using Newtonsoft.Json;
using Task1;

//Here it could be customized to take the path as an input 
//string path = Console.ReadLine();

string path = "../../../input.txt";
string json = File.ReadAllText(path);
IEnumerable<MovieStar> movieStars = JsonConvert.DeserializeObject<IEnumerable<MovieStar>>(json);

foreach (var movieStar in movieStars)
{
    Console.WriteLine(movieStar.ToString());
}