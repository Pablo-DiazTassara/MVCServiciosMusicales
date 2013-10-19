using System;
using System.Collections.Generic;

namespace Entity {
	public class Direccion {
		private System.Int32 _id;
		private System.String _calle;
		private System.Int16 _numero;

		public System.Int32 Id {
			get {
				return _id;
			}
			set {
				_id = value;
			}
		}

		public System.String Calle {
			get {
				return _calle;
			}
			set {
				_calle = value;
			}
		}

		public System.Int16 Numero {
			get {
				return _numero;
			}
			set {
				_numero = value;
			}
		}

	}
}
