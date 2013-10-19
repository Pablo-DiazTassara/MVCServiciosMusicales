using System;
using System.Collections.Generic;

namespace Entity {
	public class Sucursal {
		private System.Int32 _id;
		private System.String _zona;
		private System.String _descripcion;

		public System.Int32 Id {
			get {
				return _id;
			}
			set {
				_id = value;
			}
		}

		public System.String Zona {
			get {
				return _zona;
			}
			set {
				_zona = value;
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
