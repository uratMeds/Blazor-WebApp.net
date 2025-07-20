using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp.Components.Pages
{
    public partial class Counter
    {
        string text = "";
        string text2 = "";
        string text3 = "";
        string divTxt = "Mouse out";
        string res = "";

        [Parameter]
        public int IncrementAmount { get; set; } = 1;

        [Parameter]
        [SupplyParameterFromQuery(Name = "initCount")] // This allows the component to receive a query parameter named "initCount"
        public int initCount { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount+= IncrementAmount;
        }

        private void OnChange(ChangeEventArgs e)
        {
            text = (string)e.Value;
        }

        private void OnInput(ChangeEventArgs e)
        {
            text2 = (string)e.Value;
        }

        private void MouseOver()
        {
            divTxt = "Mouse over";
        }

        private void MouseOut()
        {
            divTxt = "Mouse out";
        }

        private void Clear(MouseEventArgs e)
        {
            text2 = "";
        }

        private void Clear2(MouseEventArgs e)
        {
            text3 = "";
        }

        async void rndm()
        {
            res = "WAIT PLZ";
            await Task.Delay(2000);
            res = "DONE";
        }
    }
}