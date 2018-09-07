/// <author>Daniel Morato Baudi</author>
using System.Data.OleDb;
using System.Windows.Forms;

namespace BibliotecaJuegos
{
    /// <summary>
    /// Stores and handles all the database related actions.
    /// </summary>
    class BaseDatos
    {
        #region Attributes
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader reader;
        private OleDbConnectionStringBuilder
            connectionData;
        private int affectedRegistries;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the 
        /// DatabaseTemplate.Forms.AccessDataBase class.
        /// </summary>
        public BaseDatos()
        {
            affectedRegistries = 0;
            connection = new OleDbConnection();
            command = new OleDbCommand();
            connectionData = new
                OleDbConnectionStringBuilder();

            connectionData.Provider = "Microsoft.ACE.OLEDB.12.0";
            connectionData.DataSource = "localhost";
            connectionData.PersistSecurityInfo = true;
            connection.ConnectionString =
                    connectionData.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the 
        /// DatabaseTemplate.Forms.AccessDataBase
        /// class when receives the data source and database.
        /// </summary>
        /// <param name="provider">Data provider 
        /// associed with the Database.</param>
        /// <param name="source">Database host.</param>
        public BaseDatos(string provider,
            string source) : this()
        {
            connectionData.Provider = provider;
            connectionData.DataSource = source;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Allows DB insertions.
        /// </summary>
        /// <param name="query">SQL insertion query.</param>
        /// <returns>Insertion status.</returns>
        public bool Insert(string query)
        {
            if (query.StartsWith("INSERT"))
            {
                StartConnection();
                command.CommandText = query;
                command.ConnectionString = 
                    connectionData.ToString();

                try {

                    affectedRegistries = 
                        command.ExecuteNonQuery();

                    if (affectedRegistries < 1)
                        Trace.WriteLine(
                            "Error trying to insert.");

                    else {
                        Trace.WriteLine(affectedRegistries
                            + " registry/ies affected");

                        return true;
                    }

                } catch (OleDbException DBError) {
                    Trace.WriteLine(
                        "Error: " + DBError.Message);

                    return false;

                } finally {
                    CloseConnection();
                }

            } else {

                Trace.WriteLine(
                    "The given query was not a"
                    + " valid INSERT query.");
            }

            return false;
        }

        /// <summary>
        /// Allows database extractions.
        /// </summary>
        /// <param name="query">SQL select query.</param>
        /// <returns>DB data readed.</returns>
        public OleDbDataReader Select(string query)
        {
            if (query.StartsWith("SELECT"))
            {
                StartConnection();
                command = new OleDbCommand(
                    query, connection);

                try {
                    reader = command.ExecuteReader();
                } catch (OleDbException ErrorDB) {
                    Trace.WriteLine("Error: " 
                        + ErrorDB.Message);
                }

            } else {

                Trace.WriteLine(
                    "The given query was not a"
                    + " valid SELECT query."); 
            }

            return reader;
        }

        /// <summary>
        /// Allows DB updates.
        /// </summary>
        /// <param name="query">SQL update query.</param>
        public bool Update(string query)
        {
            if (query.StartsWith("UPDATE"))
            {
                StartConnection();
                command.CommandText = query;
                command.Connection = connection;

                try {

                    affectedRegistries = 
                        command.ExecuteNonQuery();

                    if (affectedRegistries < 1)
                        Trace.WriteLine("No se ha podido editar.");

                    else {

                        Trace.WriteLine(affectedRegistries
                            + " registry/ies affected.");
                        return true;
                    }

                } catch (OleDbException ErrorDB) {
                    Trace.WriteLine(
                        "Error: " + ErrorDB.Message);

                    return false;

                } finally {
                    CloseConnection();
                }

            } else {

                Trace.WriteLine(
                    "The given query was not a"
                    + " valid UPDATE query.");
            }

            return false;
        }

        /// <summary>
        /// Allows DB deletes.
        /// </summary>
        /// <param name="query">SQL delete query.</param>
        public bool Delete(string query)
        {
            if (query.StartsWith("DELETE"))
            {
                StartConnection();
                command.CommandText = query;
                command.Connection = connection;

                try {
                    affectedRegistries = 
                        command.ExecuteNonQuery();

                    if (affectedRegistries < 1)
                        Trace.WriteLine("No se ha podido borrar.");
                    
                    else {
                        Trace.WriteLine(affectedRegistries
                            + " registry/ies affected.");

                        return true;
                    }

                } catch (OleDbException ErrorDB) {
                    Trace.WriteLine("Error: " + ErrorDB.Message);

                } finally {
                    CloseConnection();
                }

            } else {

                Trace.WriteLine(
                     "The given query was not a"
                     + " valid DELETE query.");
            }

            return false;
        }

        /// <summary>
        /// Starts the connection with the DB.
        /// </summary>
        public void StartConnection()
        {
            try {

                connection = new OleDbConnection(
                    connectionData.ToString());

                connection.Open();

            } catch (OleDbException ex) {

                Trace.WriteLine("Error: " + ex.Message);
                CloseConnection();
            }
        }

        /// <summary>
        /// Closes the connection with the DB.
        /// </summary>
        public void CloseConnection()
        {
            if (!(connection == null))
                connection.Close();
            if (!(reader == null))
                reader.Close();
        }
        #endregion

        #region Properties
        public OleDbCommand Orden
        {
            get { return this.command; }
            set { this.command = value; }
        }
        #endregion
    }
}