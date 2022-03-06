using static System.Console;
using static Character;
using static Warrior;
using static Mage;

public class Program
{
    
    public static void Main()
    {
        
        WriteLine("|-----------Enter the class of your hero-----------|");
        WriteLine("|-----------------------List-----------------------|");
        WriteLine("|-Warrior------------------------------------------|");
        WriteLine("|-Mage---------------------------------------------|");
        WriteLine("|--------------------------------------------------|");
        string ClassHero = ReadLine();
        switch(ClassHero){
            case "Warrior":
                WriteLine("|-----------Enter the name of your hero -----------|");
                string WarriorName = ReadLine();
                WriteLine("|-----------Enter the level of your hero-----------|");
                string WAttributeValue = ReadLine();
                int WarriorLevel = Int32.Parse(WAttributeValue);
                WriteLine("|----------Enter the health of your hero-----------|");
                WAttributeValue = ReadLine();
                int WarriorHealth = Int32.Parse(WAttributeValue);
                WriteLine("|----------Enter the strengh of your hero----------|");
                WAttributeValue = ReadLine();
                int WarriorStrengh = Int32.Parse(WAttributeValue);
                WriteLine("|----------Enter the defense of your hero----------|");
                WAttributeValue = ReadLine();
                int WarriorDefense = Int32.Parse(WAttributeValue);
                WriteLine("|----------Enter the dextery of your hero----------|");
                WAttributeValue = ReadLine();
                int WarriorDextery = Int32.Parse(WAttributeValue);
                WriteLine("|-------Enter the intelligence of your hero--------|");
                WAttributeValue = ReadLine();
                int WarriorIntelligence = Int32.Parse(WAttributeValue);
                WriteLine("|----------Enter the wisdom of your hero-----------|");
                WAttributeValue = ReadLine();
                int WarriorWisdom = Int32.Parse(WAttributeValue);
                WriteLine("|---------Enter the charisma of your hero----------|");
                WAttributeValue = ReadLine();
                int WarriorCharisma = Int32.Parse(WAttributeValue);
                WriteLine("|----------Enter the reign of your hero -----------|");
                string WarriorReign = ReadLine();
                Warrior Whero = new Warrior(WarriorName,WarriorLevel,WarriorHealth,WarriorStrengh,WarriorDefense,WarriorDextery,WarriorIntelligence,WarriorWisdom,WarriorCharisma,WarriorReign);
                WriteLine(Whero.ToString());
                break;
            case "Mage":WriteLine("|-----------Enter the name of your hero -----------|");
                string MageName = ReadLine();
                WriteLine("|-----------Enter the level of your hero-----------|");
                string MAttributeValue = ReadLine();
                int MageLevel = Int32.Parse(MAttributeValue);
                WriteLine("|----------Enter the health of your hero-----------|");
                MAttributeValue = ReadLine();
                int MageHealth = Int32.Parse(MAttributeValue);
                WriteLine("|----------Enter the strengh of your hero----------|");
                MAttributeValue = ReadLine();
                int MageStrengh = Int32.Parse(MAttributeValue);
                WriteLine("|----------Enter the defense of your hero----------|");
                MAttributeValue = ReadLine();
                int MageDefense = Int32.Parse(MAttributeValue);
                WriteLine("|----------Enter the dextery of your hero----------|");
                MAttributeValue = ReadLine();
                int MageDextery = Int32.Parse(MAttributeValue);
                WriteLine("|-------Enter the intelligence of your hero--------|");
                MAttributeValue = ReadLine();
                int MageIntelligence = Int32.Parse(MAttributeValue);
                WriteLine("|----------Enter the wisdom of your hero-----------|");
                MAttributeValue = ReadLine();
                int MageWisdom = Int32.Parse(MAttributeValue);
                WriteLine("|---------Enter the charisma of your hero----------|");
                MAttributeValue = ReadLine();
                int MageCharisma = Int32.Parse(MAttributeValue);
                WriteLine("|----------Enter the reign of your hero -----------|");
                string MageReign = ReadLine();
                Mage Mhero = new Mage(MageName,MageLevel,MageHealth,MageStrengh,MageDefense,MageDextery,MageIntelligence,MageWisdom,MageCharisma,MageReign);
                WriteLine(Mhero.ToString());
                break;
            case "null":
                Character Hero = new Character();
                WriteLine(Hero.ToString());
                break;
            default:
                WriteLine("|-----------Enter the class of your hero-----------|");
                WriteLine("|-----------------------List-----------------------|");
                WriteLine("|-Warrior------------------------------------------|");
                WriteLine("|-Mage---------------------------------------------|");
                WriteLine("|--------------------------------------------------|");
                ClassHero = ReadLine();
                break;

        }
    }
};
