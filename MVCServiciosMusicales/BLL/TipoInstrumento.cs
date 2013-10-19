using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class TipoInstrumento {

		public static List<Entity.TipoInstrumento> GetAllAdapted(){
			try {
				return DAL.TipoInstrumentoFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.TipoInstrumento GetAdapted(System.Int32 Id){
			try {
				return DAL.TipoInstrumentoFacade.GetAdapted(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.TipoInstrumento _object){
			try {
				DAL.TipoInstrumentoFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.TipoInstrumento _object){
			try {
				DAL.TipoInstrumentoFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.TipoInstrumento _object){
			try {
				DAL.TipoInstrumentoFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.TipoInstrumentoFacade.Select(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.TipoInstrumentoFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
