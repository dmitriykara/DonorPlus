//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("DonorPlus.Views.ChatPage.xaml", "Views/ChatPage.xaml", typeof(global::DonorPlus.Views.ChatPage))]

namespace DonorPlus.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\ChatPage.xaml")]
    public partial class ChatPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::DonorPlus.Controls.ExtendedListView ChatList;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::DonorPlus.Views.Partials.ChatInputBarView chatInput;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ChatPage));
            ChatList = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DonorPlus.Controls.ExtendedListView>(this, "ChatList");
            chatInput = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::DonorPlus.Views.Partials.ChatInputBarView>(this, "chatInput");
        }
    }
}