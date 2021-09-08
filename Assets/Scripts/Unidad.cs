using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnidadTipo {
  Civil,
  Militar,
  Humanoide,
  Mecanizada,
  Voladora,
  Artillería,
  Antiaerea,
  Antiblindado,
}

public class Unidad : MonoBehaviour {
  private UnidadTipo[] _tipo;
  private int _vida;
  private int _fuerza;
  private string _nombre;
  private int _movimiento;
  private int _distancia;
  private int _posicion;

  public Unidad(UnidadTipo[] tipo, int vida, int fuerza, string nombre, int movimiento, int distancia, int posicion) {
    _tipo = tipo;
    _vida = vida;
    _fuerza = fuerza;
    _movimiento = movimiento;
    _distancia = distancia;
    _posicion = posicion;
  }

  public int Posicion
  { get; set; }
}
