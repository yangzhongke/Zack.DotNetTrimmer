using System;
using System.Linq;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using XamlWPFDemo.Demos;

namespace XamlWPFDemo.ViewModel
{
  public class ViewModelLocator
  {
    public MainViewModel Main => SimpleIoc.Default.GetInstance<MainViewModel>();

    public BindingObservableCollectionViewModel BindingObservableCollectionViewModel
      => SimpleIoc.Default.GetInstance<BindingObservableCollectionViewModel>();

    public BindingDataPropertiesViewModel BindingDataPropertiesViewModel
      => SimpleIoc.Default.GetInstance<BindingDataPropertiesViewModel>();

    public ViewModelLocator()
    {
      RegisterViewModels();
    }

    private static void RegisterViewModels()
    {
      SimpleIoc.Default.Register<MainViewModel>();
      SimpleIoc.Default.Register<BindingObservableCollectionViewModel>();
      SimpleIoc.Default.Register<BindingDataPropertiesViewModel>();
    }

    public static void Cleanup()
    {
      CleanupViewModel(typeof(BindingObservableCollectionViewModel));
      CleanupViewModel(typeof(BindingDataPropertiesViewModel));
      SimpleIoc.Default.Reset();
      RegisterViewModels();
    }

    private static void CleanupViewModel(Type type)
    {
      foreach (var vm in SimpleIoc.Default.GetAllCreatedInstances(type).Cast<ViewModelBase>())
      {
        vm.Cleanup();
      }
    }
  }
}
