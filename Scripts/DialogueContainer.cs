using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/Dialogue/Dialogue_")]

public class DialogueContainer : ScriptableObject
{
    public List<string> line;
    public Actor actor;
}
