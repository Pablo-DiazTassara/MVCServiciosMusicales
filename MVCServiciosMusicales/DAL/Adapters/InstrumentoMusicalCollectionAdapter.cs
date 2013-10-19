using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class InstrumentoMusicalCollectionAdapter {

		private DataTable datosDT;

		public InstrumentoMusicalCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.InstrumentoMusical> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.InstrumentoMusical _object = new Entity.InstrumentoMusical();
				InstrumentoMusicalAdapter adapter = new InstrumentoMusicalAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
