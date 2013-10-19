using System;
using System.Collections.Generic;

namespace Entity {
	public class InstrumentoMusical {
		private System.Int32 _id;
		private System.String _nombre;
		private TipoInstrumento _tipo;
		private System.String _estado;
		private System.DateTime _antiguedad;

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

		public TipoInstrumento Tipo {
			get {
				return _tipo;
			}
			set {
				_tipo = value;
			}
		}

		public System.String Estado {
			get {
				return _estado;
			}
			set {
				_estado = value;
			}
		}

		public System.DateTime Antiguedad {
			get {
				return _antiguedad;
			}
			set {
				_antiguedad = value;
			}
		}

	}
}
