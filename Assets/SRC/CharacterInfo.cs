using System.Collections;
using UnityEngine;

public class CharacterInfo {

    public int Level { get; set; }
    public int HP { get; set; }
    public CharacterInfo() { }
    public CharacterInfo(int level, int hp) {
        Level = level;
        HP = hp;

    }
}
