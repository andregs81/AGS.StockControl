using AGS.StockControl.Domain.Entities;
using AGS.StockControl.Domain.ValueObjects;
using AGS.StockControl.Shared.Commands;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.Commands
{
    public class CreateProductCommand : Notifiable, ICommand
    {
        public Category Category { get; set; }
        public Codes ProductCodes { get; set; }
        public DescriptionProduct DescriptionProduct { get; set; }
        public void Validate()
        {
            // TODO : Implementar aqui minhas validações(obs: Não regra de negócio)
            // Abordagem tem o nome de Fail Fast Validaton.
            // Validação rápida. Benefícios reduz o número de requests no banco de dados por exemplo.
        }
    }
}
