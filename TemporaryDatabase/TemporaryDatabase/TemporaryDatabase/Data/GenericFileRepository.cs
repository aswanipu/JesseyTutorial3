using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TemporaryDatabase.Data
{
   public class GenericFileRepository <T> where T:IEntity
    {
        private string fileName;
        public GenericFileRepository( string filename)
        {
            this.fileName = filename;
        }
        public T Get(int id)
        {
            var items = LoadEntities();
            return items.FirstOrDefault(i => i.ID == id);
        }
        public IEnumerable<T> GetAll()
        {
            return LoadEntities();
        }
        private IEnumerable<T> LoadEntities()
        {
            var savedJson = DependencyService.Get<IFile>().LoadText(fileName);
            var deserializedTrayItems = JsonConvert.DeserializeObject<IEnumerable<T>>(savedJson);
            return deserializedTrayItems;
        }
        public void Save(T entity)
        {
            List<T> items;
            if (DependencyService.Get<IFile>().FileExists(fileName))
            {
                items = LoadEntities().ToList();
                var item= items.FirstOrDefault(i => i.ID == entity.ID);
                if(item!= null)
                {
                    items.Remove(item);

                }
                else
                {
                    items = new List<T>();
                }
                items.Add(entity);
                StoreEntities(items);
            }


        }

    }
}
