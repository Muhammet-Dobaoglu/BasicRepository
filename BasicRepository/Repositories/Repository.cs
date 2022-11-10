using BasicRepository.context;
using Microsoft.EntityFrameworkCore;
using BasicRepository.Data;

namespace BasicRepository.Repositories
{
    public class Repository<T> where T : class
        //herhangi bir gelebilir
        //t tip 
        //T nesne herhangi bir harf olabilir.
        //where T:class int string gibi değişkenler gelmez.
        //Biizm yaptığımız sınıfları istyiyor
        //T t; T bir değişken tipi t
    {

        private readonly MyContext _db;
        public Repository(MyContext db)
        {
            _db = db;
        }
        public List<T> Liste()
        {
            return Set().ToList();//şehir,personel büütn 
        }
        public T Find(int Id)
        {
            // return _db.Set<T>().Find(Id); bunları alttaki gibi çevirdik
             return Set().Find(Id);

        }
        //Ulke ıd string 
        public T Find(string  Id)
        {
            return Set().Find(Id);

        }
        public string  Update(T entity)
            //normalde personel tablosu yazılır.
        {
            try { 
                Set().Update(entity);
               // _db.Entry(entity).State = EntityState.Modified;
                return "HATALI";
            }
            catch (Exception ex) 
            {
             return ex.Message;
                }
   
        }
        public bool Create(T entity)
        //normalde personel tablosu yazılır.
        {
            try
            {
                Set().Add(entity);
                // _db.Entry(entity).State = EntityState.Added;
                return true;
            }
            catch { return false; }
            
        }
        public bool Delete(T entity)
        //normalde personel tablosu yazılır.
        {

            try
            {
                // _db.Entry(entity).State = EntityState.Deleted;
                Set().Remove(entity);
                return true;
            }
            catch { return false; }
         
        }
        public DbSet<T> Set()
        {
            return _db.Set<T>();
            //genel set

        }
        public string Save()
        {
            try
            {
                _db.SaveChanges();
                return "OK";
                //save demedik
                //elektrik kesintsinde patlar.
            }
            catch(Exception ex)
            {
                return ex.Message;
            }



        }

      
    }
}
