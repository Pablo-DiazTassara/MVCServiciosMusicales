using System;
using System.Collections.Generic;

namespace Entity {
	public class Tecnico {
		private System.Int32 _id;
		private System.String _nombre;
		private System.String _apellido;
		private System.Int32 _dNI;
		private System.String _descripcion;

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

		public System.String Descripcion {
			get {
				return _descripcion;
			}
			set {
				_descripcion = value;
			}
		}

	}
}
