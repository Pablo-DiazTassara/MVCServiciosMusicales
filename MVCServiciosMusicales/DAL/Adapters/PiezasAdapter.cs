using System;
using System.Data;

namespace DAL.Adapters {
	public class PiezasAdapter {

		private DataRow row;

		public PiezasAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Piezas _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Descripcion = (System.String)row["Descripcion"];

			_object.Costo = (System.Int32)row["Costo"];

		}
	}
}
