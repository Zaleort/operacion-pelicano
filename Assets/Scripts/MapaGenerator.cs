using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaGenerator : MonoBehaviour {
  [SerializeField] private int _tamano;
  [SerializeField] private GameObject _mapa;
  [SerializeField] private GameObject _casilla;
  [SerializeField] private MapaData _mapaData;

  public MapaGenerator(GameObject mapa, GameObject casilla, MapaData mapaData, int tamano) {
    _mapa = mapa;
    _casilla = casilla;
    _tamano = tamano;
    _mapaData = mapaData;
  }

  public int Tamano
  { get; set; }

  public GameObject Mapa
  { get; set; }

  public GameObject Casilla
  { get; set; }

  public MapaData MapaData
  { get; set; }

  void Start() {
    generarMapa(3);
  }

  public void generarMapa(int tamano) {
    GameObject[,] casillas = new GameObject[tamano, tamano];
    MapaData.Casillas = casillas;
    for (int i = 0; i < casillas.GetLength(0); i++) {
      for (int j = 0; j < casillas.GetLength(1); j++) {
        GameObject casillaObject = Instantiate(Casilla, new Vector3(j * 32, i * 32, 0), Quaternion.identity, Mapa.transform);
        Casilla casillaComponent = casillaObject.GetComponent(typeof(Casilla)) as Casilla;
        casillaComponent.Posicion = i * tamano + j;
        casillaComponent.Terreno = TerrenoTipo.Llanura;
        MapaData.Casillas[i, j] = casillaObject;
      }
    }
  }
}
