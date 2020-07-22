using SkillCard;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class PlayerView : MonoBehaviour
    {
        public GameObject skillcardPrefab;
        List<GameObject> displayedCards = new List<GameObject>();
        List<SkillCardModel> hand = new List<SkillCardModel>();

        public void addToHand(List<SkillCardModel> cards) {
            hand.AddRange(cards);
            destroyCards();
            displayCards();
        }
        private void displayCards() {
            float x = -7f;
            foreach (var card in hand) {
                displayCard(card, new Vector3(x, -3f));
                x += 2.15f;
            }    
        }

        private void displayCard(SkillCardModel card, Vector3 vector) {
            GameObject newCard = Instantiate(skillcardPrefab, vector, Quaternion.identity);
            SkillCardController cont = newCard.GetComponent<SkillCardController>();
            cont.model = card;
            cont.setView();
            displayedCards.Add(newCard);            
        }


        public List<SkillCardModel> destroyCards() {
            List<SkillCardModel> cards = new List<SkillCardModel>();
            while (displayedCards.Count > 0) { 
                SkillCardModel skc = displayedCards[0].GetComponent<SkillCardController>().model;
                cards.Add(skc);
                GameObject go = displayedCards[0];
                displayedCards.RemoveAt(0);
                Destroy(go);
            }
            return cards;
        }

        //itt kerül be egy null
        public List<SkillCardModel> getSelectedCards(){
            List<SkillCardModel> cards = new List<SkillCardModel>();
            List<GameObject> tmp = new List<GameObject>();
            foreach (var card in displayedCards){
                SkillCardController skc = card.GetComponent<SkillCardController>();
                if (skc.isSelected()) {
                    cards.Add(skc.model);
                    hand.Remove(skc.model);
                    tmp.Add(card);
                }
            }
            while (tmp.Count > 0) {
                Destroy(tmp[0]);
                displayedCards.Remove(tmp[0]);
                tmp.RemoveAt(0);
            }
            return cards;
        }

        

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
