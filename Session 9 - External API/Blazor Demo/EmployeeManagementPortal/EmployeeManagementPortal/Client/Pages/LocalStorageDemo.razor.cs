using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class LocalStorageDemo
    {
        [Inject]
        ILocalStorageService localStorage { get; set; }

        public string Name { get; set; } = "Name";
        public List<string> RecentSearches { get; set; } = new List<string>();
        private string search;
        private int localStorageLength;
        private string localStorageKey0;
        private bool localStorageHasName;

        protected override async Task OnInitializedAsync()
        {
            Name = await localStorage.GetItemAsStringAsync("name");
            RecentSearches = await localStorage.GetItemAsync<List<string>>("recent-searches") ?? new List<string>();
        }

        private async Task SaveName()
        {
            await localStorage.SetItemAsStringAsync("name", Name);
        }

        private async Task SaveSearch()
        {
            RecentSearches.Add(search);
            await localStorage.SetItemAsync("recent-searches", RecentSearches);
            search = string.Empty;
        }

        private async Task ClearSearches()
        {
            await localStorage.RemoveItemAsync("recent-searches");
            RecentSearches?.Clear();
            search = string.Empty;
        }

        private async Task ClearLocalStorage()
        {
            await localStorage.ClearAsync();
            RecentSearches?.Clear();
            search = string.Empty;
            Name = string.Empty;
        }

        private async Task DemoOtherProperties()
        {
            localStorageLength = await localStorage.LengthAsync();
            localStorageKey0 = await localStorage.KeyAsync(0);
            localStorageHasName = await localStorage.ContainKeyAsync("name");
        }
    }
}
