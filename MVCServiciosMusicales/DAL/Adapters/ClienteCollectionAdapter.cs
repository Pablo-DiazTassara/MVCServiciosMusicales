using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Adapters {
	public class ClienteCollectionAdapter {

		private DataTable datosDT;

		public ClienteCollectionAdapter(DataTable datosDT){
			this.datosDT = datosDT;
		}

		public void Fill(List<Entity.Cliente> collection){
			foreach (DataRow row in datosDT.Rows){
				Entity.Cliente _object = new Entity.Cliente();
				ClienteAdapter adapter = new ClienteAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
