using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class TipoInstrumentoCollectionAdapter {

		private DataTable datosDT;

		public TipoInstrumentoCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.TipoInstrumento> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.TipoInstrumento _object = new Entity.TipoInstrumento();
				TipoInstrumentoAdapter adapter = new TipoInstrumentoAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
