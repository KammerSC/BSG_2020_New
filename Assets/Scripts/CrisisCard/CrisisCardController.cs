using SkillCard;
using System.Collections.Generic;
using UnityEngine;
namespace Skillcheck
{
    public class CrisisCardController : MonoBehaviour
    {
        public CrisisCardView view;
        CrisisCardModel model;

        public void AddToPile(List<SkillCardModel> cards) {
            model.addToPile(cards);
        }

        public List<SkillCardModel> returnPlayedCards() {
            return model.returnCards();
        }

        public int calculateResult() {
            return model.calculateCardPowerSum();
        }

        public bool isResolved(){
            return model.isResolved();
        }


        public void setNewEasy() {
            model = CrisisCardModel.createCrisisCard(CrisisCardType.EASY);
            view.renderCrisisCard(model);
        }

        public void setNewMedium(){
            model = CrisisCardModel.createCrisisCard(CrisisCardType.MEDIUM);
            view.renderCrisisCard(model);
        }

        public void setNewHard(){
            model = CrisisCardModel.createCrisisCard(CrisisCardType.HARD);
            view.renderCrisisCard(model);
        }

        public void setNewSuper(){
            model = CrisisCardModel.createCrisisCard(CrisisCardType.SUPER);
            view.renderCrisisCard(model);
        }

        private void renderView() {
            view.renderCrisisCard(model);
        }
    }
}