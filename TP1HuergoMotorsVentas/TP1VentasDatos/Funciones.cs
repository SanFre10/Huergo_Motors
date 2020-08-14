using TP1VentasDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4_TP1VentasDTOs;
using System.Reflection;

namespace TP1VentasDatos
{
    public class Funciones
    {
        public static List<T> DataTable_a_DTO<T>(DataTable dt) where T : DTOBase,new()
        {
            T tipo = new T();
            List<T> lista = new List<T>();
            PropertyInfo[] props = tipo.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (DataRow dr in dt.Rows)
            {
                T dto = new T();
                foreach (PropertyInfo propiedad in props)
                {
                    //Evita la primer propiedad
                    if(props.First() != propiedad && dr[$"{propiedad.Name}"] != System.DBNull.Value)
                    {
                        propiedad.SetValue(dto, dr[$"{propiedad.Name}"]);
                    }

                }
                lista.Add(dto);
            }
            return lista;
        }
       
    }
}
