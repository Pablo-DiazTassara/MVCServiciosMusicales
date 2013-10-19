using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class TecnicoCollectionAdapter {

		private DataTable datosDT;

		public TecnicoCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Tecnico> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Tecnico _object = new Entity.Tecnico();
				TecnicoAdapter adapter = new TecnicoAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
