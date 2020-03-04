using System;
using System.Collections.Generic;
using System.Text;
using WePass.Domain.Model;

namespace WePass.Service.Interfaces
{
    public interface IPagamentoService
    {
        //Create
        string CadastrarPagamentoService(Pagamento pagamento);

        //Read
        Pagamento BuscarPagamentoPorId(Guid id);
        List<Pagamento> BuscarTodosPagamentosPorId(Pagamento pagamento);

        //Update
        Pagamento EditarPagamento(Pagamento pagamento);
        string AtivarPagamentoService(Guid id);

        //Delete
        string DesativarUsuarioService(Pagamento pagamento);
    }
}
