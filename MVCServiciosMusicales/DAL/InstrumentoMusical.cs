using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : InstrumentoMusical
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Pablo]	15/09/2013 13:52:20
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class InstrumentoMusical
	{
		/// <summary>
		/// Selecciona todos los registros de la tabla InstrumentoMusical.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:20
		/// </history>
		public static DataSet SelectAll()
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("InstrumentoMusical_SelectAll");
			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla InstrumentoMusical.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:20
		/// </history>
		public static DataSet Select(System.Int32 Id) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("InstrumentoMusical_Select");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, Id);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla InstrumentoMusical por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:20
		/// </history>
		public static void Delete(Entity.InstrumentoMusical _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("InstrumentoMusical_Delete");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla InstrumentoMusical.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:20
		/// </history>
		public static void Update(Entity.InstrumentoMusical _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("InstrumentoMusical_Update");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.AddInParameter(myCommand, "@TipoInstrumento_Id", DbType.Int32, _object.Tipo.Id);
			myDatabase.AddInParameter(myCommand, "@Estado", DbType.String, _object.Estado);
			myDatabase.AddInParameter(myCommand, "@Antiguedad", DbType.DateTime, _object.Antiguedad);
			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Inserta registros en la tabla InstrumentoMusical.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:20
		/// </history>
		public static void Insert(Entity.InstrumentoMusical _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("InstrumentoMusical_Insert");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.AddInParameter(myCommand, "@TipoInstrumento_Id", DbType.Int32, _object.Tipo.Id);
			myDatabase.AddInParameter(myCommand, "@Estado", DbType.String, _object.Estado);
			myDatabase.AddInParameter(myCommand, "@Antiguedad", DbType.DateTime, _object.Antiguedad);
			myDatabase.ExecuteNonQuery(myCommand);
		}

	}
}
