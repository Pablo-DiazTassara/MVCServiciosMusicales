using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : Servicio
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Pablo]	15/09/2013 13:52:20
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class Servicio
	{
		/// <summary>
		/// Selecciona todos los registros de la tabla Servicio.
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
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Servicio_SelectAll");
			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Servicio.
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
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Servicio_Select");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, Id);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Servicio por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:20
		/// </history>
		public static void Delete(Entity.Servicio _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Servicio_Delete");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla Servicio.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:20
		/// </history>
		public static void Update(Entity.Servicio _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Servicio_Update");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Descripcion", DbType.String, _object.Descripcion);
			myDatabase.AddInParameter(myCommand, "@Costo", DbType.Int32, _object.Costo);
			myDatabase.AddInParameter(myCommand, "@Piezas_Id", DbType.Int32, _object.Piezas.Id);
			myDatabase.AddInParameter(myCommand, "@Garantia", DbType.DateTime, _object.Garantia);
			myDatabase.AddInParameter(myCommand, "@TipoServicio_Id", DbType.Int32, _object.Tipo.Id);
			myDatabase.AddInParameter(myCommand, "@Instrucciones_Id", DbType.Int32, _object.Istrucciones.Id);
			myDatabase.AddInParameter(myCommand, "@Fecha", DbType.DateTime, _object.Fecha);
			myDatabase.AddInParameter(myCommand, "@Estado_Id", DbType.Int32, _object.Estado.Id);
			myDatabase.AddInParameter(myCommand, "@FechaProxRev", DbType.Int32, _object.FechaProxRev);
			myDatabase.AddInParameter(myCommand, "@Tecnico_Id", DbType.Int32, _object.Tecnico.Id);
			myDatabase.AddInParameter(myCommand, "@InstrumentoMusical_Id", DbType.Int32, _object.Instrumento.Id);
			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Inserta registros en la tabla Servicio.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:20
		/// </history>
		public static void Insert(Entity.Servicio _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Servicio_Insert");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Descripcion", DbType.String, _object.Descripcion);
			myDatabase.AddInParameter(myCommand, "@Costo", DbType.Int32, _object.Costo);
			myDatabase.AddInParameter(myCommand, "@Piezas_Id", DbType.Int32, _object.Piezas.Id);
			myDatabase.AddInParameter(myCommand, "@Garantia", DbType.DateTime, _object.Garantia);
			myDatabase.AddInParameter(myCommand, "@TipoServicio_Id", DbType.Int32, _object.Tipo.Id);
			myDatabase.AddInParameter(myCommand, "@Instrucciones_Id", DbType.Int32, _object.Istrucciones.Id);
			myDatabase.AddInParameter(myCommand, "@Fecha", DbType.DateTime, _object.Fecha);
			myDatabase.AddInParameter(myCommand, "@Estado_Id", DbType.Int32, _object.Estado.Id);
			myDatabase.AddInParameter(myCommand, "@FechaProxRev", DbType.Int32, _object.FechaProxRev);
			myDatabase.AddInParameter(myCommand, "@Tecnico_Id", DbType.Int32, _object.Tecnico.Id);
			myDatabase.AddInParameter(myCommand, "@InstrumentoMusical_Id", DbType.Int32, _object.Instrumento.Id);
			myDatabase.ExecuteNonQuery(myCommand);
		}

	}
}
