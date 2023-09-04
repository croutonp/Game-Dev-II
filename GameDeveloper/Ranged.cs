using System.ComponentModel;
using System.ComponentModel.Design;

public class Ranged : Enemy
{

int Distance = 5;
public Ranged(string name) : base(name)
{
    Name = name;
    Health = 50;
    AttackList = new List<Attack>()
    {
        new("Arrow Shot", 20),
        new("Knife Throw", 15),
        
    };
}

public override void PerformAttack(Enemy Target, Attack ChosenAttack)
{
    if (Distance < 10)
    {
        Console.WriteLine("You're too close!");
    } else {
        Console.WriteLine($"{Name} used {ChosenAttack.Name} dealing {ChosenAttack.Damage} damage to {Target.Name}");
    }
    
}

public void Dash()
{
    Distance = 20;
}

}