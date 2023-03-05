using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppp_dom_zad
{
    interface IVolshebstvo
    {
        public void MagicVozdeistvie(RPGCharacter a, int power_vozdeistvia);
    }
    public abstract class Zaklinanie : IVolshebstvo
    {
        protected int minMana;
        protected bool canSpeak;
        protected bool canMove;

        public int MinMana
        {
            get { return minMana; }
        }
        public bool CanSpeak
        {
            get { return canSpeak; }
        }
        public bool CanMove
        {
            get { return canMove; }
        }
        public Zaklinanie(int minMana, bool canSpeak, bool canMove)
        {
            this.minMana = minMana;
            this.canSpeak = canSpeak;
            this.canMove = canMove;
        }

        public abstract void MagicVozdeistvie(RPGCharacter a, int power_vozdeistvia);
    }
    public class Health : Zaklinanie
    {
        public Health(int minMana, bool canSpeak, bool canMove) : base(minMana, canSpeak, canMove)
        {
        }

        public override void MagicVozdeistvie(RPGCharacter a, int power_vozdeistvia)
        {
            if (power_vozdeistvia < minMana)
            {
                Console.WriteLine("Не хвататет маны"); //ниче не делаем
                return;
            }
            if (canSpeak == true)
            {
                Console.WriteLine($"Добавить здоровье магией hp: {a} + {power_vozdeistvia / 2}");
                a.currentHealth += power_vozdeistvia / 2;
                if (a.currentHealth > a.maxHealth)
                {
                    a.currentHealth = a.maxHealth; // текущее стало максимальным тк мы дали ему больше чем положено 
                }
            }
            else
            {
                Console.WriteLine("Мы не можем добавить здоровье, тк не можем говорить");
            }
        }
    }
    public class Lechenie : Zaklinanie // hp-здоровье постоянно
    {
        public Lechenie(bool canSpeak, bool canMove) : base(20, canSpeak, canMove)
        {
        }

        public override void MagicVozdeistvie(RPGCharacter a, int power_vozdeistvia)
        {
            if (power_vozdeistvia < minMana)
            {
                Console.WriteLine("Не хвататет маны"); //ниче не делаем
                return;
            }
            if (canSpeak == true)
            {
                Console.WriteLine($"Вылечиваем магией hp: {a} + {power_vozdeistvia / 2}");
                if (a.state == HealthState.Болен)
                {
                    a.state = HealthState.Ослаблен;
                }
                else if (a.state == HealthState.Ослаблен)
                {
                    a.state = HealthState.Нормальное;
                }
            }
            else
            {
                Console.WriteLine("Мы не можем вылечить, тк не можем говорить");
            }
        }
    }
    public class Protivoyadie : Zaklinanie
    {
        public Protivoyadie(bool canSpeak, bool canMove) : base(30, canSpeak, canMove)
        {

        }

        public override void MagicVozdeistvie(RPGCharacter a, int power_vozdeistvia)
        {
            if (power_vozdeistvia < MinMana)
            {
                Console.WriteLine("Не хвататет маны"); //ниче не делаем
                return;
            }
            if (canSpeak == true)
            {
                Console.WriteLine($"Пьет противоядие , hp: {a} + {power_vozdeistvia / 2}");
                if (a.state == HealthState.Отравлен)
                {
                    a.state = HealthState.Ослаблен;
                }
                else if (a.state == HealthState.Ослаблен)
                {
                    a.state = HealthState.Нормальное;
                }
            }
            else
            {
                Console.WriteLine("Мы не можем вылечить, тк не можем говорить");
            }
        }
    }
}
