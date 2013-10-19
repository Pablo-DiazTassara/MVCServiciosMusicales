using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class InstruccionesFacade {

		public static List<Entity.Instrucciones> GetAllAdapted(){
			try {
				DAL.Adapters.InstruccionesCollectionAdapter adapter = new DAL.Adapters.InstruccionesCollectionAdapter(SelectAll());
				List<Entity.Instrucciones> collection = new List<Entity.Instrucciones>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Instrucciones GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.InstruccionesAdapter adapter = new DAL.Adapters.InstruccionesAdapter(Select(Id));
				Entity.Instrucciones _object = new Entity.Instrucciones();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Instrucciones _object){
			try {
				DAL.Instrucciones.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Instrucciones _object){
			try {
				DAL.Instrucciones.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Instrucciones _object){
			try {
				DAL.Instrucciones.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.Instrucciones.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Instrucciones.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
