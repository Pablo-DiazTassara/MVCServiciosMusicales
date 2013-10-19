using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class TipoServicioFacade {

		public static List<Entity.TipoServicio> GetAllAdapted(){
			try {
				DAL.Adapters.TipoServicioCollectionAdapter adapter = new DAL.Adapters.TipoServicioCollectionAdapter(SelectAll());
				List<Entity.TipoServicio> collection = new List<Entity.TipoServicio>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.TipoServicio GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.TipoServicioAdapter adapter = new DAL.Adapters.TipoServicioAdapter(Select(Id));
				Entity.TipoServicio _object = new Entity.TipoServicio();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.TipoServicio _object){
			try {
				DAL.TipoServicio.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.TipoServicio _object){
			try {
				DAL.TipoServicio.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.TipoServicio _object){
			try {
				DAL.TipoServicio.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.TipoServicio.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.TipoServicio.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
