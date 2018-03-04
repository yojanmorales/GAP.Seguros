using GAP.Seguros.Entities;
using System.Collections.Generic;

namespace GAP.Procesos.Model.Repository.Polizas
{
    public interface IPolizasRepository
    {
        List<Poliza> ObtenerPolizasPorCliente(int clienteId);
        void GuardarPoliza(Poliza poliza);
        void CancelarPolizas(Poliza poliza);
    }
}
