using UnityEngine;
using UnityEngine.Events;

using System;
using System.Collections;

[Serializable]
public class DialogueEvents : UnityEvent<DialogueSO, GameObject, DialogueTrigger> { }

