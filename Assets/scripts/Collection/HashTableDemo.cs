using UnityEngine;
using System.Collections;

public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hashtable hash = new Hashtable();
        hash[0] = "���ѹα�";
        hash["���̸�"] = "����Ư����";
        hash["���̸�"] = "������";

        foreach(var o in hash.Keys)
        {
            Debug.Log($"{o.ToString()} -{hash[o]}");
        }
        /*Debug.Log(hash[0]);
        Debug.Log(hash["���̸�"]);
        Debug.Log(hash["���̸�"]);*/
    }
}
