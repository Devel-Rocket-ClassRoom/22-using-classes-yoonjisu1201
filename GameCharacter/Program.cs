using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine();
GameCharacter hero = new GameCharacter("용사", 5);
GameCharacter monster = new GameCharacter("고블린", 3);

hero.ShowStatus();
monster.ShowStatus();

Console.WriteLine("\n=== 전투 시작 ===");

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();
class GameCharacter
{
    public string Name { get; }
    public int Level { get; }
    public int MaxHp => Level * 100;
    public int CurrentHp { get; private set; }
    public int AttackPower => Level * 10;
    public bool IsAlive => CurrentHp > 0;

    public GameCharacter(string name, int level)
    {
        Name = name;
        Level = level;
        CurrentHp = MaxHp;
    }

    public void Attack(GameCharacter target)
    {
        Console.WriteLine($"{Name}이(가) {target.Name}에게 {AttackPower} 데미지를 입혔습니다!");
        target.TakeDamage(this.AttackPower);
    }

    public int TakeDamage(int damage)
    {
        CurrentHp -= damage;
        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }
        return CurrentHp;
    }
    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] Lv.{Level} - HP: {CurrentHp}/{MaxHp}, 공격력: {AttackPower}");
    }
}