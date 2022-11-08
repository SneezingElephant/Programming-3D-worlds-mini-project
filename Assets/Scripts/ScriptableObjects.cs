using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjects : MonoBehaviour
{
    [CreateAssetMenu(
 menuName = "Variables/Int Variable",
 fileName = "IntVariable")]
    public class IntVariable : ScriptableObject
    {
        public int value;
    }

}
