using static System.Console;

public class Mage : Character
{
    public Mage(string Name, int Level, int MaxHealth, int Strengh, int Defense, int Dextery, int Intelligence, int Wisdom, int Charisma, string Region)
    {
        this.Name = Name;
        this.Level = Level;
        this.MaxHealth = MaxHealth;
        this.Health = MaxHealth;
        this.Strengh = Strengh;
        this.Defense = Defense;
        this.Dextery = Dextery;
        this.Intelligence = Intelligence;
        this.Wisdom = Wisdom;
        this.Charisma = Charisma;
        this.Region = Region;
    }

    public string MageAttacked()
    {
        double dmg = this.Dextery * 1.7;
        return this.Name + " attacked and caused: " + dmg + " of damage.";
    }
}