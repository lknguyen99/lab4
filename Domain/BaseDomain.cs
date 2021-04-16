using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Data.Common;
using log4net;
using QuanLyKho.Domain;


namespace QuanLyKho.Domain
{
    public class BaseDomain<T> where T : class,  ICommonFunctions<T>
    {
        readonly static ILog logger = LogManager.GetLogger(typeof(T));

        protected System.Nullable<bool> _IsDeleted;
        protected System.DateTime _CreateDate;
        protected System.DateTime _UpdateDate;
        protected string _CreateUser;
        protected string _UpdateUser;

        #region Class Method

      

        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        public string Serialize()
        {
            string strReturn = "";
            try
            {
                System.IO.StringWriter sw = new System.IO.StringWriter();
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(sw, this);
                strReturn = sw.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                //throw ex;
            }

            return strReturn;
        }

        public static Table<T> GetTable()
        {
            DBContext db = new DBContext();            
            return db.GetTable<T>();
        }

        public static Table<T> GetTable(DBContext db)
        {            
            return db.GetTable<T>();
        }

        public static List<T> GetAll()
        {           
            var list = from i in GetTable() select i;
            logger.Debug("list.count: " + list.Count());
            return list.ToList();
        }        

        #region New Insert, Delete, Update

        public void Insert()
        {
            this._CreateDate = this._UpdateDate = DateTime.Now;
            this._UpdateUser = this._CreateUser;  
     
            DBContext db = new DBContext();
            db.Insert<T>(this as T);
        }

        public void Delete()
        {
            DBContext db = new DBContext();
            db.Delete<T>(this as T);
        }

        public void Update()
        {

            this._UpdateDate = DateTime.Now;
            DBContext db = new DBContext();
            db.Update<T>(this as T);
        }

        public void SystemUpdate()
        {

            this._UpdateDate = DateTime.Now;
            DBContext db = new DBContext();
            db.SubmitChanges();
        }

        #endregion
        
        #endregion        

    }


    public interface ICommonFunctions<T>
    {
        T GetByPrimaryKey() ;
    }

}
