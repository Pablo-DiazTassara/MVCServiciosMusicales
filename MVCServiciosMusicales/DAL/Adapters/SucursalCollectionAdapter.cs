using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class SucursalCollectionAdapter {

		private DataTable datosDT;

		public SucursalCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Sucursal> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Sucursal _object = new Entity.Sucursal();
				SucursalAdapter adapter = new SucursalAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
