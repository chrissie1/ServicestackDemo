Imports ServiceStackModel.Response
Imports ServiceStackModel.Request
Imports ServiceStack.ServiceHost

Public Class PlantService
    Implements IService(Of PlantRequest)

    Public Function Execute(request As PlantRequest) As Object Implements ServiceStack.ServiceHost.IService(Of PlantRequest).Execute
        Return New PlantResponse With {.Name = "Name: " & request.Name}
    End Function

End Class
