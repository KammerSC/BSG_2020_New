using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillCheck{
    public class SkillCheckStateMachine{

        SkillCheckState currentState = SkillCheckState.SELECT_CRISIS;

        public void next() {
            if (currentState == SkillCheckState.DISCARD_CARDS){
                currentState = 0;
            }
            else {
                currentState++;
            }
        
        }

        public SkillCheckState getState() {
            return currentState;
        }
    }
}
