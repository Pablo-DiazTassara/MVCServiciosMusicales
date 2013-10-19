using System;
using System.Data;

namespace DAL.Adapters {
	public class ClienteAdapter {

		private DataRow row;

		public ClienteAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Cliente _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Nombre = (System.String)row["Nombre"];

			_object.Apellido = (System.String)row["Apellido"];

			_object.DNI = (System.Int32)row["DNI"];

			_object.Telefono = (System.Int32)row["Telefono"];

			_object.Email = (System.String)row["Email"];

			_object.Direccion = DireccionFacade.GetAdapted((System.Int32)row["Direccion_Id"]);

			_object.Tipo = TipoClienteFacade.GetAdapted((System.Int32)row["TipoCliente_Id"]);

			_object.Instrumento = InstrumentoMusicalFacade.GetAdapted((System.Int32)row["InstrumentoMusical_Id"]);

		}
	}
}
