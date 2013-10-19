using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class PiezasFacade {

		public static List<Entity.Piezas> GetAllAdapted(){
			try {
				DAL.Adapters.PiezasCollectionAdapter adapter = new DAL.Adapters.PiezasCollectionAdapter(SelectAll());
				List<Entity.Piezas> collection = new List<Entity.Piezas>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Piezas GetAdapted(System.Int32 Id){
			try {
				DAL.Adapters.PiezasAdapter adapter = new DAL.Adapters.PiezasAdapter(Select(Id));
				Entity.Piezas _object = new Entity.Piezas();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Piezas _object){
			try {
				DAL.Piezas.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Piezas _object){
			try {
				DAL.Piezas.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Piezas _object){
			try {
				DAL.Piezas.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.Piezas.Select(Id).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Piezas.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
