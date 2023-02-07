using System;
using MAUIHandlers.Application.Models;
using MAUIHandlers.Application.Services.Routing;

namespace MAUIHandlers.Application.ViewModels
{
	public class ItemDetailViewModel : BaseViewModel
    {
        private ItemModel _selectedItem;

        public ItemDetailViewModel(ItemModel objItemModel=null)
        {
            SelectedItem = objItemModel;
        }
        
        public ItemModel SelectedItem
        {
            get { return _selectedItem; }
            set { SetProperty(ref _selectedItem, value); }
        }
    }
}

