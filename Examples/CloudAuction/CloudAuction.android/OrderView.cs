using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmQuickCross;
using CloudAuction.Shared.ViewModels;
using CloudAuction.Shared;

namespace CloudAuction
{
    [Activity(Label = "Order View")]
    public class OrderView : ActivityViewBase<OrderViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.OrderView);

            var spinner = FindViewById<Spinner>(Resource.Id.OrderView_DeliveryLocation);
            spinner.Adapter = new DataBindableListAdapter<string>(LayoutInflater, Resource.Layout.TextListItem, Resource.Id.TextListItem);

            /* Specify binding in code:
            var bindingsParameters = new BindingParameters[] {
               new BindingParameters { BindingMode.TwoWay, spinner, OrderViewModel.PROPERTYNAME_DeliveryLocation, OrderViewModel.PROPERTYNAME_DeliveryLocations }
            };
            */

            Initialize(FindViewById(Resource.Id.OrderView), CloudAuctionApplication.Instance.OrderViewModel /*, bindingsParameters */);
        }
    }
}