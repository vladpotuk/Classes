using System;

public class City
{
    private int population;

    public int Population
    {
        get { return population; }
        set { population = value; }
    }


    public City(int population)
    {
        this.population = population;
    }


    public static City operator +(City city, int increase)
    {
        city.population += increase;
        return city;
    }


    public static City operator -(City city, int decrease)
    {
        city.population -= decrease;
        return city;
    }


    public static bool operator ==(City city1, City city2)
    {
        if (ReferenceEquals(city1, city2))
        {
            return true;
        }

        if (ReferenceEquals(city1, null) || ReferenceEquals(city2, null))
        {
            return false;
        }

        return city1.population == city2.population;
    }


    public static bool operator !=(City city1, City city2)
    {
        return !(city1 == city2);
    }


    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is City))
        {
            return false;
        }

        City city = (City)obj;
        return this.population == city.population;
    }


    public override int GetHashCode()
    {
        return population.GetHashCode();
    }


    public static bool operator >(City city1, City city2)
    {
        return city1.population > city2.population;
    }


    public static bool operator <(City city1, City city2)
    {
        return city1.population < city2.population;
    }
}
