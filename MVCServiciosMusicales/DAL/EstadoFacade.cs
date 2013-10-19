using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class EstadoFacade {

		public static List<Entity.Estado> GetAllAdapted(){
			try {
				DAL.Adapters.EstadoCollectionAdapter adapter = new DAL.Adapters.EstadoCollectionAdapter(SelectAll());
				List<Entity.Estado> collection = new List<Entity.Estado>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Estado GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.EstadoAdapter adapter = new DAL.Adapters.EstadoAdapter(Select(Id));
				Entity.Estado _object = new Entity.Estado();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Estado _object){
			try {
				DAL.Estado.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Estado _object){
			try {
				DAL.Estado.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Estado _object){
			try {
				DAL.Estado.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.Estado.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Estado.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
