using System;
using System.Data;

namespace DAL.Adapters {
	public class TipoClienteAdapter {

		private DataRow row;

		public TipoClienteAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.TipoCliente _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Descripcion = (System.String)row["Descripcion"];

		}
	}
}
