using GAP.Seguros.Entities;
using System.Collections.Generic;

namespace GAP.Procesos.Model.Repository.Polizas
{
    public interface IPolizasRepository
    {
        IEnumerable<Poliza> ObtenerPolizasPorCliente(int clienteId);
        void GuardarPoliza(Poliza poliza);
        void CancelarPolizas(List<Poliza> polizas);
    }
}
