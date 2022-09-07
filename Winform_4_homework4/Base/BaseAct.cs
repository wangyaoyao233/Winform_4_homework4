using BaseLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Winform_4_homework4.Base
{
    public class BaseAct<T>
    {
        List<T> list = new List<T>();

        // 获取list数量(记录数)
        public int ListCnt { get { return this.list.Count; } }

        /// <summary>
        /// 添加t到list
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public void Add(T t)
        {
            this.list.Add(t);
        }

        /// <summary>
        /// 从list获取t
        /// </summary>
        /// <param name="id">需要获取的id值</param>
        /// <param name="idName">id的指定名称</param>
        /// <returns></returns>
        public T Find(int id, string idName)
        {
            Type type = typeof(T);
            PropertyInfo propertyInfo = type.GetProperty(idName);
            if (propertyInfo != null)
            {
                foreach (var t in this.list)
                {
                    if (int.Equals(propertyInfo.GetValue(t), id))
                    {
                        return t;
                    }

                }
            }
            return default;
        }

        /// <summary>
        /// 从list中移除t
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idName"></param>
        public void Remove(int id, string idName)
        {
            Type type = typeof(T);
            PropertyInfo propertyInfo = type.GetProperty(idName);
            if (propertyInfo != null)
            {
                foreach (var t in this.list)
                {
                    if (int.Equals(propertyInfo.GetValue(t), id))
                    {
                        this.list.Remove(t);
                    }

                }
            }
        }

        /// <summary>
        /// 生成记录字符串
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public string GetInfo(T t)
        {
            Type type = typeof(T);
            string str = "";
            foreach (var item in type.GetProperties())
            {
                if (str != "") str += ",";
                str += item.GetValue(t).ToString();
            }
            str += "\r\n";
            return str;
        }

        /// <summary>
        /// 设置t的属性值
        /// </summary>
        /// <param name="t"></param>
        /// <param name="propName"></param>
        /// <param name="value"></param>
        public void SetProp(T t, string propName, object value)
        {
            Type type = typeof(T);
            PropertyInfo propertyInfo = type.GetProperty(propName);
            if(propertyInfo != null)
            {
                propertyInfo.SetValue(t, value);
            }
        }

        /// <summary>
        /// 将Dictionary封装到实体类
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public T CreateInfo(Dictionary<string, object> dict)
        {
            Type type = typeof(T);
            var instance = Activator.CreateInstance<T>();
            foreach (var prop in type.GetProperties())
            {
                prop.SetValue(instance, dict[prop.Name]);
            }
            return instance;
        }

        /// <summary>
        /// 计算总收入或总支出
        /// </summary>
        /// <param name="t"></param>
        public void CalTotalAmount(T t)
        {
            Type type = typeof(T);
            decimal.TryParse(type.GetProperty("Amount").GetValue(t).ToString(), out decimal result);
            
            if(t is IncomeRecord)
            {
                ComUtility.TotalIncome += result;
            }
            else if (t is ExpendRecord)
            {
                ComUtility.TotalExpend += result;
            }
        }
    }
}
