using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
	public class Piezas {

		public static List<Entity.Piezas> GetAllAdapted(){
			try {
				return DAL.PiezasFacade.GetAllAdapted();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Entity.Piezas GetAdapted(System.Int32 Id){
			try {
				return DAL.PiezasFacade.GetAdapted(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Entity.Piezas _object){
			try {
				DAL.PiezasFacade.Insert(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Entity.Piezas _object){
			try {
				DAL.PiezasFacade.Update(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Entity.Piezas _object){
			try {
				DAL.PiezasFacade.Delete(_object);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataRow Select(System.Int32 Id){
			try {
				return DAL.PiezasFacade.Select(Id);
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static DataTable SelectAll(){
			try {
				return DAL.PiezasFacade.SelectAll();
			}
			catch (Exception ex) {
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
