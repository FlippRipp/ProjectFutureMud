using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ActorTags), typeof(ActorAppearance))]
public class Actor : MonoBehaviour
{
    public ActorTags actorTags;
    public ActorAppearance actorAppearance;

    public string actorIDName;
    public string actorDisplayName;
}