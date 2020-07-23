using SkillCard;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class Character 
    {

        SkillSet skillSet = SkillSet.getHelo();

        public int getSkillCardAmount(Type type) {
            return skillSet.getSkillTypeAmount(type);
        }
    }
}