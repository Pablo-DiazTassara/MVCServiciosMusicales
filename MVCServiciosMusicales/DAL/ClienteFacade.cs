using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class ClienteFacade {

		public static List<Entity.Cliente> GetAllAdapted(){
			try {
				DAL.Adapters.ClienteCollectionAdapter adapter = new DAL.Adapters.ClienteCollectionAdapter(SelectAll());
				List<Entity.Cliente> collection = new List<Entity.Cliente>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Cliente GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.ClienteAdapter adapter = new DAL.Adapters.ClienteAdapter(Select(Id));
				Entity.Cliente _object = new Entity.Cliente();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Cliente _object){
			try {
				DAL.Cliente.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Cliente _object){
			try {
				DAL.Cliente.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Cliente _object){
			try {
				DAL.Cliente.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.Cliente.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Cliente.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
