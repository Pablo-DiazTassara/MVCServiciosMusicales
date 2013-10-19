using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class SucursalFacade {

		public static List<Entity.Sucursal> GetAllAdapted(){
			try {
				DAL.Adapters.SucursalCollectionAdapter adapter = new DAL.Adapters.SucursalCollectionAdapter(SelectAll());
				List<Entity.Sucursal> collection = new List<Entity.Sucursal>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Sucursal GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.SucursalAdapter adapter = new DAL.Adapters.SucursalAdapter(Select(Id));
				Entity.Sucursal _object = new Entity.Sucursal();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Sucursal _object){
			try {
				DAL.Sucursal.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Sucursal _object){
			try {
				DAL.Sucursal.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Sucursal _object){
			try {
				DAL.Sucursal.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.Sucursal.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Sucursal.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
