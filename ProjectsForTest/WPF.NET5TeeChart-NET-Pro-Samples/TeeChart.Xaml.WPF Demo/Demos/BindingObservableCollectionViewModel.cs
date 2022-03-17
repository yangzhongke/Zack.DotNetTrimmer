using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace XamlWPFDemo.Demos
{
  public class BindingObservableCollectionViewModel : ViewModelBase
  {
    public ObservableCollection<Data> DataArray { get; }

    public RelayCommand AddDataCommand { get; }

    private readonly Random _random;

    public BindingObservableCollectionViewModel()
    {
      DataArray = new ObservableCollection<Data>();

      _random = new Random();
      for (var i = 0; i < 5; i++)
      {
        DataArray.Add(new Data {A = _random.NextDouble() * 100, B = _random.NextDouble() * 200});
      }

      AddDataCommand = new RelayCommand(AddData);
    }

    private void AddData()
    {
      DataArray.Add(new Data {A = _random.NextDouble() * 100, B = _random.NextDouble() * 200});
    }

    public class Data
    {
      public double A;
      public double B;

      public override string ToString()
      {
        return $"({A:F2}, {B:F2})";
      }
    }
  }
}