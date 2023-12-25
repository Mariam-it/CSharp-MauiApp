using Shared.Services;

namespace MyMauiApp.Pages;
public partial class ProductAddPage : ContentPage
{
	private readonly ProductService _productService;

	public ProductAddPage(ProductService productService)
    {
        InitializeComponent();
        _productService = productService;
    }
}