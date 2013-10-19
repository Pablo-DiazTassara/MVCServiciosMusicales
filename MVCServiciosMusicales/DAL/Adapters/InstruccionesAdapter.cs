using System;
using System.Data;

namespace DAL.Adapters {
	public class InstruccionesAdapter {

		private DataRow row;

		public InstruccionesAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Instrucciones _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Descripcion = (System.String)row["Descripcion"];

		}
	}
}
