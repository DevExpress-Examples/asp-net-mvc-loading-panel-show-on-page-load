<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128552866/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4057)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Loading Panel for ASP.NET MVC - How to show a loading panel when a page is loading

This example demonstrates how to show [LoadingPanel](https://docs.devexpress.com/AspNetMvc/11423/components/docking-and-popups/loading-panel) when a View is loaded. 

## Implementation Details

Call the [ASPxClientLoadingPanel.Show](https://docs.devexpress.com/AspNet/js-ASPxClientLoadingPanel.Show) method in the `Init` event handler of the first DevExpress MVC Extension of the View to show a loading panel when client-side objects start initializing.

```jscript
function OnLoadingPanelInit(s, e) {
    s.Show();
}
```

To hide the loading panel when all client-side objects are already initialized, call the [ASPxClientLoadingPanel.Hide](https://docs.devexpress.com/AspNet/js-ASPxClientLoadingPanel.Hide) method in the `Init` event handler of the last DevExpress MVC Extension of the View.

```jscript
function OnLabelInit(s, e) {
    lp.Hide();
}
```

## Files to Review

* [Index.cshtml](./CS/Views/Home/Index.cshtml)

## More Examples

* [A Loading Panel for ASP.NET Web Forms - How to show a loading panel when a page is loading](https://github.com/DevExpress-Examples/asp-net-web-forms-loading-panel-display-control-on-page-load)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-loading-panel-show-on-page-load&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-loading-panel-show-on-page-load&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
