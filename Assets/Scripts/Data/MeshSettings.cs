using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class MeshSettings : UpdatableData {

    public const int numSuppportedLODs = 5;
    public const int numSupportedChunkSizes = 9;
    public const int numSupportedFlatShadedChunkSizes = 3;
    public static readonly int[] supportedChunkSizes = { 48, 72, 96, 120, 144, 168, 192, 216, 240 };

    public float meshScale = 2.5f;
    public bool useFlatShading;

    [Range(0, numSupportedChunkSizes - 1)]
    public int chunkSizeIndex;
    [Range(0, numSupportedFlatShadedChunkSizes - 1)]
    public int flatShadedChunkSizeIndex;

    /* max 65000 vertex for a single mesh
     * 240 (minus 1) because 240 is divisible by all pairs until 12
     * only supported : 
     * 0
     * 24
     * 48
     * 72
     * 96
     * 120
     * 144
     * 168
     * 192
     * 216
     * 240
     */
    // public const int mapChunkSize = 95;

    // num verts per line of mesh rendered at LOD = 0. Includes ths 2 extra verts that excluded from final mesh, but used for calculating normals;
    public int numVertsPerLine {
        get {
            return supportedChunkSizes[(useFlatShading) ? flatShadedChunkSizeIndex : chunkSizeIndex] + 5;
        }
    }

    public float meshWorldSize {
        get {
            return (numVertsPerLine - 3) * meshScale;
        }
    }



}
