using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestCoreAspiria.Models.Response;
using ApiRestCoreAspiria.Models.Request;
using ApiRestCoreAspiria.Models;

namespace ApiRestCoreAspiria.Controllers
{

    [Route("api/[controller]")]
    //[Route("[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Producto>> oRespuesta = new Respuesta<List<Producto>>();
            try
            {
                using (CRUDAspiriaContext db = new CRUDAspiriaContext())
                {
                    var lst = db.Producto.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            //el metodo Ok es nativo de netcore en proyectos mvc api que sirve para regresar por defecto por ejemplo json
            return Ok(oRespuesta);
        }
        //Metodo para que solo regrese un elemento para editar desde el front
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            Respuesta<Producto> oRespuesta = new Respuesta<Producto>();

            try
            {

                using (CRUDAspiriaContext db = new CRUDAspiriaContext())
                {
                    var lst = db.Producto.Find(Id);
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;

                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpPost]
        public IActionResult Add(ProductoRequest model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (CRUDAspiriaContext db = new CRUDAspiriaContext())
                {
                    Producto oProducto = new Producto();
                    oProducto.Nombre = model.Nombre;
                    oProducto.Descripcion = model.Descripcion;
                    oProducto.Edad = model.Edad;
                    oProducto.Compañia = model.Compañia;
                    oProducto.Precio = model.Precio;

                    db.Producto.Add(oProducto);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

        [HttpPut]
        public IActionResult Edit(ProductoRequest model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();

            try
            {
                using (CRUDAspiriaContext db = new CRUDAspiriaContext())
                {
                    Producto oProducto = db.Producto.Find(model.Id);
                    oProducto.Nombre = model.Nombre;
                    oProducto.Descripcion = model.Descripcion;
                    oProducto.Edad = model.Edad;
                    oProducto.Compañia = model.Compañia;
                    oProducto.Precio = model.Precio;


                    db.Entry(oProducto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }


        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (CRUDAspiriaContext db = new CRUDAspiriaContext())
                {
                    Producto oProducto = db.Producto.Find(Id);
                    db.Remove(oProducto);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }





    }
}

