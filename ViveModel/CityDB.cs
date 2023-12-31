﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ViveModel
{
    internal class CityDB : BaseDB
    {
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            City city = entity as City;
            city.ID = int.Parse(reader["id"].ToString());
            city.Name = reader["CityName"].ToString();
            return city;
        }
        public CityList SelectAll()
        {
            command.CommandText = "SELECT * FROM tbCity";
            CityList list = new CityList(ExecuteCommand());
            return list;
        }
        public City SelectById(int id)
        {
            command.CommandText = "SELECT * FROM tbCity WHERE id=" + id;
            CityList list = new CityList(ExecuteCommand());
            if (list.Count == 0)
                return null;
            return list[0];
        }

        protected override BaseEntity NewEntity()
        {
            return new City();
        }
    }
}
