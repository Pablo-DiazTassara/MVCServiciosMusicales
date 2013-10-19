using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class ServicioFacade {

		public static List<Entity.Servicio> GetAllAdapted(){
			try {
				DAL.Adapters.ServicioCollectionAdapter adapter = new DAL.Adapters.ServicioCollectionAdapter(SelectAll());
				List<Entity.Servicio> collection = new List<Entity.Servicio>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Servicio GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.ServicioAdapter adapter = new DAL.Adapters.ServicioAdapter(Select(Id));
				Entity.Servicio _object = new Entity.Servicio();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Servicio _object){
			try {
				DAL.Servicio.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Servicio _object){
			try {
				DAL.Servicio.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Servicio _object){
			try {
				DAL.Servicio.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.Servicio.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Servicio.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
