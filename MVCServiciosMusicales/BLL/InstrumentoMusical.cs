using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class InstrumentoMusical {

		public static List<Entity.InstrumentoMusical> GetAllAdapted(){
			try {
				return DAL.InstrumentoMusicalFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.InstrumentoMusical GetAdapted(System.Int32 Id){
			try {
				return DAL.InstrumentoMusicalFacade.GetAdapted(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.InstrumentoMusical _object){
			try {
				DAL.InstrumentoMusicalFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.InstrumentoMusical _object){
			try {
				DAL.InstrumentoMusicalFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.InstrumentoMusical _object){
			try {
				DAL.InstrumentoMusicalFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.InstrumentoMusicalFacade.Select(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.InstrumentoMusicalFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
