using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class Factura {

		public static List<Entity.Factura> GetAllAdapted(){
			try {
				return DAL.FacturaFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Factura GetAdapted(System.Int32 Numero){
			try {
				return DAL.FacturaFacade.GetAdapted(Numero);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Factura _object){
			try {
				DAL.FacturaFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Factura _object){
			try {
				DAL.FacturaFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Factura _object){
			try {
				DAL.FacturaFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Numero){
			try {
				return DAL.FacturaFacade.Select(Numero);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.FacturaFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
