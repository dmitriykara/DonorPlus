//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("DonorPlus.Pages.Search.xaml", "Pages/Search.xaml", typeof(global::DonorPlus.Search))]

namespace DonorPlus {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\Search.xaml")]
    public partial class Search : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label SearchLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::DonorPlus.Renderers.ImageRenderer SearchImage;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::DonorPlus.Renderers.EntryRenderer SearchEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::DonorPlus.Renderers.ImageRenderer ClearImage;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ListView ResultList;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Search));
            SearchLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "SearchLabel");
            SearchImage = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DonorPlus.Renderers.ImageRenderer>(this, "SearchImage");
            SearchEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DonorPlus.Renderers.EntryRenderer>(this, "SearchEntry");
            ClearImage = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DonorPlus.Renderers.ImageRenderer>(this, "ClearImage");
            ResultList = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ListView>(this, "ResultList");
        }
    }
}