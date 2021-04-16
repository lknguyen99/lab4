using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = UnitColumn.TABLE_NAME)]
    public class Unit : BaseDomain<Unit>, ICommonFunctions<Unit>
    {
        private string _UnitID;
		private string _UnitName;
        private int _Priority;

       
		private string _Description;

        [ColumnAttribute(Name = UnitColumn.ID, IsPrimaryKey = true, CanBeNull = false)]
        public string UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }
        [ColumnAttribute(Name = UnitColumn.NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [ColumnAttribute(Name = UnitColumn.PRIORITY, IsPrimaryKey = false, CanBeNull = false)]
        public int Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }
        [ColumnAttribute(Name = UnitColumn.DESCRIPTION , IsPrimaryKey = false, CanBeNull = true)]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [ColumnAttribute(Name = BaseColumn.IS_DELETED, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<bool> IsDeleted
        {
            get { return this._IsDeleted; }
            set { this._IsDeleted = value; }
        }

        [ColumnAttribute(Name = BaseColumn.CREATE_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public System.DateTime CreateDate
        {
            get { return this._CreateDate; }
            set { this._CreateDate = value; }
        }

        [ColumnAttribute(Name = BaseColumn.CREATE_USER, IsPrimaryKey = false, CanBeNull = false)]
        public string CreateUser
        {
            get { return this._CreateUser; }
            set { this._CreateUser = value; }
        }
        [ColumnAttribute(Name = BaseColumn.UPDATE_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public System.DateTime UpdateDate
        {
            get { return this._UpdateDate; }
            set { this._UpdateDate = value; }
        }
        [ColumnAttribute(Name = BaseColumn.UPDATE_USER, IsPrimaryKey = false, CanBeNull = false)]
        public string UpdateUser
        {
            get { return this._UpdateUser; }
            set { this._UpdateUser = value; }
        }

        #region ICommonFunction
        public Unit GetByPrimaryKey()
        {
            Table<Unit> table = GetTable();

            Unit item = table.Single(d => (d.UnitID == this.UnitID));
            if (item != null)
                item.Detach<Unit>();
            return item;
        }

        #endregion

        public Unit()
        {

        }
        public static List<Unit> GetAllUnit()
        {
            return (from item in GetTable()
                    where
                     item.IsDeleted == null || item.IsDeleted == false
                    select item).ToList();
        }
        public static Unit GetUnit(string unitID)
        {
            return (from item in GetTable()
                    where
                     item.UnitID == unitID 
                     && ( item.IsDeleted == null || item.IsDeleted == false)
                    select item).FirstOrDefault();
        }
        public static Unit GetMinUnit()
        {
            return (from item in GetTable()
                    where   
                      (item.IsDeleted == null || item.IsDeleted == false)
                    orderby item.Priority
                    select item).FirstOrDefault();
        }
      
     
    }

		
}
