using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class TipoClienteFacade {

		public static List<Entity.TipoCliente> GetAllAdapted(){
			try {
				DAL.Adapters.TipoClienteCollectionAdapter adapter = new DAL.Adapters.TipoClienteCollectionAdapter(SelectAll());
				List<Entity.TipoCliente> collection = new List<Entity.TipoCliente>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.TipoCliente GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.TipoClienteAdapter adapter = new DAL.Adapters.TipoClienteAdapter(Select(Id));
				Entity.TipoCliente _object = new Entity.TipoCliente();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.TipoCliente _object){
			try {
				DAL.TipoCliente.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.TipoCliente _object){
			try {
				DAL.TipoCliente.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.TipoCliente _object){
			try {
				DAL.TipoCliente.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.TipoCliente.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.TipoCliente.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
