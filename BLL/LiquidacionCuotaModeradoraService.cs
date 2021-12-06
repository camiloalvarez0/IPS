using DAL;
using Entity;
using System;
using System.Collections.Generic;
namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {
        private static LiquidacionCuotaRepository cuotaRepository = new LiquidacionCuotaRepository();
        public LiquidacionCuotaModeradoraService()
        {
            cuotaRepository = new LiquidacionCuotaRepository();
        }

        public string Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            try
            {
                if (cuotaRepository.Buscar(liquidacion.NumeroLiquidacion) == null)
                {
                    cuotaRepository.Guardar(liquidacion);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                else
                {
                    return $"El numero de liquidacion: {liquidacion.NumeroLiquidacion} Ya se encuentra registrado en el sistema";
                }

            }
            catch (Exception e)
            {

                return "Error de Datos: " + e.Message;
            }
        }

        public string Eliminar(string numeroLiquidacion)
        {
            try
            {
                if (cuotaRepository.Buscar(numeroLiquidacion) != null)
                {
                    cuotaRepository.Eliminar(numeroLiquidacion);
                    return $"se elimino la liquidacion numero: {numeroLiquidacion} correctamente";
                }
                return $"El numero de liquidacion no esta registrado en el sistema";
            }
            catch (Exception e)
            {
                return $"ERROR" + e.Message;
            }
        }
        public static IList<LiquidacionCuotaModeradora> ConsultarTodos()
        {
            return cuotaRepository.Consultar();
        }
        public string Modificar(LiquidacionCuotaModeradora liquidacion)
        {
            try
            {
                if (cuotaRepository.Buscar(liquidacion.NumeroLiquidacion) != null)
                {
                    cuotaRepository.Modificar(liquidacion);
                    return $"la liquidacion numero: {liquidacion.NumeroLiquidacion} ha sido modificada con exito!";

                }
                return $"El numero de liquidacion: {liquidacion.NumeroLiquidacion} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }
        public LiquidacionCuotaModeradora BuscarID(string numeroLiquidacion)
        {
            try
            {
                return cuotaRepository.Buscar(numeroLiquidacion);
            }
            catch (Exception e)
            {
                string mensaje = " ERROR" + e.Message;
                return null;
            }
        }

    }

}
