using System;
using System.Data;

namespace DAL.Adapters {
	public class TipoServicioAdapter {

		private DataRow row;

		public TipoServicioAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.TipoServicio _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Descripcion = (System.String)row["Descripcion"];

		}
	}
}
