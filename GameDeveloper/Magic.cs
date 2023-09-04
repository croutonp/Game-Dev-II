using System.ComponentModel;

class Magic : Enemy
{


public Magic(string name) : base(name)
{
    Name = name;
    Health = 80;
    AttackList = new List<Attack>()
    {
        new("Fireball", 25),
        new("Lightning Bolt", 20),
        new("Staff Strike", 10) 
    };
}

public void Heal(Enemy Target)
{
    Health = Target.Health + 40;
    Console.WriteLine($"{Name} has healed {Target.Name} by 40 HP. They are now at {Health}!");
    
}

}