using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificio : MonoBehaviour {
  private int _vida;
  private int _fuerza;
  private string _nombre;
  private int _posicion;
  public Edificio(int vida, int fuerza, string nombre, int posicion) {
    _vida = vida;
    _fuerza = fuerza;
    _nombre = nombre;
    _posicion = posicion;
  }

  public int Posicion
  { get; set; }
}
