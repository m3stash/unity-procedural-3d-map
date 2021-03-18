using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FalloffGenerator {
    // creates a gradient square from black to white to outline the map with water
    public static float[,] GenerateFalloffMap(int size) {
        float[,] map = new float[size, size];

        for(int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                float x = i / (float)size * 2 - 1;
                float y = j / (float)size * 2 - 1;

                float value = Mathf.Max(Mathf.Abs(x), Mathf.Abs(y));
                map[i, j] = Evaluate(value);
            }
        }

        return map;
    }
    static float Evaluate(float value) {
        float a = 3;
        float b = 2.2f;
        // create curve color black to white
        return Mathf.Pow(value, a) / (Mathf.Pow(value, a) + Mathf.Pow(b - b * value, a)); 
    }

}
