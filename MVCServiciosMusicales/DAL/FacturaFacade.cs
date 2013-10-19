using System;
using System.Collections.Generic;
using System.Data;

namespace DAL {
	public class FacturaFacade {

		public static List<Entity.Factura> GetAllAdapted(){
			try {
				DAL.Adapters.FacturaCollectionAdapter adapter = new DAL.Adapters.FacturaCollectionAdapter(SelectAll());
				List<Entity.Factura> collection = new List<Entity.Factura>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Factura GetAdapted(System.Int32 Numero){
			try {
				DAL.Adapters.FacturaAdapter adapter = new DAL.Adapters.FacturaAdapter(Select(Numero));
				Entity.Factura _object = new Entity.Factura();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Factura _object){
			try {
				DAL.Factura.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Factura _object){
			try {
				DAL.Factura.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Factura _object){
			try {
				DAL.Factura.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Numero){
			try {
				return DAL.Factura.Select(Numero).Tables[0].Rows[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.Factura.SelectAll().Tables[0];
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
