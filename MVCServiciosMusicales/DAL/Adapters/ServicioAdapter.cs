using System;
using System.Data;

namespace DAL.Adapters {
	public class ServicioAdapter {

		private DataRow row;

		public ServicioAdapter(DataRow row){
			this.row = row;
		}

		public void Fill(Entity.Servicio _object){
			_object.Id = (System.Int32)row["Id"];

			_object.Descripcion = (System.String)row["Descripcion"];

			_object.Costo = (System.Int32)row["Costo"];

			_object.Piezas = PiezasFacade.GetAdapted((System.Int32)row["Piezas_Id"]);

			_object.Garantia = (System.DateTime)row["Garantia"];

			_object.Tipo = TipoServicioFacade.GetAdapted((System.Int32)row["TipoServicio_Id"]);

			_object.Istrucciones = InstruccionesFacade.GetAdapted((System.Int32)row["Instrucciones_Id"]);

			_object.Fecha = (System.DateTime)row["Fecha"];

			_object.Estado = EstadoFacade.GetAdapted((System.Int32)row["Estado_Id"]);

			_object.FechaProxRev = (System.Int32)row["FechaProxRev"];

			_object.Tecnico = TecnicoFacade.GetAdapted((System.Int32)row["Tecnico_Id"]);

			_object.Instrumento = InstrumentoMusicalFacade.GetAdapted((System.Int32)row["InstrumentoMusical_Id"]);

		}
	}
}
