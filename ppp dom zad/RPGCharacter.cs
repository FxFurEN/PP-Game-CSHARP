using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ppp_dom_zad
{
    enum HealthState
    {
        Нормальное,
        Ослаблен,
        Болен,
        Отравлен,
        Парализован,
        Мертв

    }

    enum Race
    {
        Человек,
        Дворф,
        Эльф,
        Гном
    }

    enum Gender
    {
        М,
        Ж
    }


    class RPGCharacter : IComparable<RPGCharacter>, ICloneable
    {
        protected static int idCounter = 0;
        protected readonly int id;
        protected readonly string name;
        protected HealthState state;
        protected bool canSpeak;
        protected bool canMove;
        protected readonly Race race;
        protected readonly Gender gender;
        protected int age;
        protected int currentHealth;
        protected readonly int maxHealth;
        protected int exp;

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

        public int EXP
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
       
        public object Clone()
        {
            return new RPGCharacter(Name, Race,Gender,MaxHealth,CurrentHealth);
        }
        public int Attack(RPGCharacter target)
        {
            if (this.currentHealth <= 0)
            {
                Console.WriteLine($"{this.name} уже мертв.");
                return 0;
            }

            int damage = new Random().Next(1, 11); // Генерируем случайный урон от 1 до 10

            target.currentHealth -= damage;

            if (target.currentHealth <= 0)
            {
                Console.WriteLine($"{target.name} умирает.");
                target.state = HealthState.Мертв;
            }

            return damage;
        }

        public bool TryToEscape()
        {
            if (this.currentHealth <= 0)
            {
                Console.WriteLine($"{this.name} уже мертв.");
                return false;
            }

            bool escaped = new Random().Next(0, 2) == 0; // Генерируем случайное число 0 или 1
            if (escaped)
            {
               
            }
            else
            {
                Console.WriteLine($"{this.name} не смог убежать.");
            }

            return escaped;
        }
       

    }

}
