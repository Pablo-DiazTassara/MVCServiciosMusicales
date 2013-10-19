using System;
using System.Data;

namespace DAL.Adapters {
	public class FacturaAdapter {

		private DataRow row;

		public FacturaAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Factura _object){
			_object.Numero = (System.Int32)row["Numero"];

			_object.Fecha = (System.DateTime)row["Fecha"];

			_object.Servicio = ServicioFacade.GetAdapted((System.Int32)row["Servicio_Id"]);

			_object.Sucursar = SucursalFacade.GetAdapted((System.Int32)row["Sucursal_Id"]);

			_object.Monto = (System.Int32)row["Monto"];

		}
	}
}
