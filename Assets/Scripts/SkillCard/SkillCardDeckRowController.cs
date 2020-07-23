using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SkillCard
{
    public class SkillCardDeckRowController : MonoBehaviour{

        public SkillCardDeckRowView view;

        SkillCardDeckRowModel model = new SkillCardDeckRowModel();

        public List<SkillCardModel> drawSkillSet(Character character) {
            List<SkillCardModel> skillSet = new List<SkillCardModel>();
            skillSet.AddRange(drawCards(Type.YELLOW, character.getSkillCardAmount(Type.YELLOW)));
            skillSet.AddRange(drawCards(Type.GREEN, character.getSkillCardAmount(Type.GREEN)));
            skillSet.AddRange(drawCards(Type.PURPLE, character.getSkillCardAmount(Type.PURPLE)));
            skillSet.AddRange(drawCards(Type.BLUE, character.getSkillCardAmount(Type.BLUE)));
            skillSet.AddRange(drawCards(Type.RED, character.getSkillCardAmount(Type.RED)));
            return skillSet;
        }

        public List<SkillCardModel> drawCards(Type type, int amount) {
            List < SkillCardModel > result = model.drawCards(type, amount);
            setView();
            return result;
        }

        public List<SkillCardModel> drawDestiny() {
            List<SkillCardModel> result = model.drawDestiny();
            setView();
            return result;
        }

        public void throwUsedCards(List<SkillCardModel> cards) {
            model.throwCards(cards);
            setView();
        }

        private void setView() {
            view.setView(model);
        }

        // Start is called before the first frame update
        void Start()
        {
            model.init();
            setView();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
