using System;
using System.Data;

namespace DAL.Adapters {
	public class TipoInstrumentoAdapter {

		private DataRow row;

		public TipoInstrumentoAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.TipoInstrumento _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Descripcion = (System.String)row["Descripcion"];

		}
	}
}
