using Architecture.Application.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Presentation.ViewModels
{
    public class BaseViewModel<T>: ObservableObject
    {
        private readonly IDataService<T> _service;

        public ObservableCollection<T> Models { get; set; }

        public BaseViewModel(IDataService<T> service)
        {
            LoadDataCommand = new AsyncRelayCommand(LoadDataAsync);
            _service = service;
        }
        public void SetProperty(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }


        public IAsyncRelayCommand LoadDataCommand { get; }

        private async Task LoadDataAsync()
        {
            var data = await _service.GetAsync();
            foreach (var item in data)
            {
                Models.Add(item);
            }
        }



    }
}
