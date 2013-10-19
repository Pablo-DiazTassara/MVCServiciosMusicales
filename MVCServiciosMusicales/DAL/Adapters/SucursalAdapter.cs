using System;
using System.Data;

namespace DAL.Adapters {
	public class SucursalAdapter {

		private DataRow row;

		public SucursalAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Sucursal _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Zona = (System.String)row["Zona"];

			_object.Descripcion = (System.String)row["Descripcion"];

		}
	}
}
