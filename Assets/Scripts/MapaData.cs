using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MapaData", menuName = "ScriptableObjects", order = 1)]
public class MapaData : ScriptableObject {
  public GameObject[,] Casillas;

  public MapaData(GameObject[,] _casillas) {
    Casillas = _casillas;
  }
}
