using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject currentGO;
    IEnumerator Start()
    {
        yield return null;
        currentGO.transform.SetParent(GameObject.Find("GUICanvas").transform);
    }
}
