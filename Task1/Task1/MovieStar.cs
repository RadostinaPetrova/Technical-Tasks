using System.Text;

namespace Task1
{
    public class MovieStar
    {
        public MovieStar(string name, string surname, string sex, string nationality, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Nationality = nationality;
            this.DateOfBirth = dateOfBirth;
        }

        public DateTime DateOfBirth { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Sex { get; set; }

        public string Nationality { get; set; }

        public string GetFullName()
        {
            return this.Name + " " + this.Surname;
        }

        public int GetCurrentAge(DateTime dateOfBirth, DateTime todaysDate)
        {
            int age = todaysDate.Year - this.DateOfBirth.Year;

            if (todaysDate.Month < this.DateOfBirth.Month ||
               (todaysDate.Month == this.DateOfBirth.Month &&
               todaysDate.Day < this.DateOfBirth.Day))
            {
                age--;
            }

            return age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetFullName())
                .AppendLine(this.Sex)
                .AppendLine(this.Nationality)
                .AppendLine(this.GetCurrentAge(this.DateOfBirth, DateTime.Now).ToString() + " years old");

            return sb.ToString();
        }
    }
}
