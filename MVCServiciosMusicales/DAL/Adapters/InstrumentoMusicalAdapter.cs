using System;
using System.Data;

namespace DAL.Adapters {
	public class InstrumentoMusicalAdapter {

		private DataRow row;

		public InstrumentoMusicalAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.InstrumentoMusical _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Nombre = (System.String)row["Nombre"];

			_object.Tipo = TipoInstrumentoFacade.GetAdapted((System.Int32)row["TipoInstrumento_Id"]);

			_object.Estado = (System.String)row["Estado"];

			_object.Antiguedad = (System.DateTime)row["Antiguedad"];

		}
	}
}
