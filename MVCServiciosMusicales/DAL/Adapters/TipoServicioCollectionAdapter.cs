using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class TipoServicioCollectionAdapter {

		private DataTable datosDT;

		public TipoServicioCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.TipoServicio> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.TipoServicio _object = new Entity.TipoServicio();
				TipoServicioAdapter adapter = new TipoServicioAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
