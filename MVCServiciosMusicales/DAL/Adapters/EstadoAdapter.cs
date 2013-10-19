using System;
using System.Data;

namespace DAL.Adapters {
	public class EstadoAdapter {

		private DataRow row;

		public EstadoAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Estado _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Descripcion = (System.String)row["Descripcion"];

		}
	}
}
