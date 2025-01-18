using GestaoMercadoriasApp.Domain.Interfaces;
using GestaoMercadoriasApp.Domain.Models;
using GestaoMercadoriasApp.Presentation.ViewModels;
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
            return View();
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
            try
            {
                var product = _productRepository.GetById(id);
                var productViewModel = new ProductEditViewModel()
                {
                    Name = product.Name,
                    Description = product.Descript,
                    Producer = product.Producer,
                    RegistrationNumber = product.RegistrationNumber,
                    Type = product.Type,
                };

                return View(productViewModel);

            }
            catch (Exception ex)
            {

                TempData["MessageErro"] = ex.Message;
            }

            return View();
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

            return View();
        }
    }
}

