using System;
using MAUIHandlers.Application.Models;
using MAUIHandlers.Application.Services.Routing;
using MAUIHandlers.Application.Views;
using static Android.Content.ClipData;

namespace MAUIHandlers.Application.ViewModels
{
	public class ItemsViewModel: BaseViewModel
    {
        private List<ItemModel> _lstItemModel;
        private ItemModel _selectedItem;

        public ItemsViewModel(IRoutingService navigationService = null)
        {
            NavigationService = navigationService;
            BindItems();
        }
        
        public List<ItemModel> lstItemModel
        {
            get { return _lstItemModel; }
            set { SetProperty(ref _lstItemModel, value); }
        }

        public ItemModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                if(_selectedItem != null)
                {
                     Shell.Current.Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(_selectedItem)));
                }
            }
        }

        public void BindItems()
        {
            lstItemModel = new List<ItemModel>();
            lstItemModel.Add(new ItemModel() { Id = 1, ImageUrl = "https://cdn-icons-png.flaticon.com/512/80/80807.png", IsLike = true, Price = 21.00, Title = "Title" });
            lstItemModel.Add(new ItemModel() { Id = 2, ImageUrl = "https://cdn-icons-png.flaticon.com/512/80/80807.png", IsLike = true, Price = 88.12, Title = "Title" });
            lstItemModel.Add(new ItemModel() { Id = 3, ImageUrl = "https://cdn-icons-png.flaticon.com/512/80/80807.png", IsLike = true, Price = 65.21, Title = "Title" });
            lstItemModel.Add(new ItemModel() { Id = 4, ImageUrl = "https://cdn-icons-png.flaticon.com/512/80/80807.png", IsLike = true, Price = 39.95, Title = "Title" });
            lstItemModel.Add(new ItemModel() { Id = 5, ImageUrl = "https://cdn-icons-png.flaticon.com/512/80/80807.png", IsLike = true, Price = 958.99, Title = "Title" });
            lstItemModel.Add(new ItemModel() { Id = 6, ImageUrl = "https://cdn-icons-png.flaticon.com/512/80/80807.png", IsLike = true, Price = 64.85, Title = "Title" });
            lstItemModel.Add(new ItemModel() { Id = 7, ImageUrl = "https://cdn-icons-png.flaticon.com/512/80/80807.png", IsLike = true, Price = 2050.55, Title = "Title" });
            lstItemModel.Add(new ItemModel() { Id = 8, ImageUrl = "https://cdn-icons-png.flaticon.com/512/80/80807.png", IsLike = true, Price = 120500.00, Title = "Title" });
        }
    }
}

