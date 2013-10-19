using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class InstrumentoMusicalFacade {

		public static List<Entity.InstrumentoMusical> GetAllAdapted(){
			try {
				DAL.Adapters.InstrumentoMusicalCollectionAdapter adapter = new DAL.Adapters.InstrumentoMusicalCollectionAdapter(SelectAll());
				List<Entity.InstrumentoMusical> collection = new List<Entity.InstrumentoMusical>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.InstrumentoMusical GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.InstrumentoMusicalAdapter adapter = new DAL.Adapters.InstrumentoMusicalAdapter(Select(Id));
				Entity.InstrumentoMusical _object = new Entity.InstrumentoMusical();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.InstrumentoMusical _object){
			try {
				DAL.InstrumentoMusical.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.InstrumentoMusical _object){
			try {
				DAL.InstrumentoMusical.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.InstrumentoMusical _object){
			try {
				DAL.InstrumentoMusical.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.InstrumentoMusical.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.InstrumentoMusical.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
