using System;
using System.Collections.Generic;

namespace Entity {
	public class Piezas {
		private System.Int32 _id;
		private System.String _descripcion;
		private System.Int32 _costo;

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

	}
}
