﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.DAL;
using System.Data.Entity;

public class ActivosImplDAL : IActivosDAL
{

    private BDContext context;

    public void Add(Activos Activo)
    {
        using (context = new BDContext())
        {
            context.Activos.Add(Activo);
            context.SaveChanges();
        }
    }

    public void Delete(int idActivo)
    {
        Activos Activo = this.GetActivo(idActivo);
        using (context = new BDContext())
        {
            context.Activos.Attach(Activo);
            context.Activos.Remove(Activo);
            context.SaveChanges();
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public List<Activos> GetActivos()
    {
        List<Activos> result;
        using (context = new BDContext())
        {
            result = (from c in context.Activos
                      select c).ToList();
        }
        IEstadoActivosDAL estadoActivosDAL = new EstadoActivosImplDAL();
        IProveedoresDAL proveedoresDAL = new ProveedoresDALImpl();
        foreach (var item in result)
        {
            item.EstadoActivos = estadoActivosDAL.obtenerEstadoActivosPorID(item.EstadoActivo ?? default(int));
            item.Proveedores = proveedoresDAL.obtenerProveedorPorID(item.Proveedor?? default(int));
        }
        return result;
    }

    public Activos GetActivo(int idActivo)
    {
        Activos result;
        using (context = new BDContext())
        {
            result = (from c in context.Activos
                      where c.IdActivo == idActivo
                      select c).First();
        }
        IEstadoActivosDAL estadoActivosDAL = new EstadoActivosImplDAL();
        IProveedoresDAL proveedoresDAL = new ProveedoresDALImpl();
        result.EstadoActivos = estadoActivosDAL.obtenerEstadoActivosPorID(result.EstadoActivo ?? default(int));
        result.Proveedores = proveedoresDAL.obtenerProveedorPorID(result.Proveedor ?? default(int));
        return result;
    }

    public void Update(Activos Activo)
    {
        try
        {
            using (context = new BDContext())
            {
                context.Entry(Activo).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        catch (Exception)
        {
            throw;
        }
    }

    public int getNextId()
    {
        int nextId = 0;
        foreach (var a in this.GetActivos())
        {
            if (a.IdActivo > nextId)
            {
                nextId = a.IdActivo;
            }
        }
        nextId = nextId + 1;
        return nextId;
    }

    public Activos mostrarActivo(int idActivo)
    {
        throw new NotImplementedException();
    }

    public void agregarActivo(Activos activos)
    {
        throw new NotImplementedException();
    }

    public void actualizarActivo(Activos activos)
    {
        throw new NotImplementedException();
    }

    public void eliminarActivo(int idActivo)
    {
        throw new NotImplementedException();
    }

    public List<Activos> obtenerActivos()
    {
        throw new NotImplementedException();
    }

    public List<object> obtenerActivosObjetos()
    {
        throw new NotImplementedException();
    }

    public List<object> buscarActivos(string busqueda)
    {
        throw new NotImplementedException();
    }
}

