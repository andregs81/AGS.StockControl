using AGS.StockControl.Domain.Commands;
using AGS.StockControl.Domain.Entities;
using AGS.StockControl.Domain.Repositories;
using AGS.StockControl.Domain.Services;
using AGS.StockControl.Domain.ValueObjects;
using AGS.StockControl.Shared.Commands;
using AGS.StockControl.Shared.Handlers;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.Handlers
{
    public class ProductHandler : Notifiable, IHandler<CreateProductCommand>
    {
        private readonly IProductRepository repository;
        private readonly IEmailService emailService;

        public ProductHandler(IProductRepository repository, IEmailService emailService)
        {
            this.repository = repository;
            this.emailService = emailService;
        }
        public ICommandResult Handle(CreateProductCommand command)
        {
            //Fail Fast Validations
            command.Validate();

            if (command.Invalid)
            {
                AddNotifications(command);
                return new CommandResult(false, "Não foi possível realizar o cadastro! Dados inválidos");
            }

            //Verificar se o produto já está cadastrado
            if (repository.ProductCodExists(command.ProductCodes.InternalCode))
            {
                AddNotification("InternalCode", "Esse código de Produto já existe");
            }

            //Gerar as VOs
            var codes = new Codes(command.ProductCodes.InternalCode, command.ProductCodes.BarCode);
            var description = new DescriptionProduct(command.DescriptionProduct.Description, command.DescriptionProduct.DescrTecnical);

            //Gerar as Entidades
            var category = new Category(command.Category.CategoryCode, command.Category.CategoryName);
            var product = new Product(category, codes, description);
            
            //Agrupar as validações
            AddNotifications(codes, description, category);

            //Salvar as informações
            repository.CreateProdutct(product);

            //Notificar por e-mail
            emailService.Send("almoxarifado", "almoxarifado@minhaempresa.com.br", "Novo produto cadastrado",
                $"Produto: {product.ToString()} cadastrado com sucesso!"
                );

            //Retornar informações

            return new CommandResult(true, "Produto cadastrado com sucesso!");
        }
    }
}
