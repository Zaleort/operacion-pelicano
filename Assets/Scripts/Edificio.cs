using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EdificioTipo {
  Ninguno,
  Nexo,
  Construccion,
  Recoleccion,
  Investigacion,
  Defensa,
}

public class Edificio : MonoBehaviour {
  [SerializeField] private EdificioTipo[] _tipo;
  [SerializeField] private int _vida;
  [SerializeField] private int _fuerza;
  [SerializeField] private string _nombre;
  [SerializeField] private int _posicion;
  [SerializeField] private int _distancia;

  public Edificio(EdificioTipo[] tipo, int vida, int fuerza, string nombre, int posicion, int distancia) {
    _tipo = tipo;
    _vida = vida;
    _fuerza = fuerza;
    _nombre = nombre;
    _posicion = posicion;
    _distancia = distancia;
  }

  public EdificioTipo Tipo
  { get; set; }

  public int Vida
  { get; set; }

  public int Fuerza
  { get; set; }

  public string Nombre
  { get; set; }

  public int Distancia
  { get; set; }

  public int Posicion
  { get; set; }
}
