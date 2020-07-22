using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace SkillCheck
{
    public class SkillCheckView : MonoBehaviour
    {

        public Text stateTitle;
        public Text stateDescription;
        public Text win;
        public Text lose;

        public GameObject crisisCard;

        public void displayCrisisCard(bool state) {
            crisisCard.SetActive(state);
        }

        public void setWinLose(int win, int lose) {
            this.win.text = "Wins: " + win;
            this.lose.text = "Lose: " + lose;
        }

        public void setStateDescAndTitle(SkillCheckState state) {
            switch (state) {
                case SkillCheckState.SELECT_CRISIS: selectCrisisPhase(); break;
                case SkillCheckState.PLAY_BEFORE_SKILLCARD: playBeforeDrawPhase(); break;
                case SkillCheckState.DRAW_DESTINY: drawDestiny(); break;
                case SkillCheckState.ADD_SKILLCARDS: addToPile(); break;
                case SkillCheckState.CALCULATE_RESULT: calculateCurrentResult(); break;
                case SkillCheckState.PLAY_AFTER_SKILLCARD: playAfterCard(); break;
                case SkillCheckState.CALCULATE_FINAL_RESULT: finalResult(); break;
                case SkillCheckState.CARRY_OUT_OUTCOME: carryOutOutcome(); break;
                case SkillCheckState.DISCARD_CARDS: discardCards(); break;
            }
        }

        public void setDescription(string msg) {
            stateDescription.text = msg;
        }

        private void selectCrisisPhase() {
            stateTitle.text = "Revealing Skillcheck";
            stateDescription.text = "Skillcheck.";
            crisisCard.SetActive(true);
        }

        private void playBeforeDrawPhase() {
            stateTitle.text = "Play before phase";
            stateDescription.text = "Not implemented";
        }

        private void drawDestiny() {
            stateTitle.text = "Draw Destiny";
            stateDescription.text = "Two card from the destiny deck added to the pile.";
        }

        private void addToPile() {
            stateTitle.text = "Add to pile";
            stateDescription.text = "Add the selected cards to pile.";
        }

        private void calculateCurrentResult() {
            stateTitle.text = "Current result";
            stateDescription.text = "";
        }

        private void playAfterCard(){
            stateTitle.text = "Play after phase";
            stateDescription.text = "Not implemented";
        }
        private void finalResult() {
            stateTitle.text = "Final result";
            stateDescription.text = "";
        }

        private void carryOutOutcome() {
            stateTitle.text = "Carry out outcome";
            stateDescription.text = "Not implemented.";
            crisisCard.SetActive(false);
        }

        private void discardCards() {
            stateTitle.text = "Discard cards";
            stateDescription.text = "Discarding skillcards not implemented.";
        }



        // Start is called before the first frame update
        void Start()
        {
            crisisCard.SetActive(false);
            setWinLose(0, 0);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
