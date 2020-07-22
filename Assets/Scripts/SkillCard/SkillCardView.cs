using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SkillCard{
    public class SkillCardView : MonoBehaviour{

        public SpriteRenderer cardRenderer;
        public SpriteRenderer powerRenderer;
        public Sprite[] sprites = new Sprite[5];

        bool selected = false;

        public void setView(SkillCardModel card) {
            setPower(card.power);
            setColor(card.type);
        }

        private void setPower(int power) {
            powerRenderer.sprite = sprites[power - 1];
        }

        private void setColor(SkillCard.Type type) {
            cardRenderer.color = selectColor(type);;
        }

        private static Color selectColor(Type type){
            Color color;
            switch (type) {
                case Type.BLUE: color = Color.blue; break;
                case Type.GREEN: color = Color.green; break;
                case Type.PURPLE: color = Color.magenta; break;
                case Type.RED: color = Color.red; break;
                case Type.YELLOW: color = Color.yellow; break;
                default: color = Color.white; break;
            }
            return color;
        }

        public bool isSelected() {
            return selected;
        }

        void OnMouseDown()
        {
            if (selected) {
                transform.position = new Vector3(transform.position.x, transform.position.y - 1f);
                selected = false;
            }
            else{
                transform.position = new Vector3(transform.position.x, transform.position.y + 1f);
                selected = true;
            }
        }

        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}