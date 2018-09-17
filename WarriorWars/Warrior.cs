using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        private int goodGuyStrartingHealth;
        private int badGuyStartingHealth;

        private Faction faction;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.faction = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = goodGuyStrartingHealth;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = badGuyStartingHealth;
                    break;
                default:
                    break;
            }
        }
    }
}
