using SkillCard;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Type = SkillCard.Type;
namespace SkillCard
{
    public class SkillCardDeckRowModel
    {
        Dictionary<SkillCard.Type, SkillCardDeck> skillCards = new Dictionary<SkillCard.Type, SkillCardDeck>();
        SkillCardDeck destiny = SkillCardDeck.createEmptyDeck(SkillCard.Type.ALL);
        SkillCardDeck usedCards = SkillCardDeck.createEmptyDeck(SkillCard.Type.ALL);

        public void init(){
            initSkillRow();
            initNewDestiny();
        }

        public void initNewDestiny(){
            destiny.addToDeck(skillCards[Type.BLUE].draw(2));
            destiny.addToDeck(skillCards[Type.GREEN].draw(2));
            destiny.addToDeck(skillCards[Type.PURPLE].draw(2));
            destiny.addToDeck(skillCards[Type.RED].draw(2));
            destiny.addToDeck(skillCards[Type.YELLOW].draw(2));
            destiny.shuffle();
        }

        public List<SkillCardModel> drawCards(Type type, int amount){
            if (!skillCards[type].hasEnoughCard(amount)){
                shuffleUsedBack();
            }
            return skillCards[type].draw(amount);
        }

        public List<SkillCardModel> drawDestiny(){
            if (destiny.cardsLeft() == 0) {
                shuffleUsedBack();
                initNewDestiny();
            }
            return destiny.draw(2);
        }


        public void throwCard(SkillCardModel card){
            usedCards.addToDeck(card);
        }

        public void throwCards(List<SkillCardModel> cards){
            usedCards.addToDeck(cards);
        }

        public int getSkillDeckSize(Type type) {
            return skillCards[type].cardsLeft();
        }

        public int getDestinySize() {
            return destiny.cardsLeft();
        }

        public int getUsedPileSize() {
            return usedCards.cardsLeft();
        }


        private void initSkillRow(){
            fillDecks();
            shuffleDecks();
        }

        private void fillDecks(){
            skillCards[SkillCard.Type.BLUE] = SkillCardDeck.createInitiatedDeck(SkillCard.Type.BLUE);
            skillCards[SkillCard.Type.GREEN] = SkillCardDeck.createInitiatedDeck(SkillCard.Type.GREEN);
            skillCards[SkillCard.Type.PURPLE] = SkillCardDeck.createInitiatedDeck(SkillCard.Type.PURPLE);
            skillCards[SkillCard.Type.RED] = SkillCardDeck.createInitiatedDeck(SkillCard.Type.RED);
            skillCards[SkillCard.Type.YELLOW] = SkillCardDeck.createInitiatedDeck(SkillCard.Type.YELLOW);
        }

        private void shuffleDecks(){
            foreach (var sd in skillCards.Values){
                sd.shuffle();
            }
        }

        private void shuffleUsedBack(){
            usedCards.shuffle();
            foreach (var card in usedCards.drawAll()){
                skillCards[card.type].addToDeck(card);
            }
        }

    }
}
