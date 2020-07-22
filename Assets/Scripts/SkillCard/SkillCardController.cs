using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillCard{
    public class SkillCardController : MonoBehaviour{

        public SkillCardModel model;
        public SkillCardView view;



        public void setView() {
            view.setView(model);
        }

        public bool isSelected() {
            return view.isSelected();
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