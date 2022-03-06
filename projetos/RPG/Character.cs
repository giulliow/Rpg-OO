using static System.Console;
public class Character
{
    public string Name {get;set;}
    public int Level {get;set;}
    public int MaxHealth {get;set;}
    public int Health {get;set;}
    public int Strengh {get;set;}
    public int Defense {get;set;}
    public int Dextery {get;set;}
    public int Intelligence {get;set;}
    public int Wisdom {get;set;}
    public int Charisma {get;set;}
    public string Region {get;set;}

    public Character()
    {
        this.Name = "null";
        this.Level = 1;
        this.MaxHealth = 1;
        this.Health = 1;
        this.Strengh = 1;
        this.Defense = 1;
        this.Dextery = 1;
        this.Intelligence = 1;
        this.Wisdom = 1;
        this.Charisma = 1;
        this.Region = "null";
    }

/*
    public Character(string Name, int Level, int MaxHealth, int Strengh, int Defense, int Dextery, int Intelligence, int Wisdom, int Charisma, string Region)
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
*/

    public void LevelUp(String Attribute)
    {
        this.Level = this.Level + 1;
        this.MaxHealth = this.MaxHealth + 50;
        this.Health = this.MaxHealth;
        switch(Attribute){
            case "Strengh":
                this.Strengh = this.Strengh + 1;
                break;
            case "Defense":
                this.Defense = this.Defense + 1;
                break;
            case "Dextery":
                this.Dextery = this.Dextery + 1;
                break;
            case "Intelligence":
                this.Intelligence = this.Intelligence + 1;
                break;
            case "Wisdom":
                this.Wisdom = this.Wisdom + 1;
                break;
            case "Charisma":
                this.Charisma = this.Charisma + 1;
                break;
            default:
                WriteLine("Enter a Valid option:");
                Attribute = ReadLine();
                break;
        }
    }

    public string Attacked()
    {
        return this.Name + " attacked and caused: " + this.Strengh + " of damage.";
    }

    public void GotAttacked(int value)
    {
        int dmg = value - (2 * this.Defense);
        this.Health = this.Health - dmg;
    }

    public void Healed(int value)
    {
        this.Health = this.Health + value;
    }

    public override string ToString()
    {
        return "|-" + this.Name + "-|\n" + "|-Level-------" + this.Level + "|\n" + "|-Health------" + this.Health + "|\n";
    }


}