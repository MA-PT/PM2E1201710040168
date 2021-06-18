using PM2E1201710040168.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PM2E1201710040168.Services
{
    public class SQLiteAssistant
    {
        SQLiteAsyncConnection db;
        public SQLiteAssistant(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Ubicacion>().Wait();
        }

        //Guardar Datos
        public Task<int> SaveUbicationAsync(Ubicacion ubicacion)
        {
            if (ubicacion.Id != 0)
            {
                return db.UpdateAsync(ubicacion);
            }
            else
            {
                return db.InsertAsync(ubicacion);
            }
        }

        //Muestar todos los datos de la BD
        public Task<List<Ubicacion>> GetUbicationAsync()
        {
            return db.Table<Ubicacion>().ToListAsync();
        }

        //Muestar todos los datos de la BD por ID
        public Task<Ubicacion> GetUbicationByIdAsync(int id)
        {
            return db.Table<Ubicacion>().Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        //Borrar datos
        public Task<int> DeleteUbicationAsync(Ubicacion ubicacion)
        {
            return db.DeleteAsync(ubicacion);
        }
    }
}
