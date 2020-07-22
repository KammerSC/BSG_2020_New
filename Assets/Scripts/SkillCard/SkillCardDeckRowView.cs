using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SkillCard{
    public class SkillCardDeckRowView : MonoBehaviour{

        public Text politics;
        public Text leadership;
        public Text tactics;
        public Text engineering;
        public Text piloting;
        public Text destiny;
        public Text usedPile;

        public void setView(SkillCardDeckRowModel model) {
            politics.text = model.getSkillDeckSize(Type.YELLOW).ToString();
            leadership.text = model.getSkillDeckSize(Type.GREEN).ToString();
            tactics.text = model.getSkillDeckSize(Type.PURPLE).ToString();
            engineering.text = model.getSkillDeckSize(Type.BLUE).ToString();
            piloting.text = model.getSkillDeckSize(Type.RED).ToString();
            destiny.text = model.getDestinySize().ToString();
            usedPile.text = model.getUsedPileSize().ToString();
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
