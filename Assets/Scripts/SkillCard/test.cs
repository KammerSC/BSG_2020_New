using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;


namespace SkillCard{
    public class test : MonoBehaviour{

        // Start is called before the first frame update
        void Start(){
            SkillCardDeck deck = SkillCardDeck.createInitiatedDeck(Type.YELLOW);
            deck.shuffle();
            deck.sort();
            ;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
