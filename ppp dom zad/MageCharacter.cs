using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppp_dom_zad
{
    class MageCharacter : RPGCharacter
    {
        private int currentMana;
        private int maxMana;

        public int CurrentMana
        {
            get { return currentMana; }
            set { currentMana = value; }
        }

        public int MaxMana
        {
            get { return maxMana; }
            set { maxMana = value; }
        }
        public MageCharacter(string name, Race race, Gender gender, int maxHealth, int currentHealth, int currentMana, int maxMana) : base(name, race, gender, maxHealth, currentHealth)
        {
            this.currentMana = currentMana;
            this.maxMana = maxMana;
        }

        public void CastSpell(int spellPower)
        {
            int manaCost = spellPower * 2;
            if (currentMana < manaCost)
            {
                Console.WriteLine("У вас мало маны");
            }
            else
            {
                currentMana -= manaCost;
                Console.WriteLine($"Вы можете  произнести заклинание\nВыберите заклинание:");

            }
        }

        public void HealSpell(RPGCharacter target, int spellPower)
        {
            int manaCost = spellPower * 2;
            if (currentMana < manaCost)
            {
                Console.WriteLine("У вас мало маны");
            }
            else
            {
                int healAmount = Math.Min(maxHealth - target.CurrentHealth, spellPower);
                target.CurrentHealth += healAmount;
                currentMana -= manaCost;
                Console.WriteLine($"Вы вылечили {target.Name} на {healAmount}");
            }

        }


    }

}
