public class Person1
{
    // to set birthdate one time

    public DateTime Birthdate { get; private set; }

    public Person1(DateTime birthdate)
    {
        this.Birthdate = birthdate;
    }

    public int Age
    {
        get
        {
            var timespan = DateTime.Today - Birthdate;

            var duratrion = timespan.Days / 365;

            return duratrion;
        }
    }
}
