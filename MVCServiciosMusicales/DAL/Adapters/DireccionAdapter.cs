using System;
using System.Data;

namespace DAL.Adapters {
	public class DireccionAdapter {

		private DataRow row;

		public DireccionAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Direccion _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Calle = (System.String)row["Calle"];

			_object.Numero = (System.Int16)row["Numero"];

		}
	}
}
