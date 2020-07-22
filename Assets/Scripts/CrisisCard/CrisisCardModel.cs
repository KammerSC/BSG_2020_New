using SkillCard;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skillcheck{
    public class CrisisCardModel {

        List<SkillCardModel> playedCards = new List<SkillCardModel>(); 

        public bool[] colors = new bool[5];
        public int power = 0;

        public static CrisisCardModel createCrisisCard(CrisisCardType typeCard) {
            CrisisCardModel card = new CrisisCardModel();
            card.power = typeCard.getPower();
            card.colors = typeCard.getColors();
            return card;
        }

        private CrisisCardModel() {}

        public void addToPile(List<SkillCardModel> cards) {
            playedCards.AddRange(cards);
        }

        public List<SkillCardModel> returnCards() {
            List<SkillCardModel> pile = new List<SkillCardModel>();
            pile.AddRange(playedCards);
            playedCards.Clear();
            return pile;
        }

        public int calculateCardPowerSum() {
            int result = 0;
            foreach (var card in playedCards) {
                if (colors[(int)card.type]){
                    result += card.power;
                }
                else {
                    result -= card.power;
                }
            }
            return result;
        }

        public bool isResolved() {
            return power < calculateCardPowerSum();
        }
    }
}