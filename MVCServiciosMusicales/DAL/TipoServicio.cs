using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : TipoServicio
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Pablo]	15/09/2013 13:52:21
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class TipoServicio
	{
		/// <summary>
		/// Selecciona todos los registros de la tabla TipoServicio.
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
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoServicio_SelectAll");
			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla TipoServicio.
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
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoServicio_Select");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, Id);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla TipoServicio por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Delete(Entity.TipoServicio _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoServicio_Delete");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla TipoServicio.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Update(Entity.TipoServicio _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoServicio_Update");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Descripcion", DbType.String, _object.Descripcion);
			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Inserta registros en la tabla TipoServicio.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:21
		/// </history>
		public static void Insert(Entity.TipoServicio _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("TipoServicio_Insert");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Descripcion", DbType.String, _object.Descripcion);
			myDatabase.ExecuteNonQuery(myCommand);
		}

	}
}
