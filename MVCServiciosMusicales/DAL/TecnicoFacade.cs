using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class TecnicoFacade {

		public static List<Entity.Tecnico> GetAllAdapted(){
			try {
				DAL.Adapters.TecnicoCollectionAdapter adapter = new DAL.Adapters.TecnicoCollectionAdapter(SelectAll());
				List<Entity.Tecnico> collection = new List<Entity.Tecnico>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Tecnico GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.TecnicoAdapter adapter = new DAL.Adapters.TecnicoAdapter(Select(Id));
				Entity.Tecnico _object = new Entity.Tecnico();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Tecnico _object){
			try {
				DAL.Tecnico.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Tecnico _object){
			try {
				DAL.Tecnico.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Tecnico _object){
			try {
				DAL.Tecnico.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.Tecnico.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Tecnico.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
