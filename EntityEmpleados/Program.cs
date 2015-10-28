using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityEmpleados.model;

namespace EntityEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTX es el encargado de las conexiones de la base de datos
            var ctx=new EmpleadosEntities();
            var p = new Puesto()
            {
                nombre = "Tecnico IT",
                salarioBase = 26000
            };
            //Para modificar, hay que buscar primero con el .Find y luego
            //ya se pueden modificar las características que se quiera.
            //if (ele != null)
            //{
            //    var ele = ctx.Puesto.Find(4);
            //    ele.salarioBase = 45000;
            //}
            //ctx.Puesto.Add(p);
            
            //Para borrar, lo mejor es buscar el objeto que queremos borrar
            //y luego borrarlo.
            //.Find busca según el ID. Sólo busca por clave primaria y de 1 en 1. 
            var ele = ctx.Puesto.Find(4);
            foreach (var empleado in ele.Empleado)
            {
                Console.WriteLine(empleado.nombre);
            }


            var emp = new Empleado()
            {
                fecha_alta = DateTime.Now,
                nombre = "Julian Lopez",
                //Diversas formas:
                //puesto = 4,
                //Puesto1 = ele,
                Puesto1= ctx.Puesto.Find(4)
            };

            //if (ele != null)
            //{
            //    //Si se quieren eliminar varios, se usa .RemoveRange, pasando
            //    //un conjunto de objetos, por ejemplo los encontrados con un
            //    //where y guardados en una lista
            //    ctx.Puesto.Remove(ele);
            //}


            //Es un commit a la base de datos, es aquí donde saltarán los errores
            //que puedan haberse producido por los add, remove, etc
            ctx.SaveChanges();
            foreach (var puesto in ctx.Puesto)
            {
                Console.WriteLine(puesto);
            }

        }
    }
}
