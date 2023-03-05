public enum HealthState // добaвлено , не хочет создавать (нельзя использовать)
{
    Нормальное,
    Ослаблен,
    Болен,
    Отравлен,
    Парализован,
    Мертв

}

public enum Race
{
    Человек,
    Дворф,
    Орк,
    Троль,
    Гном
}

public enum Gender
{
    М,
    Ж
}
public enum ListSpell
{
    ОгненныйШар,
    ЛедяннойПик,
    МеторитныйДождь,
    КругИсцеления,
    Исцеление,
    Жаба
}

public class RPGCharacter : IComparable<RPGCharacter>
{
    internal static int idCounter = 0;
    internal readonly int id;
    internal readonly string name;
    internal HealthState state;
    internal bool canSpeak;
    internal bool canMove;
    internal readonly Race race;
    internal readonly Gender gender;
    internal int age;
    internal int currentHealth;
    internal readonly int maxHealth;
    internal int exp;

    public RPGCharacter(string name, Race race, Gender gender, int maxHealth, int currentHealth)
    {
        this.id = ++idCounter;
        this.name = name;
        this.currentHealth = currentHealth;
        this.state = HealthState.Нормальное;
        this.canSpeak = true;
        this.canMove = true;
        this.race = race;
        this.gender = gender;
        this.age = 0;
        this.maxHealth = maxHealth;
        this.exp = 0;
    }

    public int Id
    {
        get { return id; }
    }

    public string Name
    {
        get { return name; }
    }

    public HealthState State
    {
        get { return state; }
        set { state = value; }
    }

    public bool CanSpeak
    {
        get { return canSpeak; }
        set { canSpeak = value; }
    }

    public bool CanMove
    {
        get { return canMove; }
        set { canMove = value; }
    }

    public Race Race
    {
        get { return race; }
    }

    public Gender Gender
    {
        get { return gender; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int CurrentHealth
    {
        get { return currentHealth; }
        set
        {
            currentHealth = value;
            if (currentHealth > maxHealth / 10)
                state = HealthState.Нормальное;
            if (currentHealth < maxHealth / 10)
                state = HealthState.Ослаблен;
            if (currentHealth < 0)
                state = HealthState.Мертв;
        }
    }

    public int MaxHealth
    {
        get { return maxHealth; }
    }

    public int EXP //кол-во опыта 
    {
        get { return exp; }
        set { exp = value; }
    }

    public int CompareTo(RPGCharacter other)
    {
        if (this.exp < other.exp)
            return -1;
        else if (this.exp == other.exp)
            return 0;
        else
            return 1;
    }

    public override string ToString()
    {
        return id + " " + name + " " + state + " " + currentHealth;
    }
}



class MageCharacter : RPGCharacter
{
    private int currentMana;
    private int maxMana;

    public int CurrentMana
    {
        get { return currentMana; }
    }

    public int MaxMana
    {
        get { return maxMana; }
    }

    public MageCharacter(string name, Race race, Gender gender, int maxHealth, int currentHealth, int currentMana, int maxMana) : base(name, race, gender, maxHealth, currentHealth)
    {
        this.currentMana = currentMana;
        this.maxMana = maxMana;
    }


    public void CastSpell(int spellPower)
    {
        int manaCost = spellPower * 2; // На единицу добавленного здоровья расходуется две единицы маны
        if (currentMana < manaCost)
        {
            Console.WriteLine("У вас мало маны");
        }
        else
        {
            currentMana -= manaCost;
            Console.WriteLine("Вы можете произнести заклинание"); // производим заклинание и теряем часть маны
        }

    }
    public void HealSpell(RPGCharacter target, int spellPower) //target - кого лечить типа цель
    {
        int manaCost = spellPower * 2;
        if (currentMana < manaCost) // текущая мана < цена маны 
        {
            Console.WriteLine("У вас мало маны");
        }
        else
        {
            int healAmount = Math.Min(spellPower, maxHealth - target.currentHealth);
            target.currentHealth += healAmount;
            currentMana -= manaCost;
            Console.WriteLine($"Вы вылечили {target} на {healAmount}");
        }
    }
}