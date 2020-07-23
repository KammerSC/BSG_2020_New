using Player;
using SkillCard;
using Skillcheck;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SkillCheck{
    public class SkillCheckController : MonoBehaviour{

        public CrisisCardController crisisController;
        public SkillCardDeckRowController rowController;
        public PlayerController playerController;

        SkillCheckModel model = new SkillCheckModel();
        public SkillCheckView view;

        public void next(){
            switch (model.getCurrentState()){
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
            model.nextState();
        }

        private void selectCrisisPhase(){
            crisisController.setNewMedium();
            view.setStateDescAndTitle(model.getCurrentState());
        }

        private void playBeforeDrawPhase()
        {
            view.setStateDescAndTitle(model.getCurrentState());
        }

        private void drawDestiny(){
            crisisController.AddToPile(rowController.drawDestiny());
            view.setStateDescAndTitle(model.getCurrentState());
            playerController.displayCard(rowController.drawSkillSet(playerController.GetCharacter()));
        }

        private void addToPile()
        {
            view.setStateDescAndTitle(model.getCurrentState());
        }

        private void calculateCurrentResult(){
            crisisController.AddToPile( playerController.getSelectedCards());
            int result = crisisController.calculateResult();
            view.setStateDescAndTitle(model.getCurrentState());
            view.setDescription("Current power of the pile is " + result);
        }

        private void playAfterCard()
        {
            view.setStateDescAndTitle(model.getCurrentState());
        }

        private void finalResult()
        {
            int result = crisisController.calculateResult();
            view.setStateDescAndTitle(model.getCurrentState());
            view.setDescription("Final power of the pile is " + result);
        }

        private void carryOutOutcome()
        {
            view.setStateDescAndTitle(model.getCurrentState());
            if (crisisController.isResolved())
            {
                view.setDescription("Skillcheck succesfully resolved.");
                model.incWin();
            }
            else {
                view.setDescription("Skillcheck failed.");
                model.incLose();
            }
            view.setWinLose(model.getWin(), model.getLose());
        }

        private void discardCards()
        {
            rowController.throwUsedCards(crisisController.returnPlayedCards());
            view.setStateDescAndTitle(model.getCurrentState());
        }

        // Start is called before the first frame update
        void Start(){
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
