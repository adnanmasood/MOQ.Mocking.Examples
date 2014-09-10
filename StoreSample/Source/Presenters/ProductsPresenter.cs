﻿using System;

namespace Store
{
    public class ProductsPresenter
    {
        private readonly ICatalogService catalog;
        private readonly IProductsView view;

        public ProductsPresenter(ICatalogService catalog, IProductsView view)
        {
            this.catalog = catalog;
            this.view = view;
            view.SetCategories(catalog.GetCategories());
            view.CategorySelected += (sender, args) => SelectCategory(args.Category);
        }

        private void SelectCategory(Category category)
        {
            view.SetProducts(catalog.GetProducts(category.Id));
        }

        public void PlaceOrder(Order order)
        {
            if (catalog.HasInventory(order.Product.Id, order.Quantity))
            {
                try
                {
                    catalog.Remove(order.Product.Id, order.Quantity);
                    order.Filled = true;
                }
                catch (InvalidOperationException)
                {
                    // LOG?
                }
            }
        }
    }
}