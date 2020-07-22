using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;


namespace SkillCard{
    public class SkillCardDeck{

        private Type type;
        private List<SkillCardModel> cards = new List<SkillCardModel>();

        public static SkillCardDeck createEmptyDeck(Type type) {
            return new SkillCardDeck(type);
        }

        public static SkillCardDeck createInitiatedDeck(Type type){
            SkillCardDeck deck = new SkillCardDeck(type);
            deck.init();
            return deck;
        }

        public void shuffle(){
            Shuffler.shuffleList(cards);
        }

        public void sort() {
            cards.Sort();
        }

        public bool hasEnoughCard(int amount) {
            return amount <= cards.Count;
        }

        public List<SkillCardModel> draw(int amount) {
            List<SkillCardModel> result = new List<SkillCardModel>();
            for (int i = 0; i < amount && cards.Count != 0; i++) {
                result.Add(cards[0]);
                cards.Remove(cards[0]);
            }
            return result;
        }

        public List<SkillCardModel> drawAll() {
            return draw(cards.Count);
        }

        public void addToDeck(SkillCardModel card){
            if (isAcceptableType(card)){
                cards.Add(card);
            }
        }
        public void addToDeck(List<SkillCardModel> cards){
            foreach (var card in cards) {
                addToDeck(card);
            }
        }

        public int cardsLeft() {
            return cards.Count;
        }

        public override string ToString(){
            return $"[Deck({type}), cards: [{cards}]]";
        }

        private SkillCardDeck(Type type) {
            this.type = type;
        }

        private bool isAcceptableType(SkillCardModel card){
            return type == Type.ALL || card.type == type;
        }

        private void init(){
            cards.AddRange(SkillCardModel.createSkillCards(type, 1, 8));
            cards.AddRange(SkillCardModel.createSkillCards(type, 2, 6));
            cards.AddRange(SkillCardModel.createSkillCards(type, 3, 4));
            cards.AddRange(SkillCardModel.createSkillCards(type, 4, 2));
            cards.AddRange(SkillCardModel.createSkillCards(type, 5, 1));
            shuffle();
        }




    }
}