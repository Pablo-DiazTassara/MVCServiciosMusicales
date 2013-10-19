using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class InstruccionesCollectionAdapter {

		private DataTable datosDT;

		public InstruccionesCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Instrucciones> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Instrucciones _object = new Entity.Instrucciones();
				InstruccionesAdapter adapter = new InstruccionesAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
