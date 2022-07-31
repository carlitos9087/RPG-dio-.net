
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Character
    {
    public Character(string playername,string charactername, string type,  string race, int level, int age, string alignment, int hp,string weapons,string masteredSpells, string equipment)

    {
        this.playername = playername;
        this.charactername = charactername;
        this.type = type;
        this.race = race;
        this.level = level;
        this.age = age;
        this.alignment = alignment;
        this.hp = hp;
        this.weapons = weapons;
        this.masteredSpells = masteredSpells;
        this.equipment = equipment;
    }
  
  public override string ToString()
  {
    return this.playername + " " + this.charactername + " " + this.type + " " + this.race + " " + this.level + " " + this.age + " " + this.alignment + " " + this.hp + " " + this.weapons + " " + this.masteredSpells + " " + this.equipment;
  }

        public string playername { get; set; }
        public string charactername { get; set; }
        public string type { get; set; }
        public string race { get; set; }
        public int level { get; set; }
        public int age { get; set; }
        public string alignment { get; set; }
        public int hp { get; set; }
        public string weapons { get; set; }
        public string masteredSpells { get; set; }
        public string equipment { get; set; }

    }
}