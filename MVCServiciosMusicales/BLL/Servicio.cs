using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class Servicio {

		public static List<Entity.Servicio> GetAllAdapted(){
			try {
				return DAL.ServicioFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Servicio GetAdapted(System.Int32 Id){
			try {
				return DAL.ServicioFacade.GetAdapted(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Servicio _object){
			try {
				DAL.ServicioFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Servicio _object){
			try {
				DAL.ServicioFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Servicio _object){
			try {
				DAL.ServicioFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.ServicioFacade.Select(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.ServicioFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
