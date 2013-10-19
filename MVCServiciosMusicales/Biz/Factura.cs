using System;
using System.Collections.Generic;

namespace Entity {
	public class Factura {
		private System.Int32 _numero;
		private System.DateTime _fecha;
		private Servicio _servicio;
		private Sucursal _sucursar;
		private System.Int32 _monto;

		public System.Int32 Numero {
			get {
				return _numero;
			}
			set {
				_numero = value;
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

		public Servicio Servicio {
			get {
				return _servicio;
			}
			set {
				_servicio = value;
			}
		}

		public Sucursal Sucursar {
			get {
				return _sucursar;
			}
			set {
				_sucursar = value;
			}
		}

		public System.Int32 Monto {
			get {
				return _monto;
			}
			set {
				_monto = value;
			}
		}

	}
}
