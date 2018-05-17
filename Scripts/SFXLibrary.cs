using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//[CreateAssetMenu(fileName = "New Library", menuName = "Libraries/SFX Library", order = 0)]
public class SFXLibrary
{
    public Queue<string> entriesBuffer;
    [SerializeField] protected List<SFX> library = new List<SFX>();
    public int Count { get { return library.Count; } }

    public SFX Add()
    {
        SFX returnValue = new SFX();
        library.Add(returnValue);
        return returnValue;
    }
    public SFX Add(string tag, AudioClip audio)
    {
        SFX returnValue = new SFX(tag, audio);
        library.Add(returnValue);
        return returnValue;
    }
    public SFX Get(string tag)
    {
        foreach (SFX sfx in library)
        {
            if (sfx.tag == tag)
            {
                return sfx;
            }
        }
        Debug.Log("Sound Effect not found in the library!");
        return default(SFX);
    }
    public SFX Get(int index)
    {
        if (library.Count != 0 && index < library.Count)
        {
            return library[index];
        }
        else
        {
            Debug.Log("Sound Effect not found in the library!");
        }
        return default(SFX);
    }
    public void Remove(string tag)
    {
        for (int i = 0; i < library.Count; i++)
        {
            if (library[i].tag == tag)
            {
                library.RemoveAt(i);
                return;
            }
        }
        Debug.Log("Sound Effect not found in the library!");
    }
    public void Remove(int index)
    {
        if (library.Count != 0 && index < library.Count)
        {
            library.RemoveAt(index);
        }
        else
        {
            Debug.Log("Sound Effect not found in the library!");
        }
    }
    public void Clear()
    {
        library.Clear();
    }
}