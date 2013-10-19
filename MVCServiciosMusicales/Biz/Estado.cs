using System;
using System.Collections.Generic;

namespace Entity {
	public class Estado {
		private System.Int32 _id;
		private System.String _descripcion;

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

	}
}
