using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class PiezasCollectionAdapter {

		private DataTable datosDT;

		public PiezasCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Piezas> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Piezas _object = new Entity.Piezas();
				PiezasAdapter adapter = new PiezasAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
