using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class ServicioCollectionAdapter {

		private DataTable datosDT;

		public ServicioCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Servicio> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Servicio _object = new Entity.Servicio();
				ServicioAdapter adapter = new ServicioAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
