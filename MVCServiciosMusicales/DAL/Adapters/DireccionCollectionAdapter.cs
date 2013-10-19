using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class DireccionCollectionAdapter {

		private DataTable datosDT;

		public DireccionCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Direccion> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Direccion _object = new Entity.Direccion();
				DireccionAdapter adapter = new DireccionAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
