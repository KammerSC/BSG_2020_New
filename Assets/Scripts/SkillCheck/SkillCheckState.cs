using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillCheck{
    public enum SkillCheckState{

        SELECT_CRISIS = 0, PLAY_BEFORE_SKILLCARD = 1, DRAW_DESTINY = 2,
        ADD_SKILLCARDS = 3, CALCULATE_RESULT = 4, PLAY_AFTER_SKILLCARD = 5,
        CALCULATE_FINAL_RESULT = 6, CARRY_OUT_OUTCOME = 7, DISCARD_CARDS = 8
    }
}
