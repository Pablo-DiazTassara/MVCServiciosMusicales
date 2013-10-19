using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class TipoServicio {

		public static List<Entity.TipoServicio> GetAllAdapted(){
			try {
				return DAL.TipoServicioFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.TipoServicio GetAdapted(System.Int32 Id){
			try {
				return DAL.TipoServicioFacade.GetAdapted(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.TipoServicio _object){
			try {
				DAL.TipoServicioFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.TipoServicio _object){
			try {
				DAL.TipoServicioFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.TipoServicio _object){
			try {
				DAL.TipoServicioFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.TipoServicioFacade.Select(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.TipoServicioFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
