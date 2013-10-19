using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace DAL
{
	/// -----------------------------------------------------------------------------
	/// Project	 : BLL
	/// Class	 : Cliente
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Pablo]	15/09/2013 13:52:19
	/// </history>
	/// -----------------------------------------------------------------------------
	internal static class Cliente
	{
		/// <summary>
		/// Selecciona todos los registros de la tabla Cliente.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:19
		/// </history>
		public static DataSet SelectAll()
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Cliente_SelectAll");
			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Cliente.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:19
		/// </history>
		public static DataSet Select(System.Int32 Id) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Cliente_Select");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, Id);

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// <summary>
		/// Suprime un registro de la tabla Cliente por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:19
		/// </history>
		public static void Delete(Entity.Cliente _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Cliente_Delete");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Actualiza registros de la tabla Cliente.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:19
		/// </history>
		public static void Update(Entity.Cliente _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Cliente_Update");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.AddInParameter(myCommand, "@Apellido", DbType.String, _object.Apellido);
			myDatabase.AddInParameter(myCommand, "@DNI", DbType.Int32, _object.DNI);
			myDatabase.AddInParameter(myCommand, "@Telefono", DbType.Int32, _object.Telefono);
			myDatabase.AddInParameter(myCommand, "@Email", DbType.String, _object.Email);
			myDatabase.AddInParameter(myCommand, "@Direccion_Id", DbType.Int32, _object.Direccion.Id);
			myDatabase.AddInParameter(myCommand, "@TipoCliente_Id", DbType.Int32, _object.Tipo.Id);
			myDatabase.AddInParameter(myCommand, "@InstrumentoMusical_Id", DbType.Int32, _object.Instrumento.Id);
			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// Inserta registros en la tabla Cliente.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Pablo]	15/09/2013 13:52:19
		/// </history>
		public static void Insert(Entity.Cliente _object)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			DbCommand myCommand = myDatabase.GetStoredProcCommand("Cliente_Insert");
			myDatabase.AddInParameter(myCommand, "@Id", DbType.Int32, _object.Id);
			myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			myDatabase.AddInParameter(myCommand, "@Apellido", DbType.String, _object.Apellido);
			myDatabase.AddInParameter(myCommand, "@DNI", DbType.Int32, _object.DNI);
			myDatabase.AddInParameter(myCommand, "@Telefono", DbType.Int32, _object.Telefono);
			myDatabase.AddInParameter(myCommand, "@Email", DbType.String, _object.Email);
			myDatabase.AddInParameter(myCommand, "@Direccion_Id", DbType.Int32, _object.Direccion.Id);
			myDatabase.AddInParameter(myCommand, "@TipoCliente_Id", DbType.Int32, _object.Tipo.Id);
			myDatabase.AddInParameter(myCommand, "@InstrumentoMusical_Id", DbType.Int32, _object.Instrumento.Id);
			myDatabase.ExecuteNonQuery(myCommand);
		}

	}
}
