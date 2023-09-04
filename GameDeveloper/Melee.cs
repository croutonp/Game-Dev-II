using System.ComponentModel;

class Melee : Enemy
{


public Melee(string name) : base(name)
{
    Name = name;
    Health = 120;
    AttackList = new List<Attack>()
    {
        new("Punch", 20),
        new("Kick", 15),
        new("Tackle", 25) 
    };
}

public void Rage(Enemy Target)
{
    Random attack = new();
        int random = attack.Next(0,2);
        Console.WriteLine($"{Name} used {AttackList[random].Name} dealing {AttackList[random].Damage + 10} of Enraged damage to {Target.Name}.");
        
}


}