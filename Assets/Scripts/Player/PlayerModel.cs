using SkillCard;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class PlayerModel
    {
        Character character = new Character();

        public Character GetCharacter() {
            return character;
        }
    }
}
