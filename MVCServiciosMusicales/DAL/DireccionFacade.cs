using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class DireccionFacade {

		public static List<Entity.Direccion> GetAllAdapted(){
			try {
				DAL.Adapters.DireccionCollectionAdapter adapter = new DAL.Adapters.DireccionCollectionAdapter(SelectAll());
				List<Entity.Direccion> collection = new List<Entity.Direccion>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Direccion GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.DireccionAdapter adapter = new DAL.Adapters.DireccionAdapter(Select(Id));
				Entity.Direccion _object = new Entity.Direccion();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Direccion _object){
			try {
				DAL.Direccion.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Direccion _object){
			try {
				DAL.Direccion.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Direccion _object){
			try {
				DAL.Direccion.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.Direccion.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Direccion.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
