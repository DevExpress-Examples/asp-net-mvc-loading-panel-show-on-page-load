<script type="text/javascript">
    function OnLoadingPanelInit(s, e) {
        s.Show();
    }
    function OnLabelInit(s, e) {
        //Hide
        //lp.Hide();

        //Hide After Timeout
        setTimeout(function () {
            lp.Hide();
        }, 3000);
    }
</script>


@*Loading Panel*@
@Html.DevExpress().LoadingPanel( _
    Sub(settings)
            settings.Name = "lp"
            settings.Modal = True
            settings.ClientSideEvents.Init = "OnLoadingPanelInit"
    End Sub).GetHtml()
@*Loading Panel*@

<b>VIEW CONTENT HERE</b>

@*Last DevExpress Object*@
@Html.DevExpress().Label( _
    Sub(settings)
            settings.Name = "lbl"
            settings.Properties.ClientSideEvents.Init = "OnLabelInit"
    End Sub).GetHtml()
@*Last DevExpress Object*@