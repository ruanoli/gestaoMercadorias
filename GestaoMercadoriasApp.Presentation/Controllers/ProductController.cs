using GestaoMercadoriasApp.Domain.Interfaces;
using GestaoMercadoriasApp.Domain.Models;
using GestaoMercadoriasApp.Presentation.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace GestaoMercadoriasApp.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var productViewModel = new List<ProductConsultViewModel>();

            try
            {
                var products = _productRepository.GetAll();

                foreach (var product in products)
                {
                    productViewModel.Add(new ProductConsultViewModel
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Descript,
                        Producer = product.Producer,
                        RegistrationNumber = product.RegistrationNumber,
                        Type = product.Type,
                    });
                }


            }
            catch (Exception)
            {

                throw;
            }

            return View(productViewModel);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(ProductRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var product = new Product()
                    {
                        Id = Guid.NewGuid(),
                        Name = viewModel.Name,
                        Descript = viewModel.Description,
                        Producer = viewModel.Producer,
                        RegistrationNumber = viewModel.RegistrationNumber,
                        Type = viewModel.Type,
                    };

                    _productRepository.Add(product);
                    ModelState.Clear();

                    TempData["MessageSuccess"] = "Produto cadastrado com sucesso!";
                }
                catch (Exception ex)
                {
                    TempData["MessageErro"] = ex.Message;
                }
            }

            return View();
        }

        public IActionResult Edit(Guid id)
        {
            var productViewModel = new ProductEditViewModel();

            try
            {
                var product = _productRepository.GetById(id);

                productViewModel.Name = product.Name;
                productViewModel.Description = product.Descript;
                productViewModel.Producer = product.Producer;
                productViewModel.RegistrationNumber = product.RegistrationNumber;
                productViewModel.Type = product.Type;

            }
            catch (Exception ex)
            {

                TempData["MessageErro"] = ex.Message;
            }

            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProductEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var product = _productRepository.GetById(viewModel.Id);

                    if (product != null)
                    {
                        product.Name = viewModel.Name;
                        product.Descript = viewModel.Description;
                        product.Producer = viewModel.Producer;
                        product.RegistrationNumber = viewModel.RegistrationNumber;
                        product.Type = viewModel.Type;

                        _productRepository.Update(product);

                        TempData["MessageSuccess"] = "Produto editado com sucesso!";
                    }
                    else
                    {
                        TempData["MessageWarning"] = "Produto não encontrado!";
                    }

                }
                catch (Exception ex)
                {

                    TempData["MessageErro"] = ex.Message;
                }
            }

            return View();
        }

        public IActionResult Delete(Guid id)
        {
            try
            {
                var product = _productRepository.GetById(id);

                if (product != null)
                {
                    _productRepository.Delete(product);

                    TempData["MessageSuccess"] = "Produto deletado com sucesso!";
                }
            }
            catch (Exception ex)
            {
                TempData["MessageErro"] = ex.Message;
            }

            return RedirectToAction("Index", "Product");
        }
    }
}

