﻿using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;
using System.Xml.Linq;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) 
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler 
        : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // create Product entity from command object
            //save to database
            //return CreateProductResult result

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            //todo
            //Save Options to data base

            return new CreateProductResult(Guid.NewGuid());
        }
    }
}