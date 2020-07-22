using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Skillcheck {
    public class CrisisCardView : MonoBehaviour{

        public Text power;
        public GameObject yellow;
        public GameObject green;
        public GameObject purple;
        public GameObject red;
        public GameObject blue;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void renderCrisisCard(CrisisCardModel card) {
            yellow.SetActive(card.colors[0]);
            green.SetActive(card.colors[1]);
            purple.SetActive(card.colors[2]);
            red.SetActive(card.colors[3]);
            blue.SetActive(card.colors[4]);
            power.text = card.power.ToString();
        }
    }
}


