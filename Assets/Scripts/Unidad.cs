using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnidadTipo {
  Ninguno,
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
  [SerializeField] private UnidadTipo[] _tipo;
  [SerializeField] private int _vida;
  [SerializeField] private int _fuerza;
  [SerializeField] private string _nombre;
  [SerializeField] private int _movimiento;
  [SerializeField] private int _distancia;
  [SerializeField] private int _posicion;

  public Unidad(UnidadTipo[] tipo, int vida, int fuerza, string nombre, int movimiento, int distancia, int posicion) {
    this._tipo = tipo;
    this._vida = vida;
    this._fuerza = fuerza;
    this._movimiento = movimiento;
    this._distancia = distancia;
    this._posicion = posicion;
  }

  public UnidadTipo Tipo
  { get; set; }

  public int Vida
  { get; set; }

  public string Nombre
  { get; set; }

  public int Movimiento
  { get; set; }

  public int Distancia
  { get; set; }

  public int Posicion
  { get; set; }
}
