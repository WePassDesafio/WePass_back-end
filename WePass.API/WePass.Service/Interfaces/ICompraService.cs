using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Model;

namespace WePass.Service.Interfaces
{
    public interface ICompraService
    {
        //Create 
        string CadastrarCompraService(Compra compra);

        //Read
        Compra BuscarCompraPorIdService(Guid Id);
        List<Compra> BuscarTodasComprasPorIdService(Compra compra);

        //Update
        Evento EditarCompraService(Compra compra);
        string AtivarCompraService(Guid id);

        //Delete
        string DesativarCompraService(Guid id);
    }
}
