using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Terreno {
  Llanura,
  Bosque,
  Colina,
  Montana,
  Rio
}

public enum Recurso {
  Ninguno,
  Metal,
  Energia
}

public class Casilla : MonoBehaviour {
  private Terreno _terreno;
  private Unidad _unidad;
  private Edificio _edificio;
  private Recurso _recurso;
  private int _posicion;

  public Casilla(Terreno terreno, Unidad unidad, Edificio edificio, Recurso recurso, int posicion) {
    _terreno = terreno;
    _unidad = unidad;
    _edificio = edificio;
    _recurso = recurso;
    _posicion = posicion;
  }

  public Terreno Terreno
  { get; set; }

  public Unidad Unidad {
    get { return _unidad; }
    set { 
      _unidad = value;
      _unidad.Posicion = _posicion;
    }
  }

  public Edificio Edificio {
    get => _edificio;
    set {
      _edificio = value;
      _edificio.Posicion = _posicion;
    }
  }
}
