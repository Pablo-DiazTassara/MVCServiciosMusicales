using System;
using System.Collections.Generic;

namespace Entity {
	public class Servicio {
		private System.Int32 _id;
		private System.String _descripcion;
		private System.Int32 _costo;
		private Piezas _piezas;
		private System.DateTime _garantia;
		private TipoServicio _tipo;
		private Instrucciones _istrucciones;
		private System.DateTime _fecha;
		private Estado _estado;
		private System.Int32 _fechaProxRev;
		private Tecnico _tecnico;
		private InstrumentoMusical _instrumento;

		public System.Int32 Id {
			get {
				return _id;
			}
			set {
				_id = value;
			}
		}

		public System.String Descripcion {
			get {
				return _descripcion;
			}
			set {
				_descripcion = value;
			}
		}

		public System.Int32 Costo {
			get {
				return _costo;
			}
			set {
				_costo = value;
			}
		}

		public Piezas Piezas {
			get {
				return _piezas;
			}
			set {
				_piezas = value;
			}
		}

		public System.DateTime Garantia {
			get {
				return _garantia;
			}
			set {
				_garantia = value;
			}
		}

		public TipoServicio Tipo {
			get {
				return _tipo;
			}
			set {
				_tipo = value;
			}
		}

		public Instrucciones Istrucciones {
			get {
				return _istrucciones;
			}
			set {
				_istrucciones = value;
			}
		}

		public System.DateTime Fecha {
			get {
				return _fecha;
			}
			set {
				_fecha = value;
			}
		}

		public Estado Estado {
			get {
				return _estado;
			}
			set {
				_estado = value;
			}
		}

		public System.Int32 FechaProxRev {
			get {
				return _fechaProxRev;
			}
			set {
				_fechaProxRev = value;
			}
		}

		public Tecnico Tecnico {
			get {
				return _tecnico;
			}
			set {
				_tecnico = value;
			}
		}

		public InstrumentoMusical Instrumento {
			get {
				return _instrumento;
			}
			set {
				_instrumento = value;
			}
		}

	}
}
