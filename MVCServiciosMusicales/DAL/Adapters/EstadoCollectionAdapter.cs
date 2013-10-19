using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class EstadoCollectionAdapter {

		private DataTable datosDT;

		public EstadoCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Estado> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Estado _object = new Entity.Estado();
				EstadoAdapter adapter = new EstadoAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
