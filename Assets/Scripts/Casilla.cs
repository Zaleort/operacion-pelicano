using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TerrenoTipo {
  Llanura,
  Bosque,
  Colina,
  Montana,
  Rio
}

public enum RecursoTipo {
  Ninguno,
  Metal,
  Energia
}

public class Casilla : MonoBehaviour {
  [SerializeField] private TerrenoTipo _terreno;
  [SerializeField] private Edificio _edificio;
  [SerializeField] private Unidad _unidad;
  [SerializeField] private RecursoTipo _recurso;
  [SerializeField] private int _posicion;

  public Casilla(TerrenoTipo terreno, Unidad unidad, Edificio edificio, RecursoTipo recurso, int posicion) {
    _terreno = terreno;
    _unidad = unidad;
    _edificio = edificio;
    _recurso = recurso;
    _posicion = posicion;
  }

  public TerrenoTipo Terreno
  { get; set; }

  public Unidad Unidad {
    get { return _unidad; }
    set { 
      _unidad = value;
      _unidad.Posicion = _posicion;
    }
  }

  public RecursoTipo Recurso
  { get; set; }

  public Edificio Edificio {
    get => _edificio;
    set {
      _edificio = value;
      _edificio.Posicion = _posicion;
    }
  }

  public int Posicion
  { get; set; }
}
