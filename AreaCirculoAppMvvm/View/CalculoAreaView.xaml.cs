using AreaCirculoAppMvvm.ViewModel;

namespace AreaCirculoAppMvvm.View;

public partial class CalculoAreaView : ContentPage
{
    CalculoAreaViewModel viewModel;
    public CalculoAreaView()
	{
	
		InitializeComponent();
		viewModel = new CalculoAreaViewModel();
		BindingContext = viewModel;

	}
}