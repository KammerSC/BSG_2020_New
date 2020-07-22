using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Utils { 
    public class Shuffler {
        private static System.Random RND = new System.Random();

        public static void shuffleList<T>(IList<T> list) {
            for (int i = list.Count-1; i > 0; i--) {
                switchElements(list, i, RND.Next(0, i + 1));
            }
        }

        private static void switchElements<T>(IList<T> list, int i, int j) {
            T tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }
    }
}