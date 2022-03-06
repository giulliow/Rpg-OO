using static System.Console;

public class Warrior : Character
{
    public int Stamina;
    public Warrior(string Name, int Level, int MaxHealth, int Strengh, int Defense, int Dextery, int Intelligence, int Wisdom, int Charisma, string Region)
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

    public string WarriorAttacked()
    {
        double dmg = this.Strengh * 1.5;
        return this.Name + " attacked and caused: " + dmg + " of damage.";
    }

}