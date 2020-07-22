using SkillCard;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player{
    public class PlayerController : MonoBehaviour{

        public PlayerView view;

        public void displayCard(List<SkillCardModel> cards){
            view.addToHand(cards);
        }

        public List<SkillCardModel> getSelectedCards() {
            return view.getSelectedCards();
        }

        public List<SkillCardModel> getDestroyedCards(){
            return view.destroyCards();
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
