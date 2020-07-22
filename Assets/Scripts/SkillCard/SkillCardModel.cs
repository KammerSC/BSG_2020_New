using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillCard{
    public class SkillCardModel : IComparable{
        public Type type;
        public int power;

        public static SkillCardModel createSkillCard(Type type, int power) {
            return new SkillCardModel(type, power);
        }

        public static List<SkillCardModel> createSkillCards(Type type, int power, int amount) {
            List<SkillCardModel> cards = new List<SkillCardModel>();
            for (int i = 0; i < amount; i++) {
                cards.Add(new SkillCardModel(type, power));
            }
            return cards;
        }

        public int CompareTo(object obj){
            int result = typeof(SkillCardModel).IsInstanceOfType(obj) ? calcOrder((SkillCardModel)obj) : - 1;
            return result;
        }

        public override string ToString(){
            return $"[{type} , power: {power}]";
        }

        private SkillCardModel(Type type, int power){
            this.type = type;
            this.power = power;
        }

        private int calcOrder(SkillCardModel other) {
            if (other.type > type || other.type == type && other.power > power){
                return -1;
            }
            else if (other.type == type && other.power == power){
                return 0;
            }
            return 1;
        }
    }
}
