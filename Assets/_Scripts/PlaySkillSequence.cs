using Flux;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlaySkillSequence : MonoBehaviour
{
    private FSequence fSequence;
    private void Awake()
    {
        GameObject gameObject = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/_Resources/_SkillPrefabs/Sequence_000.prefab");
        fSequence = Instantiate(gameObject).GetComponent<FSequence>();
        

    }

    private void Start()
    {
        fSequence.Play();
    }
}
