using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SkillCheck
{
    public class SkillCheckModel 
    {
        SkillCheckStateMachine state = new SkillCheckStateMachine();
        int win = 0;
        int lose = 0;

        public SkillCheckState getCurrentState() {
            return state.getState();
        }

        public void nextState() {
            state.next();
        }
        public void incWin()
        {
            win++;
        }
        public void incLose() {
            lose++;
        }

        public int getWin() {
            return win;
        }
        public int getLose()
        {
            return lose;
        }
    }
}