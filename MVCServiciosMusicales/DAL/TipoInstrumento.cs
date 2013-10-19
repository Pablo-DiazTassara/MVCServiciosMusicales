using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : TipoInstrumento
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Pablo]	15/09/2013 13:52:21
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class TipoInstrumento
	{
		/// <summary>
		/// Selecciona todos los registros de la tabla TipoInstrumento.
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
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoInstrumento_SelectAll");
			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla TipoInstrumento.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static DataSet Select(System.Int32 Id) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoInstrumento_Select");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, Id);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla TipoInstrumento por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Delete(Entity.TipoInstrumento _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoInstrumento_Delete");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla TipoInstrumento.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Update(Entity.TipoInstrumento _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoInstrumento_Update");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Descripcion", DbType.String, _object.Descripcion);
			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Inserta registros en la tabla TipoInstrumento.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Insert(Entity.TipoInstrumento _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoInstrumento_Insert");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Descripcion", DbType.String, _object.Descripcion);
			myDatabase.ExecuteNonQuery(myCommand);
		}

	}
}
