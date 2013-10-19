using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class TipoClienteCollectionAdapter {

		private DataTable datosDT;

		public TipoClienteCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.TipoCliente> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.TipoCliente _object = new Entity.TipoCliente();
				TipoClienteAdapter adapter = new TipoClienteAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
