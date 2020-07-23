using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class SkillSet 
    {
        private static SkillSet LAURA = new SkillSet(3, 2, 0, 0, 0);
        private static SkillSet ADAMA = new SkillSet(0, 3, 2, 0, 0);
        private static SkillSet HELO = new SkillSet(0, 2, 2, 1, 0);

        
        Dictionary<SkillCard.Type, int> skillset = new Dictionary<SkillCard.Type, int>();


        public static SkillSet getLaura() {
            return LAURA;
        }
        public static SkillSet getAdama(){
            return ADAMA;
        }
        public static SkillSet getHelo(){
            return HELO;
        }

        public int getSkillTypeAmount(SkillCard.Type type) {
            return skillset[type];
        }

        private SkillSet(int yellow, int green, int purple, int blue, int red) {
            skillset[SkillCard.Type.YELLOW] = yellow;
            skillset[SkillCard.Type.GREEN] = green;
            skillset[SkillCard.Type.PURPLE] = purple;
            skillset[SkillCard.Type.BLUE] = blue;
            skillset[SkillCard.Type.RED] = red;
        }



    }
}
