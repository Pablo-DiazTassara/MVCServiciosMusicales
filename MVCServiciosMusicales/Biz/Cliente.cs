using System;
using System.Collections.Generic;

namespace Entity {
	public class Cliente {
		private System.Int32 _id;
		private System.String _nombre;
		private System.String _apellido;
		private System.Int32 _dNI;
		private System.Int32 _telefono;
		private System.String _email;
		private Direccion _direccion;
		private TipoCliente _tipo;
		private InstrumentoMusical _instrumento;

		public System.Int32 Id {
			get {
				return _id;
			}
			set {
				_id = value;
			}
		}

		public System.String Nombre {
			get {
				return _nombre;
			}
			set {
				_nombre = value;
			}
		}

		public System.String Apellido {
			get {
				return _apellido;
			}
			set {
				_apellido = value;
			}
		}

		public System.Int32 DNI {
			get {
				return _dNI;
			}
			set {
				_dNI = value;
			}
		}

		public System.Int32 Telefono {
			get {
				return _telefono;
			}
			set {
				_telefono = value;
			}
		}

		public System.String Email {
			get {
				return _email;
			}
			set {
				_email = value;
			}
		}

		public Direccion Direccion {
			get {
				return _direccion;
			}
			set {
				_direccion = value;
			}
		}

		public TipoCliente Tipo {
			get {
				return _tipo;
			}
			set {
				_tipo = value;
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
