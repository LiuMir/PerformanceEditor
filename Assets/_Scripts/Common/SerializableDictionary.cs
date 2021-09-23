﻿using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SerializableDictionary<TKey, TValue>: Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
    [SerializeField]
    private List<TKey> keys = new List<TKey>();
    [SerializeField]
    private List<TValue> values = new List<TValue>();

    public void OnAfterDeserialize()
    {
        Clear();
        int count = Mathf.Min(keys.Count, values.Count);
        for (int i = 0; i < count; ++i)
        {
            if (!ContainsKey(keys[i]))
            {
                Add(keys[i], values[i]);
            }
        }
    }

    public void OnBeforeSerialize()
    {
    }

    public void ClearList()
    {
        keys.Clear();
        values.Clear();
    }

    public void AddKeyAndValue(TKey key, TValue value)
    {
        keys.Add(key);
        values.Add(value);
    }
}

[System.Serializable]
public class SerializableStringGameObjectDictionary: SerializableDictionary<string, GameObject> { }

[System.Serializable]
public class SerializableFluxParamDictionary : SerializableDictionary<string, ContainParamBase> { }