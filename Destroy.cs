using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //блок выполняется в первом кадре после запуска сцены
    void Start()
    {
        Destroy(gameObject); //удаление объекта со сцены
    }
}
