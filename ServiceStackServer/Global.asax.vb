Imports System.Web.SessionState
Imports Funq
Imports ServiceStackModel.Request
Imports ServiceStack.WebHost.Endpoints

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Public Class HelloAppHost
        Inherits AppHostBase

        Public Sub New()
            MyBase.New("Plant Web Services", GetType(PlantService).Assembly)
        End Sub
        
        Public Overrides Sub Configure(container As Container)
            Routes.Add(Of PlantRequest)("/plant").Add(Of PlantRequest)("/plant/{Name}")
        End Sub
    End Class

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        Dim apphost = New HelloAppHost()
        apphost.Init()
    End Sub

End Class