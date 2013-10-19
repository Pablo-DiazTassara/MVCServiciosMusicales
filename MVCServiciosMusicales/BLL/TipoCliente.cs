using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class TipoCliente {

		public static List<Entity.TipoCliente> GetAllAdapted(){
			try {
				return DAL.TipoClienteFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.TipoCliente GetAdapted(System.Int32 Id){
			try {
				return DAL.TipoClienteFacade.GetAdapted(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.TipoCliente _object){
			try {
				DAL.TipoClienteFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.TipoCliente _object){
			try {
				DAL.TipoClienteFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.TipoCliente _object){
			try {
				DAL.TipoClienteFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.TipoClienteFacade.Select(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.TipoClienteFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
