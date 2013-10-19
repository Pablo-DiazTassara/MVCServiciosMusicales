using System;
using System.Data;

namespace DAL.Adapters {
	public class TecnicoAdapter {

		private DataRow row;

		public TecnicoAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Tecnico _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Nombre = (System.String)row["Nombre"];

			_object.Apellido = (System.String)row["Apellido"];

			_object.DNI = (System.Int32)row["DNI"];

			_object.Descripcion = (System.String)row["Descripcion"];

		}
	}
}
