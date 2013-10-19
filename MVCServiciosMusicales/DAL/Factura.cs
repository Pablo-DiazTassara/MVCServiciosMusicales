using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : Factura
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Pablo]	15/09/2013 13:52:21
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class Factura
	{
		/// <summary>
		/// Selecciona todos los registros de la tabla Factura.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static DataSet SelectAll()
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Factura_SelectAll");
			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Factura.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static DataSet Select(System.Int32 Numero) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Factura_Select");
			myDatabase.AddInParameter(myCommand, "@Numero", DbType.Int32, Numero);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Factura por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Delete(Entity.Factura _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Factura_Delete");
			myDatabase.AddInParameter(myCommand, "@Numero", DbType.Int32, _object.Numero);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla Factura.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Update(Entity.Factura _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Factura_Update");
			myDatabase.AddInParameter(myCommand, "@Numero", DbType.Int32, _object.Numero);
			myDatabase.AddInParameter(myCommand, "@Fecha", DbType.DateTime, _object.Fecha);
			myDatabase.AddInParameter(myCommand, "@Servicio_Id", DbType.Int32, _object.Servicio.Id);
			myDatabase.AddInParameter(myCommand, "@Sucursal_Id", DbType.Int32, _object.Sucursar.Id);
			myDatabase.AddInParameter(myCommand, "@Monto", DbType.Int32, _object.Monto);
			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Inserta registros en la tabla Factura.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Insert(Entity.Factura _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Factura_Insert");
			myDatabase.AddInParameter(myCommand, "@Numero", DbType.Int32, _object.Numero);
			myDatabase.AddInParameter(myCommand, "@Fecha", DbType.DateTime, _object.Fecha);
			myDatabase.AddInParameter(myCommand, "@Servicio_Id", DbType.Int32, _object.Servicio.Id);
			myDatabase.AddInParameter(myCommand, "@Sucursal_Id", DbType.Int32, _object.Sucursar.Id);
			myDatabase.AddInParameter(myCommand, "@Monto", DbType.Int32, _object.Monto);
			myDatabase.ExecuteNonQuery(myCommand);
		}

	}
}
