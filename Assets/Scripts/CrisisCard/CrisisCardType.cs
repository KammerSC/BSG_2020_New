using System;
using System.Collections.Generic;
using UnityEngine;


namespace Skillcheck{
    public class CrisisCardType{

        public static CrisisCardType EASY = new CrisisCardType(5,7,4);
        public static CrisisCardType MEDIUM = new CrisisCardType(8, 10, 3);
        public static CrisisCardType HARD = new CrisisCardType(11, 13, 2);
        public static CrisisCardType SUPER = new CrisisCardType(14, 20, 4);

        private int lowerPowerLimit;
        private int upperPowerLimit;
        

        public int colorCount;

        private CrisisCardType(int lowerPowerLimit, int upperPowerLimit, int colorCount) {
            this.lowerPowerLimit = lowerPowerLimit;
            this.upperPowerLimit = upperPowerLimit;
            this.colorCount = colorCount;
        }

        public int getPower() {
            float rnd = UnityEngine.Random.Range(lowerPowerLimit-0.5f, upperPowerLimit+0.4f);
            return Mathf.RoundToInt(rnd);
        }

        public bool[] getColors() {
            bool[] result = new bool[5];
            List<int> colorIndex = getColorIndexes();
            setColors(result, colorIndex, colorCount);
            return result;
        }

        private List<int> getColorIndexes(){
            return randomizeOrder(new List<int> { 0, 1, 2, 3, 4});
        }

        private List<int> randomizeOrder(List<int> nums){
            for (int i = 0; i < nums.Count; i++) {
                switchElements(nums, i, Mathf.RoundToInt(UnityEngine.Random.Range(i-0.5f, nums.Count-1+0.4f)));
            }
            return nums;
        }

        private void switchElements(List<int> nums, int i, int j) {
            int temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }

        private void setColors(bool[] result, List<int> colorIndex, int count){
            for (int i = 0; i < count; i++) {
                result[colorIndex[i]] = true;
            }            
        }

    }
}