using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class FacturaCollectionAdapter {

		private DataTable datosDT;

		public FacturaCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Factura> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Factura _object = new Entity.Factura();
				FacturaAdapter adapter = new FacturaAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
