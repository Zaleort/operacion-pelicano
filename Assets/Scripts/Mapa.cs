using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour {
  private Casilla[,] _casillas;
  private int _tamano;

  public Mapa(Casilla[,] casillas, int tamano) {
    _casillas = casillas;
    _tamano = tamano;
  }

  public Casilla[,] Casillas
  { get; set; }

  public int Tamano
  { get; set; }

  void Start() {
    generarCasillas(10);
  }

  public void generarCasillas(int tamano) {
    Casilla[,] casillas = new Casilla[tamano, tamano];
    for (int i = 0; i < casillas.GetLength(0); i++) {
      for (int j = 0; j < casillas.GetLength(1); j++) {
        casillas[i, j] = new Casilla(Terreno.Llanura, null, null, Recurso.Ninguno, 0);
      }
    }
  }
}

