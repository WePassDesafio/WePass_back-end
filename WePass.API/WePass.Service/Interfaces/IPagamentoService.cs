﻿using System;
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
        List<Pagamento> BuscarTodosPagamentosPorId(Usuario usuario);

        //Update
        Pagamento EditarPagamento(Usuario usuario);
        string AtivarUsuarioService(Guid id);

        //Delete
        string DesativarUsuarioService(Usuario usuario);
    }
}
