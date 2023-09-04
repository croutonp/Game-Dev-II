using System.Reflection.Metadata;

public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;
    
    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random attack = new();
        int random = attack.Next(0,3);
        Console.WriteLine($"{Name} used {AttackList[random].Name} dealing {AttackList[random].Damage} damage.");
    }

    
public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
{
    Target.Health = Health - ChosenAttack.Damage;

    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.Damage} damage and reducing {Target.Name}'s health to {Target.Health}!!");
}



}