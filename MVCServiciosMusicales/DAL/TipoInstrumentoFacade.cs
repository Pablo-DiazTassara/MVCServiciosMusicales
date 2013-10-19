using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class TipoInstrumentoFacade {

		public static List<Entity.TipoInstrumento> GetAllAdapted(){
			try {
				DAL.Adapters.TipoInstrumentoCollectionAdapter adapter = new DAL.Adapters.TipoInstrumentoCollectionAdapter(SelectAll());
				List<Entity.TipoInstrumento> collection = new List<Entity.TipoInstrumento>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.TipoInstrumento GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.TipoInstrumentoAdapter adapter = new DAL.Adapters.TipoInstrumentoAdapter(Select(Id));
				Entity.TipoInstrumento _object = new Entity.TipoInstrumento();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.TipoInstrumento _object){
			try {
				DAL.TipoInstrumento.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.TipoInstrumento _object){
			try {
				DAL.TipoInstrumento.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.TipoInstrumento _object){
			try {
				DAL.TipoInstrumento.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.TipoInstrumento.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.TipoInstrumento.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
